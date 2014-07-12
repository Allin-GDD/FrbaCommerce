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
      
        public static List<string> obtenerTodosLosCuit()
        {

            List<String> listaDeCuit = new List<String>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("Select Nro_Documento from Empresa", conexion);
            SqlDataReader lectura = Comando.ExecuteReader();

            while (lectura.Read())
            {                
                listaDeCuit.Add(lectura.GetString(0));
               }


            return listaDeCuit;
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


            dataGridView1.Columns["Id_Usuario"].Visible = false;
            }

        public static Entidades.Ent_Empresa buscarEmpresa(Decimal id)
        {
            Entidades.Ent_Empresa pEmpresa = new Entidades.Ent_Empresa();
           
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarUnaSolaEmpresa", conn,
            new SqlParameter("@Id", id));

            SqlDataReader lectura = cmd.ExecuteReader();
            while (lectura.Read())
            {
                pEmpresa.RazonSocial = lectura.GetString(0);
                pEmpresa.CUIT = lectura.GetString(1);
                pEmpresa.Fecha_Creacion = Convert.ToString(lectura.GetDateTime(2));
                pEmpresa.Mail = lectura.GetString(3);
                pEmpresa.Dom_Calle = lectura.GetString(4);
                pEmpresa.Nro_Calle = lectura.GetDecimal(5);
                pEmpresa.Piso = lectura.GetDecimal(6);
                pEmpresa.Dpto = lectura.GetString(7);
                pEmpresa.Cod_Postal = lectura.GetString(8);
                pEmpresa.Localidad = lectura.GetString(9);
                pEmpresa.Telefono = lectura.GetString(10);
                pEmpresa.Ciudad = lectura.GetString(11);
                pEmpresa.NombreContacto = lectura.GetString(12);
            }
            conn.Close();
           
            return pEmpresa;
        }

        internal static void actualizarEmpresa(Entidades.Ent_Empresa pEmpresa, Decimal empresaAModificar)
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
                        new SqlParameter("@Nombre_Contacto", pEmpresa.NombreContacto));


                    retorno = cmd.ExecuteNonQuery();
                    conn.Close();
                    Mensajes.Generales.validarAlta(retorno);
                }
            }
            catch (Exception) {
                     Mensajes.Errores.NoHayConexion(); }
                    }

        internal static void crearEmpresaUsuario(FrbaCommerce.Entidades.Ent_Empresa pEmpresa, decimal IdUsuario)
        {
             int retorno;
            using (SqlConnection conexion = DBConexion.obtenerConexion())
            {

                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.agregarNuevaEmpresaUsuario", conexion,
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
                   new SqlParameter("@IdUsuario", IdUsuario));

                retorno = cmd.ExecuteNonQuery();
            }
            Mensajes.Generales.validarAlta(retorno);
        }
        }
    }

