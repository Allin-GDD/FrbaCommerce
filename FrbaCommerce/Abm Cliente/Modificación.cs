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
        public Modificación(Int32 idSeleccionado)
        {
            Int16 rolCliente = 1;
            InitializeComponent();
            this.clienteAModificar = idSeleccionado;
            Utiles.Inicializar.comboBoxTipoDNI(cboTipoDoc);
            Utiles.Inicializar.comboBoxHabilitado(cmbHabilitado, idSeleccionado,rolCliente);
            cargarDatosDelClienteSeleccionado();
          
        }
        public Entidades.Ent_Cliente clienteAnt;
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
        }

        public Int32 clienteAModificar;


        private void btmGuardar_Click(object sender, EventArgs e)
        {
            Entidades.Ent_Cliente cliente = new Entidades.Ent_Cliente();

            try
            {
                //Verifica si los datos ingresados no son nulos
      
                Utiles.Validaciones.NulidadDeDatosIngresados(this, txtDpto, txtNroPiso, txtFechaNac, txtTelefono);

                //Verifica si lo que se estan ingresando es correcto
                validarTipoDeDatosIngresados();
                
                //Verifica si la fecha está dentro del limite

                Utiles.Validaciones.ValidarFecha(txtFechaNac.Text);

                //Verifica si el DNI y Telefono ya no existen
                verificarDNIyTelefono(); //se fija si no es igual al que ingreso antes y no lo cambia

                //Inicializa el cliente con datos correctos
                inicializarCliente(cliente);

                Datos.Dat_Cliente.ActualizarCamposACliente(cliente, clienteAModificar);
               

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void verificarDNIyTelefono()
        {
            
            if (clienteAnt.Telefono != txtTelefono.Text)
            {
                Datos.Dat_Telefonos.validarTelefono(txtTelefono.Text);
            }
            if (clienteAnt.Dni != Convert.ToDecimal(txtDNI.Text))
            {
                Datos.Dat_Dni.validarDni(Convert.ToDecimal(txtDNI.Text));
            }
        }



        private void validarTipoDeDatosIngresados()
        {
         
            Utiles.Validaciones.ValidarTipoDni(txtDNI.Text);

            Utiles.Validaciones.ValidarTipoNroCalle(txtNroCalle.Text);

            if (!string.IsNullOrEmpty(txtNroPiso.Text))
            {
                Utiles.Validaciones.ValidarTipoPiso(txtNroPiso.Text);
            }
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

     

    
    
    
    
    }
}