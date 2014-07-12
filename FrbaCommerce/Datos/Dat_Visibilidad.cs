using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace FrbaCommerce.Datos
{
    class Dat_Visibilidad
    {
        public static void AgregarVisibilidad(Entidades.Ent_Visibilidad pvisibilidad)
        {//agrega una nueva visibilidad a la tabla Visibilidad
            int retorno;
            using (SqlConnection conexion = DBConexion.obtenerConexion())
            {

                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.agregarNuevaVisibilidad", conexion,
                   new SqlParameter("@Codigo", pvisibilidad.Codigo),
                   new SqlParameter("@Descripcion", pvisibilidad.Descripcion),
                   new SqlParameter("@Precio", pvisibilidad.Precio),
                   new SqlParameter("@Porcentaje", pvisibilidad.Porcentaje),
                   new SqlParameter("@Estado", 1),
                   new SqlParameter("@Vencimiento", pvisibilidad.Vencimiento));

                retorno = cmd.ExecuteNonQuery();
                conexion.Close();
            }


            Mensajes.Generales.validarAlta(retorno);

        }


        public static Entidades.Ent_Visibilidad buscarVisibilidad(Int32 codigo)
        {//obtiene todos los campos de una visibilidad a partir del codigo
            Entidades.Ent_Visibilidad pVis = new Entidades.Ent_Visibilidad();
            pVis.Codigo = codigo;

            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarUnaVisibilidad", conn,
            new SqlParameter("@Codigo", Convert.ToDecimal(codigo)));

            SqlDataReader lectura = cmd.ExecuteReader();

            while (lectura.Read())
            {
                pVis.Descripcion = lectura.GetString(1);
                pVis.Precio = Convert.ToDouble(lectura.GetDecimal(2));
                pVis.Porcentaje = Convert.ToDouble(lectura.GetDecimal(3));
                pVis.Vencimiento = lectura.GetInt16(5);

            }
            conn.Close();

            return pVis;
        }



        public static void ActualizarCamposAVisibilidad(Entidades.Ent_Visibilidad pvisibilidad, int visibilidadAModificar)
        {//actualiza los campos de una visibilidad
            int retorno;
            using (SqlConnection conn = DBConexion.obtenerConexion())
            {
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.actualizarVisibilidad", conn,
                new SqlParameter("@Codigo", visibilidadAModificar),
                new SqlParameter("@Descripcion", pvisibilidad.Descripcion),
                new SqlParameter("@Precio", pvisibilidad.Precio),
                new SqlParameter("@Porcentaje", pvisibilidad.Porcentaje),
                new SqlParameter("@Vencimiento", pvisibilidad.Vencimiento));


                retorno = cmd.ExecuteNonQuery();
                conn.Close();
            }

            Mensajes.Generales.validarAlta(retorno);
        }

        public static void buscarListaDeVisibilidades(Entidades.Ent_ListadoVisibilidad pListado, DataGridView dataGridView1)
        {//Llena datagrid con visibilidades según el filtro elegido.
            
                SqlConnection conn = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.listaDeVisibilidades", conn,
                new SqlParameter("@Codigo", pListado.Codigo),
                new SqlParameter("@Descripcion", pListado.Descripcion),
                new SqlParameter("@Precio", pListado.Precio),
                new SqlParameter("@Porcentaje", pListado.Porcentaje));

                Utiles.SQL.llenarDataGrid(dataGridView1, conn, cmd);
            }


        public static List<String> obtenerTodasLasDescripciones()
        {//listado de todos las descripciones de las visibilidades. La usamos para evitar repetidos

            List<String> listDescripciones = new List<String>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("Select Descripcion from Visibilidad", conexion);
            SqlDataReader lectura = Comando.ExecuteReader();

            while (lectura.Read())
            {

                listDescripciones.Add(lectura.GetString(0));

            }
            conexion.Close();
            return listDescripciones;
        }

        public static bool validarDescripcion(TextBox descp) {
            //validar de que no haya visibilidades con el mismo nombre(descripcion)
            List<String> list = obtenerTodasLasDescripciones();
            foreach (String descripcion in list) {

                if (descp.Text == descripcion) {
                    descp.BackColor = Color.Coral;
                    return true;
                }
            }
            return false;
        }

    }
}