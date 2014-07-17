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
    public partial class VentanaCompraAdmin : Form
    {

        // esta ventana es para cuando la publicacion es de una empresa
        private decimal codigo;
        private decimal idusuario;


        public VentanaCompraAdmin(decimal codigoPub, decimal idUsuario)
        {
            InitializeComponent();
            idusuario = idUsuario;
            this.codigo = codigoPub;

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

        private void button1_Click(object sender, EventArgs e)
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
