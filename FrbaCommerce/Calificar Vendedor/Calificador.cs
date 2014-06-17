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
    public partial class Calificador : Form
    {
        public Calificador(decimal id)
        {
            InitializeComponent();
            idCompra = id;
        }
        decimal idCompra;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal puntaje = Convert.ToDecimal(textBox1.Text);
                Utiles.Validaciones.ValidarTipoDecimal(textBox1);
                validarPuntaje(puntaje);
                decimal cod_calificacion = obternerCodCalificacionMax()+1;

                SqlConnection conn = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.agregarCalificacion", conn,
                new SqlParameter("@Id", idCompra),
                new SqlParameter("@Cal_Cod", cod_calificacion),
                new SqlParameter("@Cant_Est", puntaje),
                new SqlParameter("@Desc", textBox2.Text));
                int retorno = cmd.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Mensajes.Exitos.ExitosAlRealizarCalificacion();
            this.Close();
        }

        private void validarPuntaje(decimal puntaje)
        {
            if (puntaje > 5 || puntaje < 1)
            {

              throw new  Excepciones.ValorMenor("La calificacion debe ser entre 1 y 5 puntos");
            }
        }

        private decimal obternerCodCalificacionMax()
        {
            decimal cod;
            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("select MAX(Calificacion_Codigo) from Compra", conexion);
            SqlDataReader lectura = Comando.ExecuteReader();
            lectura.Read();
            cod = lectura.GetDecimal(0);
            return cod;
        }
    }
}
