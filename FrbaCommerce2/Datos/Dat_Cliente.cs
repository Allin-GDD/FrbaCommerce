using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Datos
{
    class Dat_Cliente
    {
        public static List<Entidades.Ent_Telefono> obtenerTodosLosTelefonos()
        {
            List<Entidades.Ent_Telefono> listaDeTelefonos = new List<Entidades.Ent_Telefono>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("Select Telefono from allin.Clientes", conexion);
            SqlDataReader lectura = Comando.ExecuteReader();


            while (lectura.Read())
            {
                Entidades.Ent_Telefono pTelefono = new Entidades.Ent_Telefono();

                if (!lectura.IsDBNull(0))
                {
                    pTelefono.Telefono = lectura.GetString(0);

                    listaDeTelefonos.Add(pTelefono);
                }

            }
            return listaDeTelefonos;




        }

        public static List<Entidades.Ent_TipoDeDoc> ObtenerTipoDoc()
        {
            //Listado de todos los tipos de documento existentes en la bd (tabla Tipo_Doc)

            List<Entidades.Ent_TipoDeDoc> listaDeTipos = new List<Entidades.Ent_TipoDeDoc>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("Select Codigo, Nombre from allin.Tipo_Doc", conexion);
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

          public static List<Entidades.Ent_Doc> obtenerTodosLosDocCliente()
        {//Listado de todos los tipo de doc y numero de doc de la tabla Cliente

            List<Entidades.Ent_Doc> listaDeDni = new List<Entidades.Ent_Doc>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("Select Nro_Documento, Tipo_Doc from allin.Clientes", conexion);
            SqlDataReader lectura = Comando.ExecuteReader();

            while (lectura.Read())
            {
                Entidades.Ent_Doc pDni = new Entidades.Ent_Doc();

                pDni.Dni = lectura.GetString(0);
                pDni.tipoDni = lectura.GetInt16(1);


                listaDeDni.Add(pDni);
            }


            return listaDeDni;
        }

         public static void buscarListaDeCliente(Entidades.Ent_ListadoCliente pListado, DataGridView dataGridView1)
        {
             //llena datagrid con los clientes según el filtro
            try
            {
                SqlConnection conn = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.allin.listaDeCliente", conn,
                new SqlParameter("@Nombre", pListado.Nombre),
                new SqlParameter("@Apellido", pListado.Apellido),
                new SqlParameter("@Dni", pListado.Dni),
                new SqlParameter("@Mail", pListado.Mail),
                new SqlParameter("@Tipo_dni", pListado.Tipo_doc));

                Utiles.SQL.llenarDataGrid(dataGridView1, conn, cmd);
            }
            catch (Exception) {
                Mensajes.Errores.NoHayConexion();
            }

            dataGridView1.Columns["Id_Usuario"].Visible = false;

        }
      
        public static Entidades.Ent_Cliente buscarCliente(Decimal id)
        {//busca un solo cliente

            Entidades.Ent_Cliente pcliente = new Entidades.Ent_Cliente();

            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.allin.buscarUnSoloCliente", conn,
            new SqlParameter("@Id", id));

            SqlDataReader lectura = cmd.ExecuteReader();
            while (lectura.Read())
            {
                pcliente.Tipo_DocNom = lectura.GetString(12);
                pcliente.Dni = lectura.GetString(1);
                pcliente.Nombre = lectura.GetString(2);
                pcliente.Apellido = lectura.GetString(3);
                pcliente.Fecha_Nac = lectura.GetDateTime(4);
                pcliente.Mail = lectura.GetString(5);
                pcliente.Dom_Calle = lectura.GetString(6);
                pcliente.Nro_Calle = lectura.GetDecimal(7);
                pcliente.Piso = lectura.GetDecimal(8);
                pcliente.Dpto = lectura.GetString(9);
                pcliente.Cod_Postal = lectura.GetString(10);
                pcliente.Localidad = lectura.GetString(11);
                pcliente.Telefono = lectura.GetString(13);
            }
            conn.Close();
            return pcliente;
        }
               
        public static void actualizarCamposACliente(Entidades.Ent_Cliente pCliente, Decimal clienteAModificar)
        {//actualiza campos del un determinado cliente
            int retorno;
            using (SqlConnection conn = DBConexion.obtenerConexion())
            {
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.allin.actualizarCliente", conn,
                new SqlParameter("@Id", clienteAModificar),
                new SqlParameter("@Dni", pCliente.Dni),
                new SqlParameter("@Nombre", pCliente.Nombre),
                new SqlParameter("@Apellido", pCliente.Apellido),
                new SqlParameter("@Fecha_Nac", pCliente.Fecha_Nac),
                new SqlParameter("@Mail", pCliente.Mail),
                new SqlParameter("@Dom_Calle", pCliente.Dom_Calle),
                new SqlParameter("@Nro_Calle", pCliente.Nro_Calle),
                new SqlParameter("@Piso", pCliente.Piso),
                new SqlParameter("@Depto", pCliente.Dpto),
                new SqlParameter("@Cod_Postal", pCliente.Cod_Postal),
                new SqlParameter("@Localidad", pCliente.Localidad),
                new SqlParameter("@Tipo_dni", pCliente.Tipo_dni),
                new SqlParameter("@Telefono", pCliente.Telefono));


                retorno = cmd.ExecuteNonQuery();
                conn.Close();
            }

            Mensajes.Generales.validarAlta(retorno);
        }

        public static void crearClienteUsuario(Entidades.Ent_Cliente pCliente, Decimal usuario)
        {//agrega a la tabla cliente un nuevo cliente
            int retorno;

            using (SqlConnection conexion = DBConexion.obtenerConexion())
            {

                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.allin.agregarNuevoClienteUsuario", conexion,
                   new SqlParameter("@Dni", pCliente.Dni),
                   new SqlParameter("@Nombre", pCliente.Nombre),
                   new SqlParameter("@Apellido", pCliente.Apellido),
                   new SqlParameter("@Fecha_Nac", pCliente.Fecha_Nac),
                   new SqlParameter("@Mail", pCliente.Mail),
                   new SqlParameter("@Dom_Calle", pCliente.Dom_Calle),
                   new SqlParameter("@Nro_Calle", pCliente.Nro_Calle),
                   new SqlParameter("@Piso", pCliente.Piso),
                   new SqlParameter("@Depto", pCliente.Dpto),
                   new SqlParameter("@Cod_Postal", pCliente.Cod_Postal),
                   new SqlParameter("@Localidad", pCliente.Localidad),
                   new SqlParameter("@Tipo_dni", pCliente.Tipo_dni),
                   new SqlParameter("@Telefono", pCliente.Telefono),
                   new SqlParameter("@IdUsuario", usuario));

                retorno = cmd.ExecuteNonQuery();
                conexion.Close();
            }


            Mensajes.Generales.validarAlta(retorno);

        }
    }
}



