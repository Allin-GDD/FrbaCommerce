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
            }
            if (retorno > 0)
            {
                Mensajes.Exitos.ExitoAlGuardaLosDatos();
            }
            else { Mensajes.Errores.ErrorAlGuardarDatos(); }
        }

        public static void buscarCliente(Entidades.Ent_Listado pListado, DataGridView dataGridView1)
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
    }
}