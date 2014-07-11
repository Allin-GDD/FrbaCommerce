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
        public Decimal IdUsuario;
        public Alta(decimal IdUsuario)
        {
            InitializeComponent();
            this.IdUsuario = IdUsuario;
        }
         public Int32 rolDeUsuario = 2;
         public bool IsComplete;
    

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Entidades.Ent_Empresa empresa = new Entidades.Ent_Empresa();
            Entidades.Ent_TxtPersona validaciones = new Entidades.Ent_TxtPersona();
            iniciarCheckText(validaciones);

            try
            {
                IsComplete = false;
                //Verifica si los datos ingresados no son nulos
                Utiles.Validaciones.evaluarPersona(validaciones, this);
                               
                //Inicializa el cliente con datos correctos
                inicializarEmpresa(empresa);

                //Agrega el cliente a la DB
                Datos.Dat_Empresa.crearEmpresaUsuario(empresa, IdUsuario);


                if (IdUsuario == 0)
                {//armo el if para que tire un mensaje de que el admin creo al cliente
                    Mensajes.Exitos.usuarioCreadoPorAdminOk();
                }
                IsComplete = true;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iniciarCheckText(Entidades.Ent_TxtPersona validaciones)
        {   
            validaciones.DNI = null;
            validaciones.Telefono = Telefono;
            validaciones.Fecha = FecCre;
            validaciones.Piso = txtNroPiso; 
            validaciones.NroCalle = NCalle;
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
            empresa.Dpto = Convert.ToString(txtDpto.Text);
            empresa.Localidad = Convert.ToString(Localidad.Text);
            empresa.Cod_Postal = Convert.ToString(CodPostal.Text);
            empresa.Ciudad = Convert.ToString(Ciudad.Text);
            empresa.Fecha_Creacion = Convert.ToString(FecCre.Text);
            //hace esto para que pueda existir gente que no vive en edificio
            if(!string.IsNullOrEmpty(txtNroPiso.Text))
            {
                empresa.Piso = Convert.ToInt32(txtNroPiso.Text);
            }
        }

      private void buttonLimpiar_Click(object sender, EventArgs e)
         {
             Utiles.LimpiarTexto.LimpiarTextBox(this);
             Utiles.LimpiarTexto.LimpiarMaskedTextBox(this);
             Utiles.LimpiarTexto.BlanquearControls(this);

         }

           }
}
