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
        public Decimal IdUsuario;
        public Alta(Decimal IdUsuario)
        {
            InitializeComponent();
            Utiles.Inicializar.comboBoxTipoDoc(cboTipoDoc);
            this.IdUsuario = IdUsuario;
            txtDNI.Enabled = false;

        }
        private void btmGuardar_Click(object sender, EventArgs e)
        {
            Entidades.Ent_Cliente cliente = new Entidades.Ent_Cliente();
            Entidades.Ent_TxtPersona pUtiles = new Entidades.Ent_TxtPersona();
            iniciarCheckText(pUtiles);

            try
            {
                //Prueba todas las validaciones
                Utiles.Validaciones.evaluarPersona(pUtiles, this);
                
                //Inicializa el cliente con datos correctos
                inicializarCliente(cliente);
                
                //Agrega el cliente a la DB
                Datos.Dat_Cliente.crearClienteUsuario(cliente, IdUsuario);

                if (IdUsuario == 0)
                {//armo el if para que tire un mensaje de que el admin creo al cliente
                    Mensajes.Exitos.usuarioCreadoPorAdminOk();
                    }
                   
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    

        }

        private void iniciarCheckText(Entidades.Ent_TxtPersona pUtiles)
        {
           
            pUtiles.DNI = txtDNI;
            pUtiles.TipoDoc = Convert.ToInt16(cboTipoDoc.SelectedValue);
            pUtiles.Piso = txtNroPiso;
            pUtiles.NroCalle = txtNroCalle;
            pUtiles.Telefono = txtTelefono;
            pUtiles.Fecha = txtFechaNac;
            pUtiles.CUIT = null;
            pUtiles.TelefonoAnt = null;
            pUtiles.DNIAnt = null;
            pUtiles.CUITAnt = null;
            pUtiles.TipoDocAnt = 0;
        }

        private void inicializarCliente(Entidades.Ent_Cliente cliente)
        {
            cliente.Nombre = Convert.ToString(txtNombre.Text);
            cliente.Apellido = Convert.ToString(txtApellido.Text);
            cliente.Dni = Convert.ToString(txtDNI.Text);
            cliente.Tipo_dni = Convert.ToInt16(cboTipoDoc.SelectedValue);
            cliente.Fecha_Nac = Convert.ToString(txtFechaNac.Text);
            cliente.Mail = Convert.ToString(txtMail.Text);
            cliente.Dom_Calle = Convert.ToString(txtCalle.Text);
            cliente.Nro_Calle = Convert.ToInt32(txtNroCalle.Text);
            cliente.Dpto = Convert.ToString(txtDpto.Text);
            cliente.Cod_Postal = Convert.ToString(txtCodPostal.Text);
            cliente.Telefono = Convert.ToString(txtTelefono.Text);
            cliente.Localidad = Convert.ToString(txtLocalidad.Text);

            //hace esto para que pueda existir gente que no vive en edificio
            if (!string.IsNullOrEmpty(txtNroPiso.Text))
            {
                cliente.Piso = Convert.ToInt32(txtNroPiso.Text);
            }

        }

        private void btmLimpiar_Click(object sender, EventArgs e)
        {

            Utiles.LimpiarTexto.LimpiarTextBox(this);
            Utiles.Inicializar.comboBoxTipoDoc(cboTipoDoc);
            Utiles.LimpiarTexto.LimpiarMaskedTextBox(this);
            Utiles.LimpiarTexto.BlanquearControls(this);
        }

        private void cboTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utiles.Inicializar.alteraComboboxTipoDoc(cboTipoDoc,txtDNI);

               }
  }
}

