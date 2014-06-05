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
    public partial class Rol_Admin : Form
    {
        public Rol_Admin()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AbmCliente_Click(object sender, EventArgs e)
        {
            VentanaCliente cliente = new VentanaCliente();
            
        }

        private void AbmEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaVisibilidad ventana = new VentanaVisibilidad();
        }
    }
}
