using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace FrbaCommerce.Datos
{
    class Dat_Cliente
    {
         public static List<Entidades.Ent_Telefono> obtenerTodosLosTelefonos()
         {
            List<Entidades.Ent_Telefono> listaDeTelefonos = new List<Entidades.Ent_Telefono>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("Select Telefono from Clientes", conexion);
            SqlDataReader lectura = Comando.ExecuteReader();


            while (lectura.Read())
            {
                Entidades.Ent_Telefono pTelefono = new Entidades.Ent_Telefono();

                pTelefono.Telefono = lectura.GetString(0);

                listaDeTelefonos.Add(pTelefono);
            }
            return listaDeTelefonos;

         
        
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

        public static List<Entidades.Ent_Dni> obtenerTodosLosDni()
        {

            List<Entidades.Ent_Dni> listaDeDni = new List<Entidades.Ent_Dni>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("Select Dni from Clientes", conexion);
            SqlDataReader lectura = Comando.ExecuteReader();

            while (lectura.Read())
            {
                Entidades.Ent_Dni pDni = new Entidades.Ent_Dni();

                pDni.Dni = lectura.GetDecimal(0);

                listaDeDni.Add(pDni);
            }

         
            return listaDeDni;
        }

        public static void validarNulidad(Entidades.Ent_Cliente pcliente)
        {
            if (pcliente.Dni == null)
            {

                throw new Excepciones.NulidadDeCamposACompletar("Faltan datos obligatorios");
            }

            if (pcliente.Tipo_dni == null)
            {
                throw new Excepciones.NulidadDeCamposACompletar("Falta dato obligatorio");

            }
            // podemos agregar mas datos para fijarnos la nulidad

        }
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

    }
}

     