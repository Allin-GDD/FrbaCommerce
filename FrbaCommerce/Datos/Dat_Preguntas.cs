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
        public static void listadoDePreguntas(string usuario, DataGridView dataGridView1)
        {
            //char rol;
            //Entidades.Ent_Usuario pusuario = Datos.Dat_Usuario.obtenerCamposDe(usuario);
            //if(pusuario.Rol == 1)
            //{rol = 'C';}
            //else { rol = 'E'; }

            try
            {
                SqlConnection conn = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.listadoDePreguntasAResponder", conn,
                new SqlParameter("@Usuario", usuario));

                Utiles.SQL.llenarDataGrid(dataGridView1, conn, cmd);

                dataGridView1.Columns["Id"].Visible = false;

                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                dataGridView1.Columns.Add(btn);
                btn.HeaderText = "¿Responder?";
                btn.Text = "Responder";
                btn.Name = "btn";
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
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.obtenerPregunta", conn,
            new SqlParameter("@Id", idSelect));
            SqlDataReader lectura = cmd.ExecuteReader();

            lectura.Read();

            String pregunta = lectura.GetString(0);
            return pregunta;
        }

        public static void agregarRespuestaA(int IdPreyRes, String respuesta)
        {
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.agregarRespuesta", conn,
            new SqlParameter("@Id", IdPreyRes),
            new SqlParameter("@Respuesta", respuesta));

            int retorno = cmd.ExecuteNonQuery();
            Mensajes.Generales.validarAlta(retorno);
        }

        internal static void listaDePreguntaRespuesta(DataGridView dataGridView1, string usuario)
        {
            try
            {
                SqlConnection conn = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.listadoDeRespYProducto", conn,
                new SqlParameter("@Id", usuario));
                Utiles.SQL.llenarDataGrid(dataGridView1, conn, cmd);
            }
            catch (Exception)
            {
                Mensajes.Errores.NoHayConexion();
            }

        }
    }
}
