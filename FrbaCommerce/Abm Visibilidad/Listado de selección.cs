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
                this.eliminar = Utiles.Inicializar.AgregarColumnaEliminar(eliminar, dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
  

        }


        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 codigoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);


            if (e.ColumnIndex == 6)
            {//4 es la pocision del boton modificar
                Abm_Visibilidad.Modificación mod = new Abm_Visibilidad.Modificación(codigoSeleccionado);
                mod.Show();

            }
            if (e.ColumnIndex == 7)
            {
            Abm_Visibilidad.Baja baj = new Abm_Visibilidad.Baja(codigoSeleccionado);
            baj.Show();
            }
        }
    }
}
