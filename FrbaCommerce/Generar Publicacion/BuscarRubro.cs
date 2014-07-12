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
  
        public string Result = string.Empty;
        public Decimal ResultCodigo;
        public Decimal codigoPub;
        public BuscarRubro(Decimal codigo)
        {
            InitializeComponent();
            codigoPub = codigo;
        }

        //Busca los rubros existentes en la base de datos segun la descripción ingresada como filtro.
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                Datos.Dat_Publicacion.filtarListaDeRubros(txtNombre.Text, dataGridView1, codigoPub);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Limpia y blanquea el textbox.
        private void button1_Click(object sender, EventArgs e)
        {
            Utiles.LimpiarTexto.LimpiarTextBox(this);
            Utiles.LimpiarTexto.BlanquearControls(this);
        }

        //Termina la ventana y devuelve el valor correspondiente al cliquear la fila que se desea devolver.
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

             Result = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
             ResultCodigo = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
             Close();
             
        }

 
    }
}
