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
            this.posiblidadesDeLoggeo = 2;

        }

        private int posiblidadesDeLoggeo;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int posiblidadesDeLoggeoAnt = this.posiblidadesDeLoggeo;
                Datos.Dat_Usuario.validarUserName(txtBoxUser.Text); //Valida si el e usuario existe

                Entidades.Ent_Usuario pusuario = Datos.Dat_Usuario.obtenerCamposDe(txtBoxUser.Text);//busca los datos del usuario

                String contraseñaIngresada = Datos.Dat_Usuario.hashearSHA256(txtBoxPass.Text);//Hashea la pw ingresada

               
                //Esto se fija si la contraseña es la misma. si no es la misma disminuye 1 la posibilidad de logearse
                posiblidadesDeLoggeo = Datos.Dat_Usuario.validarContraseña(pusuario.Contraseña, contraseñaIngresada, posiblidadesDeLoggeo);
                
                Datos.Dat_Usuario.dispararExcepcionLogin(posiblidadesDeLoggeoAnt, posiblidadesDeLoggeo);

                //verifica si las posibilidades son 0 y bloquea el usario
                Datos.Dat_Usuario.bloquearUsuario(posiblidadesDeLoggeo, pusuario.Rol, pusuario.IdUsuario);

                abrirVentanas(pusuario.Rol);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void abrirVentanas(decimal rol)
        {
            switch (Convert.ToInt16(rol))
            {
                case 3:

                    Roles.Rol_Admin admin = new Roles.Rol_Admin();
                    admin.Show();
                    this.Close();

                    break;


                case 2:

                    Roles.Rol_Empresa empresa = new Roles.Rol_Empresa();
                    empresa.Show();
                    this.Close();

                    break;


                case 1:

                    Roles.Rol_Cliente cliente = new Roles.Rol_Cliente();
                    cliente.Show();
                    this.Close();

                    break;



            }
        }


    }

}

