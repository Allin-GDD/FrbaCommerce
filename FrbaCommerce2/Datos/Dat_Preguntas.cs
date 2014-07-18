using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FrbaCommerce.Datos
{
    class Dat_Preguntas
    {
        public static void listadoDePreguntas(Decimal usuario, DataGridView dataGridView1)
        {
            try
            {
                SqlConnection conn = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.allin.listadoDePreguntasAResponder", conn,
                new SqlParameter("@Usuario", usuario));

                Utiles.SQL.llenarDataGrid(dataGridView1, conn, cmd);

                dataGridView1.Columns["Id"].Visible = false;

                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                dataGridView1.Columns.Add(btn);
                btn.HeaderText = "¿Responder?";
                btn.Text = "Responder";
                btn.Name = "btnResponder";
                btn.UseColumnTextForButtonValue = true;
            }
            catch (Exception)
            {
                Mensajes.Errores.NoHayConexion();
            }

        }

        public static String buscarPregunta(int idSelect)
        {
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.allin.obtenerPregunta", conn,
            new SqlParameter("@Id", idSelect));
            SqlDataReader lectura = cmd.ExecuteReader();

            lectura.Read();

            String pregunta = lectura.GetString(0);
            return pregunta;
        }

        public static void agregarRespuestaA(int IdPreyRes, String respuesta)
        {
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.allin.agregarRespuesta", conn,
            new SqlParameter("@Id", IdPreyRes),
            new SqlParameter("@Respuesta", respuesta),
            new SqlParameter("@Fecha",DBConexion.fechaIngresadaPorElAdministrador()));

            int retorno = cmd.ExecuteNonQuery();
           // Mensajes.Generales.validarAlta(retorno);
        }

        public static void listaDePreguntaRespuesta(DataGridView dataGridView1, Decimal usuario)
        {
            try
            {
                SqlConnection conn = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.allin.listadoDeRespYProducto", conn,
                new SqlParameter("@Id", usuario));
                Utiles.SQL.llenarDataGrid(dataGridView1, conn, cmd);
            }
            catch (Exception)
            {
                Mensajes.Errores.NoHayConexion();
            }

        }

        public static void AgregarPregunta(Decimal usuario, decimal codigoPub, string pregunta)
        {
           SqlConnection conn = DBConexion.obtenerConexion();
           SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.allin.agregarUnaPregunta", conn,
               new SqlParameter("@UsuarioPreg", usuario),
               new SqlParameter("@Id_Publicacion", codigoPub),
               new SqlParameter("@Pregunta", pregunta));

           int retorno = cmd.ExecuteNonQuery();

           Mensajes.Generales.validarAlta(retorno);
        }
   }
}
