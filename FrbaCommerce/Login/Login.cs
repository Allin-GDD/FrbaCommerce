using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Registro_de_Usuario;

namespace FrbaCommerce.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.primerLogin = true;
        }
        private bool primerLogin;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                //Valida si el e usuario existe
                Utiles.Validaciones.validarUsuario(Datos.Dat_Usuario.validarUserName(txtBoxUser.Text));
                //busca los datos del usuario
                Entidades.Ent_Usuario pusuario = Datos.Dat_Usuario.obtenerCamposDe(txtBoxUser.Text);

                //verifica si es la primera vez que ingresa al sistema
                primerLogin = Datos.Dat_Usuario.validarPrimerIngreso(txtBoxPass.Text, pusuario.Contraseña, pusuario, this);

                if (primerLogin)
                {
                    this.Close();
                }
                else
                {
                    String contraseñaIngresada = Datos.Dat_Usuario.hashearSHA256(txtBoxPass.Text);//Hashea la pw ingresada

                    Datos.Dat_Usuario.validarIntentos(pusuario.Intentos); //Valida si los intentos son menores a 3

                    Datos.Dat_Usuario.validarEstado(pusuario.Estado); //valida si el estado del usuario es correcto

                    Datos.Dat_Usuario.controlDeLogeo(pusuario, contraseñaIngresada, this); //Controla si la pw es correcta y abre las opciones correspondientes al rol de usuario
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        }
    }

