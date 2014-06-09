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
    public partial class VentanaRol : Form
    {
        public VentanaRol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ABM_Rol.Alta rol = new FrbaCommerce.ABM_Rol.Alta();
            rol.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ABM_Rol.Listado rol = new FrbaCommerce.ABM_Rol.Listado();
            rol.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ABM_Rol.Listado_de_selección rol = new FrbaCommerce.ABM_Rol.Listado_de_selección();
            rol.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
