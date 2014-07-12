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

            //inicializo el comboBox Tipo de documento con los tipos que hay en la BD por defecto.
            Utiles.Inicializar.comboBoxTipoDoc(cmbTipoDoc);
            txtDNI.Enabled = false;

            botonModificar = false;
            botonDelete = false;
        }

        private bool botonModificar;
        private bool botonDelete;


        private void btnBuscar_Click(object sender, EventArgs e)
        {
             
            try
            {
                cargarDatagrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarDatagrid()
        {
            Entidades.Ent_ListadoCliente pCliente = new Entidades.Ent_ListadoCliente();
            pCliente.Nombre = txtNombre.Text;
            pCliente.Apellido = txtApellido.Text;
            pCliente.Dni = txtDNI.Text;
            pCliente.Mail = txtMail.Text;
            pCliente.Tipo_doc = Convert.ToInt16(cmbTipoDoc.SelectedValue);

            //Llena el datagrid según los datos seleccionados
            Datos.Dat_Cliente.buscarListaDeCliente(pCliente, dataGridView1);

            //Agrega los botones de Modificar y editar
            this.botonModificar = Utiles.Inicializar.agregarColumnaModificar(botonModificar, dataGridView1);
            this.botonDelete = Utiles.Inicializar.agregarColumnaEliminar(botonDelete, dataGridView1);
        }
           
         

        private void btnLimpiar_Click(object sender, EventArgs e)
        {//Limpia los textbox, datagrid e inicializar los valores de los botones.
            Utiles.LimpiarTexto.LimpiarTextBox(this);
                   
            bool valor = Utiles.LimpiarTexto.LimpiarDataGridBoton(dataGridView1);
            if (!valor) {
                botonDelete = false;
                botonModificar = false;
            }

            Utiles.LimpiarTexto.LimpiarDataGrid(dataGridView1);
            }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           try{ 
            Decimal idSeleccionado = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Id_Usuario"].Value);

               //Según el botón seleccionado, ejecutará la acción ( Modificar o baja)
            if (e.ColumnIndex == dataGridView1.CurrentRow.Cells["btnEdit"].ColumnIndex)
            {
                Abm_Cliente.Modificación mod = new Abm_Cliente.Modificación(idSeleccionado, false);
                this.Hide();
                mod.ShowDialog();
                cargarDatagrid();

                Show();
      
            }
            if (e.ColumnIndex == dataGridView1.CurrentRow.Cells["btnDelete"].ColumnIndex)
            {
                Abm_Cliente.Baja baj = new Abm_Cliente.Baja(idSeleccionado);
                this.Hide();
                baj.ShowDialog();
                cargarDatagrid();
                Show();
                
            }
        }
              catch(Exception)
           {
                Mensajes.Errores.NoHayDatosAmodificar();
            }

        }

        private void cmbTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Según la selección del comboBox, se irá editando la MaskedTextBox dependiendo de lo que se elija. 
            Utiles.Inicializar.alteraComboboxTipoDoc(cmbTipoDoc, txtDNI);
        }

      
         }
}

