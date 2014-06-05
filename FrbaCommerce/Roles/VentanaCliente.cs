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
    public partial class VentanaCliente : Form
    {
        public VentanaCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abm_Cliente.Alta cliente = new Abm_Cliente.Alta();
            cliente.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Abm_Cliente.Listado_de_selección cliente = new FrbaCommerce.Abm_Cliente.Listado_de_selección();
            cliente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Abm_Cliente.Listado cliente = new FrbaCommerce.Abm_Cliente.Listado();
            cliente.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
