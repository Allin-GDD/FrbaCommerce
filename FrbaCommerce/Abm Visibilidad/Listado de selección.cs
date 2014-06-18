using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Visibilidad
{
    public partial class Listado_de_selección : Form
    {




        public Listado_de_selección()
        {
            InitializeComponent();
            eliminar = false;
            modificar = false;
            

        }
       private bool eliminar;
       private bool modificar;

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                Entidades.Ent_ListadoVisibilidad pvisibilidad = new Entidades.Ent_ListadoVisibilidad();


                pvisibilidad.Codigo = textBox1.Text;
                pvisibilidad.Descripcion = textBox2.Text;
                pvisibilidad.Precio = textBox3.Text;
                pvisibilidad.Porcentaje = textBox4.Text;

                Datos.Dat_Visibilidad.buscarListaDeVisibilidades(pvisibilidad,dataGridView1);

                //LE METO UN BOOLEANDO PQ SINO LOS SIGUE AGREGANDO
                this.modificar = Utiles.Inicializar.agregarColumnaModificar(modificar, dataGridView1);
                this.eliminar = Utiles.Inicializar.agregarColumnaEliminar(eliminar, dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
  

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Int32 codigoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Codigo"].Value);


            if (e.ColumnIndex == dataGridView1.CurrentRow.Cells["btnEdit"].ColumnIndex)
            {
                Abm_Visibilidad.Modificación mod = new Abm_Visibilidad.Modificación(codigoSeleccionado);
                this.Hide();
                mod.ShowDialog();
                Show();
                

            }
            if (e.ColumnIndex == dataGridView1.CurrentRow.Cells["btnDelete"].ColumnIndex)
            {
                Abm_Visibilidad.Baja baj = new Abm_Visibilidad.Baja(codigoSeleccionado);
                this.Hide();
                baj.ShowDialog();
                this.Refresh();
                Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utiles.LimpiarTexto.LimpiarTextBox(this);
            
            bool valor = Utiles.LimpiarTexto.LimpiarDataGridBoton(dataGridView1);
            if (!valor)
            {
                eliminar = false;
                modificar = false;
            }

            Utiles.LimpiarTexto.LimpiarDataGrid(dataGridView1);
        }
    }
}
