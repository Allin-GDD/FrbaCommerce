using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Empresa
{
    public partial class Listado : Form
    {
        public Listado()
        {
            InitializeComponent();
            Utiles.Inicializar.comboBoxTipoDoc(cmbTipo_Doc);
            txtNroDoc.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entidades.Ent_ListadoEmpresa pEmpresa = new Entidades.Ent_ListadoEmpresa();
            try{
            pEmpresa.CUIT = txtNroDoc.Text;
            pEmpresa.Mail = txtMail.Text;
            pEmpresa.Razon_Social = txtRazonSocial.Text;
            pEmpresa.TipoDoc = Convert.ToInt16(cmbTipo_Doc.SelectedValue);

            Datos.Dat_Empresa.buscarListaDeEmpresa(pEmpresa, dataGridView1);
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utiles.LimpiarTexto.LimpiarTextBox(this);
            Utiles.LimpiarTexto.LimpiarDataGrid(dataGridView1);
        }

        private void cmbTipo_Doc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utiles.Inicializar.alteraComboboxTipoDoc(cmbTipo_Doc, txtNroDoc);
        }

        

       
    }
}
