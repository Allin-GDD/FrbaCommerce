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
                
                //Agrega el cliente a la DB
                int resultado = Datos.Dat_Cliente.AgregarCliente(cliente);

                if (resultado > 0)
                {
                    Mensajes.Exitos.ExitoAlGuardaLosDatos();
                    this.Close();
                }
                else
                {
                    Mensajes.Errores.ErrorAlGuardarDatos();

                }

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
            Datos.Dat_Telefonos.validarTelefono(ptelefono);
            Datos.Dat_Dni.validarDni(pDni);
        }

        private void validarFecha()
        {
            Mensajes.Cliente.ValidarFecha(txtFechaNac.Text);
        }

        private void validarNulidadDeDatosIngresados()
        {

            Mensajes.Cliente.ValidarNulidadNombre(txtNombre.Text);
            Mensajes.Cliente.ValidarNulidadApellido(txtApellido.Text);
            Mensajes.Cliente.ValidarNulidadDNI(txtDNI.Text);
            Mensajes.Cliente.ValidarNulidadLocalidad(txtLocalidad.Text);
            Mensajes.Cliente.ValidarNulidadDomicilio(txtCalle.Text);
            Mensajes.Cliente.ValidarNulidadNroCalle(txtNroCalle.Text);
            Mensajes.Cliente.ValidarNulidadCodPostal(txtCodPostal.Text);
            Mensajes.Cliente.ValidarNulidadFechaNac(txtFechaNac.Text);

            /*HACE LO MISMO QUE ARRIBA PERO CON TODOS LOS DATOS PERO NO DEVUELVE MENSAJES DIFERENTES
             * LO PODEMOS USAR PARA AHORRAR CODIGO, PERO ES LO MISMO
             * Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (TextBox control in controls)
                    if (String.IsNullOrEmpty(control.Text))
                    {
                        throw new Excepciones.NulidadDeCamposACompletar("Faltan datos obligatorios");
                    };
            };*/
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


        private void btmLimpiar_Click(object sender, EventArgs e)
        {

            LimpiaTextBoxes();
            LimpiaMaskedTextBoxes();
        }


        public void LimpiaTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else
                    {
                        func(control.Controls);
                    }
            };

            func(Controls);
        }

        public void LimpiaMaskedTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is MaskedTextBox)
                    {
                        (control as MaskedTextBox).Clear();
                    }
                    else
                    {
                        func(control.Controls);
                    }
            };

            func(Controls);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Abm_Cliente.Listado la = new Abm_Cliente.Listado();
            la.Show();
           
        }

    }
}
