using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Entidades;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class Modificación : Form
    {
  
        public Modificación(Decimal idSeleccionado, bool isUsuario)
        {
            
            InitializeComponent();
            this.clienteAModificar = idSeleccionado;
            //inicializo el comboBox Tipo de documento con los tipos que hay en la BD por defecto.
            Utiles.Inicializar.comboBoxTipoDoc(cboTipoDoc);
            txtDNI.Enabled = false;
            cargarDatosDelClienteSeleccionado();

            //El modificar lo puede ejecutar tanto el usuario como el administrador. 
            //Si lo ejecuta el administrador se mostrarán la opción de habilitar si lo hace el cliente se pondrán ocultos
            if (isUsuario)
            {
                lblHabil.Visible = false;
                cmbHabilitado.Visible = false;
            }
             Utiles.Inicializar.comboBoxHabilitado(cmbHabilitado, idSeleccionado); 
           


        }
        public Entidades.Ent_Cliente clienteAnt;
        public String DniAnt;
        public String TelefonoAnt;
        public short TipoDoc;
        public Decimal clienteAModificar;

        private void cargarDatosDelClienteSeleccionado()
        {
            clienteAnt = Datos.Dat_Cliente.buscarCliente(clienteAModificar);
            txtNombre.Text = clienteAnt.Nombre;
            txtApellido.Text = clienteAnt.Apellido;
            txtDNI.Text = Convert.ToString(clienteAnt.Dni);
            txtNroCalle.Text = Convert.ToString(clienteAnt.Nro_Calle);
            txtCodPostal.Text = clienteAnt.Cod_Postal;
            txtCalle.Text = clienteAnt.Dom_Calle;
            txtDpto.Text = clienteAnt.Dpto;
            txtFechaNac.Text = Convert.ToString(clienteAnt.Fecha_Nac);
            txtNroPiso.Text = Convert.ToString(clienteAnt.Piso);
            txtMail.Text = clienteAnt.Mail;
            txtTelefono.Text = clienteAnt.Telefono;
            txtLocalidad.Text = clienteAnt.Localidad;
            cboTipoDoc.Text = clienteAnt.Tipo_DocNom;

            this.DniAnt = clienteAnt.Dni;
            this.TelefonoAnt = clienteAnt.Telefono;    
           
        }

     


        private void btmGuardar_Click(object sender, EventArgs e)
        {
            Entidades.Ent_Cliente cliente = new Entidades.Ent_Cliente();

            
            try
            {
                Ent_TxtPersona validaciones = new Ent_TxtPersona();
                iniciarCheckText(validaciones);
                //hace todas las validaciones
                Utiles.Validaciones.evaluarPersona(validaciones, this);

                //Inicializa el cliente con datos correctos
                inicializarCliente(cliente);
                //actualiza los datos, por los ingresados
                Datos.Dat_Cliente.actualizarCamposACliente(cliente, clienteAModificar);
                //cambia el estado del usuario si es Administrador
                Datos.Dat_Usuario.actualizarEstadoUsuario(Convert.ToInt16(cmbHabilitado.SelectedValue),clienteAModificar);
                Close();

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void iniciarCheckText(Ent_TxtPersona validaciones)
        {
            validaciones.NroCalle = txtNroCalle;
            validaciones.DNI = txtDNI;
            validaciones.Telefono = txtTelefono;
            validaciones.Fecha = txtFechaNac;
            validaciones.Piso = txtNroPiso;
            validaciones.CUIT = null;
            validaciones.CUITAnt = null;
            validaciones.TipoDoc = Convert.ToInt16(cboTipoDoc.SelectedValue);
            validaciones.DNIAnt = this.DniAnt;
            validaciones.TelefonoAnt = this.TelefonoAnt;
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
            Utiles.LimpiarTexto.LimpiarMaskedTextBox(this);
            Utiles.LimpiarTexto.BlanquearControls(this);
        }

            private void cboTipoDoc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Utiles.Inicializar.alteraComboboxTipoDoc(cboTipoDoc, txtDNI);

        }

     

    
    
    
    
    }
}