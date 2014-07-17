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
        {//listado de todos los roles

            List<Entidades.Entidad_Rol> listaDeRoles = new List<Entidades.Entidad_Rol>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("Select Id, Nombre, Estado from Rol", conexion);
            SqlDataReader lectura = Comando.ExecuteReader();

            while (lectura.Read())
            {
                Entidades.Entidad_Rol pRol = new Entidades.Entidad_Rol();
                pRol.id = lectura.GetDecimal(0);
                pRol.nombre = lectura.GetString(1);
                pRol.Estado = lectura.GetInt16(2);
                if (pRol.id != 3 && pRol.Estado == 1)
                {
                    listaDeRoles.Add(pRol);
                }
            }


            return listaDeRoles;
        }

        public static bool verificarSiElRolYaExiste(string nuevoRol)
        {//verifica si el rol ya esta en la tabla rol, para evitar repetidos
            List<Entidades.Entidad_Rol> listaDeRoles = ObtenerTodosLosRoles();

            foreach (Entidades.Entidad_Rol rol in listaDeRoles)
            {
                if (rol.nombre == nuevoRol)
                {
                    return true;
                }
            }
            return false;
        }


        public static int agregarFuncionalidad(Decimal rol, int func)
        {//le agrega una funcionalidad a un determinado rol
            int retorno;

            Utiles.Validaciones.ValidarFuncionalidadRepetida(rol, func);

            using (SqlConnection conn = DBConexion.obtenerConexion())
            {
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.agregarFuncionabilidadAlRol", conn,
                new SqlParameter("@Id_Rol", rol),
                new SqlParameter("@Id_Funcionabilidad", func));
                retorno = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return retorno;
        }

        public static void filtarListaDeRoles(string rol, DataGridView dataGridView1, int num)
        {//llena datagrid según un determinado filtro.
            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.filtrarRol", conexion,
           new SqlParameter("@Rol", rol),
           new SqlParameter("@Filtrado", num));
            Utiles.SQL.llenarDataGrid(dataGridView1, conexion, cmd);

            dataGridView1.Columns["Id"].Visible = false;
        }

        public static void darDeBajaRol(decimal rolADarDeBaja)
        {//da de baja a un determinado rol
            int retorno;
            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.darDeBajaRol", conexion,
           new SqlParameter("@Rol", rolADarDeBaja));
            retorno = cmd.ExecuteNonQuery();
            Mensajes.Generales.validarBaja(retorno);
        }

        public static string obtenerNombreIdRol(decimal rolADarDeBaja)
        {
            string nombre = null;
            using (SqlConnection conexion = DBConexion.obtenerConexion())
            {//devuelve el nombre de un rol
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
        {//quita de la tabla relación Rol_Func una determinada funcionalidad
            int retorno = 0;
            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.quitarRol", conexion,
                new SqlParameter("@Id_Rol", rol),
                new SqlParameter("@funcionalidad", func));
            retorno = cmd.ExecuteNonQuery();
            Mensajes.Generales.validarBaja(retorno);
        }

        public static void actualizarEstadoRol(int estado, decimal rol)
        {  //cambia estado a un rol
            try
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
        {//obtiene el estado de un rol
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

        internal static int agregarRol(string nuevoRol)
        {//agrega un determinado rol y su respectiva funcionalidad inicial
            int retorno;
            using (SqlConnection conn = DBConexion.obtenerConexion())
            {
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.agregarNuevoRol", conn,
                new SqlParameter("@Rol_Nombre", nuevoRol));

                retorno = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return retorno;
        }

        internal static void reemplazarNombre(Decimal idRol, string nombreRolNuevo)
        {//le cambia el nombre al rol
            int retorno;
            using (SqlConnection conn = DBConexion.obtenerConexion())
            {
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.actualizarNombreRol", conn,
                new SqlParameter("@Id_Rol", idRol),
                new SqlParameter("@Nombre_New", nombreRolNuevo));

                retorno = cmd.ExecuteNonQuery();
                conn.Close();
            }
            Mensajes.Generales.validarAlta(retorno);
        }

        internal static void abrirVentanasSegunRol(Decimal pusuario, Form login)
        {//En el login según la cantidad de roles que tenga el usuario determina si abre una ventana para que elija un rol o
            //directamete abre la ventana para el rol correspondiente
            List<Entidades.Entidad_Rol> listaDeRoles = new List<Entidades.Entidad_Rol>();
            try
            {
                SqlConnection conexion = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.obtenerTodosLosRoles", conexion,
                    new SqlParameter("@Id_Usuario", pusuario));
                SqlDataReader lectura = cmd.ExecuteReader();
                while (lectura.Read())
                {
                    Entidades.Entidad_Rol entRol = new Entidades.Entidad_Rol();
                    entRol.id = lectura.GetDecimal(0);
                    entRol.nombre = lectura.GetString(1);

                    listaDeRoles.Add(entRol);
                }
                conexion.Close();

                if (listaDeRoles.Count == 1)
                {
                    Entidades.Entidad_Rol rol = listaDeRoles.ElementAt(0);
                    Utiles.Ventanas.Opciones.AbrirVentanas(rol.id, pusuario, login);
                }
                else if (listaDeRoles.Count > 1)
                {

                    Utiles.Ventanas.ElegirRol vent = new Utiles.Ventanas.ElegirRol(listaDeRoles, pusuario, login);
                    vent.ShowDialog();

                }
                else
                {
                    throw new Excepciones.InexistenciaUsuario("El rol de usuario se encuentra inhabilitado");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        internal static Decimal obtenerIdRol(string RolNombre)
        {
            Decimal rol = 0;
            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.obtenerIdRol", conexion,
                new SqlParameter("@NombreRol", RolNombre));
            SqlDataReader lectura = cmd.ExecuteReader();
            while (lectura.Read())
            {
                rol = lectura.GetDecimal(0);
            }
            return rol;
        }
    }
}