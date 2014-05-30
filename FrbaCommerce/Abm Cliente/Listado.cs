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
            Entidades.Ent_Listado pCliente = new Entidades.Ent_Listado();

            pCliente.Nombre = txtNombre.Text;
            pCliente.Apellido = txtApellido.Text;
            pCliente.Dni = txtDNI.Text;
            pCliente.Mail = txtMail.Text;
            pCliente.Tipo_dni = Convert.ToString(cmbTipoDoc.SelectedValue);

            Datos.Dat_Cliente.buscar(pCliente, dataGridView1);




        }

    
    }
}
