using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace FrbaCommerce.Datos
{
    class Dat_Cliente
    {
        public static int AgregarCliente(Entidades.Ent_Cliente pCliente)
        {
            int retorno = 0;
            using (SqlConnection conexion = DBConexion.obtenerConexion())
            {
               SqlCommand Comando = new SqlCommand(string.Format("Insert into Clientes(Nombre, Apellido, Dni, Tipo_dni, Fecha_Nac, Mail, Dom_Calle, Nro_Calle, Piso, Depto, Cod_Postal, Telefono, Localidad) values('{0}','{1}',{2},{3},'{4}','{5}','{6}',{7},{8},'{9}','{10}','{11}','{12}')",
                    pCliente.Nombre, pCliente.Apellido, pCliente.Dni, pCliente.Tipo_dni, pCliente.Fecha_Nac, pCliente.Mail, pCliente.Dom_Calle, pCliente.Nro_Calle, pCliente.Piso, pCliente.Dpto, pCliente.Cod_Postal, pCliente.Telefono, pCliente.Localidad), conexion);

               
                retorno = Comando.ExecuteNonQuery();
            }

            return retorno;
        }
     
         public static List<Entidades.Ent_TipoDeDoc> ObtenerTipoDoc()
         {

             List<Entidades.Ent_TipoDeDoc> listaDeTipos = new List<Entidades.Ent_TipoDeDoc>();

             SqlConnection conexion = DBConexion.obtenerConexion();
             SqlCommand Comando = new SqlCommand("Select Codigo, Nombre from Tipo_Doc", conexion);
             SqlDataReader lectura = Comando.ExecuteReader();

             while (lectura.Read())
             {
                 Entidades.Ent_TipoDeDoc pTipoDeDoc = new Entidades.Ent_TipoDeDoc();
                 pTipoDeDoc.codigo = lectura.GetInt16(0);
                 pTipoDeDoc.tipo = lectura.GetString(1);

                 listaDeTipos.Add(pTipoDeDoc);
             }
             return listaDeTipos;
         }
    
    }
}

     /*   public static int BuscarTipo(Entidades.Ent_TipoDeDoc pTipoDeDoc) {
            int retorno = 0;
            using (SqlConnection conn = DBConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Select Codigo, Nombre FROM Tipo_Doc WHERE Nombre = '{0}'", pTipoDeDoc.tipo), conn);
                retorno = Comando.ExecuteNonQuery();
            }
            if (retorno == 0)
            {
                using (SqlConnection conn2 = DBConexion.obtenerConexion())
                {
                    SqlCommand comando = new SqlCommand(string.Format("Insert into Tipo_Doc(Nombre) values('{0}')", pTipoDeDoc.tipo), conn2);
                    int retorno2 = comando.ExecuteNonQuery();                
                }
            }
            return retorno2;
            
           }

        
        
        public static List<Entidades.Ent_TipoDeDoc> ObtenerTipoDoc()
         {

             List<Entidades.Ent_TipoDeDoc> listaDeTipos = new List<Entidades.Ent_TipoDeDoc>();

             SqlConnection conexion = DBConexion.obtenerConexion();
             SqlCommand Comando = new SqlCommand("Select Codigo, Nombre from dbo.Tipo_Doc", conexion);
             SqlDataReader lectura = Comando.ExecuteReader();

             while (lectura.Read())
             {
                 Entidades.Ent_TipoDeDoc pTipoDeDoc = new Entidades.Ent_TipoDeDoc();
                 pTipoDeDoc.codigo = lectura.GetInt16(0);
                 pTipoDeDoc.tipo = lectura.GetString(1);

                 listaDeTipos.Add(pTipoDeDoc);
             }
             return listaDeTipos;
}*/