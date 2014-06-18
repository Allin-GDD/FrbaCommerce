using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Empresa
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

            Entidades.Ent_ListadoEmpresa pEmpresa = new Entidades.Ent_ListadoEmpresa();
            try{
            pEmpresa.CUIT = txtCUIT.Text;
            pEmpresa.Mail = txtMail.Text;
            pEmpresa.Razon_Social = txtRazonSocial.Text;

            Datos.Dat_Empresa.buscarListaDeEmpresa(pEmpresa, dataGridView1);
           
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
            Int32 idSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                        
            if (e.ColumnIndex == dataGridView1.CurrentRow.Cells["btnEdit"].ColumnIndex)
            {//14 es la pocision del boton modificar
                Abm_Empresa.Modificación mod = new Abm_Empresa.Modificación(idSeleccionado,false);
                this.Hide();
                mod.ShowDialog();
                this.Refresh();
                Show();

            }
            if (e.ColumnIndex == dataGridView1.CurrentRow.Cells["btnDelete"].ColumnIndex)
            {
                Abm_Empresa.Baja baj = new Abm_Empresa.Baja(idSeleccionado);
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
