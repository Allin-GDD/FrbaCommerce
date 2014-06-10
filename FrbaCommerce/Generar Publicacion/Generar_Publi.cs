﻿using System;
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
        private string usuario;
        public Generar_Publi(string usuarioPk)
        {
            InitializeComponent();

            Utiles.Inicializar.comboBoxVisibilidad(cmbVisib);
            this.usuario = usuarioPk;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utiles.LimpiarTexto.LimpiarTextBox(this);
            Utiles.LimpiarTexto.BlanquearControls(this);
            Utiles.LimpiarTexto.SacarCheckBox(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entidades.Ent_Publicacion publicacion = new Entidades.Ent_Publicacion();
            try
            {
                Utiles.Validaciones.ValidarTipoDecimalPublicacion(textBox1, textBox2, textBox3, textBox5);

                inicializarPublicacion(publicacion);
        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            publicacion.Tipo = Convert.ToString(cmbTipoPub.SelectedValue);
            publicacion.Stock = Convert.ToInt32(textBox2.Text);
            publicacion.Rubro = Convert.ToInt16(textBox1.Text);
            publicacion.Precio = Convert.ToInt32(textBox3.Text);
            publicacion.Descripcion = Convert.ToString(textBox5.Text);
            publicacion.Permitir_Preguntas = Convert.ToBoolean(checkBox1.Checked);
            Datos.Dat_Publicacion.buscarPublicador(usuario, publicacion.Id, publicacion.Publicador);
            Datos.Dat_Publicacion.buscarDuracionVisibilidad(publicacion.Visibilidad, publicacion.Fecha_Venc);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Generar_Publicacion.BuscarRubro list = new Generar_Publicacion.BuscarRubro(textBox1);
            list.Show();
        }


    }
}
