using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FrbaCommerce.Datos
{
    class Dat_Rol
    {

        public static List<Entidades.Entidad_Rol> ObtenerTodosLosRoles()
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
            List<Entidades.Entidad_Rol> listaDeRoles = ObtenerTodosLosRoles();

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

            Utiles.Validaciones.ValidarFuncionablidadRepetida(rol, func);

            using (SqlConnection conn = DBConexion.obtenerConexion())
            {
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.agregarFuncionabilidadAlRol", conn,
                new SqlParameter("@Id_Rol", rol),
                new SqlParameter("@Id_Funcionabilidad", func));
                retorno = cmd.ExecuteNonQuery();
                conn.Close();
            }
            Mensajes.Generales.validarAlta(retorno);
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

        public static List<int> buscarFuncDe(decimal rol)
        {
            List<int> listaDeFuncionabilidades = new List<int>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.listadoDeFuncionabilidades", conexion,
           new SqlParameter("@Rol", rol));
            SqlDataReader lectura = cmd.ExecuteReader();
            while (lectura.Read())
            {
                listaDeFuncionabilidades.Add(lectura.GetInt32(0));
            }
            return listaDeFuncionabilidades;

        }

        public static void filtarListaDeRoles(string rol, DataGridView dataGridView1)
        {
            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.filtrarRol2", conexion,
           new SqlParameter("@Rol", rol));
            Utiles.SQL.llenarDataGrid(dataGridView1, conexion, cmd);

            dataGridView1.Columns["Id"].Visible = false;
        }

        public static void darDeBajaRol(decimal rolADarDeBaja)
        {
            int retorno;
            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.darDeBajaRol", conexion,
           new SqlParameter("@Rol", rolADarDeBaja));
            retorno = cmd.ExecuteNonQuery();
            Mensajes.Generales.validarBaja(retorno);
        }

        public static string obtenerNombreIdRol(decimal rolADarDeBaja)
        {
            string nombre = "a";
            using (SqlConnection conexion = DBConexion.obtenerConexion())
            {
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.obtenerNombreIdRol", conexion,
               new SqlParameter("@Id_Rol", rolADarDeBaja));
                SqlDataReader lectura = cmd.ExecuteReader();

                while (lectura.Read())
                {

                    nombre = lectura.GetString(0);
                }

                conexion.Close();
            }
            return nombre;
        }

        public static void removerFuncionalidad(decimal rol, int func)
        {
            int retorno = 0;
            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.quitarRol", conexion,
                new SqlParameter("@Id_Rol", rol),
                new SqlParameter("@funcionalidad", func));
            retorno = cmd.ExecuteNonQuery();
            Mensajes.Generales.validarBaja(retorno);//VER BIEN EL MENSAJE
        }

        public static void actualizarEstadoRol(int estado, decimal rol)
        {   try
        {
            int retorno = 0;
            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.actualizarEstadoRol", conexion,
                new SqlParameter("@Id_Rol", rol),
                new SqlParameter("@Estado", estado));
            retorno = cmd.ExecuteNonQuery();
               }
            catch (Exception)
            {
                MessageBox.Show("Error al actualizar el estado del rol", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static int obtenerEstado(decimal idSeleccionado)
        {
            int estado = -1;
            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.obtenerEstado", conexion,
                new SqlParameter("@Id_Rol", idSeleccionado));
            SqlDataReader lectura = cmd.ExecuteReader();
            while (lectura.Read())
            {
                estado = lectura.GetInt16(0);
            }
            return estado;
        }
    }
}