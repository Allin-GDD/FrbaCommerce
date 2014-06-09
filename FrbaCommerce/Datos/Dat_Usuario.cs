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

        public static void validarUserName(String userName)
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
            Utiles.Validaciones.validarUsuario(retorno);

        }

        public static void CrearNuevoUsuario(string usuario, string pw, decimal rolDeUsuario, Decimal IdUsuario)
        {
            int retorno = 0;
            String pwHash = hashearSHA256(pw);
            using (SqlConnection conexion = DBConexion.obtenerConexion())
            {
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.darDeAltaUsuario", conexion,
                new SqlParameter("@Usuario", usuario),
                new SqlParameter("@Password", pwHash),
                new SqlParameter("@IdUsuario", IdUsuario),
                new SqlParameter("@IdRol", rolDeUsuario),
                new SqlParameter("@Intentos", retorno),
                new SqlParameter("@Estado", 1)
                );

                retorno = cmd.ExecuteNonQuery();
                conexion.Close();
            }


            Mensajes.Generales.validarAlta(retorno);

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

        public static bool validarContraseña(string contraseñaValida, string contraseñaIngresada)
        {
            bool exito = true;
            if (contraseñaIngresada != contraseñaValida)
            {
                exito = false;
            }
            return exito;

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
    }
}