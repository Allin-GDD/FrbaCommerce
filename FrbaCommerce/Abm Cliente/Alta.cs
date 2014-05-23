using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FrbaCommerce.Abm_Cliente
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
            cboTipoDoc.DataSource = Datos.Dat_Cliente.ObtenerTipoDoc();
            cboTipoDoc.DisplayMember = "tipo";
            cboTipoDoc.ValueMember = "codigo";
        }

        private void btmGuardar_Click(object sender, EventArgs e)
        {
            
           try
            {
                Entidades.Ent_Cliente cliente = new Entidades.Ent_Cliente();
                inicializarCliente(cliente);

                    int resultado = Datos.Dat_Cliente.AgregarCliente(cliente);

                    if (resultado > 0)
                    {
                        Mensajes.Exitos.ExitoAlGuardaLosDatos();
                    }
                    else
                    {
                        Mensajes.Errores.ErrorAlGuardarDatos();
                        
                    }
               
            }

            catch (FormatException)
            {
                Mensajes.Errores.ErrorAlIngresarDatos();
            }
        }
       
        
        private void inicializarCliente(Entidades.Ent_Cliente cliente)
        {
            cliente.Nombre = Convert.ToString(txtNombre.Text);
            cliente.Apellido = Convert.ToString(txtApellido.Text);
            cliente.Dni = Convert.ToInt64(txtDNI.Text);
            cliente.Tipo_dni = Convert.ToInt16(cboTipoDoc.SelectedValue);
            cliente.Fecha_Nac = Convert.ToString(txtFechaNac.Text);
            cliente.Mail = Convert.ToString(txtMail.Text);
            cliente.Dom_Calle = Convert.ToString(txtCalle.Text);
            cliente.Nro_Calle = Convert.ToInt64(txtNroCalle.Text);
            cliente.Piso = Convert.ToInt64(txtNroPiso.Text);//no me importa que sea nulo
            cliente.Dpto = Convert.ToString(txtDpto.Text);//no me importa que sea nulo
            cliente.Cod_Postal = Convert.ToString(txtCodPostal.Text);
            cliente.Telefono = Convert.ToString(txtTelefono.Text);
            cliente.Localidad = Convert.ToString(txtLocalidad.Text);

        }


        private void btmLimpiar_Click(object sender, EventArgs e)
        {
           
            ClearTextBoxes();
        }
        
        
        
        public void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }


    }
}
