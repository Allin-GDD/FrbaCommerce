using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Visibilidad
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Entidades.Ent_Visibilidad visibilidad = new FrbaCommerce.Entidades.Ent_Visibilidad();

        }
        private void inicializarVisibilidad(Entidades.Ent_Visibilidad visibilidad)
        {

            visibilidad.Codigo = Convert.ToDecimal(textBox1.Text);
            visibilidad.Descripcion = Convert.ToString(textBox2.Text);
            visibilidad.Porcentaje = Convert.ToDouble(textBox3.Text);
            visibilidad.Precio = Convert.ToDouble(textBox4.Text);


        }

        private void btmLimpiar_Click(object sender, EventArgs e)
        {

            Utiles.LimpiarTexto.LimpiarTextBox(this);
            Utiles.LimpiarTexto.LimpiarMaskedTextBox(this);
            Utiles.LimpiarTexto.BlanquearControls(this);
        }


    }
}
