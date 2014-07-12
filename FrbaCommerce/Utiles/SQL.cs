using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FrbaCommerce.Utiles
{
    class SQL
    {

        public static void llenarDataGrid(DataGridView dataGridView1, SqlConnection conexion, SqlCommand cmd)
        {
          
                SqlDataAdapter da = new SqlDataAdapter { SelectCommand = cmd };
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                conexion.Close();
                dataGridView1.DataSource = tabla;
                dataGridView1.Refresh();
                dataGridView1.ClearSelection();
         
        }

     public static SqlCommand crearProcedure(string nombre, SqlConnection conexion, params SqlParameter[] parametrosDelSP)
        {//Recibo una lista de parametros del procedure, con el nombre del sp y la conexión a utilizar
            SqlCommand sp = new SqlCommand(nombre, conexion) { CommandType = CommandType.StoredProcedure };
          
            foreach (SqlParameter parametro in parametrosDelSP)
            {
                agregarSqlParameter(parametro, sp);
            }

            return sp;
        }

     public static void agregarSqlParameter(SqlParameter parametro, SqlCommand sp)
     {
         sp.Parameters.Add(parametro);
     }

   }
}
