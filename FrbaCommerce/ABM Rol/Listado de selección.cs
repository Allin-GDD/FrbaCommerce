using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.ABM_Rol
{
    public partial class Listado_de_selección : Form
    {
        public Listado_de_selección()
        {
            InitializeComponent();
            botonModificar = false;
            botonDelete = false;
        }
        private bool botonModificar;
        private bool botonDelete;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Datos.Dat_Rol.filtarListaDeRoles(txtNombre.Text, dataGridView1);
                this.botonModificar = Utiles.Inicializar.agregarColumnaModificar(botonModificar, dataGridView1);
                this.botonDelete = Utiles.Inicializar.agregarColumnaEliminar(botonDelete, dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utiles.LimpiarTexto.LimpiarTextBox(this); 
            bool valor = Utiles.LimpiarTexto.LimpiarDataGridBoton(dataGridView1);
            if (!valor)
            {
                botonDelete = false;
                botonModificar = false;
            }

            Utiles.LimpiarTexto.LimpiarDataGrid(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try{
                Decimal idSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            if (e.ColumnIndex == dataGridView1.CurrentRow.Cells["btnEdit"].ColumnIndex)
            {
                ABM_Rol.Modificación mod = new ABM_Rol.Modificación(idSeleccionado);
                this.Hide();
                mod.ShowDialog();
                this.Refresh();
                Show();

            }
            if (e.ColumnIndex == dataGridView1.CurrentRow.Cells["btnDelete"].ColumnIndex)
            {
                ABM_Rol.Baja baj = new ABM_Rol.Baja(idSeleccionado);
                this.Hide();
                baj.ShowDialog();
                this.Refresh();
                Show();

            }
               }
            catch {
                Mensajes.Errores.NoHayDatosAmodificar();
            }
        }
    }
}
