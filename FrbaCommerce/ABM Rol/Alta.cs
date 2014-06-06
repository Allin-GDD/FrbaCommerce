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

               
                Utiles.Validaciones.validarUnaSolaNulidad(txtNombre);

                Datos.Dat_Rol.verificarSiElRolYaExiste(txtNombre.Text);
                Datos.Dat_Rol.agregarRol(txtNombre.Text);

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
