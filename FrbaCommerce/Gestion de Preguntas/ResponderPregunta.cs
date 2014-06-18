using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Gestion_de_Preguntas
{
    public partial class ResponderPregunta : Form
    {
        public ResponderPregunta(String usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
        private String usuario;
        private void ResponderPregunta_Load(object sender, EventArgs e)
        {
            Datos.Dat_Preguntas.listadoDePreguntas(usuario, dataGridView1);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 idSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            if (e.ColumnIndex == dataGridView1.CurrentRow.Cells["btnResponder"].ColumnIndex && dataGridView1.DataSource != null)
            {
                Utiles.Ventanas.TipearRespuesta vent = new Utiles.Ventanas.TipearRespuesta(idSeleccionado);
                vent.ShowDialog();
                this.Refresh();
            }

        }
    }

}

