using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace FrbaCommerce.Datos
{
    class Dat_Rol
    {

        public static List<Entidades.Entidad_Rol> ObtenerRol()
        {


            List<Entidades.Entidad_Rol> listaDeRoles = new List<Entidades.Entidad_Rol>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("Select Id, Nombre from Rol", conexion);
            SqlDataReader lectura = Comando.ExecuteReader();

            while (lectura.Read())
            {
                Entidades.Entidad_Rol pRol = new Entidades.Entidad_Rol();
                pRol.id = lectura.GetDecimal(0);
                pRol.nombre = lectura.GetString(1);

                listaDeRoles.Add(pRol);
            }


            return listaDeRoles;
        }

        public static void verificarSiElRolYaExiste(string nuevoRol)
        {
            List<Entidades.Entidad_Rol> listaDeRoles = ObtenerRol();

            foreach (Entidades.Entidad_Rol rol in listaDeRoles)
            {
                if (rol.nombre == nuevoRol)
                {
                    throw new Excepciones.DuplicacionDeDatos("El rol ingresado ya existe");
                }
            }
        }

        public static void agregarRol(string nuevoRol)
        {
            int retorno;
            using (SqlConnection conn = DBConexion.obtenerConexion())
            {
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.agregarNuevoRol", conn,
                new SqlParameter("@Rol_Nombre", nuevoRol));

                retorno = cmd.ExecuteNonQuery();
                conn.Close();
            }

            Mensajes.Generales.validarAlta(retorno);
        }



        public static void agregarFuncionabilidad(Decimal rol, int func)
        {
            int retorno;
            using (SqlConnection conn = DBConexion.obtenerConexion())
            {
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.agregarFuncionabilidadAlRol", conn,
                new SqlParameter("@Id_Rol", rol),
                new SqlParameter("@Id_Funcionabilidad", func));
                retorno = cmd.ExecuteNonQuery();
                conn.Close();
            }
            Mensajes.Errores.ErrorAlGuardarDatos(retorno);
        }

        public static Decimal obtenerIdRol(string nombre)
        {
            Decimal id = -1;
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarIdRol", conn,
            new SqlParameter("@Rol_Nombre", nombre));
            SqlDataReader lectura = cmd.ExecuteReader();

            while (lectura.Read())
            {

                id = lectura.GetDecimal(0);
            }

            conn.Close();
            return id;

        }
    }

}