using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.ABM_Rol
{
    public partial class Listado : Form
    {
        public Listado()
        {
            InitializeComponent();
           
        }

          private void button2_Click(object sender, EventArgs e)
        {
  
            Datos.Dat_Rol.filtarRol(txtNombre.Text,dataGridView1);
        }

          private void button1_Click(object sender, EventArgs e)
          {
              Utiles.LimpiarTexto.LimpiarTextBox(this);
              Utiles.LimpiarTexto.BlanquearControls(this);
          }
    }
}
