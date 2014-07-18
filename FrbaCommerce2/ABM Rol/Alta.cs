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
            listView1.CheckBoxes = true;
            Utiles.Inicializar.listViewFunc(listView1);
            

            
        }
        private Decimal IdRol;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                //Verifica si lo puso bien y si ya no existe el rol
                Utiles.Validaciones.evaluarRol(txtNombre, this,listView1);
                //agregar el rol
                int i = Datos.Dat_Rol.agregarRol(txtNombre.Text);
                IdRol = Datos.Dat_Rol.obtenerIdRol(txtNombre.Text);
                //Agrega todas las funcionalidades marcadas
                Datos.Dat_Funcionalidad.agregarFuncionabilidadesARol(IdRol, listView1);


                Mensajes.Generales.validarAlta(i);
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
            listView1.Clear();
            Utiles.Inicializar.listViewFunc(listView1);
        }
    }
}
