using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FrbaCommerce.Datos
{
    class Dat_Empresa
    {
        public static List<Entidades.Ent_Telefono> obtenerTodosLosTelefonos()
        {
            List<Entidades.Ent_Telefono> listaDeTelefonos = new List<Entidades.Ent_Telefono>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("Select Telefono from Empresa", conexion);
            SqlDataReader lectura = Comando.ExecuteReader();


            while (lectura.Read())
            {
                Entidades.Ent_Telefono pTelefono = new Entidades.Ent_Telefono();

                pTelefono.Telefono = lectura.GetString(0);

                listaDeTelefonos.Add(pTelefono);
            }
            return listaDeTelefonos;




        }

        public static List<Entidades.Ent_Cuit> obtenerTodosLosCuit()
        {

            List<Entidades.Ent_Cuit> listaDeCuit = new List<Entidades.Ent_Cuit>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("Select Cuit from Empresa", conexion);
            SqlDataReader lectura = Comando.ExecuteReader();

            while (lectura.Read())
            {
                Entidades.Ent_Cuit pCUIT = new Entidades.Ent_Cuit();

                pCUIT.CUIT = lectura.GetString(0);


                listaDeCuit.Add(pCUIT);
            }


            return listaDeCuit;
        }

        public static void AgregarEmpresa(Entidades.Ent_Empresa pEmpresa)
        {
            int retorno;
            using (SqlConnection conexion = DBConexion.obtenerConexion())
            {

                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.agregarNuevaEmpresa", conexion,
                   new SqlParameter("@RazonSocial", pEmpresa.RazonSocial),
                   new SqlParameter("@Cuit", pEmpresa.CUIT),
                   new SqlParameter("@Fecha_Creacion", pEmpresa.Fecha_Creacion),
                   new SqlParameter("@Mail", pEmpresa.Mail),        
                   new SqlParameter("@Dom_Calle", pEmpresa.Dom_Calle),
                   new SqlParameter("@Nro_Calle", pEmpresa.Nro_Calle),
                   new SqlParameter("@Piso", pEmpresa.Piso),
                   new SqlParameter("@Depto", pEmpresa.Dpto),
                   new SqlParameter("@Cod_Postal", pEmpresa.Cod_Postal),
                   new SqlParameter("@Localidad", pEmpresa.Localidad),
                   new SqlParameter("@Telefono", pEmpresa.Telefono),
                   new SqlParameter("@Ciudad", pEmpresa.Ciudad),
                   new SqlParameter("@Nombre_Contacto", pEmpresa.NombreContacto),
                   new SqlParameter("@Tipo_doc", pEmpresa.Tipo_Doc));

                retorno = cmd.ExecuteNonQuery();
            }
            Mensajes.Generales.validarAlta(retorno);
        }



        public static Decimal buscarIdEmpresa(string pw)
        {
            Decimal idObtenido = 0;

            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarIdEmpresa", conn,
            new SqlParameter("@Cuit", pw));

            SqlDataReader lectura = cmd.ExecuteReader();
            while (lectura.Read())
            {
                idObtenido = lectura.GetDecimal(0);
            }
            conn.Close();
            return (idObtenido);
         
          
        }

        public static void buscarListaDeEmpresa(Entidades.Ent_ListadoEmpresa pEmpresa, DataGridView dataGridView1)
        {
            try
            {
                SqlConnection conn = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.listaDeEmpresas", conn,
                new SqlParameter("@Razon_Social", pEmpresa.Razon_Social),
                new SqlParameter("@CUIT", pEmpresa.CUIT),
                new SqlParameter("@Mail", pEmpresa.Mail));

                Utiles.SQL.llenarDataGrid(dataGridView1, conn, cmd);
            }

            catch (Exception) {
                Mensajes.Errores.NoHayConexion(); 
            }


            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Tipo"].Visible = false;
        }

        public static Entidades.Ent_Empresa buscarEmpresa(int id)
        {
            Entidades.Ent_Empresa pEmpresa = new Entidades.Ent_Empresa();
            try {
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarUnaSolaEmpresa", conn,
            new SqlParameter("@Id", id));

            SqlDataReader lectura = cmd.ExecuteReader();
            while (lectura.Read())
            {
                pEmpresa.RazonSocial = lectura.GetString(1);
                pEmpresa.CUIT = lectura.GetString(2);
                pEmpresa.Fecha_Creacion = Convert.ToString(lectura.GetDateTime(3));
                pEmpresa.Mail = lectura.GetString(4);
                pEmpresa.Dom_Calle = lectura.GetString(5);
                pEmpresa.Nro_Calle = lectura.GetDecimal(6);
                pEmpresa.Piso = lectura.GetDecimal(7);
                pEmpresa.Dpto = lectura.GetString(8);
                pEmpresa.Cod_Postal = lectura.GetString(9);
                pEmpresa.Localidad = lectura.GetString(10);
                pEmpresa.Telefono = lectura.GetString(11);
                pEmpresa.Ciudad = lectura.GetString(12);
                pEmpresa.NombreContacto = lectura.GetString(13);
            }
            conn.Close();
            }
            catch (Exception) { Mensajes.Errores.NoHayConexion(); }
            return pEmpresa;
        }

        internal static void actualizarEmpresa(Entidades.Ent_Empresa pEmpresa, int empresaAModificar)
        {    

            int retorno;
            try
            {
                using (SqlConnection conn = DBConexion.obtenerConexion())
                {
                    SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.actualizarEmpresa", conn,
                        new SqlParameter("@Id", empresaAModificar),
                        new SqlParameter("@RazonSocial", pEmpresa.RazonSocial),
                        new SqlParameter("@Cuit", pEmpresa.CUIT),
                        new SqlParameter("@Fecha_Creacion", pEmpresa.Fecha_Creacion),
                        new SqlParameter("@Mail", pEmpresa.Mail),
                        new SqlParameter("@Dom_Calle", pEmpresa.Dom_Calle),
                        new SqlParameter("@Nro_Calle", pEmpresa.Nro_Calle),
                        new SqlParameter("@Piso", pEmpresa.Piso),
                        new SqlParameter("@Depto", pEmpresa.Dpto),
                        new SqlParameter("@Cod_Postal", pEmpresa.Cod_Postal),
                        new SqlParameter("@Localidad", pEmpresa.Localidad),
                        new SqlParameter("@Telefono", pEmpresa.Telefono),
                        new SqlParameter("@Ciudad", pEmpresa.Ciudad),
                        new SqlParameter("@Nombre_Contacto", pEmpresa.NombreContacto),
                        new SqlParameter("@Tipo_doc", pEmpresa.Tipo_Doc));


                    retorno = cmd.ExecuteNonQuery();
                    conn.Close();
                    Mensajes.Generales.validarAlta(retorno);
                }
            }
            catch (Exception) {
                     Mensajes.Errores.NoHayConexion(); }
                    }
    }
}
