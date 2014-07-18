using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace FrbaCommerce.Datos
{
    class Dat_Factura
    {
        public static List<Entidades.Ent_TipoDePago> ObtenerTipoPago()
        {


            List<Entidades.Ent_TipoDePago> listaDeTipos = new List<Entidades.Ent_TipoDePago>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("Select Codigo, Nombre from allin.Tipo_Pago", conexion);
            SqlDataReader lectura = Comando.ExecuteReader();

            while (lectura.Read())
            {
                Entidades.Ent_TipoDePago pTipoPago = new Entidades.Ent_TipoDePago();
                pTipoPago.codigo = lectura.GetDecimal(0);
                pTipoPago.tipo = lectura.GetString(1);

                listaDeTipos.Add(pTipoPago);
            }
            return listaDeTipos;
        }
    }
}
