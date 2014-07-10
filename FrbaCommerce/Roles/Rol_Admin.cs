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

            List<Int32> funcionalidades = Datos.Dat_Usuario.validarFuncionalidades("Admin");
         
        }

        private List<int> funcionalidades = new List<int>(); 
        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AbmCliente_Click(object sender, EventArgs e)
        {
            if(funcionalidades.Contains(1)){
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
            if(funcionalidades.Contains(2)){
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
             if(funcionalidades.Contains(4)){
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
            if(funcionalidades.Contains(3))
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
            if (funcionalidades.Contains(6))
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
            if (funcionalidades.Contains(5))
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
