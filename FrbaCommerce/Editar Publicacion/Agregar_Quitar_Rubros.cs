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
    public partial class Agregar_Quitar_Rubros : Form
    {
        private Decimal codRubro = 0;
        private Decimal codPublicacion;
        public Agregar_Quitar_Rubros(Decimal codigoPub)
        {
            InitializeComponent();
            codPublicacion = codigoPub;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox2.Checked = false;
                checkBox2.Enabled = true;
                Utiles.LimpiarTexto.LimpiarTextBox(this);
                Utiles.LimpiarTexto.BlanquearControls(this);
                textBox1.Enabled = false;
                textBox1.BackColor = Color.WhiteSmoke;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox1.Checked = false;
                checkBox1.Enabled = true;
                Utiles.LimpiarTexto.LimpiarTextBox(this);
                Utiles.LimpiarTexto.BlanquearControls(this);
                textBox1.Enabled = false;
                textBox1.BackColor = Color.WhiteSmoke;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Generar_Publicacion.BuscarRubro list = new Generar_Publicacion.BuscarRubro(codPublicacion,"agregar");
                list.ShowDialog();
                textBox1.Enabled = true;
                textBox1.Text = list.Result;
                codRubro = list.ResultCodigo;
            }
            else
            {
                Generar_Publicacion.BuscarRubro list = new Generar_Publicacion.BuscarRubro(codPublicacion,"quitar");
                list.ShowDialog();
                textBox1.Enabled = true;
                textBox1.Text = list.Result;
                codRubro = list.ResultCodigo;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utiles.LimpiarTexto.LimpiarTextBox(this);
            Utiles.LimpiarTexto.BlanquearControls(this);
            textBox1.Enabled = false;
            textBox1.BackColor = Color.WhiteSmoke;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Utiles.Validaciones.validarUnSoloTxt(textBox1);
                if (checkBox1.Checked == true)
                {
                    Datos.Dat_Publicacion.AgregarRubro(textBox1, codPublicacion);
                    Mensajes.Exitos.ExitoAlGenerarRubro();
                }
                else
                {
                    Datos.Dat_Publicacion.QuitarRubro(textBox1, codPublicacion);
                    Mensajes.Exitos.ExitoAlQuitarRubro();
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
