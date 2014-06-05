using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Datos
{
    class Dat_Visibilidad
    {
        public static void AgregarVisibilidad(Entidades.Ent_Visibilidad pvisibilidad)
        {
            int retorno;
            using (SqlConnection conexion = DBConexion.obtenerConexion())
            {

                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.agregarNuevaVisibilidad", conexion,
                   new SqlParameter("@Codigo", pvisibilidad.Codigo),
                   new SqlParameter("@Descripcion", pvisibilidad.Descripcion),
                   new SqlParameter("@Precio", pvisibilidad.Precio),
                   new SqlParameter("@Porcentaje",pvisibilidad.Porcentaje),
               
                retorno = cmd.ExecuteNonQuery();
                conexion.Close();
            }


            Mensajes.Generales.validarAlta(retorno);

        }
    
           public static void ActualizarCamposAVisibilidad(Entidades.Ent_Visibilidad pvisibilidad,int visibilidadAModificar)
        {
            int retorno;
            using (SqlConnection conn = DBConexion.obtenerConexion())
            {
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.ActualizarVisibilidad", conn,
                new SqlParameter("@Codigo", visibilidadAModificar),
                new SqlParameter("@Descripcion", pvisibilidad.Descripcion),
                new SqlParameter("@Precio", pvisibilidad.Precio),
                new SqlParameter("@Porcentaje", pvisibilidad.Porcentaje),
               

                retorno = cmd.ExecuteNonQuery();
                conn.Close();
            }

            Mensajes.Generales.validarAlta(retorno);
        }
           public static void buscarListaDeVisibilidades(Entidades.Ent_Visibilidad pListado, DataGridView dataGridView1)
           {


               SqlConnection conn = DBConexion.obtenerConexion();
               SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.listaDeVisibilidades", conn,
               new SqlParameter("@Codigo", pListado.Codigo),
               new SqlParameter("@Descripcion", pListado.Descripcion),
               new SqlParameter("@Precio", pListado.Precio),
               new SqlParameter("@Porcentaje", pListado.Porcentaje),

               Utiles.SQL.llenarDataGrid(dataGridView1, conn, cmd);


           }
    }

}
