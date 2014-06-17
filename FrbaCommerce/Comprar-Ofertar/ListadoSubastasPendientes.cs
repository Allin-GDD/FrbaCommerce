using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Comprar_Ofertar
{
    public partial class ListadoSubastasPendientes : Form
    {
        public ListadoSubastasPendientes(decimal id)
        {
            InitializeComponent();
            idUsuario = id;
            botonAceptar = false;
        }

        decimal idUsuario;
        private bool botonAceptar;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Decimal codigo = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[0].Value);
            Decimal idSeleccionado = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value);
            

            if (e.ColumnIndex == 3)
            {
                
                    cambiarcan_ganador(codigo);
                    SqlConnection conn = DBConexion.obtenerConexion();
                    SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.agregarCompra", conn,
                    new SqlParameter("@Codigo", codigo),
                    new SqlParameter("@Id", idSeleccionado),
                    new SqlParameter("@Stock", 1));

               conn.Close();
              
              
            }
            Mensajes.Exitos.ExitoAlGuardaLosDatos();
            
        }
       private static void buscarSubastasSinConfirmarGanador(decimal idUsuario, DataGridView dataGridView1)
        {

            try
            {
                SqlConnection conn = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.listaSubastasSinConfirmarGanador", conn,
                new SqlParameter("@id_Cliente", idUsuario));

                Utiles.SQL.llenarDataGrid(dataGridView1, conn, cmd);
            }
            catch (Exception)
            {
                Mensajes.Errores.NoHayConexion();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscarSubastasSinConfirmarGanador(idUsuario, dataGridView1);
               this.botonAceptar = Utiles.Inicializar.agregarColumnaModificar(botonAceptar, dataGridView1);
              
        }
        private static void cambiarcan_ganador(decimal codigo)
        {
        

        //    try
        //    {

                SqlConnection conn2 = DBConexion.obtenerConexion();
                SqlCommand cmd2 = Utiles.SQL.crearProcedure("GD1C2014.dbo.cambiarConGanador", conn2,
                    new SqlParameter("@Codigo", codigo));
                int retorno = cmd2.ExecuteNonQuery();
                conn2.Close();
         //   }
         //   catch (Exception)
         //   {
           //     Mensajes.Errores.NoHayConexion();
           // }

        }
    }
}
