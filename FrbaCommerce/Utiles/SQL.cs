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

     public static void llenarDataGrid(DataGridView dataGridView1, SqlConnection conexion,SqlCommand cmd)
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
        {
            //Recibo una lista de parametros de longitud variable para instanciar el SP de forma comoda.
            //Instancio un SP
            SqlCommand sp = new SqlCommand(nombre, conexion) { CommandType = CommandType.StoredProcedure };
            //Le agrego sus parametros.
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
