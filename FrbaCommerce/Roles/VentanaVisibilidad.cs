using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Roles
{
    public partial class VentanaVisibilidad : Form
    {
        public VentanaVisibilidad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abm_Visibilidad.Alta visibilidad = new FrbaCommerce.Abm_Visibilidad.Alta();
            visibilidad.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
