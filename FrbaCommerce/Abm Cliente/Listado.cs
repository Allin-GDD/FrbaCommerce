using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class Listado : Form
    {
        public Listado()
        {
            InitializeComponent(); 
            Utiles.Inicializar.comboBoxTipoDoc(cmbTipoDoc);
            txtDNI.Enabled = false;
         }
       

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Ent_ListadoCliente pCliente = new Entidades.Ent_ListadoCliente();
                
                pCliente.Nombre = txtNombre.Text;
                pCliente.Apellido = txtApellido.Text;
                pCliente.Dni = txtDNI.Text;
                pCliente.Mail = txtMail.Text;
                pCliente.Tipo_doc = Convert.ToInt16(cmbTipoDoc.SelectedValue);

                Datos.Dat_Cliente.buscarListaDeCliente(pCliente, dataGridView1);
               
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Utiles.LimpiarTexto.LimpiarTextBox(this);
            Utiles.LimpiarTexto.LimpiarDataGrid(dataGridView1);
        }

        private void cmbTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utiles.Inicializar.alteraComboboxTipoDoc(cmbTipoDoc, txtDNI);
        }

        
    }
}