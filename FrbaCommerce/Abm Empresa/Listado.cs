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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entidades.Ent_ListadoEmpresa pEmpresa = new Entidades.Ent_ListadoEmpresa();
            try{
            pEmpresa.CUIT = txtCUIT.Text;
            pEmpresa.Mail = txtMail.Text;
            pEmpresa.Razon_Social = txtRazonSocial.Text;

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

        

       
    }
}
