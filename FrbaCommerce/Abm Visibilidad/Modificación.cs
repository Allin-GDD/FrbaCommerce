using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Visibilidad
{
    public partial class Modificación : Form
    {


        public Modificación(int codigoSeleccionado)
        {
            InitializeComponent();
            this.visibilidadAModificar = codigoSeleccionado;
            cargarDatosVisibilidadSeleccionada();
        }
        private Entidades.Ent_Visibilidad visibilidadAnt;
        private TextBox codigoAnt;
        private TextBox DescripAnt;

        private void cargarDatosVisibilidadSeleccionada()
        {
            visibilidadAnt = Datos.Dat_Visibilidad.buscarVisibilidad(visibilidadAModificar);

            txtCodigo.Text = Convert.ToString(visibilidadAnt.Codigo);
            txtDescripcion.Text = visibilidadAnt.Descripcion;
            txtPrecio.Text = Convert.ToString(visibilidadAnt.Precio);
            txtPorcentaje.Text = Convert.ToString(visibilidadAnt.Porcentaje);
            txtTiempVenc.Text = Convert.ToString(visibilidadAnt.Vencimiento);

            this.codigoAnt = txtCodigo;
            this.DescripAnt = txtDescripcion;


        }
        public Int32 visibilidadAModificar;

        private void button2_Click(object sender, EventArgs e)
        {
            Entidades.Ent_TxtVisibilidad txtVisi = new Entidades.Ent_TxtVisibilidad();
            Entidades.Ent_Visibilidad visibilidad = new FrbaCommerce.Entidades.Ent_Visibilidad();
            IniciarCheckText(txtVisi);

            try
            {
                Utiles.Validaciones.evaluarVisibilidad(this, txtVisi,codigoAnt,DescripAnt);

                //Inicializa el cliente con datos correctos
                inicializarVisibilidad(visibilidad);
 
                Datos.Dat_Visibilidad.ActualizarCamposAVisibilidad(visibilidad, visibilidadAModificar);
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IniciarCheckText(FrbaCommerce.Entidades.Ent_TxtVisibilidad txtVisi)
        {
            txtVisi.Codigo = txtCodigo;
            txtVisi.Descripcion = txtDescripcion;
            txtVisi.Porcentaje = txtPorcentaje;
            txtVisi.Precio = txtPrecio;
            txtVisi.Vencimiento = txtTiempVenc;
        }

        private void inicializarVisibilidad(Entidades.Ent_Visibilidad visibilidad)
        {

            visibilidad.Codigo = Convert.ToDecimal(txtCodigo.Text);
            visibilidad.Descripcion = Convert.ToString(txtDescripcion.Text);
            visibilidad.Precio = Convert.ToDouble(txtPrecio.Text);
            visibilidad.Porcentaje = Convert.ToDouble(txtPorcentaje.Text);
            visibilidad.Vencimiento = Convert.ToDecimal(txtTiempVenc.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utiles.LimpiarTexto.LimpiarTextBox(this);
        }
    }
}
