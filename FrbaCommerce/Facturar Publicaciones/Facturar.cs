using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Facturar_Publicaciones
{
    public partial class Facturar : Form
    {
        public Facturar( decimal id)
        {
            InitializeComponent();
            idUsuario = id;
            Utiles.Inicializar.comboBoxTipoFormaDePago(comboBox1);
        }

        decimal idUsuario;
        private void button1_Click(object sender, EventArgs e)
        {
            buscarPublicacionesSinFacturar(idUsuario, dataGridView1);
        }

        private static void buscarPublicacionesSinFacturar(decimal idUsuario, DataGridView dataGridView1)
        {

                 try
            {
                SqlConnection conn = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.listaDePublicacionesSinFacturar", conn,
                new SqlParameter("@id", idUsuario));

                Utiles.SQL.llenarDataGrid(dataGridView1, conn, cmd);
                conn.Close();
            }
            catch (Exception)
            {
                Mensajes.Errores.NoHayConexion();
            }
        }

        //private static Facturar(decimal codigo)
        //{
        //    Entidades.Ent_ListFactura items = traerFuturasItemFacutar(codigo);
           

        // //   foreach (int item in items)
        //  //  {
        //    //agregarItemFactura
        //   // }

        //    double precioFinal = traerFuturasFacturas(codigo);
        //    //agregarFactura(codigo, precioFinal,tipopago);
        //}

        private static void agregarFactura(decimal codigo,double  precioFinal,string tipopago)
        {

            int retorno;
             using (SqlConnection conexion = DBConexion.obtenerConexion())
            {


                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.agregarFactura", conexion,
                   new SqlParameter("@Codigo", codigo),
                   new SqlParameter("@Precio", precioFinal),
                   new SqlParameter("@Tipo_Pago", tipopago));
                   

                retorno = cmd.ExecuteNonQuery();
                conexion.Close();
            }
            

            Mensajes.Generales.validarAlta(retorno);

        
        }


        private static double traerFuturasFacturas(decimal codigo)
        {

                Entidades.Ent_ListFactura pfact = new Entidades.Ent_ListFactura();
 
              double aFacturar=0;
                SqlConnection conn = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.publicacionAFacturar", conn,
                new SqlParameter("@Codigo", codigo));
                SqlDataReader lectura = cmd.ExecuteReader();

                while (lectura.Read())
                {
                    pfact.Codigo = lectura.GetDecimal(0);
                    pfact.Cantidad = lectura.GetDecimal(1);
                    pfact.Porcentaje = lectura.GetDouble(2);
                    pfact.Precio = lectura.GetDouble(3);
                    pfact.PrecioVis = lectura.GetDouble(4);
                    aFacturar = aFacturar + Convert.ToDouble(pfact.Cantidad) * pfact.Precio*pfact.Porcentaje;

                }
                conn.Close();
                
                
                return aFacturar;
          
        }




        private static Entidades.Ent_ListFactura traerFuturasItemFacutar(decimal codigo)
        {

            Entidades.Ent_ListFactura pfact = new Entidades.Ent_ListFactura();

            
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.publicacionAFacturar", conn,
            new SqlParameter("@Codigo", codigo));
            SqlDataReader lectura = cmd.ExecuteReader();

            while (lectura.Read())
            {
                pfact.Codigo = lectura.GetDecimal(0);
                pfact.Cantidad = lectura.GetDecimal(1);
                pfact.Porcentaje = lectura.GetDouble(2);
                pfact.Precio = lectura.GetDouble(3);
                pfact.PrecioVis = lectura.GetDouble(4);
            
            }
            conn.Close();

            return pfact;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal cantidadmax = Convert.ToDecimal(textBox1.Text);
            string Tipo_pago = Convert.ToString(comboBox1.SelectedValue);

        }

         }
}
