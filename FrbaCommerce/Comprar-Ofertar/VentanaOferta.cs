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
        public VentanaOferta(decimal codigoPub,decimal id)
        {
            InitializeComponent();
            codigoPublicacion = codigoPub;
            idusuario = id;
            
        }
        private decimal codigoPublicacion;
        private decimal idusuario;
      
        private void button1_Click(object sender, EventArgs e)
        {
            Entidades.Ent_Oferta oferta = new FrbaCommerce.Entidades.Ent_Oferta();
           
           try

            {
                Utiles.Validaciones.ValidarTipoDouble(textBox1);

                oferta.Monto = Convert.ToDouble(textBox1.Text);
                oferta.Codigo_Pub = codigoPublicacion;
                oferta.Id_Cli = idusuario;
               
                Utiles.Validaciones.validarValorMayorAPrecio(codigoPublicacion,oferta.Monto);
                Utiles.Validaciones.validarValorMayorAUltOferta(codigoPublicacion, oferta.Monto);

               Datos.Dat_CompraOferta.AgregarOferta(oferta);
         }

           catch (Exception ex)
           {
              MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }
    }
}
