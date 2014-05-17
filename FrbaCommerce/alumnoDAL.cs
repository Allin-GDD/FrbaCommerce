using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace FrbaCommerce
{
    class alumnoDAL
    {
        public static int Agregar(alumno pAlumno)
        {
            int retorno = 0;
            using (SqlConnection conn = DBConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert into cliente(nombre, apellido, edad) values('{0}','{1}','{2}')",
                    pAlumno.nombre, pAlumno.apellido, pAlumno.edad), conn);
                retorno = Comando.ExecuteNonQuery();
            }

            return retorno;
        }
    }
}
