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
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
            Utiles.Inicializar.comboBoxFuncionalidades(cmbFuncionalidad);
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

<<<<<<< HEAD
=======

>>>>>>> b055948a8c900f7476f0ca06212c821b70489399
                Decimal rol = Datos.Dat_Rol.obtenerIdRol(txtNombre.Text);

                Datos.Dat_Rol.agregarFuncionabilidad(rol, Convert.ToInt32(cmbFuncionalidad.SelectedValue));


            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            Utiles.LimpiarTexto.LimpiarTextBox(this);
            Utiles.LimpiarTexto.BlanquearControls(this);
        }

        
        
    }
}
