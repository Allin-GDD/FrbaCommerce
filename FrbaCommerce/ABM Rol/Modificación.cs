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
            this.nombreRolAnt = Datos.Dat_Rol.obtenerNombreIdRol(idSeleccionado);
            txtNombre.Text = this.nombreRolAnt;
            this.IdRol = idSeleccionado;
           
        }
        private String nombreRolAnt;
        private Decimal IdRol;
        private Int32 func_A_Agregar;
        private Int32 func_A_ASacar;

            private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                Utiles.LimpiarTexto.BlanquearControls(this);
                List<String> errores = new List<string>();
                  if (nombreRolAnt != txtNombre.Text)
                {
                   errores.Add(Utiles.Validaciones.validarUnSoloTxt(txtNombre));
                    Datos.Dat_Rol.reemplazarNombre(IdRol, txtNombre.Text);
                }

                  errores.Add(Utiles.Validaciones.evaluarCheck(chkAgregar, txtAgregar));
                  errores.Add(Utiles.Validaciones.evaluarCheck(chkQuitar, txtQuitar));
                  Mensajes.Generales.evaluarErrores(errores);

                //CHEQUEA SI TIENE QUE AGREGAR O SACAR FUNCIONALIDAD
                Datos.Dat_Funcionalidad.chequeoDeAddFuncionalidad(chkAgregar, IdRol,func_A_Agregar);
                Datos.Dat_Funcionalidad.chequeoRemoveFuncioalidad(chkQuitar, IdRol, func_A_ASacar);


                //CAMBIA EL ESTADO DE ROL (HABILITADO O DESHABILITADO)
                Datos.Dat_Rol.actualizarEstadoRol(Convert.ToInt32(cmbHabilitado.SelectedValue), IdRol);
                reiniciarAppSiEsAdminYQuitoFunc();
                this.Close();
                
           }
            catch (Exception ex) {
               MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private void reiniciarAppSiEsAdminYQuitoFunc()
            {
                if (chkQuitar.Checked && txtNombre.Text == "Admin")
                {

                    MessageBox.Show("La aplicación se reiniciará", "Reinicio de aplicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
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
                txtAgregar.Text = list.Result;
                func_A_Agregar = list.ResultCodigo;
            }

            private void btnQuitar_Click(object sender, EventArgs e)
            {
                Utiles.Ventanas.ListaFuncionabilidades list = new FrbaCommerce.Utiles.Ventanas.ListaFuncionabilidades(IdRol);
                list.ShowDialog();
                txtQuitar.Text = list.Result;
                func_A_ASacar = list.ResultCodigo;
            }

           


        }

    

     
    }

