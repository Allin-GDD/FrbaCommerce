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

           List<Entidades.Ent_Telefono> listaTelefonos =  Datos.Dat_Cliente.obtenerTodosLosTelefonos();
           List<Entidades.Ent_Dni> listaDNI =  Datos.Dat_Cliente.obtenerTodosLosDni();
        }

        private void btmGuardar_Click(object sender, EventArgs e)
        {
            Entidades.Ent_Cliente cliente = new Entidades.Ent_Cliente();
         
           
                 try
                    {
                        validarNulidadDeDatosIngresados();   
                        //ACA TIENE QUE HACER ALGO PARA QUE DIGA SI LO QUE DEVUELVE ES LO QUE PIDE, PQ SINO DEVUELVE:
                        //"LA CADENA DE ENTRADA NO TIENE EL MISMO FORMATO"
                        inicializarCliente(cliente);

                       // Datos.Dat_Cliente.validarNulidad(cliente);

                        Entidades.Ent_Telefono ptelefono = new Entidades.Ent_Telefono();
                        Entidades.Ent_Dni pDni = new Entidades.Ent_Dni();

                       

                        // no me acuerdo si ya hacia esto de la nulidad pero por las dudas lo hice 

                        // Datos.Cliente.validarDniYTipo(pcliente.Dni,pcliente.Tipo_Doc);
                        //hacer el de arriba

                        ptelefono.Telefono = cliente.Telefono;
                        pDni.Dni = cliente.Dni;

                        
                        Datos.Dat_Telefonos.validarTelefono(ptelefono);
                        Datos.Dat_Dni.validarDni(pDni);


                        int resultado = Datos.Dat_Cliente.AgregarCliente(cliente);

                        if (resultado > 0)
                        {
                            Mensajes.Exitos.ExitoAlGuardaLosDatos();
                        }
                        else
                        {
                            Mensajes.Errores.ErrorAlGuardarDatos();

                        }

                    }catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                   
                  

          
           
        }

        private void validarNulidadDeDatosIngresados()
        {
            if(string.IsNullOrEmpty(txtNombre.Text)){
                throw new Excepciones.NulidadDeCamposACompletar("Falta el dato: Nombre");
            }
            if(string.IsNullOrEmpty(txtApellido.Text)){
                throw new Excepciones.NulidadDeCamposACompletar("Falta el dato: Apellido");
            }
            if(string.IsNullOrEmpty(txtDNI.Text)){
                throw new Excepciones.NulidadDeCamposACompletar("Falta el dato: DNI");
            }
            if(string.IsNullOrEmpty(txtLocalidad.Text)){
                throw new Excepciones.NulidadDeCamposACompletar("Falta el dato: Localidad");
            }
            if (string.IsNullOrEmpty(txtCalle.Text))
            {
                throw new Excepciones.NulidadDeCamposACompletar("Falta el dato: Calle");
            }
            if (string.IsNullOrEmpty(txtNroCalle.Text))
            {
                throw new Excepciones.NulidadDeCamposACompletar("Falta el dato: Número de Calle");
            }
            if (string.IsNullOrEmpty(txtCalle.Text))
            {
                throw new Excepciones.NulidadDeCamposACompletar("Falta el dato: Domicilio");
            }

            if (string.IsNullOrEmpty(txtCodPostal.Text))
            {
                throw new Excepciones.NulidadDeCamposACompletar("Falta el dato: Código Postal");
            }
            if (string.IsNullOrEmpty(txtFechaNac.Text))
            {
                throw new Excepciones.NulidadDeCamposACompletar("Falta el dato: Fecha de Nacimiento");
            }
            /*HACE LO MISMO QUE ARRIBA PERO CON TODOS LOS DATOS DEVUELVE MENSAJES DIFERENTES
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
            cliente.Piso = Convert.ToInt32(txtNroPiso.Text);
            cliente.Dpto = Convert.ToString(txtDpto.Text);
            cliente.Cod_Postal = Convert.ToString(txtCodPostal.Text);
            cliente.Telefono = Convert.ToString(txtTelefono.Text);
            cliente.Localidad = Convert.ToString(txtLocalidad.Text);

            
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


    }
}
