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
        public Modificación(Int32 idSeleccionado)
        {
            InitializeComponent();
            this.empresaAModificar = idSeleccionado;
            cargarDatosDelClienteSeleccionado();
        }

        public Entidades.Ent_Empresa empresaAnt;
        private void cargarDatosDelClienteSeleccionado()
        {
            empresaAnt = Datos.Dat_Empresa.buscarEmpresa(empresaAModificar);
        }
        public Int32 empresaAModificar;

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
             Entidades.Ent_Empresa empresa = new Entidades.Ent_Empresa();

             try
             {
                 //Verifica si los datos ingresados no son nulos
                 Utiles.Validaciones.NulidadDeDatosIngresados(this, Dpto, NroPiso, FecCre, Telefono, CUIT, CodPostal);


                 //Verifica si lo que se estan ingresando es correcto
                 validarTipoDeDatosIngresados();


                 //Verifica si la fecha está dentro del limite
                 Utiles.Validaciones.ValidarFecha(FecCre.Text);

                 //Verifica si el DNI y Telefono ya no existen
                 Datos.Dat_Telefonos.validarTelefono(Telefono.Text);
                 Datos.Dat_Cuit.validarCuit(CUIT.Text);


                 //Inicializa el cliente con datos correctos
                 inicializarEmpresa(empresa);

                 Datos.Dat_Empresa.ActualizarEmpresa(empresa, empresaAModificar);
             }
             catch (Exception ex) {
                 MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }

        private void validarTipoDeDatosIngresados()
        {
            if (empresaAnt.Telefono != Telefono.Text)
            {
                Datos.Dat_Telefonos.validarTelefono(Telefono.Text);
            }
            if (empresaAnt.CUIT != CUIT.Text)
            {
                Datos.Dat_Dni.validarDni(Convert.ToDecimal(CUIT.Text));
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
            if (!string.IsNullOrEmpty(NroPiso.Text))
            {
                empresa.Piso = Convert.ToInt32(NroPiso.Text);
            }
        }
    }
}
