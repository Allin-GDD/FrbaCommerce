﻿using System;
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
            Utiles.Inicializar.comboBoxTipoDoc(cmbTipoDoc);
            txtDNI.Enabled = false;

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
                pCliente.Tipo_doc = Convert.ToInt16(cmbTipoDoc.SelectedValue);

                Datos.Dat_Cliente.buscarListaDeCliente(pCliente, dataGridView1);
                
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
            Decimal idSeleccionado = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Id_Usuario"].Value);


            if (e.ColumnIndex == dataGridView1.CurrentRow.Cells["btnEdit"].ColumnIndex)
            {
                Abm_Cliente.Modificación mod = new Abm_Cliente.Modificación(idSeleccionado, false);
                this.Hide();
                mod.ShowDialog();
                this.Refresh();

                Show();
              
                

            }
            if (e.ColumnIndex == dataGridView1.CurrentRow.Cells["btnDelete"].ColumnIndex)
            {
                Abm_Cliente.Baja baj = new Abm_Cliente.Baja(idSeleccionado);
                this.Hide();
                baj.ShowDialog();
                this.Refresh();
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
            Utiles.Inicializar.alteraComboboxTipoDoc(cmbTipoDoc, txtDNI);
        }

      
         }
}

