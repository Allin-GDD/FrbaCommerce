using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Datos
{
    class Dat_Listados
    {
        internal static void vendedoresQueMEnosVenden(Int16 año, Decimal visibilidad, int mes, DataGridView dataGridView1)
        {
            using (SqlConnection conn = DBConexion.obtenerConexion())
            {
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.listadoVendedoresQueVendenMenos", conn,
                new SqlParameter("@Año", año),
                new SqlParameter("@Visibilidad", visibilidad),
                new SqlParameter("@Mes", mes));

                Utiles.SQL.llenarDataGrid(dataGridView1, conn, cmd);

                conn.Close();
            }
        }

        internal static void vendedoresMayorFacturacion(short año, int filtroTrimestre, DataGridView dataGridView1)
        {
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.listadoMayoresFacturacion", conn,
              new SqlParameter("@Año", año),
            new SqlParameter("@Trimestre", filtroTrimestre));


            Utiles.SQL.llenarDataGrid(dataGridView1, conn, cmd);
        }

        internal static void vendedoresConMayoresCalificaciones(short año, int filtroTrimestre, DataGridView dataGridView1)
        {
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.listadoMayoresCalificaciones", conn,
            new SqlParameter("@Año", año),
            new SqlParameter("@Trimestre", filtroTrimestre));

            Utiles.SQL.llenarDataGrid(dataGridView1, conn, cmd);
        }

        internal static void clientesMayoresPublicacionesSinCalif(short año, int filtroTrimestre, DataGridView dataGridView1)
        {
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.listadoMayoresSinCalificaciones", conn,
              new SqlParameter("@Año", año),
            new SqlParameter("@Trimestre", filtroTrimestre));


            Utiles.SQL.llenarDataGrid(dataGridView1, conn, cmd);
        }
    }
}
