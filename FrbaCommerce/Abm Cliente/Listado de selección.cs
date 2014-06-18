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

            List<Entidades.Ent_TipoDeDoc> listaDeDoc = new List<Entidades.Ent_TipoDeDoc>();
            listaDeDoc = Datos.Dat_Cliente.ObtenerTipoDoc();

            Entidades.Ent_TipoDeDoc entDoc = new Entidades.Ent_TipoDeDoc();
            entDoc.codigo = 0;
            entDoc.tipo = "";

            listaDeDoc.Insert(0, entDoc);

            cmbTipoDoc.DataSource = listaDeDoc;
            cmbTipoDoc.DisplayMember = "tipo";
            cmbTipoDoc.ValueMember = "codigo";

            botonModificar = false;
            botonDelete = false;
        }

        private bool botonModificar;
        private bool botonDelete;


        private void btnBuscar_Click(object sender, EventArgs e)
        {
              Entidades.Ent_ListadoCliente pCliente = new Entidades.Ent_ListadoCliente();
            try
            {
                pCliente.Nombre = txtNombre.Text;
                pCliente.Apellido = txtApellido.Text;
                pCliente.Dni = txtDNI.Text;
                pCliente.Mail = txtMail.Text;
                pCliente.Tipo_dni = Convert.ToString(cmbTipoDoc.SelectedValue);

                if (Convert.ToString(cmbTipoDoc.SelectedValue) == "0")
                {
                    Datos.Dat_Cliente.buscarListaDeCliente2(pCliente, dataGridView1);
                }
                else
                {
                    Datos.Dat_Cliente.buscarListaDeCliente(pCliente, dataGridView1);
                }

                //LE METO UN BOOLEANDO PQ SINO LOS SIGUE AGREGANDO
                this.botonModificar = Utiles.Inicializar.agregarColumnaModificar(botonModificar, dataGridView1);
                this.botonDelete = Utiles.Inicializar.agregarColumnaEliminar(botonDelete, dataGridView1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
           
         

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
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
            Decimal idSeleccionado = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Id"].Value);


            if (e.ColumnIndex == dataGridView1.CurrentRow.Cells["btnEdit"].ColumnIndex)
            {
                Abm_Cliente.Modificación mod = new Abm_Cliente.Modificación(idSeleccionado, false);
                mod.Show();

            }
            if (e.ColumnIndex == dataGridView1.CurrentRow.Cells["btnDelete"].ColumnIndex)
            {
                Abm_Cliente.Baja baj = new Abm_Cliente.Baja(idSeleccionado);
                baj.Show();
                
            }
        }
              catch {
                Mensajes.Errores.NoHayDatosAmodificar();
            }

        }

      
         }
}

