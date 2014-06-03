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

            pEmpresa.CUIT = txtCUIT.Text;
            pEmpresa.Mail = txtMail.Text;
            pEmpresa.Razon_Social = txtRazonSocial.Text;

            Datos.Dat_Empresa.buscarListaDeEmpresa(pEmpresa, dataGridView1);

            Utiles.Inicializar.AgregarColumnaEliminarYSeleccionar(botonDelete, botonModificar, dataGridView1);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utiles.LimpiarTexto.LimpiarTextBox(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 idSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);


            if (e.ColumnIndex == 15)
            {//14 es la pocision del boton modificar
                Abm_Empresa.Modificación mod = new Abm_Empresa.Modificación(idSeleccionado);
                mod.Show();

            }
            if (e.ColumnIndex == 16)
            {
                //Abm_Empresa.Baja baj = new Abm_Empresa.Baja(idSeleccionado);
                //baj.Show();
                                
            }
        }
    }
}
