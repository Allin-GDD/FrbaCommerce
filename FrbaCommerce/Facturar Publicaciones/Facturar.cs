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
        public string Tipo;
        decimal idUsuario;

        public Facturar( decimal id)
        {
            InitializeComponent();
            idUsuario = id;
            Tipo = null;
            Utiles.Inicializar.comboBoxTipoFormaDePago(comboBox1);
        }
       

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


        
       
        private static decimal agregarFactura(decimal codigo,double  precioFinal,string tipopago)

        {
            decimal nfact;
            int retorno;
             using (SqlConnection conexion = DBConexion.obtenerConexion())
            {
                nfact = generarNroFactura();

                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.agregarFactura", conexion,
                   new SqlParameter("@Codigo", codigo),
                   new SqlParameter("@Precio", precioFinal),
                   new SqlParameter("@Tipo_Pago",Convert.ToInt16(tipopago)),
                   new SqlParameter("@Nro_Fac", nfact));
                   

                retorno = cmd.ExecuteNonQuery();
                conexion.Close();
                return nfact;

       
            }
            

            Mensajes.Generales.validarAlta(retorno);

        
        }


        private static double buscarPrecioFinalFactura(decimal codigo)
        {

                Entidades.Ent_ListFactura pfact = new Entidades.Ent_ListFactura();
                double precioBase = 0;
              double aFacturar=0;
                SqlConnection conn = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.publicacionAFacturar", conn,
                new SqlParameter("@Codigo", codigo));
                SqlDataReader lectura = cmd.ExecuteReader();

                while (lectura.Read())
                {
                    pfact.Codigo = lectura.GetDecimal(0);
                    pfact.Cantidad = lectura.GetDecimal(1);
                    pfact.Porcentaje = Convert.ToDouble(lectura.GetDecimal(2));
                    pfact.Precio = Convert.ToDouble(lectura.GetDecimal(3));
                    pfact.PrecioVis = Convert.ToDouble(lectura.GetDecimal(4));
                    precioBase = pfact.PrecioVis;
                    
                    aFacturar = aFacturar + Convert.ToDouble(pfact.Cantidad) * pfact.Precio*pfact.Porcentaje;

                }
                conn.Close();

        
                return aFacturar+precioBase;
          
        }

        private static decimal generarNroFactura()
        {
            using (SqlConnection conexion = DBConexion.obtenerConexion())
            {
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.nroFactura", conexion);
                SqlDataReader lectura = cmd.ExecuteReader();
                lectura.Read();
             //   throw new Excepciones.DuplicacionDeDatos(Convert.ToString(lectura.GetDecimal(0)));
                return (lectura.GetDecimal(0) +1);
            }
        }



        private static List<Entidades.Ent_ListFactura> buscarItemsFactura(decimal codigo)
        {
            List<Entidades.Ent_ListFactura> lista = new List<FrbaCommerce.Entidades.Ent_ListFactura>();


            
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.publicacionAFacturar", conn,
            new SqlParameter("@Codigo", codigo));
            SqlDataReader lectura = cmd.ExecuteReader();

            while (lectura.Read())
            {

                Entidades.Ent_ListFactura pfact = new Entidades.Ent_ListFactura();
                pfact.Codigo = lectura.GetDecimal(0);
                pfact.Cantidad = lectura.GetDecimal(1);
                pfact.Porcentaje = Convert.ToDouble(lectura.GetDecimal(2));
                pfact.Precio = Convert.ToDouble(lectura.GetDecimal(3));
                pfact.PrecioVis = Convert.ToDouble(lectura.GetDecimal(4));
                lista.Add(pfact);
            }

            conn.Close();

            return lista;
            

        }
        private void buscarFacturasTop(decimal id,decimal cantidad,string tipo)
        {

             SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.facturasTop", conn,
            new SqlParameter("@Id", id),
            new SqlParameter("@Cant", cantidad));
            SqlDataReader lectura = cmd.ExecuteReader();

            while(lectura.Read()){
            
                unaFactura(lectura.GetDecimal(0),tipo);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            decimal cantidadmax = Convert.ToDecimal(textBox1.Text);
            
             Tipo = Convert.ToString(comboBox1.SelectedValue);

            buscarFacturasTop(idUsuario,cantidadmax,Tipo);



        }
         private static void unaFactura(decimal codigo, string tipo)
        {
            decimal nfactura= 0; 
            double precioFinal = buscarPrecioFinalFactura(codigo);
            if (!string.IsNullOrEmpty(tipo))
            {
                
                nfactura = agregarFactura(codigo, precioFinal, tipo);
            }


            List<Entidades.Ent_ListFactura> items = buscarItemsFactura(codigo);
           

          foreach (Entidades.Ent_ListFactura item in items)
            {
            agregarItemFactura(item.Codigo,nfactura,item.Cantidad,item.Precio);
              
            }
       
        }
         private static void agregarItemFactura(decimal codigo, decimal nfactura, decimal cantidad, double precio)
         {
             int retorno;
             using (SqlConnection conexion = DBConexion.obtenerConexion())
             {

                 SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.agregarItemFactura", conexion,
                    new SqlParameter("@Codigo", codigo),
                    new SqlParameter("@Precio", precio),
                    new SqlParameter("@Nro_Fact", nfactura),
                    new SqlParameter("@Cant", cantidad));


                 retorno = cmd.ExecuteNonQuery();
                 conexion.Close();
              }


        
         }

         }
}
