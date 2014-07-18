using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Abm_Visibilidad
{
    public partial class Baja : Form
    {
        public Baja(Int32 visibilidadSeleccionada)
        {
            InitializeComponent();
            this.visibilidadABajar = visibilidadSeleccionada;
            cargarDatosVisibilidadSeleccionada();
        }
        public Int32 visibilidadABajar;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.allin.darDeBajaVisibilidad", conn,
                new SqlParameter("@Codigo", visibilidadABajar));
                int retorno = cmd.ExecuteNonQuery();

                Mensajes.Generales.validarBaja(retorno);
                Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void cargarDatosVisibilidadSeleccionada()
        {
            Entidades.Ent_Visibilidad pvisibilidad = new Entidades.Ent_Visibilidad();
            pvisibilidad = Datos.Dat_Visibilidad.buscarVisibilidad(visibilidadABajar);

            textBox1.Text = Convert.ToString(pvisibilidad.Codigo);
            textBox2.Text = pvisibilidad.Descripcion;
            textBox3.Text = Convert.ToString(pvisibilidad.Precio);
            textBox4.Text = Convert.ToString(pvisibilidad.Porcentaje);
            textBox5.Text = Convert.ToString(pvisibilidad.Vencimiento);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
