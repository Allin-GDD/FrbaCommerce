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
        public Alta(bool isUser)
        {
            InitializeComponent();
            Utiles.Inicializar.comboBoxTipoDNI(cboTipoDoc);
            this.isCliente = isUser;

        }
        public bool isCliente;
        public Int32 rolDeUsuario = 1;
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
                Datos.Dat_Cliente.AgregarCliente(cliente);
                IdUsuario = Datos.Dat_Cliente.buscarIdCliente(cliente.Dni);


                if (!isCliente)
                {
                    int estado = 10;
                    Datos.Dat_Usuario.CrearNuevoUsuario(cliente.Mail, Convert.ToString(txtDNI.Text), rolDeUsuario, IdUsuario, estado); //el usuario va a ser el mail y la contraseña su dni

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
            pUtiles.Piso = txtNroPiso;
            pUtiles.NroCalle = txtNroCalle;
            pUtiles.Telefono = txtTelefono;
            pUtiles.Fecha = txtFechaNac;
            pUtiles.CUIT = null;
            pUtiles.TelefonoAnt = null;
            pUtiles.DNIAnt = null;
            pUtiles.CUITAnt = null;
        }

        private void inicializarCliente(Entidades.Ent_Cliente cliente)
        {
            cliente.Nombre = Convert.ToString(txtNombre.Text);
            cliente.Apellido = Convert.ToString(txtApellido.Text);
            cliente.Dni = Convert.ToInt32(txtDNI.Text);
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
            Utiles.LimpiarTexto.LimpiarMaskedTextBox(this);
            Utiles.LimpiarTexto.BlanquearControls(this);
        }
  }
}
