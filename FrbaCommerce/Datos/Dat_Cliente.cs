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


        //ESTO ES MAS FÁCIL QUE HACERLO CON UN PROCEDURE PQ ESTOY SELECCIONANDO TODOS LOS CAMPOS, SIN FILTROS
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

        public static void AgregarCliente(Entidades.Ent_Cliente pCliente)
        {
            int retorno;
            using (SqlConnection conexion = DBConexion.obtenerConexion())
            {

                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.agregarNuevoCliente", conexion,
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
                conexion.Close();
            }
            

            Mensajes.Generales.validarAlta(retorno);

        }

        public static void buscarListaDeCliente(Entidades.Ent_ListadoCliente pListado, DataGridView dataGridView1)
        {


            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.listaDeCliente", conn,
            new SqlParameter("@Nombre", pListado.Nombre),
            new SqlParameter("@Apellido", pListado.Apellido),
            new SqlParameter("@Dni", pListado.Dni),
            new SqlParameter("@Mail", pListado.Mail),
            new SqlParameter("@Tipo_dni", pListado.Tipo_dni));

            Utiles.SQL.llenarDataGrid(dataGridView1, conn, cmd);


            dataGridView1.Columns["Id"].Visible = false;

        }

        public static Entidades.Ent_Cliente buscarCliente(Int32 id)
        {

            Entidades.Ent_Cliente pcliente = new Entidades.Ent_Cliente();

            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarUnSoloCliente", conn,
            new SqlParameter("@Id", id));

            SqlDataReader lectura = cmd.ExecuteReader();
            while (lectura.Read())
            {
                pcliente.Dni = lectura.GetDecimal(1);
                pcliente.Nombre = lectura.GetString(2);
                pcliente.Apellido = lectura.GetString(3);
                pcliente.Fecha_Nac = Convert.ToString(lectura.GetDateTime(4));
                pcliente.Mail = lectura.GetString(5);
                pcliente.Dom_Calle = lectura.GetString(6);
                pcliente.Nro_Calle = lectura.GetDecimal(7);
                pcliente.Piso = lectura.GetDecimal(8);
                pcliente.Dpto = lectura.GetString(9);
                pcliente.Cod_Postal = lectura.GetString(10);
                pcliente.Localidad = lectura.GetString(11);
                pcliente.Tipo_dni = lectura.GetInt16(12);
                pcliente.Telefono = lectura.GetString(13);
            }
            conn.Close();
            return pcliente;
        }

        public static Decimal buscarIdCliente(string pw)
        {
            Decimal idObtenido = 0;

            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarIdCliente", conn,
            new SqlParameter("@Dni", pw));
            SqlDataReader lectura = cmd.ExecuteReader();
            while (lectura.Read())
            {
                idObtenido = lectura.GetDecimal(0);
            }
            conn.Close();


            if (idObtenido != 0)
            {
                return (idObtenido);
            }
            else
            {
                throw new Excepciones.InexistenciaUsuario("Error al obtener Id");
            }


        }

        public static void ActualizarCamposACliente(Entidades.Ent_Cliente pCliente, int clienteAModificar)
        {
            int retorno;
            using (SqlConnection conn = DBConexion.obtenerConexion())
            {
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.ActualizarCliente", conn,
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
    }
}



