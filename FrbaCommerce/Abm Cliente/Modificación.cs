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
            InitializeComponent();
            this.clienteAModificar = idSeleccionado;
            Utiles.Inicializar.comboBoxTipoDNI(cboTipoDoc);
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
                validarNulidadDeDatosIngresados();

                //Verifica si lo que se estan ingresando es correcto
                validarTipoDeDatosIngresados();
                //Verifica si la fecha está dentro del limite
                validarFecha();
                //Verifica si el DNI y Telefono ya no existen
                verificarDNIyTelefono();

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
            List<Entidades.Ent_Telefono> listaTelefonos = Datos.Dat_Cliente.obtenerTodosLosTelefonos();
            List<Entidades.Ent_Dni> listaDNI = Datos.Dat_Cliente.obtenerTodosLosDni();

            Entidades.Ent_Telefono ptelefono = new Entidades.Ent_Telefono();
            Entidades.Ent_Dni pDni = new Entidades.Ent_Dni();
            ptelefono.Telefono = txtTelefono.Text;
            pDni.Dni = Convert.ToDecimal(txtDNI.Text);

            if (clienteAnt.Telefono != ptelefono.Telefono)
            {
                Datos.Dat_Telefonos.validarTelefono(ptelefono);
            }
            if (clienteAnt.Dni != pDni.Dni)
            {
                Datos.Dat_Dni.validarDni(pDni);
            }
        }

        private void validarFecha()
        {
            Mensajes.Cliente.ValidarFecha(txtFechaNac.Text);
        }

        private void validarNulidadDeDatosIngresados()
        {
            Action<Control.ControlCollection> func = null;
            int i = 0;

            Utiles.LimpiarTexto.BlanquearControls(this);

            //Se fija si la maskText es nula o no
            if (!txtFechaNac.MaskCompleted)
            {
                txtFechaNac.BackColor = Color.Coral;
                i++;
            }
            //Esto se fija si los datos cargados son nulos o no. Con la excepción de los campo depto y piso
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                    {
                        if (string.IsNullOrEmpty(control.Text) && (control != txtDpto) && (control != txtNroPiso))
                        {
                            control.BackColor = Color.Coral;
                            i++;
                        }

                    }
                    else { func(control.Controls); }
            };

            func(Controls);


            if (i > 0)
            {
                throw new Excepciones.NulidadDeCamposACompletar("Faltan completar los siguientes campos");
            }
        }

        private void validarTipoDeDatosIngresados()
        {
            Mensajes.Cliente.ValidarTipoDni(txtDNI.Text);
            Mensajes.Cliente.ValidarTipoNroCalle(txtNroCalle.Text);

            if (!string.IsNullOrEmpty(txtNroPiso.Text))
            {
                Mensajes.Cliente.ValidarTipoPiso(txtNroPiso.Text);
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