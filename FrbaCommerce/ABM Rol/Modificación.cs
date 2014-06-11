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
            Utiles.Inicializar.comboBoxHabilitadoRol(cmbHabilitado,idSeleccionado);

            txtNombre.Text = Datos.Dat_Rol.obtenerNombreIdRol(idSeleccionado);
            this.nombreRolAnt = Datos.Dat_Rol.obtenerNombreIdRol(idSeleccionado);
           
        }
        private String nombreRolAnt;
            private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Decimal rol = verificarSiElRolYaExiste();

                Datos.Dat_Funcionalidad.chequeoDeAddFuncionalidad(chkAgregar, rol, Convert.ToInt32(cmbTodaFunc.SelectedValue));
                Datos.Dat_Funcionalidad.chequeoRemoveFuncioalidad(chkQuitar, rol, Convert.ToInt32(cmbPropias.SelectedValue));

                Datos.Dat_Rol.actualizarEstadoRol(Convert.ToInt32(cmbHabilitado.SelectedValue),rol);
                this.Close();
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private Decimal verificarSiElRolYaExiste()
            {
                if (nombreRolAnt != txtNombre.Text)
                {
                    Utiles.Validaciones.evaluarRol(txtNombre, this);
                    Datos.Dat_Rol.agregarRol(txtNombre.Text);
                }
                Decimal rol = Datos.Dat_Rol.obtenerIdRol(txtNombre.Text);
                return rol;
            }

            private void btnLimpiar_Click(object sender, EventArgs e)
            {
                Utiles.LimpiarTexto.LimpiarTextBox(this);
            }

           


        }

    

     
    }

