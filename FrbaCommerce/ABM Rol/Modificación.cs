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
            Utiles.Inicializar.comboBoxHabilitadoRol(cmbHabilitado,idSeleccionado);
            txtNombre.Text = Datos.Dat_Rol.obtenerNombreIdRol(idSeleccionado);
            this.nombreRolAnt = Datos.Dat_Rol.obtenerNombreIdRol(idSeleccionado);
            this.IdRol = idSeleccionado;
           
        }
        private String nombreRolAnt;
        private Decimal IdRol;
        private Int32 idAAgregar;
        private Int32 idASacar;

            private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Decimal rol = verificarSiElRolYaExiste();

                Datos.Dat_Funcionalidad.chequeoDeAddFuncionalidad(chkAgregar, rol, idAAgregar);
                Datos.Dat_Funcionalidad.chequeoRemoveFuncioalidad(chkQuitar, rol, idASacar);

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
                Utiles.LimpiarTexto.SacarCheckBox(this);
            }

            private void btnAgregar_Click(object sender, EventArgs e)
            {
                Utiles.Ventanas.ListaFuncionabilidades list = new FrbaCommerce.Utiles.Ventanas.ListaFuncionabilidades(0);
                list.ShowDialog();
                txtAgregar.Text = list.ResultShow;
                if (!string.IsNullOrEmpty(list.Result))  idAAgregar = Convert.ToInt32(list.Result);
            }

            private void btnQuitar_Click(object sender, EventArgs e)
            {
                Utiles.Ventanas.ListaFuncionabilidades list = new FrbaCommerce.Utiles.Ventanas.ListaFuncionabilidades(IdRol);
                list.ShowDialog();
                txtQuitar.Text = list.ResultShow;
                if(!string.IsNullOrEmpty(list.Result)) idASacar = Convert.ToInt32(list.Result);
            }

           


        }

    

     
    }

