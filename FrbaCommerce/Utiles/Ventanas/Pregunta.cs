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
        public Pregunta(Decimal idUsuario, String rol, decimal codigoPublicacion, String publicador)
        {

            InitializeComponent();
            Decimal rolAsignado;
            if (rol == "E")
            {
                rolAsignado = 2;
            }
            else {
                rolAsignado = 1;
            }

            this.Publicador = publicador;
            this.codigoPub = codigoPublicacion;
            usuario = Datos.Dat_Usuario.getNameUser(idUsuario, rolAsignado);
        }

        private String Publicador;
        private String usuario;
        private Decimal codigoPub; 

        private void button1_Click(object sender, EventArgs e)
        {
           if(String.IsNullOrEmpty(txtPregunta.Text)) throw new Excepciones.NulidadDeCamposACompletar("De escribir una pregunta");
           Datos.Dat_Preguntas.AgregarPregunta(usuario, codigoPub,txtPregunta.Text,Publicador);
           Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utiles.LimpiarTexto.LimpiarTextBox(this);
        }
     
    }
}
