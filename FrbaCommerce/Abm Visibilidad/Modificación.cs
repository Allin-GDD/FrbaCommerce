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
        private short estado ;

    private void cargarDatosVisibilidadSeleccionada()
        {
            visibilidadAnt = Datos.Dat_Visibilidad.buscarVisibilidad(visibilidadAModificar);

            textBox1.Text = Convert.ToString(visibilidadAnt.Codigo);
            textBox2.Text = visibilidadAnt.Descripcion;
            textBox3.Text = Convert.ToString(visibilidadAnt.Precio);
            textBox4.Text = Convert.ToString(visibilidadAnt.Porcentaje);
            textBox5.Text = Convert.ToString(visibilidadAnt.Vencimiento);
            textBox6.Text = Convert.ToString(estado);

            
 
        }
        public Int32 visibilidadAModificar;

        private void button2_Click(object sender, EventArgs e)
        {
             Entidades.Ent_Visibilidad visibilidad = new Entidades.Ent_Visibilidad();

             try
             {

                 //Inicializa el cliente con datos correctos
                 inicializarVisibilidad(visibilidad);

                 Datos.Dat_Visibilidad.ActualizarCamposAVisibilidad(visibilidad, visibilidadAModificar,estado);

             }
             catch (Exception ex) {
                 MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }
       
           private void inicializarVisibilidad (Entidades.Ent_Visibilidad visibilidad)
        {
            
            visibilidad.Codigo = Convert.ToDecimal(textBox1.Text);
            visibilidad.Descripcion = Convert.ToString(textBox2.Text);
            visibilidad.Precio = Convert.ToDouble(textBox3.Text);
            visibilidad.Porcentaje = Convert.ToDouble(textBox4.Text);
            visibilidad.Vencimiento = Convert.ToDecimal(textBox5.Text);
 
        }

           private void button1_Click(object sender, EventArgs e)
           {
               Utiles.LimpiarTexto.LimpiarTextBox(this);
           }
    }
}
