using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Calificar_Vendedor
{
    public partial class listadoDePublicaciones : Form
    {
        public listadoDePublicaciones(decimal id)
        {
            InitializeComponent();
            idUsuario = id;
            botonCalificar = false;
        }
        decimal idUsuario;
        private bool botonCalificar;


        public static void buscarListaDeNoCalificadas(decimal idUsuario, DataGridView dataGridView1)
        {

            try
            {
                SqlConnection conn = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.listaDePubSinCalificar", conn,
                new SqlParameter("@id_Cliente", idUsuario));

                Utiles.SQL.llenarDataGrid(dataGridView1, conn, cmd);
            }
            catch (Exception)
            {
                Mensajes.Errores.NoHayConexion();
            }

            dataGridView1.Columns["Id"].Visible = false;
            //dataGridView1.Columns["Calificacion_Cod"].Visible = false;
            //dataGridView1.Columns["Calificacion_Cant_Estrellas"].Visible = false;
            //dataGridView1.Columns["Calificaciones_Descripcion"].Visible = false;

        }
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Int32 idSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                  if (e.ColumnIndex == dataGridView1.CurrentRow.Cells["btnEdit"].ColumnIndex){
            
                Calificador mod = new Calificador(idSeleccionado);

                mod.ShowDialog();}
            }
            catch {
                Mensajes.Errores.NoHayDatosAmodificar();
            }
            
       

            }
        

        private void button1_Click(object sender, EventArgs e)
        {
            buscarListaDeNoCalificadas(idUsuario, dataGridView1);
            this.botonCalificar = Utiles.Inicializar.agregarColumnaModificar(botonCalificar, dataGridView1);
              
        }

    }

}
