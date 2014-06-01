using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FrbaCommerce.Datos
{
    class Dat_Usuario
    {
        public static List<Entidades.Ent_Usuario> obtenerTodosLosUsuarios()
        {
            List<Entidades.Ent_Usuario> listaDeUsuarios = new List<Entidades.Ent_Usuario>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("Select Usuario from Usuario", conexion);
            SqlDataReader lectura = Comando.ExecuteReader();


            while (lectura.Read())
            {
                Entidades.Ent_Usuario pUsuario = new Entidades.Ent_Usuario();

                pUsuario.Usuario = lectura.GetString(0);

                listaDeUsuarios.Add(pUsuario);
            }
            return listaDeUsuarios;




        }

        public static int validarUsuario(Entidades.Ent_Usuario pusuario)
        {
            List<Entidades.Ent_Usuario> listaDeUsuarios = Datos.Dat_Usuario.obtenerTodosLosUsuarios();
            int devolucion = 0;
            foreach (Entidades.Ent_Usuario usuario in listaDeUsuarios)
            {

                if ((pusuario.Usuario == usuario.Usuario) && (pusuario.Contraseña == usuario.Contraseña))
                {
                    devolucion = 1;
                }
                else
                {

                }

            }
            return devolucion;


        }

        public static void CrearNuevoUsuario(string usuario, string pw, Int32 rolDeUsuario)
        {
            Decimal IdUsuario = buscarId(pw, rolDeUsuario);

            //ACA HAY QUE CONVERTIR LA PW EN UNA CONTRASEÑA BINARIA PARA PODER GUARDARALA
            try
            {
                SqlConnection conn = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.darDeAltaUsuario", conn,
                new SqlParameter("@Usuario", usuario),
                new SqlParameter("@Password", pw),
                new SqlParameter("@IdUsuario", IdUsuario),
                new SqlParameter("@IdRod", rolDeUsuario),
                new SqlParameter("@Estado", 1));

            }
            catch (Exception) {
                MessageBox.Show("Error al crear un nuevo usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        public static Decimal buscarId(string pw, int rolDeUsuario)
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
    }
}