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
    public partial class Editar_Publicacion_Borrada : Form
    {
        private Boolean esGratuita;
        private Decimal codigoPk;
        private Decimal stockInicial = 0;
        private Boolean estaActiva = false;
        //Si la publicación está en estado Borrador (no borrada aunque se llame así), debe dejar editar todos los campos, por eso te trae a esta ventana.
        public Editar_Publicacion_Borrada(Decimal codigo)
        {
            InitializeComponent();
            this.codigoPk = codigo;
            Utiles.Inicializar.comboBoxVisibilidad(cmbVisib);
            inicializarValores();
            if (cmbEstado.Text == "Publicada")
            {
                estaActiva = true;
            }
            cmbEstado.Text = "Borrador";
            
            
        }

        //Trae los valores actuales de la publicación que se desea editar.
        private void inicializarValores()
        {
            Entidades.Ent_Publicacion publicacion = new Entidades.Ent_Publicacion();
            publicacion = Datos.Dat_Publicacion.buscarDatosPublicacion(codigoPk);
            List<Entidades.Ent_Visibilidad> listaDeVisibilidades = new List<Entidades.Ent_Visibilidad>();
            Entidades.Ent_Visibilidad elementoQuiero;

            listaDeVisibilidades = Datos.Dat_Publicacion.ObtenerVisibilidades();
            if (Datos.Dat_Publicacion.obtenerVisibilidad(publicacion.Visibilidad) == "Gratis")
            {
                esGratuita = true;
            }
            elementoQuiero = listaDeVisibilidades.Find(item => item.Descripcion == Datos.Dat_Publicacion.obtenerVisibilidad(publicacion.Visibilidad));
            listaDeVisibilidades.Remove(elementoQuiero);
            listaDeVisibilidades.Insert(0, elementoQuiero);
            cmbVisib.DataSource = listaDeVisibilidades;
            cmbVisib.DisplayMember = "Descripcion";
            cmbVisib.ValueMember = "Codigo";
            
            cmbTipoPub.Text = Datos.Dat_Publicacion.obtenerNombreTipoPublicacion(publicacion.Tipo);

            textBox3.Text = publicacion.Precio.ToString();

            if (publicacion.Tipo == 1)
            {
                textBox2.Text = publicacion.Stock.ToString();
            }
            else
            {
                textBox2.Enabled = false;
            }

            textBox5.Text = publicacion.Descripcion;
            checkBox1.Checked = publicacion.Permitir_Preguntas;

        }

        //Inicializa los valores de la entidad publicación para poder actualizar la tabla.
        private void inicializarPublicacion(Entidades.Ent_Publicacion publicacion)
        {

            publicacion.Visibilidad = Convert.ToInt16(cmbVisib.SelectedValue);
            publicacion.Tipo = Datos.Dat_Publicacion.obtenerCodTipoPublicacion(cmbTipoPub.Text);

            if (textBox2.Enabled == true)
            {
                publicacion.Stock = Convert.ToDecimal(textBox2.Text);
            }
            else
            {
                publicacion.Stock = 1;
            }
            publicacion.Precio = Convert.ToDecimal(textBox3.Text);
            publicacion.Descripcion = Convert.ToString(textBox5.Text);
            publicacion.Permitir_Preguntas = Convert.ToBoolean(checkBox1.Checked);
            publicacion.Estado = Datos.Dat_Publicacion.obtenerCodEstadoPublicacion(cmbEstado.Text);
            publicacion.Codigo = codigoPk;
            
            publicacion.Fecha_Venc = Datos.Dat_Publicacion.buscarDuracionVisibilidad(publicacion.Visibilidad).fecha;

        }

        //Limpia los textbox, checkbox y blanquea las validaciones
        private void button1_Click(object sender, EventArgs e)
        {
            Utiles.LimpiarTexto.LimpiarTextBox(this);
            Utiles.LimpiarTexto.BlanquearControls(this);
            Utiles.LimpiarTexto.SacarCheckBox(this);
        }

        //Al aceptar hace las validaciones correspondientes, luego inicializa y finalmente edita la publicación en la base de datos.
        private void button2_Click(object sender, EventArgs e)
        {
            Entidades.Ent_Publicacion publicacion = new Entidades.Ent_Publicacion();
            try
            {
                Utiles.Validaciones.ValidarTipoDecimalPublicacion(stockInicial, textBox2, textBox3, textBox5);
                

                if (cmbEstado.Text == "Publicada" && Convert.ToInt16(cmbVisib.SelectedValue) == 10006 && (esGratuita == false || estaActiva == false))
                {

                    Utiles.Validaciones.ValidarVisibilidadGratuita(Datos.Dat_Publicacion.buscarUsuarioCod(codigoPk));
                }
                
                inicializarPublicacion(publicacion);
                Datos.Dat_Publicacion.EditarPublicacionBorrador(publicacion);
                Mensajes.Exitos.PublicacionEditada();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //LLeva a la selección de rubro
        private void button3_Click(object sender, EventArgs e)
        {
            Editar_Publicacion.Agregar_Quitar_Rubros list = new Editar_Publicacion.Agregar_Quitar_Rubros(codigoPk);
            list.ShowDialog();
        }

        //Cambia algunos labels si se modifica el tipo de publicación correspondientemente
        private void cmbTipoPub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoPub.SelectedItem.ToString() == "Subasta")
            {
                textBox2.Text = "";
                label7.Text = "Precio inicial";
                textBox2.BackColor = Color.WhiteSmoke;
                textBox2.Enabled = false;

            }
            else if (cmbTipoPub.SelectedItem.ToString() == "Compra inmediata")
            {
                label7.Text = "Precio unitario";
                textBox2.BackColor = Color.White;
                textBox2.Enabled = true;
            }
        }

      

        

        

    }
}

