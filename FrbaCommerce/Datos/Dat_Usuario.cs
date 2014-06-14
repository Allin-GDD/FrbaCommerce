using System;
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
        {
            List<String> listaDeUsuarios = new List<String>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("Select Usuario from Usuario", conexion);
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
        {
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

        public static void CrearNuevoUsuario(string usuario, string pw, decimal rolDeUsuario, Decimal IdUsuario, int estado)
        {
            int retorno = 0;
           // String pwHash = hashearSHA256(pw);
            using (SqlConnection conexion = DBConexion.obtenerConexion())
            {
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.darDeAltaUsuario", conexion,
                new SqlParameter("@Usuario", usuario),
                new SqlParameter("@Password", pw),
                new SqlParameter("@IdUsuario", IdUsuario),
                new SqlParameter("@IdRol", rolDeUsuario),
                new SqlParameter("@Intentos", retorno),
                new SqlParameter("@Estado", estado)
                );

                retorno = cmd.ExecuteNonQuery();
                conexion.Close();
            }


            Mensajes.Generales.valirUsuarioCliente(retorno);

        }

        public static void ActualizarEstadoUsuario(Int16 estado, Decimal clienteAModificar, Decimal rolCliente)
        {
            int retorno = 0;

            using (SqlConnection conn = DBConexion.obtenerConexion())
            {
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.actualizarEstadoDelUsuario", conn,
                new SqlParameter("@Estado", estado),
                new SqlParameter("@Id", clienteAModificar),
                new SqlParameter("Rol", rolCliente));

                retorno = cmd.ExecuteNonQuery();
                conn.Close();
            }
            if (retorno == 0)
            {
                throw new Excepciones.InexistenciaUsuario("Error al actualizar el estado de usuario");
            }
        }

        public static short obtenerEstado(int id, short rol)
        {
            Int16 estado = -1;
            using (SqlConnection conn = DBConexion.obtenerConexion())
            {
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.obtenerEstadoDelId", conn,
                new SqlParameter("@Id", id),
                new SqlParameter("@Rol", rol));
                SqlDataReader lectura = cmd.ExecuteReader();
                while (lectura.Read())
                {
                    estado = lectura.GetInt16(0);
                }
                conn.Close();
            }
            return estado;
        }

        public static String hashearSHA256(String input)
        {
            SHA256Managed encriptador = new SHA256Managed();
            byte[] inputEnBytes = Encoding.UTF8.GetBytes(input);
            byte[] inputHashBytes = encriptador.ComputeHash(inputEnBytes);
            return BitConverter.ToString(inputHashBytes).Replace("-", String.Empty).ToLower();
        }

        public static void bloquearUsuario(int intentosFallidos, Decimal rol, Decimal Idusuario)
        {
            if (intentosFallidos == 3)
            {

                Dat_Usuario.ActualizarEstadoUsuario(0, Convert.ToInt32(Idusuario), Convert.ToInt16(rol));

                throw new Excepciones.ElUsuarioSeBloqueo("Se agotaron las posibilidades de logeo, el usuario ha sido bloquedo. Por favor comuniquese con el administrador");
            }
        }

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
                pUsuario.Rol = lectura.GetDecimal(2);
                pUsuario.Intentos = lectura.GetInt16(3);
                pUsuario.Estado = lectura.GetInt16(4);

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

        public static void actualizarIntentos(string usuario, int intentos)
        {
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
        
            if (passwordIngresa == passwordOriginal && pusuario.Estado == 10)
                {
                    Utiles.Ventanas.First_Login flogin = new Utiles.Ventanas.First_Login(pusuario.Usuario, pusuario.Rol , pusuario.IdUsuario);
                    flogin.Show();
                    return true;
                }
            return false;
           

        }

        public static void actualizarContraseña(string usuario, string pw)
        {
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
                Datos.Dat_Usuario.actualizarIntentos(pusuario.Usuario, 0);
                Utiles.Ventanas.Opciones.AbrirVentanas(pusuario.Rol, login,pusuario.IdUsuario);

            }
            else
            {
                int intentosFallidos = pusuario.Intentos + 1;
                Datos.Dat_Usuario.actualizarIntentos(pusuario.Usuario, intentosFallidos);

                Datos.Dat_Usuario.bloquearUsuario(Convert.ToInt16(intentosFallidos), pusuario.IdUsuario, pusuario.Rol);

                Mensajes.Errores.ErrorEnlaContraseña(intentosFallidos);
            }
        }

            }
}
