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

        funcionalidades = Datos.Dat_Usuario.validarFuncionalidades("Admin");
         
        }

        private List<int> funcionalidades = new List<int>();
        private Int32 i;
        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AbmCliente_Click(object sender, EventArgs e)
        {
            i = 1;
            if (funcionalidades.Any(x => x == i))
            {
                Roles.VentanaCliente cliente = new VentanaCliente();
                this.Hide();
                cliente.ShowDialog();
                this.Show();
            }
            else{
                Mensajes.Errores.UsuarioNoTienePermisos();
            }
        }

        private void AbmEmpresa_Click(object sender, EventArgs e)
        {
            i = 2;
            if (funcionalidades.Any(x => x == i))
            {
            Roles.VentanaEmpresa empresa = new Roles.VentanaEmpresa();
            this.Hide();
            empresa.ShowDialog();
            this.Show();
            }
             else{
                Mensajes.Errores.UsuarioNoTienePermisos();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 4;
            if (funcionalidades.Any(x => x == i))
            {
            VentanaVisibilidad ventana = new VentanaVisibilidad();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }
             else{
                Mensajes.Errores.UsuarioNoTienePermisos();
            }
        }

        private void AbmRubro_Click(object sender, EventArgs e)
        {
           i = 3;
            if (funcionalidades.Any(x => x == i))
            {
            Roles.VentanaRol rol = new Roles.VentanaRol();
            this.Hide();
            rol.ShowDialog();
            this.Show();
        }
         else{
                Mensajes.Errores.UsuarioNoTienePermisos();
            }
        }

        private void ListadoEstadistico_Click(object sender, EventArgs e)
        {
             i = 6;
            if (funcionalidades.Any(x => x == i))
            {
                Listado_Estadistico.ListadoEstadistico list = new Listado_Estadistico.ListadoEstadistico();
                this.Hide();
                list.ShowDialog();
                this.Show();
            }
            else
            {
                Mensajes.Errores.UsuarioNoTienePermisos();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = 5;
            if (funcionalidades.Any(x => x == i))
            {
                Utiles.Ventanas.CambiarPw changpw = new FrbaCommerce.Utiles.Ventanas.CambiarPw(true);
                Hide();
                changpw.ShowDialog();
                Show();
            }
            else
            {
                Mensajes.Errores.UsuarioNoTienePermisos();
            }

        }
    }
}
