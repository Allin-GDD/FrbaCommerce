using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace FrbaCommerce.Datos
{
    class Dat_Rol
    {

        public static List<Entidades.Entidad_Rol> ObtenerRol()
        {


            List<Entidades.Entidad_Rol> listaDeRoles = new List<Entidades.Entidad_Rol>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("Select Id, Nombre from Rol", conexion);
            SqlDataReader lectura = Comando.ExecuteReader();

            while (lectura.Read())
            {
                Entidades.Entidad_Rol pRol = new Entidades.Entidad_Rol();
                pRol.id = lectura.GetDecimal(0);
                pRol.nombre= lectura.GetString(1);

                listaDeRoles.Add(pRol);
            }

           
            return listaDeRoles;
        }
    }
}
