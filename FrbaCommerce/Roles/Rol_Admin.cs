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
            this.Hide();
            cliente.ShowDialog();
            this.Show();
          
        }

        private void AbmEmpresa_Click(object sender, EventArgs e)
        {
            Roles.VentanaEmpresa empresa = new Roles.VentanaEmpresa();
            this.Hide();
            empresa.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaVisibilidad ventana = new VentanaVisibilidad();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
            
        }

        private void AbmRubro_Click(object sender, EventArgs e)
        {
            Roles.VentanaRol rol = new Roles.VentanaRol();
            this.Hide();
            rol.ShowDialog();
            this.Show();
        }

        private void ListadoEstadistico_Click(object sender, EventArgs e)
        {
            Listado_Estadistico.ListadoEstadistico list = new Listado_Estadistico.ListadoEstadistico();
            this.Hide();
            list.ShowDialog();
            this.Show();
        }
    }
}
