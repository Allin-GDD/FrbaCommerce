using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FrbaCommerce.Datos
{
    class Dat_CompraOferta
    {
        public static List<Entidades.Ent_Rubros> ObtenerRubros()
        {

            List<Entidades.Ent_Rubros> listaDeRubros = new List<Entidades.Ent_Rubros>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("Select Codigo, Descripcion from Rubro", conexion);
            SqlDataReader lectura = Comando.ExecuteReader();

            while (lectura.Read())
            {
                Entidades.Ent_Rubros pRubro = new Entidades.Ent_Rubros();
                pRubro.codigo = lectura.GetInt16(0);
                pRubro.rubro = lectura.GetString(1);

                listaDeRubros.Add(pRubro);
            }
            return listaDeRubros;
        }

        public static void buscarListado(Entidades.Ent_ListadoPublicacion pListado, DataGridView dataGridView1)
        {

            try
            {
                SqlConnection conn = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.listaDePublicaciones", conn,
                new SqlParameter("@Descripcion", pListado.Descripcion),
                new SqlParameter("@Rubro", pListado.Rubro))
                ;
                Utiles.SQL.llenarDataGrid(dataGridView1, conn, cmd);
            }
            catch (Exception)
            {
                Mensajes.Errores.NoHayConexion();
            }

        }

        public static void validarValorOferta(decimal codigoPub, double precioOfertado)
        {

            double precioBase = 0;
            double precioMayorOferta = 0;

            using (SqlConnection conn = DBConexion.obtenerConexion())
            {
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarPrecio", conn,
                    new SqlParameter("@Cod_Pub", codigoPub));
                SqlDataReader lectura = cmd.ExecuteReader();
                while (lectura.Read())
                {

                    precioBase = Convert.ToDouble(lectura.GetDecimal(0));
                }
               
            
                if (precioOfertado <= precioBase)
            {
                throw new Excepciones.ValorMenor("El valor ingresado es menor al precio base");
            
            }
                conn.Close();
            }
                using (SqlConnection conn2 = DBConexion.obtenerConexion())
            {

                SqlCommand cmd2 = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarMaximaOferta", conn2,
                      new SqlParameter("@Cod_Pub", codigoPub));
                SqlDataReader lectura2 = cmd2.ExecuteReader();
              while (lectura2.Read())
              {
                 
                 precioMayorOferta = Convert.ToDouble(lectura2.GetDecimal(0));
              }
                if (precioOfertado <= precioMayorOferta)
            {
                throw new Excepciones.ValorMenor("El valor ingresado es menor a la última oferta realizada");

            }
                conn2.Close();
            }
  
        }

        public static void AgregarOferta(Entidades.Ent_Oferta pOferta)
        {
            int retorno;

            using (SqlConnection conexion = DBConexion.obtenerConexion())
            {

                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.agregarNuevaOferta", conexion,
                   new SqlParameter("@Cod_Pub", pOferta.Codigo_Pub),
                   new SqlParameter("@Monto", pOferta.Monto),
                   new SqlParameter("@Id_Cli", pOferta.Id_Cli));
              
                retorno = cmd.ExecuteNonQuery();
                conexion.Close();
            }


            Mensajes.Generales.validarAlta(retorno);

        }

    }
}
