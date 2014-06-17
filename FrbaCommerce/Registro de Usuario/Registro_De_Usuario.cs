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
            try
            {

                Utiles.Validaciones.validarDatosObligatorios(this);
                Utiles.Validaciones.controlDeUsuario(Datos.Dat_Usuario.validarUserName(txtUser.Text));
                
                String pwHash = Datos.Dat_Usuario.hashearSHA256(txtPass.Text);
                Decimal idUsuario = 0;
                int estado = 1;
                Int16 rol = Convert.ToInt16(cboRol.SelectedValue);
                switch (rol)
                {
                    case 1:
                        Abm_Cliente.Alta altCli = new Abm_Cliente.Alta(true);
                        altCli.ShowDialog();
                        this.Hide();
                        idUsuario = altCli.IdUsuario;
                        break;
                    case 2:
                        Abm_Empresa.Alta altEmp = new FrbaCommerce.Abm_Empresa.Alta(true);
                        altEmp.ShowDialog();
                        this.Hide();
                        idUsuario = altEmp.IdUsuario;
                        break;
                }
                if(idUsuario != 0){
                Datos.Dat_Usuario.CrearNuevoUsuario(txtUser.Text, pwHash, rol, idUsuario, estado);
                Mensajes.Exitos.UsuarioRegistrado();
                };
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Utiles.Ventanas.CambiarPw newPw = new FrbaCommerce.Utiles.Ventanas.CambiarPw();
            newPw.ShowDialog();
            Close();
        }

          }
}
