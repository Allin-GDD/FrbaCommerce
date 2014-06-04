using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.ABM_Rol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Utiles.Inicializar.comboBoxFuncionalidades();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNombre.Text))
                {   txtNombre.BackColor = Color.Coral;
                    throw new Excepciones.NulidadDeCamposACompletar("Faltan completar los siguientes campos");
                }

                Datos.Dat_Rol.verificarSiElRolYaExiste(txtNombre.Text);

                Datos.Dat_Rol.agregarRol(txtNombre.Text);

            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        
    }
}
