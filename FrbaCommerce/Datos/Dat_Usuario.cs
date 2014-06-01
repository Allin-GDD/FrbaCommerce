using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

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

                if ((pusuario.Usuario == usuario.Usuario )&& (pusuario.Contraseña == usuario.Contraseña))
                {
                    devolucion = 1;
                }
                else
                {
                    
                }
                
            }
            return devolucion;


        }
    }
}
