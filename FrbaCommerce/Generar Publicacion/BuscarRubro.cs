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
    public partial class BuscarRubro : Form
    {
        public BuscarRubro()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                Datos.Dat_Publicacion.filtarListaDeRubros(txtNombre.Text, dataGridView1);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //textboxDesc.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

        }


    }
}
