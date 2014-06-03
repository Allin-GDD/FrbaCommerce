using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class Listado_de_selección : Form
    {
        public Listado_de_selección()
        {
            InitializeComponent();
            Utiles.Inicializar.comboBoxTipoDNI(cmbTipoDoc);

         

            botonModificar = false;
            botonDelete = false;
        }

        private bool botonModificar;
        private bool botonDelete;
        
       // public Int32 idSeleccionado;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Entidades.Ent_ListadoCliente pCliente = new Entidades.Ent_ListadoCliente();

            pCliente.Nombre = txtNombre.Text;
            pCliente.Apellido = txtApellido.Text;
            pCliente.Dni = txtDNI.Text;
            pCliente.Mail = txtMail.Text;
            pCliente.Tipo_dni = Convert.ToString(cmbTipoDoc.SelectedValue);

            Datos.Dat_Cliente.buscarListaDeCliente(pCliente, dataGridView1);

            //LE METO UN BOOLEANDO PQ SINO LOS SIGUE AGREGANDO
            Utiles.Inicializar.AgregarColumnaEliminarYSeleccionar(botonDelete, botonModificar, dataGridView1);
            
           

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Utiles.LimpiarTexto.LimpiarTextBox(this);
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 idSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                           

            if (e.ColumnIndex == 14)
            {//14 es la pocision del boton modificar
                Abm_Cliente.Modificación mod = new Abm_Cliente.Modificación(idSeleccionado);
                mod.Show();

            }
            if (e.ColumnIndex == 15)
            {
                Abm_Cliente.Baja baj = new Abm_Cliente.Baja(idSeleccionado);
                baj.Show();
                
            }
        }

      
         }
}

