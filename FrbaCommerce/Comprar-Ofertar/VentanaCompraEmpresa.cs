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
    public partial class VentanaCompraEmpresa : Form
    {

        // esta ventana es para cuando la publicacion es de una empresa
        private decimal codigo;
        private decimal idusuario;
        

        public VentanaCompraEmpresa(decimal codigoPub,decimal idUsuario)
        {
            InitializeComponent();
            idusuario = idUsuario;
            this.codigo = codigoPub;
            cargarDatosDelVendedor();

        }

        private string cargarUsuario(decimal id)
        {
           string usuario = "";
           using (SqlConnection conexion = DBConexion.obtenerConexion())
           {
               
               SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarUsuarioEmpresa", conexion,
               new SqlParameter("@Id", id));

               SqlDataReader lectura = cmd.ExecuteReader();
               while (lectura.Read())
               {

                   usuario = lectura.GetString(0);

               }
               conexion.Close();
           }
            return usuario;
            }
        

        private void cargarDatosDelVendedor()
        {
            

            Entidades.Ent_VendedorEmpresa pcliente = new Entidades.Ent_VendedorEmpresa();
            decimal clienteABuscar = buscaridVendedor(codigo);
            pcliente = buscarEmpresa(clienteABuscar);
            pcliente.Usuario = cargarUsuario(clienteABuscar);
            

            
            txtrazon.Text = pcliente.RazonSocial;
            txtcuil.Text = pcliente.CUIT;
            txtcalle.Text = pcliente.Dom_Calle;
            txtcp.Text = pcliente.Cod_Postal;
            txtdpto.Text = pcliente.Dpto;
            txtmail.Text = pcliente.Mail;
            txtnum.Text = Convert.ToString(pcliente.Nro_Calle);
            textpiso.Text = Convert.ToString(pcliente.Piso);  
            txtlocalidad.Text = pcliente.Localidad;
            txtusuario.Text = pcliente.Usuario;
            txttel.Text = Convert.ToString(pcliente.Telefono);
            textciudad.Text = pcliente.Ciudad;
            txtcontacto.Text = pcliente.NombreContacto;
        

        }
        public decimal buscaridVendedor(decimal codigo)
        {


            SqlConnection conn = DBConexion.obtenerConexion();
            
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarIdPorPublicacion", conn,
                new SqlParameter("@Codigo", codigo));
                SqlDataReader lectura = cmd.ExecuteReader();

                lectura.Read();
                
                decimal  id = lectura.GetDecimal(0);
                
                conn.Close();
                return id;
            
            
            
        }

        public static Entidades.Ent_VendedorEmpresa buscarEmpresa(decimal id)
        {

            Entidades.Ent_VendedorEmpresa pEmpresa = new Entidades.Ent_VendedorEmpresa();

            try {
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarUnaSolaEmpresa", conn,
            new SqlParameter("@Id", id));

            SqlDataReader lectura = cmd.ExecuteReader();
            while (lectura.Read())
            {
                pEmpresa.RazonSocial = lectura.GetString(1);
                pEmpresa.CUIT = lectura.GetString(2);
                pEmpresa.Fecha_Creacion = Convert.ToString(lectura.GetDateTime(3));
                pEmpresa.Mail = lectura.GetString(4);
                pEmpresa.Dom_Calle = lectura.GetString(5);
                pEmpresa.Nro_Calle = lectura.GetDecimal(6);
                pEmpresa.Piso = lectura.GetDecimal(7);
                pEmpresa.Dpto = lectura.GetString(8);
                pEmpresa.Cod_Postal = lectura.GetString(9);
                pEmpresa.Localidad = lectura.GetString(10);
                pEmpresa.Telefono = lectura.GetString(11);
                pEmpresa.Ciudad = lectura.GetString(12);
                pEmpresa.NombreContacto = lectura.GetString(13);
            }
            conn.Close();
            }
            catch (Exception) { Mensajes.Errores.NoHayConexion(); }
            return pEmpresa;
        }

        private static void validarStock(decimal valor, decimal codigo)
        {
            decimal stock;
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.averiguarStock", conn,
            new SqlParameter("@Codigo", codigo));
            SqlDataReader lectura = cmd.ExecuteReader();
            lectura.Read();

            stock = lectura.GetDecimal(0);

            if (valor > stock)
            {
                throw new Excepciones.ValorMenor("No hay suficiente stock disponible");
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {


                decimal stock = Convert.ToDecimal(txtvalor.Text);
                Utiles.Validaciones.ValidarTipoDecimal(txtvalor);
                validarStock(stock, codigo);

                SqlConnection conn = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.agregarCompra", conn,
                new SqlParameter("@Codigo", codigo),
                new SqlParameter("@Id", idusuario),
                new SqlParameter("@Stock", stock),
                new SqlParameter("@Fecha", DBConexion.fechaIngresadaPorElAdministrador()));
                int retorno = cmd.ExecuteNonQuery();

                


                SqlCommand cmd2 = Utiles.SQL.crearProcedure("GD1C2014.dbo.actualizarStock", conn,
                new SqlParameter("@Codigo", codigo),
                new SqlParameter("@Stock", stock));
                int retorno2 = cmd2.ExecuteNonQuery();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            Mensajes.Exitos.ExitoEnCompra();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
           
    }
}
