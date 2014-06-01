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
            Entidades.Ent_Usuario usuario = new Entidades.Ent_Usuario();

            try
            {
                if (validarUsuario() == 1)
                {
                    Registro_de_Usuario.Registro Reg1 = new Registro_de_Usuario.Registro();
                    Reg1.Show();
                }
                else {
                    throw new Excepciones.InexistenciaUsuario("Usuario o contraseña inválida");
                }
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            
        }
            private int validarUsuario()
            {

                  List<Entidades.Ent_Usuario> listaUsuarios = Datos.Dat_Usuario.obtenerTodosLosUsuarios();

                  Entidades.Ent_Usuario pusuario = new Entidades.Ent_Usuario();

                  pusuario.Usuario = txtBoxUser.Text;
                  pusuario.Contraseña = txtBoxPass.Text;


                 return( Datos.Dat_Usuario.validarUsuario(pusuario));
                  
            }

        }

    }

