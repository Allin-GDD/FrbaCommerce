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
            Entidades.Ent_ValidacionesUtil validaciones = new Entidades.Ent_ValidacionesUtil();
            iniciarCheckText(validaciones);

            try
            {
                //Verifica si los datos ingresados no son nulos
                Utiles.Validaciones.evaluarUsuario(validaciones, this);
                               
                //Inicializa el cliente con datos correctos
                inicializarEmpresa(empresa);

                //Agrega el cliente a la DB
                Datos.Dat_Empresa.AgregarEmpresa(empresa);
                Decimal IdUsuario = Datos.Dat_Empresa.buscarIdEmpresa(empresa.CUIT);

                Datos.Dat_Usuario.CrearNuevoUsuario(empresa.Mail, empresa.CUIT, rolDeUsuario,IdUsuario);
                //el usuario va a ser el mail y la contraseña su cuit


                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iniciarCheckText(Entidades.Ent_ValidacionesUtil validaciones)
        {
            validaciones.Dpto = Dpto;
            validaciones.DNI = null;
            validaciones.Piso = NroPiso;
            validaciones.Telefono = Telefono;
            validaciones.Fecha = FecCre;
            validaciones.NroCalle = NroCalle;
            validaciones.CUIT = CUIT;
            validaciones.TelefonoAnt = null;
            validaciones.DNIAnt = null;
            validaciones.CUITAnt = null;
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
