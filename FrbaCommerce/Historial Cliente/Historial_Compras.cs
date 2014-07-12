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
    public partial class Historial_Compras : Form
    {
        DataTable dtSource;
        Decimal idCliente;
        public Historial_Compras(Decimal id)
        {
            InitializeComponent();
            idCliente = id;
            inicializarListado();
        }

        private void inicializarListado()
        {
            try
            {
                DataTable tabla = new DataTable();

                SqlConnection conn = DBConexion.obtenerConexion();

                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.historialCompras", conn,
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
