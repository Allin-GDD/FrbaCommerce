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
         

        }

     
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
               
                Datos.Dat_Usuario.validarUserName(txtBoxUser.Text); //Valida si el e usuario existe

                Entidades.Ent_Usuario pusuario = Datos.Dat_Usuario.obtenerCamposDe(txtBoxUser.Text);//busca los datos del usuario

                String contraseñaIngresada = Datos.Dat_Usuario.hashearSHA256(txtBoxPass.Text);//Hashea la pw ingresada

                Datos.Dat_Usuario.validarIntentos(pusuario.Intentos); //Valida si los intentos son menores a 3

                Datos.Dat_Usuario.validarEstado(pusuario.Estado); //valida si el estado del usuario es correcto
                
                if (pusuario.Contraseña == contraseñaIngresada)
                {
                    Datos.Dat_Usuario.actualizarIntentos(pusuario.Usuario,0);
                    abrirVentanas(pusuario.Rol);
                }
                else {
                    int intentosFallidos = pusuario.Intentos + 1;
                    Datos.Dat_Usuario.actualizarIntentos(pusuario.Usuario, intentosFallidos);
                    
                    Datos.Dat_Usuario.bloquearUsuario(Convert.ToInt16(intentosFallidos),pusuario.IdUsuario, pusuario.Rol);

                    Mensajes.Errores.ErrorEnlaContraseña(intentosFallidos);
                     }

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

