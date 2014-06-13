using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Registro_de_Usuario
{
    public partial class Registro_De_Usuario : Form
    {
        public Registro_De_Usuario()
        {
            InitializeComponent();
            Utiles.Inicializar.comboBoxRol(cboRol);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            Datos.Dat_Usuario.validarUserName(txtUser.Text);

        }

       
    }
}
