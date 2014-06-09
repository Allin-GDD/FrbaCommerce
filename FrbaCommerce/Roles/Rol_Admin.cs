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
            Roles.VentanaCliente cliente = new VentanaCliente();
            cliente.Show();
            
        }

        private void AbmEmpresa_Click(object sender, EventArgs e)
        {
            Roles.VentanaEmpresa empresa = new Roles.VentanaEmpresa();
            empresa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaVisibilidad ventana = new VentanaVisibilidad();
            ventana.Show();
        }
    }
}
