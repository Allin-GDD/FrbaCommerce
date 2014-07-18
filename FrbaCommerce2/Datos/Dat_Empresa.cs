using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace FrbaCommerce.Datos
{
    class Dat_Empresa
    {
      
        public static List<string> obtenerTodosLosCuit()
        {
            //Listado de todos los CUIT de la tabla Empresa
            List<String> listaDeCuit = new List<String>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("Select Nro_Documento from allin.Empresa", conexion);
            SqlDataReader lectura = Comando.ExecuteReader();

            while (lectura.Read())
            {                
                listaDeCuit.Add(lectura.GetString(0));
               }


            return listaDeCuit;
        }

        public static void buscarListaDeEmpresa(Entidades.Ent_ListadoEmpresa pEmpresa, DataGridView dataGridView1)
        {//llena datagrid con los datos filtrados
            try
            {
                SqlConnection conn = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.allin.listaDeEmpresas", conn,
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
        {//obtiene una sola empresa
            Entidades.Ent_Empresa pEmpresa = new Entidades.Ent_Empresa();
           
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.allin.buscarUnaSolaEmpresa", conn,
            new SqlParameter("@Id", id));

            SqlDataReader lectura = cmd.ExecuteReader();
            while (lectura.Read())
            {
                pEmpresa.RazonSocial = lectura.GetString(1);
                pEmpresa.CUIT = lectura.GetString(2);
                pEmpresa.Fecha_Creacion = lectura.GetDateTime(3);
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
           
            return pEmpresa;
        }

        internal static void actualizarEmpresa(Entidades.Ent_Empresa pEmpresa, Decimal empresaAModificar)
        {    
            //Actualiza una determinada empresa
            int retorno;
            try
            {
                using (SqlConnection conn = DBConexion.obtenerConexion())
                {
                    SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.allin.actualizarEmpresa", conn,
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
        {//Agrega un nueva nueva empresa en la tabla Empresa
             int retorno;
            using (SqlConnection conexion = DBConexion.obtenerConexion())
            {

                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.allin.agregarNuevaEmpresaUsuario", conexion,
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

        internal static bool validarRazonSocial(TextBox razonSocial)
        {
            List<String> listaDeRazon = Datos.Dat_Empresa.obtenerTodasLasRazones();

            foreach (String razon in listaDeRazon)
            {
                if (razonSocial != null && razonSocial.Text == razon)
                {
                    razonSocial.BackColor = Color.Coral;
                    return true;
                }
            }
            return false;
        }

        private static List<string> obtenerTodasLasRazones()
        {
            //Listado de todos los CUIT de la tabla Empresa
            List<String> listaDeRazones = new List<String>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("Select Razon_Social from allin.Empresa", conexion);
            SqlDataReader lectura = Comando.ExecuteReader();

            while (lectura.Read())
            {
                listaDeRazones.Add(lectura.GetString(0));
            }


            return listaDeRazones;
        }

        internal static List<Entidades.Ent_Telefono> obtenerTodosLosTelefonos()
        {

            List<Entidades.Ent_Telefono> listaDeTelefonos = new List<Entidades.Ent_Telefono>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("Select Telefono from allin.Empresa", conexion);
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
    }
    }

