using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Utiles.Ventanas
{
    public partial class TipearRespuesta : Form
    {
        public TipearRespuesta(Int32 id)
        {
            InitializeComponent();
            this.IdPreyRes = id;
            txtPregunta.Text = Datos.Dat_Preguntas.buscarPregunta(id);
        }

        private Int32 IdPreyRes;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtRespuesta.Text)) throw new Excepciones.NulidadDeCamposACompletar("El campo pregunta es obligatorio");

                Datos.Dat_Preguntas.agregarRespuestaA(IdPreyRes, txtRespuesta.Text);

                Mensajes.Exitos.ExitoAlGuardaLosDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtRespuesta.Clear();
        }
    }
}
