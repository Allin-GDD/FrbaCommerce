using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Comprar_Ofertar
{
    public partial class VentanaOferta : Form
    {
        public VentanaOferta(Int32 codigoPub)
        {
            InitializeComponent();
            codiigoPublicacion = codigoPub;
        }
        private Int32 codiigoPublicacion;
        private double precioBase;
        private void button1_Click(object sender, EventArgs e)
        {
            Entidades.Ent_Oferta oferta = new FrbaCommerce.Entidades.Ent_Oferta();

            try
            {
                validarValor(codiigoPublicacion,Convert.ToDouble(textBox1));
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       public void validarValor(Int32 codigoPub,double precioOfertado)
       {
           SqlConnection conn = DBConexion.obtenerConexion();
           //Set the DataAdapter's query.
           precioBase = Convert.ToDouble(new SqlDataAdapter("select precio from publicacion where id = codigoPub", conn));
           if (precioOfertado > precioBase)
           {
               // agregarOferta
           }
           else
           {
              throw new  Excepciones.ValorMenor("El valor ingresado es menor a la última oferta realizada");
           }
       }
    }
}
