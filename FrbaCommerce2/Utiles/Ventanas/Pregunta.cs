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
    public partial class Pregunta : Form
    {
        public Pregunta(Decimal idUsuario, decimal codigoPublicacion)
        {

            InitializeComponent();
            this.usuario = idUsuario;
            this.codigoPub = codigoPublicacion;
        }

        private Decimal usuario;
        private Decimal codigoPub; 

        private void button1_Click(object sender, EventArgs e)
        {
           if(String.IsNullOrEmpty(txtPregunta.Text)) throw new Excepciones.NulidadDeCamposACompletar("Debe escribir una pregunta");
           Datos.Dat_Preguntas.AgregarPregunta(usuario, codigoPub,txtPregunta.Text);
           Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utiles.LimpiarTexto.LimpiarTextBox(this);
        }
     
    }
}
