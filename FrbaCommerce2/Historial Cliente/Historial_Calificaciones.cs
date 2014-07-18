using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Historial_Cliente
{
    public partial class Historial_Calificaciones : Form
    {
        DataTable dtSource;
        Decimal idCliente;
        public Historial_Calificaciones(Decimal id)
        {
            InitializeComponent();
            idCliente = id;
            inicializarListado1();
            inicializarListado2();
        }

        private void inicializarListado2()
        {
            try
            {
                DataTable tabla = new DataTable();

                SqlConnection conn = DBConexion.obtenerConexion();

                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.allin.historialCalificacionesRecibidas", conn,
                new SqlParameter("@Id", idCliente.ToString()));
                SqlDataAdapter da = new SqlDataAdapter { SelectCommand = cmd };
                da.Fill(tabla);
                conn.Close();


                dataGridView2.DataSource = tabla;
                dataGridView2.Refresh();
                dataGridView2.ClearSelection();

                this.dtSource = tabla;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inicializarListado1()
        {
            try
            {
                DataTable tabla = new DataTable();

                SqlConnection conn = DBConexion.obtenerConexion();

                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.allin.historialCalificacionesOtorgadas", conn,
                new SqlParameter("@Id", idCliente.ToString()));
                SqlDataAdapter da = new SqlDataAdapter { SelectCommand = cmd };
                da.Fill(tabla);
                conn.Close();


                dataGridView1.DataSource = tabla;
                dataGridView1.Refresh();
                dataGridView1.ClearSelection();

                this.dtSource = tabla;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
