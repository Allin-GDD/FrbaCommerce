using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

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
                   new SqlParameter("@FechaDeCreacion",pEmpresa.Fecha_Creacion),
                   new SqlParameter("@Mail", pEmpresa.Mail),        
                   new SqlParameter("@Dom_Calle", pEmpresa.Dom_Calle),
                   new SqlParameter("@Nro_Calle", pEmpresa.Nro_Calle),
                   new SqlParameter("@Piso", pEmpresa.Piso),
                   new SqlParameter("@Depto", pEmpresa.Dpto),
                   new SqlParameter("@Cod_Postal", pEmpresa.Cod_Postal),
                   new SqlParameter("@Localidad", pEmpresa.Localidad),
                   
                   new SqlParameter("@Telefono", pEmpresa.Telefono),
                   new SqlParameter("@Ciud", pEmpresa.Ciudad),
                   new SqlParameter("@Nombre_Contacto", pEmpresa.NombreContacto),
                   new SqlParameter("@Tipo", "CUIT"));

                retorno = cmd.ExecuteNonQuery();
            }
            if (retorno > 0)
            {
                Mensajes.Exitos.ExitoAlGuardaLosDatos();
            }
            else { Mensajes.Errores.ErrorAlGuardarDatos(); }
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


            if (idObtenido != 0)
            {
                return (idObtenido);
            }
            else
            {
                throw new Excepciones.InexistenciaUsuario("Error al obtener Id");
            }

        }
    }
}
