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

            pEmpresa.CUIT = txtCUIT.Text;
            pEmpresa.Mail = txtMail.Text;
            pEmpresa.Razon_Social = txtRazonSocial.Text;

            Datos.Dat_Empresa.buscarListaDeEmpresa(pEmpresa, dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
