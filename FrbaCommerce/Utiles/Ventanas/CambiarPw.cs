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
    public partial class CambiarPw : Form
    {
        public CambiarPw(bool isAdm)
        {
            InitializeComponent();
            this.isAdm = isAdm;
            if (isAdm) {
                txtPwOriginal.Visible = false;
                label2.Visible = false;
            }
        }

        private bool isAdm;
        private void button2_Click(object sender, EventArgs e)
        {
            Utiles.LimpiarTexto.LimpiarTextBox(this);
            Utiles.LimpiarTexto.BlanquearControls(this);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Utiles.Validaciones.validarDatosObligatorios(this);

                if (Datos.Dat_Usuario.validarUserName(txtUser.Text) != 1) {
                    throw new Excepciones.InexistenciaUsuario("El usuario ingresado no existe");
                }

                if (txtNewPw1.Text != txtNewPw2.Text)
                {

                    txtNewPw2.BackColor = Color.Coral;
                    txtNewPw1.BackColor = Color.Coral;
                    throw new Excepciones.InexistenciaUsuario("Las contraseñas no cohinciden");
                }
                Entidades.Ent_Usuario pusuario = Datos.Dat_Usuario.obtenerCamposDe(txtUser.Text);
                if (!isAdm)
                {
                    String pwOriginal = Datos.Dat_Usuario.hashearSHA256(txtPwOriginal.Text);


                    if (pwOriginal != pusuario.Contraseña)
                    {
                        txtPwOriginal.BackColor = Color.Coral;
                        throw new Excepciones.InexistenciaUsuario("La contraseña ingresada no es válida");
                    }
                }

                Datos.Dat_Usuario.actualizarContraseña(pusuario.IdUsuario, txtNewPw1.Text);

                Mensajes.Exitos.ExitoAlGuardaLosDatos();
                Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            
               
        }
    }
}
