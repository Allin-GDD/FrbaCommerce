﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace FrbaCommerce.Datos
{
    class Dat_Usuario
    {
        public static List<String> obtenerTodosLosUsuarios()
        {//arma un listado con todos los usuarios creados, para evitar repetidos
            List<String> listaDeUsuarios = new List<String>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("Select usuario from Usuario", conexion);
            SqlDataReader lectura = Comando.ExecuteReader();


            while (lectura.Read())
            {
                String usuario;

                usuario = lectura.GetString(0);
                listaDeUsuarios.Add(usuario);

            }
            return listaDeUsuarios;




        }

        public static int validarUserName(String userName)
        {//se fija si nombre de usuario que ingreso ya existe
            List<String> listaDeUsuarios = Datos.Dat_Usuario.obtenerTodosLosUsuarios();
            int retorno = 0;

            foreach (String usuario in listaDeUsuarios)
            {
                if (userName == usuario)
                {
                    retorno++;
                }

            }
            return retorno;

        }

        public static void CrearNuevoUsuario(string usuario, string pw, decimal rolDeUsuario,int estado)
        {//agrega un nuevo usuario
            int retorno = 0;
            using (SqlConnection conexion = DBConexion.obtenerConexion())
            {
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.darDeAltaUsuario", conexion,
                new SqlParameter("@UsuarioName", usuario),
                new SqlParameter("@Password", pw),
                new SqlParameter("@Rol", rolDeUsuario),
                new SqlParameter("@Intentos", retorno),
                new SqlParameter("@Estado", estado)
                );

                retorno = cmd.ExecuteNonQuery();
                conexion.Close();
            }


            Mensajes.Generales.valirUsuarioCliente(retorno);

        }
        public static void actualizarEstadoUsuario(Int16 estado, Decimal idUsuario)
        {//actualiza los estados del usuario
            int retorno = 0;

            using (SqlConnection conn = DBConexion.obtenerConexion())
            {
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.actualizarEstadoDelUsuario", conn,
                new SqlParameter("@Estado", estado),
                new SqlParameter("@Id", idUsuario));

                retorno = cmd.ExecuteNonQuery();
                conn.Close();
            }
            if (retorno == 0)
            {
                throw new Excepciones.InexistenciaUsuario("Error al actualizar el estado de usuario");
            }
        }

        public static short obtenerEstado(Decimal id)
        {
            Int16 estado = -1;
            using (SqlConnection conn = DBConexion.obtenerConexion())
            {
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.estaHabilitado", conn,
                new SqlParameter("@Id", id));
                SqlDataReader lectura = cmd.ExecuteReader();
                while (lectura.Read())
                {
                    estado = lectura.GetInt16(0);
                }
                conn.Close();
            }
            return estado;
        }

        // encriptacion password
        public static String hashearSHA256(String input)
        {
            SHA256Managed encriptador = new SHA256Managed();
            byte[] inputEnBytes = Encoding.UTF8.GetBytes(input);
            byte[] inputHashBytes = encriptador.ComputeHash(inputEnBytes);
            return BitConverter.ToString(inputHashBytes).Replace("-", String.Empty).ToLower();
        }

        public static void bloquearUsuario(int intentosFallidos, Decimal Idusuario)
        {//bloquea al usuario que fallo 3 veces la contreseña
            if (intentosFallidos == 3)
            {

                Dat_Usuario.actualizarEstadoUsuario(0,Idusuario);

                throw new Excepciones.ElUsuarioSeBloqueo("Se agotaron las posibilidades de logeo, el usuario ha sido bloquedo. Por favor comuniquese con el administrador");
            }
        }


        // obtiene un usuario
        public static Entidades.Ent_Usuario obtenerCamposDe(string nombre)
        {
            Entidades.Ent_Usuario pUsuario = new Entidades.Ent_Usuario();
            pUsuario.Usuario = nombre;

            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarCamposDeUsuario", conn,
            new SqlParameter("@Usuario", nombre));
            SqlDataReader lectura = cmd.ExecuteReader();
            while (lectura.Read())
            {
                pUsuario.Contraseña = lectura.GetString(0);
                pUsuario.IdUsuario = lectura.GetDecimal(1);
                pUsuario.Intentos = lectura.GetInt16(2);
                pUsuario.Estado = lectura.GetInt16(3);

            }
            conn.Close();

            return pUsuario;
        }

        public static void validarIntentos(short intentos)
        {
            if (intentos >= 3)
            {
                throw new Excepciones.InexistenciaUsuario("El usuario se encuentra bloqueado, comuniquese con su administrador");
            }
        }

        public static void actualizarIntentos(decimal usuario, int intentos)
        {//actualiza los intentos de usuario
            int retorno = 0;
            using (SqlConnection conn = DBConexion.obtenerConexion())
            {
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.actualizarIntentos", conn,
                new SqlParameter("@Usuario", usuario),
                new SqlParameter("@Intentos", intentos));
                retorno = cmd.ExecuteNonQuery();
                conn.Close();

            }
            if (retorno == 0)
            {
                throw new Excepciones.ElUsuarioSeBloqueo("error al actualizar intentos");
            }

        }

        public static void validarEstado(short estado)
        {
            if (estado != 1)
            {
                throw new Excepciones.ElUsuarioSeBloqueo("El usuario se encuentra bloqueado o ha sido dado de baja. Por favor comuniquese con el administrador");
            }
        }

        public static bool validarPrimerIngreso(string passwordIngresa, string passwordOriginal, Entidades.Ent_Usuario pusuario, Form ofrm)
        {
            //si es la primera vez que ingresa, le muestra una pantalla para que cambie su contraseña
            if (passwordIngresa == passwordOriginal && pusuario.Estado == 10)
            {
                Utiles.Ventanas.First_Login flogin = new Utiles.Ventanas.First_Login(pusuario.IdUsuario);
                ofrm.Hide();
                flogin.ShowDialog();
                ofrm.Show();
                return true;
            }
            return false;

        }

        public static void actualizarContraseña(Decimal usuario, string pw)
        {//actualiza la contraseña, (siempre la va a hashear)
            int retorno = 0;
            String pwHash = hashearSHA256(pw);
            using (SqlConnection conn = DBConexion.obtenerConexion())
            {
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.actualizarContraseña", conn,
                new SqlParameter("@Usuario", usuario),
                new SqlParameter("@Contraseña", pwHash));
                retorno = cmd.ExecuteNonQuery();
                conn.Close();

            }
            if (retorno == 0)
            {
                throw new Excepciones.ElUsuarioSeBloqueo("error al actualizar la contraseña");
            }
        }

        public static void controlDeLogeo(Entidades.Ent_Usuario pusuario, string contraseñaIngresada, Form login)
        {

            if (pusuario.Contraseña == contraseñaIngresada)
            {
                Datos.Dat_Usuario.actualizarIntentos(pusuario.IdUsuario, 0);
                login.Hide();

                    //Si tiene mas de un rol, le da a elegir el rol que quiera, sino abre directarmente el único rol que tiene
                Datos.Dat_Rol.abrirVentanasSegunRol(pusuario.IdUsuario,login);
            }
            else
            {
                //aumenta los intentos fallidos
                int intentosFallidos = pusuario.Intentos + 1;
                Datos.Dat_Usuario.actualizarIntentos(pusuario.IdUsuario, intentosFallidos);
                //se fija si hay que bloquear al usuario por intentos fallidos
                Datos.Dat_Usuario.bloquearUsuario(Convert.ToInt16(intentosFallidos), pusuario.IdUsuario);
                //muestra el mensaje de que se bloqueo
                Mensajes.Errores.ErrorEnlaContraseña(intentosFallidos);
            }
        }

       

        internal static decimal getIdUsuario(string p)
        {//Devuelve el Id_Usuario a partir del nombre de usuario
            Decimal user = 0;
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarMiIDUsuario", conn,
            new SqlParameter("@UserName", p));

            SqlDataReader lectura = cmd.ExecuteReader();
            while (lectura.Read())
            {
                user = lectura.GetDecimal(0);
            }
            return user;
        }

        internal static List<Int32> validarFuncionalidades(string p)
        {//listado de funcionalidades
            List<Int32> func = new List<int>();
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarFuncionalidades", conn,
            new SqlParameter("@rol", p));

            SqlDataReader lectura = cmd.ExecuteReader();
            while (lectura.Read())
            {
                func.Add(lectura.GetInt32(0));
                
            }
            return func;
        }
    }
}