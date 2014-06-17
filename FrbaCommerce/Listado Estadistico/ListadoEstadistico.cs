using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Listado_Estadistico
{
    public partial class ListadoEstadistico : Form
    {
        private Boolean tipo1 = false;
        private Boolean tipo2 = false;
        private Boolean tipo3 = false;
        private Boolean tipo4 = false;
        private int filtroTrimestre = 0;


     
        public ListadoEstadistico()
        {

            InitializeComponent();
           
            cmbMes.Enabled = false;
            cmbVisibilidad.Enabled = false;

            cmbMes.Text = "";
            cmbTipolist.Text = "";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy";
            dateTimePicker2.ShowUpDown = true;

        }

    

        private void cmbTipolist_SelectedIndexChanged(object sender, EventArgs e)
        {
                         if(cmbTipolist.SelectedItem.ToString() == "Vendedores con mayor cantidad de productos no vendidos")
                         {
                cmbMes.Enabled = true;
                cmbVisibilidad.Enabled = true;

                tipo1 = true;
                tipo2 = false;
                tipo3 = false;
                tipo4 = false;
                              
                Utiles.Inicializar.comboBoxVisibilidad(cmbVisibilidad);
                           }
            else
            {
                cmbMes.Enabled = false;
                cmbVisibilidad.Enabled = false;
                cmbMes.Text = "";
                cmbVisibilidad.DataSource = null;
             
            }

                     if (cmbTipolist.SelectedItem.ToString() == "Vendedores con mayor facturación") {

                         tipo1 = false;
                         tipo2 = true;
                         tipo3 = false;
                         tipo4 = false;
                     }
                     if (cmbTipolist.SelectedItem.ToString() == "Vendedores con mayores calificaciones")
                     {

                         tipo1 = false;
                         tipo2 = false;
                         tipo3 = true;
                         tipo4 = false;

                     }
                     if (cmbTipolist.SelectedItem.ToString() == "Clientes con mayor cantidad de publicaciones en calificar")
                     {
                         tipo1 = false;
                         tipo2 = false;
                         tipo3 = false;
                         tipo4 = true;
                     }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Int16 año = Convert.ToInt16(dateTimePicker2.Text);

            dataGridView1.DataSource = null;

            if (tipo1) { Datos.Dat_Listados.vendedoresQueMEnosVenden(año, Convert.ToDecimal(cmbVisibilidad.SelectedValue), Convert.ToInt32(cmbMes.SelectedValue), dataGridView1); }
            if (tipo2) { Datos.Dat_Listados.vendedoresMayorFacturacion(año, filtroTrimestre,dataGridView1); }
            if (tipo3) { Datos.Dat_Listados.vendedoresConMayoresCalificaciones(año, filtroTrimestre,dataGridView1); }
            if (tipo4) { Datos.Dat_Listados.clientesMayoresPublicacionesSinCalif(año, filtroTrimestre,dataGridView1); }

        }

        private void cmbTrimestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTrimestre.SelectedItem.ToString() == "Primer Trimestre") {

                cmbMes.DataSource = null;
                filtroTrimestre = 1;
                Utiles.Inicializar.comboBoxMes(cmbMes, 1);
            }

            if (cmbTrimestre.SelectedItem.ToString() == "Segundo Trimestre")
            {
                cmbMes.DataSource = null;
                filtroTrimestre = 2;
                Utiles.Inicializar.comboBoxMes(cmbMes, 2);
            }

            if (cmbTrimestre.SelectedItem.ToString() == "Tercer Trimestre")
            {

                cmbMes.DataSource = null;
                filtroTrimestre = 3;
                Utiles.Inicializar.comboBoxMes(cmbMes, 3);
            }

            if (cmbTrimestre.SelectedItem.ToString() == "Cuarto Trimestre")
            {

                cmbMes.DataSource = null;
                filtroTrimestre = 4;
                Utiles.Inicializar.comboBoxMes(cmbMes, 4);
            }

            
        }

       

         }
}
