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
        }
        private Int32 idFuncionabilidad;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                Utiles.Validaciones.evaluarRol(txtNombre, this);
                Datos.Dat_Rol.agregarRol(txtNombre.Text);
                Decimal rol = Datos.Dat_Rol.obtenerIdRol(txtNombre.Text);
                Datos.Dat_Rol.agregarFuncionabilidad(rol, idFuncionabilidad);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            Utiles.LimpiarTexto.LimpiarTextBox(this);
            Utiles.LimpiarTexto.BlanquearControls(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utiles.Ventanas.ListaFuncionabilidades list = new FrbaCommerce.Utiles.Ventanas.ListaFuncionabilidades(0);
            list.ShowDialog();
            txtFunc.Text = list.ResultShow;
            idFuncionabilidad = Convert.ToInt32(list.Result);
           
        }

       


    }
}
