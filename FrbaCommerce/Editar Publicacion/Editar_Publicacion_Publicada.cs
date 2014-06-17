using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Editar_Publicacion
{
    public partial class Editar_Publicacion_Publicada : Form
    {
        private Decimal stockInicial;
        private Decimal codigoPk;
        public Editar_Publicacion_Publicada(Decimal codigo)
        {
            InitializeComponent();
            this.codigoPk = codigo;
            inicializarValores();
            if (Datos.Dat_Publicacion.estaPausado(codigo))
            {
                textBox2.Enabled = false;
                textBox5.Enabled = false;
                
                cmbEstado.Items.Remove("Finalizada");
            }
            
            cmbEstado.Text = "Publicada";
        }


        private void inicializarValores()
        {
            try
            {

                Entidades.Ent_Publicacion publ = new Entidades.Ent_Publicacion();
                publ = Datos.Dat_Publicacion.buscarDatosPublicacion(codigoPk);
                textBox5.Text = publ.Descripcion;

                
                if (publ.Tipo == "Compra Inmediata")
                {
                    textBox2.Text = Convert.ToString(publ.Stock);
                    stockInicial = Convert.ToDecimal(textBox2.Text);
                }
                else if(publ.Tipo == "Subasta")
                {
                    textBox2.Enabled = false;
                    cmbEstado.Items.Remove("Pausada");
                    
                    cmbEstado.Enabled = false;
                    
                }
            
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utiles.LimpiarTexto.LimpiarTextBox(this);
            Utiles.LimpiarTexto.BlanquearControls(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entidades.Ent_Publicacion publicacion = new Entidades.Ent_Publicacion();
            try
            {
                Utiles.Validaciones.ValidarTipoDecimalPublicacion(stockInicial, textBox2, textBox5);
                inicializarPublicacion(publicacion);
                Datos.Dat_Publicacion.EditarPublicacionPublicada(publicacion);
                Mensajes.Exitos.PublicacionEditada();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inicializarPublicacion(Entidades.Ent_Publicacion publicacion)
        {

            if (textBox2.Enabled == true)
            {
                publicacion.Stock = Convert.ToDecimal(textBox2.Text);
            }
            else
            {
                publicacion.Stock = 1;
            }
            publicacion.Codigo = codigoPk;
            publicacion.Descripcion = Convert.ToString(textBox5.Text);
            publicacion.Estado = Convert.ToString(cmbEstado.Text);

        }


    }
}

