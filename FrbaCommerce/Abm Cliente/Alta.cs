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
            Utiles.Inicializar.comboBoxTipoDNI(cboTipoDoc);

        }
        public Int32 rolDeUsuario = 1;
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
                Datos.Dat_Telefonos.validarTelefono(txtTelefono.Text);
                Datos.Dat_Dni.validarDni(Convert.ToDecimal(txtDNI.Text));

               
                
                //Inicializa el cliente con datos correctos
                inicializarCliente(cliente);

                
                
                //Agrega el cliente a la DB
                Datos.Dat_Cliente.AgregarCliente(cliente);
                Decimal IdUsuario = Datos.Dat_Cliente.buscarIdCliente(cliente.Dni);

                //throw new Excepciones.DuplicacionDeDatos("mail: " + cliente.Mail + "dni: " + Convert.ToString(txtDNI.Text) + "rol: " + rolDeUsuario + "id" + IdUsuario); 
                Datos.Dat_Usuario.CrearNuevoUsuario(cliente.Mail,Convert.ToString(txtDNI.Text), rolDeUsuario,IdUsuario);
                //el usuario va a ser el mail y la contraseña su dni

                this.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

    

       

        private void validarTipoDeDatosIngresados()
        {

            
            Utiles.Validaciones.ValidarTipoDecimal(txtDNI, txtNroCalle);

            if (!string.IsNullOrEmpty(txtNroPiso.Text))
            {
                Utiles.Validaciones.ValidarTipoDecimal(txtNroPiso);
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

            Utiles.LimpiarTexto.LimpiarTextBox(this);
            Utiles.LimpiarTexto.LimpiarMaskedTextBox(this);
            Utiles.LimpiarTexto.BlanquearControls(this);
        }



        private void button1_Click(object sender, EventArgs e)
        {

            Abm_Cliente.Listado la = new Abm_Cliente.Listado();
            la.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Abm_Cliente.Listado_de_selección list = new Abm_Cliente.Listado_de_selección();
            list.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Generar_Publicacion.Generar_Publi list = new Generar_Publicacion.Generar_Publi("1");
            list.Show();
        }

       
    }
}
