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
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entidades.Ent_TxtVisibilidad txtVisi = new Entidades.Ent_TxtVisibilidad();
            Entidades.Ent_Visibilidad visibilidad = new FrbaCommerce.Entidades.Ent_Visibilidad();
            IniciarCheckText(txtVisi);

            try
            {
                Utiles.Validaciones.evaluarVisibilidad(this, txtVisi, null, null);
                //Verifica si lo que se estan ingresando es correcto

                //Inicializa la visibilidad con datos correctos
                inicializarVisibilidad(visibilidad);


                //Agrega la visibilidad a la DB
                Datos.Dat_Visibilidad.AgregarVisibilidad(visibilidad);

                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void IniciarCheckText(Entidades.Ent_TxtVisibilidad txtVisi)
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
            visibilidad.Porcentaje = Convert.ToDouble(txtPrecio.Text);
            visibilidad.Precio = Convert.ToDouble(txtPorcentaje.Text);
            visibilidad.Vencimiento = Convert.ToDecimal(txtTiempVenc.Text);

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Utiles.LimpiarTexto.LimpiarTextBox(this);
            Utiles.LimpiarTexto.LimpiarMaskedTextBox(this);
            Utiles.LimpiarTexto.BlanquearControls(this);
        }

    }




}

