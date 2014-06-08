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
        private Int32 id_Cliente;
        public Generar_Publi(Int32 idSeleccionado)
        {
            InitializeComponent();
            Utiles.Inicializar.comboBoxRubro(cmbRub);
            Utiles.Inicializar.comboBoxVisibilidad(cmbVisib);
            Utiles.Inicializar.comboBoxTipo_Publicacion(cmbTipoPub);
            this.id_Cliente = idSeleccionado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utiles.LimpiarTexto.LimpiarTextBox(this);
            Utiles.LimpiarTexto.BlanquearControls(this);
            Utiles.LimpiarTexto.SacarCheckBox(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       



    
    }
}
