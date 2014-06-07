using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Abm_Empresa
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
            
        }

        public Int32 rolDeUsuario = 2;
    

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Entidades.Ent_Empresa empresa = new Entidades.Ent_Empresa();

            try
            {
                //Verifica si los datos ingresados no son nulos
               Utiles.Validaciones.NulidadDeDatosIngresados(this, Dpto, NroPiso,FecCre,Telefono,CUIT,CodPostal);

                
                //Verifica si lo que se estan ingresando es correcto
                validarTipoDeDatosIngresados();

                
                //Verifica si la fecha está dentro del limite
                Utiles.Validaciones.ValidarFecha(FecCre.Text);

                //Verifica si el DNI y Telefono ya no existen
                Datos.Dat_Telefonos.validarTelefono(Telefono.Text);
                Datos.Dat_Cuit.validarCuit(CUIT.Text);

               
                //Inicializa el cliente con datos correctos
                inicializarEmpresa(empresa);

                //Agrega el cliente a la DB
                Datos.Dat_Empresa.AgregarEmpresa(empresa);


                Datos.Dat_Usuario.CrearNuevoUsuario(empresa.Mail, empresa.CUIT, rolDeUsuario);
                //el usuario va a ser el mail y la contraseña su cuit


                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inicializarEmpresa(Entidades.Ent_Empresa empresa)
        {


            empresa.NombreContacto = Convert.ToString(NombreContacto.Text);
            empresa.RazonSocial = Convert.ToString(RazonSocial.Text);
            empresa.CUIT = Convert.ToString(CUIT.Text);
            empresa.Mail = Convert.ToString(Mail.Text);
            empresa.Telefono = Convert.ToString(Telefono.Text);
            empresa.Dom_Calle = Convert.ToString(Calle.Text);
            empresa.Nro_Calle = Convert.ToDecimal(NCalle.Text);
            empresa.Dpto = Convert.ToString(Dpto.Text);
            empresa.Localidad = Convert.ToString(Localidad.Text);
            empresa.Cod_Postal = Convert.ToString(CodPostal.Text);
            empresa.Ciudad = Convert.ToString(Ciudad.Text);
            empresa.Fecha_Creacion = Convert.ToString(FecCre.Text);
            empresa.Tipo_Doc = 2;
            //hace esto para que pueda existir gente que no vive en edificio
            if(!string.IsNullOrEmpty(NroPiso.Text))
            {
                empresa.Piso = Convert.ToInt32(NroPiso.Text);
            }
        }


         private void validarTipoDeDatosIngresados()
         {
             Utiles.Validaciones.ValidarTipoNroCalle(NCalle.Text);
            

             if (!string.IsNullOrEmpty(NroPiso.Text))
             {
                 Utiles.Validaciones.ValidarTipoPiso(NroPiso.Text);
             }
         }

        

      private void buttonLimpiar_Click(object sender, EventArgs e)
         {
             Utiles.LimpiarTexto.LimpiarTextBox(this);
             Utiles.LimpiarTexto.LimpiarMaskedTextBox(this);
             Utiles.LimpiarTexto.BlanquearControls(this);

         }

      private void button1_Click(object sender, EventArgs e)
      {
          Abm_Empresa.Listado list = new Abm_Empresa.Listado();
          list.Show();
      }

      private void button2_Click(object sender, EventArgs e)
      {
          Abm_Empresa.Listado_de_selección list = new Abm_Empresa.Listado_de_selección();
          list.Show();
      }

       
    }
}
