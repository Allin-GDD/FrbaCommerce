using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace FrbaCommerce.Datos
{
    class Dat_Factura
    {
        public static List<Entidades.Ent_TipoDeDoc> ObtenerTipoPago()
        {


            List<Entidades.Ent_TipoDeDoc> listaDeTipos = new List<Entidades.Ent_TipoDeDoc>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("Select Codigo, Nombre from Tipo_Pago", conexion);
            SqlDataReader lectura = Comando.ExecuteReader();

            while (lectura.Read())
            {
                Entidades.Ent_TipoDeDoc pTipoPago = new Entidades.Ent_TipoDeDoc();
                pTipoPago.codigo = lectura.GetInt16(0);
                pTipoPago.tipo = lectura.GetString(1);

                listaDeTipos.Add(pTipoPago);
            }
            return listaDeTipos;
        }
    }
}
