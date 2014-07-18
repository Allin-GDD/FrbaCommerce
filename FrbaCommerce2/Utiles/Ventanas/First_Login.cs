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
        public First_Login(Decimal idUsuario)
        {
            InitializeComponent();
            idUsuarioAAct = idUsuario;

         
        }

        private Decimal idUsuarioAAct;
        private void button1_Click(object sender, EventArgs e)
        {
            Datos.Dat_Usuario.actualizarContraseña(idUsuarioAAct, contraseña.Text);
            Datos.Dat_Usuario.actualizarEstadoUsuario(1, idUsuarioAAct);

            Mensajes.Exitos.ExitosAlActualizarLosDatos();
           
            this.Close();
        }

      
    }
}
