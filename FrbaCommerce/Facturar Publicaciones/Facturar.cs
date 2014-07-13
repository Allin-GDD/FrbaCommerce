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
        char rolEste;

        public Facturar( decimal id,char rol)
        {
            InitializeComponent();
            idUsuario = id;
            rolEste = rol;
            Tipo = null;
            Utiles.Inicializar.comboBoxTipoFormaDePago(comboBox1);
          
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // segun la cantidad de facturas seleccionadas busca el top y las cancela
            try
            {
                Utiles.Validaciones.validarDatosObligatorios(this);
                if (Utiles.Validaciones.ValidarTipoDecimal(textBox1))
                    throw new Excepciones.ValoresConTiposDiferentes("El campo marcado se debe completar con números");

                decimal cantidadmax = Convert.ToDecimal(textBox1.Text);
                
                Tipo = Convert.ToString(comboBox1.SelectedValue);
                buscarFacturasTop(idUsuario, cantidadmax, Tipo);
                Mensajes.Exitos.ComisionesCanceladas();
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buscarFacturasTop(decimal id, decimal cantidad, string tipo)
        {

            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.facturasTop", conn,
            new SqlParameter("@Id", id),
            new SqlParameter("@Cant", cantidad));
            SqlDataReader lectura = cmd.ExecuteReader();

            while (lectura.Read())
            {

                unaFactura(lectura.GetDecimal(0), tipo,lectura.GetDecimal(1),id,lectura.GetString(2));
            }
            conn.Close();
        }


        private static void unaFactura(decimal codigo, string tipo,Decimal visibilidad,Decimal id, string rol)
        {
            decimal nfactura = 0;
            double precioFinal;
            //se fija si es bonificada la publicacion para ver si es gratis o no
            if (esBonificada(codigo,visibilidad, id,rol))
            {
                precioFinal = 0;
            }
            else
            {
                precioFinal = buscarPrecioFinalFactura(codigo);
                List<Entidades.Ent_ListFactura> items = buscarItemsFactura(codigo);
                double preciovisibilidad = 0;
                //agrega todos los items
                foreach (Entidades.Ent_ListFactura item in items)
                {

                    agregarItemFacturaPublicacion(item.Codigo, nfactura, item.Cantidad, item.Precio * Convert.ToDouble(item.Cantidad) * item.Porcentaje);
                    preciovisibilidad = item.PrecioVis;
                }
                // agrega el item del precio base de la visibilidad
                agregarItemFacturaComision(codigo, nfactura, preciovisibilidad);
            }


            if (!string.IsNullOrEmpty(tipo))
            {
                //agrega la factura
                nfactura = agregarFactura(codigo, precioFinal, tipo);
            }



        }
        //lista todas las que no fueron facturadas.
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

        //Agrega la factura correspondiente.
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
                   new SqlParameter("@Tipo_Pago",Convert.ToDecimal(tipopago)),
                   new SqlParameter("@Nro_Fac", nfact),
                   new SqlParameter("@Fecha", DBConexion.fechaIngresadaPorElAdministrador()));
                   

                retorno = cmd.ExecuteNonQuery();
                conexion.Close();
                return nfact;

       
            }
            
      
        }

        //Devuelve el precio final de la factura teniendo en cuenta porcentaje y precio base
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
        //Devuelve el número de la factura
        private static decimal generarNroFactura()
        {
            using (SqlConnection conexion = DBConexion.obtenerConexion())
            {
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.nroFactura", conexion);
                SqlDataReader lectura = cmd.ExecuteReader();
                lectura.Read();
             //   throw new Excepciones.DuplicacionDeDatos(Convert.ToString(lectura.GetDecimal(0)));
                
                conexion.Close();
                return (lectura.GetDecimal(0) + 1);
            }
        }


        //Busca los items que son una tabla distinta de la de factura.
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
         
        //Se fija si la factura en cuestión es bonificada (osea cada diez del mismo tipo de visibilidad te regalan una)
         private static bool esBonificada(decimal codigo,Decimal visibilidad,Decimal Id, string Rol)
         {
             int retorno;
             Boolean esBonif = false;
             using (SqlConnection conexion = DBConexion.obtenerConexion())
             {
                 
                 SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.esBonificada", conexion,
                 new SqlParameter("@Id", Id),
                // new SqlParameter("@Rol", Rol),
                 new SqlParameter("@Visibilidad", codigo));

                 SqlDataReader lectura = cmd.ExecuteReader();

                 while (lectura.Read())
                 {
                     if (lectura.GetDecimal(0) == codigo)
                     {
                         esBonif = true;
                     }
                 }
                 retorno = cmd.ExecuteNonQuery();
                 conexion.Close();
             }

             return esBonif;

         }
        //agrega el item factura
         private static void agregarItemFacturaPublicacion(decimal codigo, decimal nfactura, decimal cantidad, double precio)
         {
             int retorno;
             using (SqlConnection conexion = DBConexion.obtenerConexion())
             {

                 SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.agregarItemFacturaPublicacion", conexion,
                    new SqlParameter("@Codigo", codigo),
                    new SqlParameter("@Precio", precio),
                    new SqlParameter("@Nro_Fact", nfactura),
                    new SqlParameter("@Cant", cantidad));


                 retorno = cmd.ExecuteNonQuery();
                 conexion.Close();
              }
        
         }
         private static void agregarItemFacturaComision(decimal codigo, decimal nfactura,double precio)
         {
             int retorno;
             using (SqlConnection conexion = DBConexion.obtenerConexion())
             {

                 SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.agregarItemFacturaComision", conexion,
                    new SqlParameter("@Codigo", codigo),
                    new SqlParameter("@Precio", precio),
                    new SqlParameter("@Nro_Fact", nfactura));


                 retorno = cmd.ExecuteNonQuery();
                 conexion.Close();
             }

         }

         private void button1_Click(object sender, EventArgs e)
         {
             Close();
         }

         private void button3_Click(object sender, EventArgs e)
         {
             buscarPublicacionesSinFacturar(idUsuario, dataGridView1);
         }


        }
}
