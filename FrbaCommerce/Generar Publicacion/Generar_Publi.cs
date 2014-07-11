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
        private Decimal stockInicial = 0;
        private Decimal usuario;
        public Generar_Publi(Decimal usuarioPk)
        {
            InitializeComponent();
            cmbTipoPub.Text = "Subasta";
            cmbEstado.Text = "Borrador";
            Utiles.Inicializar.comboBoxVisibilidad(cmbVisib);
            this.usuario = usuarioPk;
        }
        
        //Limpia textbox y las blanquea, limpia checkbox.
        private void button1_Click(object sender, EventArgs e)
        {
            Utiles.LimpiarTexto.LimpiarTextBox(this);
            Utiles.LimpiarTexto.BlanquearControls(this);
            Utiles.LimpiarTexto.SacarCheckBox(this);
            textBox1.Enabled = false;
            textBox1.BackColor = Color.WhiteSmoke;
        }

        //Hace las validaciones correspondientes y luego agrega la publicación a la base de datos.
        private void button2_Click(object sender, EventArgs e)
        {
            Entidades.Ent_Publicacion publicacion = new Entidades.Ent_Publicacion();
            try
            {
                Utiles.Validaciones.ValidarTipoDecimalPublicacion(stockInicial, textBox1, textBox2, textBox3, textBox5);
                if (cmbEstado.Text == "Publicada" && Convert.ToInt16(cmbVisib.SelectedValue) == 10006)
                {

                    Utiles.Validaciones.ValidarVisibilidadGratuita(usuario);
                }
                
                inicializarPublicacion(publicacion);
                Datos.Dat_Publicacion.AgregarPublicacion(publicacion);
                Mensajes.Exitos.ExitoAlGenerarPublicacion();
        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Cambia labels según input en combox tipo de publicación.
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

        //Inicializa los valores en la entidad publicación para su posterior inserción en tabla.
        private void inicializarPublicacion(Entidades.Ent_Publicacion publicacion)
        {

            publicacion.Visibilidad = Convert.ToInt16(cmbVisib.SelectedValue);
            publicacion.Tipo = Datos.Dat_Publicacion.obtenerCodTipoPublicacion(Convert.ToString(cmbTipoPub.Text));

            if (textBox2.Enabled == true)
            {
                publicacion.Stock = Convert.ToDecimal(textBox2.Text);
            }
            else
            {
                publicacion.Stock = 1;
            }
            publicacion.Rubro = codRubro;
            publicacion.Precio = Convert.ToDecimal(textBox3.Text);
            publicacion.Descripcion = Convert.ToString(textBox5.Text);
            publicacion.Permitir_Preguntas = Convert.ToBoolean(checkBox1.Checked);
            publicacion.Estado = Datos.Dat_Publicacion.obtenerCodEstadoPublicacion(Convert.ToString(cmbEstado.Text));
            publicacion.Usuario = usuario;
            
            if (publicacion.Estado == 1)
            {
                publicacion.Fecha = DBConexion.fechaIngresadaPorElAdministrador();
                publicacion.Fecha_Venc = Datos.Dat_Publicacion.buscarDuracionVisibilidad(publicacion.Visibilidad).fecha;
            }
            else
            {
                publicacion.Fecha = Convert.ToDateTime("01/01/1753");
                publicacion.Fecha_Venc = Convert.ToDateTime("31/12/9999");
            }
            

        }

      
        //Lleva a la ventana para buscar rubros y devuelve el valor seleccionado en el textbox correspondiente.
        private void button3_Click_1(object sender, EventArgs e)
        {
            Generar_Publicacion.BuscarRubro list = new Generar_Publicacion.BuscarRubro(0);
            list.ShowDialog();
            textBox1.Enabled = true;
            textBox1.Text = list.Result;
            codRubro = list.ResultCodigo;

          
        }

    }
}
