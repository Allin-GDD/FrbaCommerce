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
            
            cmbTipoDoc.DataSource = Datos.Dat_Cliente.ObtenerTipoDoc();
            cmbTipoDoc.DisplayMember = "tipo";
            cmbTipoDoc.ValueMember = "codigo";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entidades.Ent_Cliente pCliente = new Entidades.Ent_Cliente();

            pCliente.Nombre = txtNombre.Text;
            pCliente.Apellido = txtApellido.Text;
            pCliente.Tipo_dni = Convert.ToInt16(cmbTipoDoc.SelectedValue);

            if (!string.IsNullOrEmpty(txtDNI.Text))
            {
                pCliente.Dni = Convert.ToDecimal(txtDNI.Text);
            }

            dataGridView1.DataSource = Datos.Dat_Cliente.buscarLosClientes(pCliente);



        }

    
    }
}
