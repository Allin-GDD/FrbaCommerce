﻿using System;
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

        public bool validarAlta;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                Utiles.Validaciones.validarDatosObligatorios(this);
                Utiles.Validaciones.controlDeUsuario(Datos.Dat_Usuario.validarUserName(txtUser.Text));
                
                String pwHash = Datos.Dat_Usuario.hashearSHA256(txtPass.Text);
                
                int estado = 1;
            
                Int16 rol = Convert.ToInt16(cboRol.SelectedValue);

                Datos.Dat_Usuario.CrearNuevoUsuario(txtUser.Text, pwHash, rol, estado);
                Decimal idUsuario = Datos.Dat_Usuario.getIdUsuario(txtUser.Text);
                switch (rol)
                {
                    case 1:
                        Abm_Cliente.Alta altCli = new Abm_Cliente.Alta(idUsuario);
                        this.Hide();
                        altCli.ShowDialog();
                        validarAlta = altCli.IsComplete;
                        break;
                    case 2:
                        Abm_Empresa.Alta altEmp = new Abm_Empresa.Alta(idUsuario);
                        altEmp.ShowDialog();
                        validarAlta = altEmp.IsComplete;
                        this.Hide();
                        break;
                }

                if (validarAlta)
                {
                    Mensajes.Exitos.UsuarioRegistrado();
                }
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

          
          }
}
