using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Empresa
{
    public partial class Modificación : Form
    {
        public Modificación(Decimal idSeleccionado, Boolean isEmpresa)
        {
           
            InitializeComponent();

            this.empresaAModificar = idSeleccionado;
            CUIT.Enabled = false;

            cargarDatosDelClienteSeleccionado();

            if (isEmpresa)
            {
                lblHabil.Visible = false;
                cmbHabilitado.Visible = false;

            }
            else { 
            Utiles.Inicializar.comboBoxHabilitado(cmbHabilitado, idSeleccionado);
            }
        }

        public Entidades.Ent_Empresa empresaAnt;
        public MaskedTextBox CUITAnt;
        public MaskedTextBox TelefonoAnt;

        private void cargarDatosDelClienteSeleccionado()
        {
            empresaAnt = Datos.Dat_Empresa.buscarEmpresa(empresaAModificar);

            Telefono.Text = empresaAnt.Telefono;
            RazonSocial.Text = empresaAnt.RazonSocial;
            NombreContacto.Text = empresaAnt.NombreContacto;
            CUIT.Text = empresaAnt.CUIT;
            Mail.Text = empresaAnt.Mail;
            Calle.Text = empresaAnt.Dom_Calle;
            NCalle.Text = Convert.ToString(empresaAnt.Nro_Calle);
            txtNroPiso.Text = Convert.ToString(empresaAnt.Piso);
            txtDpto.Text = empresaAnt.Dpto;
            Localidad.Text = empresaAnt.Localidad;
            CodPostal.Text = empresaAnt.Cod_Postal;
            Ciudad.Text = empresaAnt.Ciudad;
            FecCre.Text = Convert.ToString(empresaAnt.Fecha_Creacion);


            this.CUITAnt = CUIT;
            this.TelefonoAnt = Telefono;
    
        }
        public Decimal empresaAModificar;
        public Int16 rolEmpresa = 2;

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
             Entidades.Ent_Empresa empresa = new Entidades.Ent_Empresa();
             Entidades.Ent_TxtPersona validaciones = new Entidades.Ent_TxtPersona();
             iniciarCheckText(validaciones);

             try
             {
                 Utiles.Validaciones.evaluarPersona(validaciones, this);
                 //Inicializa el cliente con datos correctos
                 inicializarEmpresa(empresa);

                 Datos.Dat_Empresa.actualizarEmpresa(empresa, empresaAModificar);

                 Datos.Dat_Usuario.actualizarEstadoUsuario(Convert.ToInt16(cmbHabilitado.SelectedValue), empresaAModificar);
                 Close();
             }
             catch (Exception ex) {
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
            validaciones.CUITAnt = this.CUITAnt;
            validaciones.DNIAnt = null;
            validaciones.TelefonoAnt = this.TelefonoAnt;
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
            if (!string.IsNullOrEmpty(txtNroPiso.Text))
            {
                empresa.Piso = Convert.ToInt32(txtNroPiso.Text);
            }
        }
        private void validarTipoDeDatosIngresados()
        {
            Utiles.Validaciones.ValidarTipoDecimal(NCalle);


            if (!string.IsNullOrEmpty(txtNroPiso.Text))
            {
                Utiles.Validaciones.ValidarTipoDecimal(txtNroPiso);
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
