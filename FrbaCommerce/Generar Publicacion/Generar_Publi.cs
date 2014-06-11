using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Generar_Publicacion
{   
    public partial class Generar_Publi : Form
    {
        private Decimal codRubro;
        private string usuario;
        public Generar_Publi(string usuarioPk)
        {
            InitializeComponent();
            cmbTipoPub.Text = "Subasta";
            cmbEstado.Text = "Borrador";
            Utiles.Inicializar.comboBoxVisibilidad(cmbVisib);
            this.usuario = usuarioPk;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Utiles.LimpiarTexto.LimpiarTextBox(this);
            Utiles.LimpiarTexto.BlanquearControls(this);
            Utiles.LimpiarTexto.SacarCheckBox(this);
            textBox1.Enabled = false;
            textBox1.BackColor = Color.WhiteSmoke;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entidades.Ent_Publicacion publicacion = new Entidades.Ent_Publicacion();
            //try
            //{
                Utiles.Validaciones.ValidarTipoDecimalPublicacion(textBox1, textBox2, textBox3, textBox5);
                inicializarPublicacion(publicacion);
                Datos.Dat_Publicacion.AgregarPublicacion(publicacion);
        
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }


        private void cmbTipoPub_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbTipoPub.SelectedItem.ToString() == "Subasta")
            {
                textBox2.Text = "";
                label7.Text = "Precio inicial";
                textBox2.BackColor = Color.WhiteSmoke;
                textBox2.Enabled = false;
                
            }
            else if(cmbTipoPub.SelectedItem.ToString() == "Compra inmediata")
            {
                label7.Text = "Precio unitario";
                textBox2.BackColor = Color.White;
                textBox2.Enabled = true;
            }
        }

        private void inicializarPublicacion(Entidades.Ent_Publicacion publicacion)
        {

            publicacion.Visibilidad = Convert.ToInt16(cmbVisib.SelectedValue);
            publicacion.Tipo = Convert.ToString(cmbTipoPub.Text);

            if (textBox2.Enabled == true)
            {
                publicacion.Stock = Convert.ToDecimal(textBox2.Text);
            }
            publicacion.Rubro = codRubro;
            publicacion.Precio = Convert.ToDecimal(textBox3.Text);
            publicacion.Descripcion = Convert.ToString(textBox5.Text);
            publicacion.Permitir_Preguntas = Convert.ToBoolean(checkBox1.Checked);
            publicacion.Estado = Convert.ToString(cmbEstado.Text);
            publicacion.Id = Datos.Dat_Publicacion.buscarPublicador(usuario).id;
            publicacion.Publicador = Datos.Dat_Publicacion.buscarPublicador(usuario).rol;
            publicacion.Fecha_Venc = Datos.Dat_Publicacion.buscarDuracionVisibilidad(publicacion.Visibilidad).fecha;
            

        }

      

        private void button3_Click_1(object sender, EventArgs e)
        {
            Generar_Publicacion.BuscarRubro list = new Generar_Publicacion.BuscarRubro();
            list.ShowDialog();
            textBox1.Enabled = true;
            textBox1.Text = list.Result;
            codRubro = list.ResultCodigo;

          
        }

    }
}
