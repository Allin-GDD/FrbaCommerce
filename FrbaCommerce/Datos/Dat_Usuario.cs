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
        public static List<Entidades.Ent_Usuario> obtenerTodosLosUsuarios()
        {
            List<Entidades.Ent_Usuario> listaDeUsuarios = new List<Entidades.Ent_Usuario>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("Select usuario,password,id_rol from Usuario", conexion);
            SqlDataReader lectura = Comando.ExecuteReader();


            while (lectura.Read())
            {
                Entidades.Ent_Usuario pUsuario = new Entidades.Ent_Usuario();

                pUsuario.Usuario = lectura.GetString(0);
                pUsuario.Contraseña = lectura.GetString(1);
                pUsuario.Rol = lectura.GetDecimal(2);

                listaDeUsuarios.Add(pUsuario);
            }
            return listaDeUsuarios;




        }

        public static int validarUsuario(Entidades.Ent_Usuario pusuario)
        {
            List<Entidades.Ent_Usuario> listaDeUsuarios = Datos.Dat_Usuario.obtenerTodosLosUsuarios();
            decimal devolucion = 0 ;
            foreach (Entidades.Ent_Usuario usuario in listaDeUsuarios)
            {

                if ((pusuario.Usuario == usuario.Usuario) && (pusuario.Contraseña == usuario.Contraseña))
                {

                    devolucion = usuario.Rol;

                }
                else
                {
                    
                }

            }
            return Convert.ToInt16(devolucion);

        }

        public static void CrearNuevoUsuario(string usuario, string pw, decimal rolDeUsuario)
        {
            Decimal IdUsuario = buscarId(pw, rolDeUsuario);
            String pwHash = hashearSHA256(pw);
          

            //ACA HAY QUE CONVERTIR LA PW EN UNA CONTRASEÑA BINARIA PARA PODER GUARDARALA
            //try
            //{
                SqlConnection conn = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.darDeAltaUsuario", conn,
                new SqlParameter("@Usuario", usuario),
                new SqlParameter("@Password", pwHash),
                new SqlParameter("@IdUsuario", IdUsuario),
                new SqlParameter("@IdRol", rolDeUsuario),
                new SqlParameter("@Estado", 1));
                int retorno = cmd.ExecuteNonQuery();
                if (retorno == 0) {
                    throw new Excepciones.ValoresConTiposDiferentes("ERROR ACA");
                }

            //}
            //catch (Exception) {
            //    MessageBox.Show("Error al crear un nuevo usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            

        }

        public static Decimal buscarId(string pw, decimal rolDeUsuario)
        {
            if (rolDeUsuario == 1)
            {
                return (Datos.Dat_Cliente.buscarIdCliente(pw));
            }
            if (rolDeUsuario == 2)
            {
                return (Datos.Dat_Empresa.buscarIdEmpresa(pw));
            }
            else {
                throw new Excepciones.InexistenciaUsuario("Datos no validos");
            }
        }

      

        public static void ActualizarEstadoUsuario(short estado, int clienteAModificar, short rolCliente)
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
    
    
    
    }
}