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
    public partial class Listado : Form
    {
     

        public Listado()
        {
            InitializeComponent();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                Entidades.Ent_ListadoVisibilidad pvisibilidad = new Entidades.Ent_ListadoVisibilidad();

                pvisibilidad.Codigo = textBox1.Text;
                pvisibilidad.Descripcion = textBox2.Text;
                pvisibilidad.Precio = textBox3.Text;
                pvisibilidad.Porcentaje = textBox4.Text;

         
                Datos.Dat_Visibilidad.buscarListaDeVisibilidades(pvisibilidad, dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utiles.LimpiarTexto.LimpiarTextBox(this);
            Utiles.LimpiarTexto.BlanquearControls(this);
        }

    }
}
