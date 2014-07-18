using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Gestion_de_Preguntas
{
    public partial class VerRespuestas : Form
    {
        public VerRespuestas(Decimal usuario)
        {
            InitializeComponent();
            Datos.Dat_Preguntas.listaDePreguntaRespuesta(dataGridView1, usuario);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        }
}
