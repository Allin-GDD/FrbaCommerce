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
    public partial class Modificación : Form
    {
        public Modificación(Decimal idSeleccionado)
        {
            InitializeComponent();
            Utiles.Inicializar.comboBoxFuncionalidades(cmbTodaFunc);
            Utiles.Inicializar.comboBoxFuncionalidadesPropias(cmbPropias, idSeleccionado);
<<<<<<< HEAD
            txtNombre.Text = Datos.Dat_Rol.obtenerNombreIdRol(idSeleccionado);
            this.nombreRolAnt = Datos.Dat_Rol.obtenerNombreIdRol(idSeleccionado);
           
        }
        private String nombreRolAnt;
            private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Decimal rol = verificarSiElRolYaExiste();

                Datos.Dat_Funcionalidad.chequeoDeAddFuncionalidad(chkAgregar, rol);
                Datos.Dat_Funcionalidad.chequeoRemoveFuncioalidad(chkQuitar, rol);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private Decimal verificarSiElRolYaExiste()
            {
                if (nombreRolAnt != txtNombre.Text)
                {
                    Datos.Dat_Rol.verificarSiElRolYaExiste(txtNombre.Text);
                    Datos.Dat_Rol.agregarRol(txtNombre.Text);
                }
                Decimal rol = Datos.Dat_Rol.obtenerIdRol(txtNombre.Text);
                return rol;
            }  

=======
        }

            private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

>>>>>>> b055948a8c900f7476f0ca06212c821b70489399
     
    }
}
