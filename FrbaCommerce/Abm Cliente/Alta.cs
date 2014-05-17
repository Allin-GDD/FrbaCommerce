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
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void btmGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Dni = Convert.ToInt64(txtDNI.Text);
            cliente.Tipo_dni = Convert.ToInt16(cmTipoDoc.Text);
            cliente.Fecha_Nac = txtFechaNac.Text;
            cliente.Mail = txtMail.Text;
            cliente.Dom_Calle = txtCalle.Text;
            cliente.Nro_Calle = Convert.ToInt64(txtNroCalle.Text);
            cliente.Piso = Convert.ToInt64(txtNroPiso.Text);
            cliente.Dpto = txtDpto.Text;
            cliente.Cod_Postal = txtCodPostal.Text;
            cliente.Telefono = txtTelefono.Text;

            int resultado = ClienteDAL.AgregarCliente(cliente);

            if (resultado > 1)
            {
                MessageBox.Show("Datos guardados exitosamente", "Guardar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Los datos no se han podido guardar", "Guardar Cliente", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }


        private void btmLimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtDNI.Clear();
            txtCalle.Clear();
            txtCodPostal.Clear();
            txtFechaNac.Clear();
            txtMail.Clear();
            txtNroPiso.Clear();
            txtTelefono.Clear();
            txtLocalidad.Clear();
            txtNroCalle.Clear();
            txtDpto.Clear();



        }


    }
}
