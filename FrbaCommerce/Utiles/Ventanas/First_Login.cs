using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Utiles.Ventanas
{
    public partial class First_Login : Form
    {
        public First_Login(String userName, Decimal rol, Decimal idUsuario)
        {
            InitializeComponent();
            label1.Text = "Bienvenido " + userName;
            Entidades.Ent_Usuario usuario = new FrbaCommerce.Entidades.Ent_Usuario();
            usuario.Usuario = userName;
            usuario.Rol = rol;
            usuario.IdUsuario = idUsuario;
            usuario2 = usuario;
        }

        private Entidades.Ent_Usuario usuario2;
        private void button1_Click(object sender, EventArgs e)
        {
            Datos.Dat_Usuario.actualizarContraseña(usuario2.Usuario, contraseña.Text);
            Datos.Dat_Usuario.ActualizarEstadoUsuario(1, usuario2.IdUsuario, usuario2.Rol);

            Mensajes.Exitos.ExitosAlActualizarLosDatos();
           
            this.Close();
        }

      
    }
}
