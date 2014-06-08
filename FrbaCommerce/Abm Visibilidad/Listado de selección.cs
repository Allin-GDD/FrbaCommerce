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
<<<<<<< HEAD
            eliminar = false;
            modificar = false;


=======
         //   eliminar = false;
         //   modificar = false;
            
          
>>>>>>> 2d24ccc7497ddcf7d891a209dd44f8a1a0994847
        }
       // private bool eliminar;
       // private bool modificar;

        private void button2_Click(object sender, EventArgs e)
        {
            Entidades.Ent_ListadoVisibilidad pvisibilidad = new Entidades.Ent_ListadoVisibilidad();


            pvisibilidad.Codigo = textBox1.Text;
            pvisibilidad.Descripcion = textBox2.Text;
            pvisibilidad.Precio = textBox3.Text;
            pvisibilidad.Porcentaje = textBox4.Text;

<<<<<<< HEAD

            //Datos.Dat_Visibilidad.buscarListaDeVisibilidades(pvisibilidad, dataGridView1);

            //LE METO UN BOOLEANDO PQ SINO LOS SIGUE AGREGANDO
            Utiles.Inicializar.agregarColumnaModificar(modificar, dataGridView1);
            Utiles.Inicializar.AgregarColumnaEliminar(eliminar, dataGridView1);

=======
        //    Datos.Dat_Visibilidad.buscarListaDeVisibilidades(pvisibilidad, dataGridView1);

            //LE METO UN BOOLEANDO PQ SINO LOS SIGUE AGREGANDO
       //     Utiles.Inicializar.AgregarColumnaEliminarYSeleccionar(eliminar, modificar, dataGridView1);
            
           
>>>>>>> 2d24ccc7497ddcf7d891a209dd44f8a1a0994847
        }


        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 codigoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);


            if (e.ColumnIndex == 14)
            {//14 es la pocision del boton modificar
                Abm_Cliente.Modificación mod = new Abm_Cliente.Modificación(codigoSeleccionado);
                mod.Show();

            }
            if (e.ColumnIndex == 15)
            {
                Abm_Cliente.Baja baj = new Abm_Cliente.Baja(codigoSeleccionado);
                baj.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
