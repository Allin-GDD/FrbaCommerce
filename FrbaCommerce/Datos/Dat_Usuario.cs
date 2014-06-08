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

        public static void validarUserName(String userName)
        {
            List<String> listaDeUsuarios = Datos.Dat_Usuario.obtenerTodosLosUsuarios();
            int retorno = 0;
            foreach (String usuario in listaDeUsuarios)
            {   
               if (userName != usuario)
                {
                    retorno++;
                }
            }
            Utiles.Validaciones.validarUsuario(retorno);

        }

        public static void CrearNuevoUsuario(string usuario, string pw, decimal rolDeUsuario, Decimal IdUsuario)
        {

            String pwHash = hashearSHA256(pw);


            //ACA HAY QUE CONVERTIR LA PW EN UNA CONTRASEÑA BINARIA PARA PODER GUARDARALA
            try
            {
                SqlConnection conn = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.darDeAltaUsuario", conn,
                new SqlParameter("@Usuario", usuario),
                new SqlParameter("@Password", pwHash),
                new SqlParameter("@IdUsuario", IdUsuario),
                new SqlParameter("@IdRol", rolDeUsuario),
                new SqlParameter("@Estado", 1));


            }
            catch (Exception)
            {
                MessageBox.Show("Error al crear un nuevo usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public static void ActualizarEstadoUsuario(short estado, Decimal clienteAModificar, Decimal rolCliente)
        {
            try
            {
                SqlConnection conn = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.actualizarEstadoDelUsuario", conn,
                new SqlParameter("@Estado", estado),
                new SqlParameter("@Id", clienteAModificar),
                new SqlParameter("Rol", rolCliente));
            }
            catch (Exception)
            {
                MessageBox.Show("Error al actualizar el estado del usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static short obtenerEstado(int id, short rol)
        {
            Int16 estado = -1;
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.obtenerEstadoDelId", conn,
            new SqlParameter("@Id", id),
            new SqlParameter("@Rol", rol));
            SqlDataReader lectura = cmd.ExecuteReader();
            while (lectura.Read())
            {
                estado = lectura.GetInt16(0);
            }
            conn.Close();

            return estado;
        }

        public static String hashearSHA256(String input)
        {
            SHA256Managed encriptador = new SHA256Managed();
            byte[] inputEnBytes = Encoding.UTF8.GetBytes(input);
            byte[] inputHashBytes = encriptador.ComputeHash(inputEnBytes);
            return BitConverter.ToString(inputHashBytes).Replace("-", String.Empty).ToLower();
        }

        public static int validarContraseña(string contraseñaValida, string contraseñaIngresada, int posiblidadesDeLoggeo)
        {
            if (contraseñaIngresada != contraseñaValida)
            {
                posiblidadesDeLoggeo--;
                
            }
            return posiblidadesDeLoggeo;

        }

        public static void bloquearUsuario(int posiblidadesDeLoggeo, Decimal rol, Decimal Idusuario)
        {
            if (posiblidadesDeLoggeo == 0)
            {
                Dat_Usuario.ActualizarEstadoUsuario(0, Idusuario, rol);
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
                pUsuario.Rol = lectura.GetDecimal(1);
                pUsuario.IdUsuario = lectura.GetDecimal(2);
            }
            conn.Close();

            return pUsuario;
        }

        public static void dispararExcepcionLogin(int posiblidadesDeLoggeo, int posiblidadesDeLoggeoNuevo)
        {

            if (posiblidadesDeLoggeo != posiblidadesDeLoggeoNuevo && (posiblidadesDeLoggeo > -1))
            {

                throw new Excepciones.ElUsuarioSeBloqueo("La contraseña ingresada no es válida. Le quedan: " + posiblidadesDeLoggeoNuevo + " intentos");
            }
        }
    }
}