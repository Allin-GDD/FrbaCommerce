using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Datos
{
    class Dat_Publicacion
    {


        //ESTO ES MAS FÁCIL QUE HACERLO CON UN PROCEDURE PQ ESTOY SELECCIONANDO TODOS LOS CAMPOS, SIN FILTROS


        public static List<Entidades.Ent_Rubros> ObtenerRubros()
        {


            List<Entidades.Ent_Rubros> listaDeRubros = new List<Entidades.Ent_Rubros>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("Select Codigo, Descripcion from Rubro", conexion);
            SqlDataReader lectura = Comando.ExecuteReader();

            while (lectura.Read())
            {
                Entidades.Ent_Rubros pRubro = new Entidades.Ent_Rubros();
                pRubro.codigo = lectura.GetDecimal(0);
                pRubro.rubro = lectura.GetString(1);

                listaDeRubros.Add(pRubro);
            }
            return listaDeRubros;
        }

        public static List<Entidades.Ent_Visibilidad> ObtenerVisibilidades()
        {


            List<Entidades.Ent_Visibilidad> listaDeVisibilidades = new List<Entidades.Ent_Visibilidad>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("Select Codigo, Descripcion from Visibilidad", conexion);
            SqlDataReader lectura = Comando.ExecuteReader();

            while (lectura.Read())
            {
                Entidades.Ent_Visibilidad pVisibilidad = new Entidades.Ent_Visibilidad();
                pVisibilidad.Codigo = lectura.GetDecimal(0);
                pVisibilidad.Descripcion = lectura.GetString(1);

                listaDeVisibilidades.Add(pVisibilidad);
            }
            return listaDeVisibilidades;
        }

        public static void AgregarPublicacion(Entidades.Ent_Publicacion pPublicacion)
        {
            int retorno;
            using (SqlConnection conexion = DBConexion.obtenerConexion())
            {

                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.agregarNuevaPublicacion", conexion,
                   new SqlParameter("@Visibilidad", pPublicacion.Visibilidad),
                   new SqlParameter("@Tipo", pPublicacion.Tipo),
                   new SqlParameter("@Rubro", pPublicacion.Rubro),
                   new SqlParameter("@Stock", pPublicacion.Stock),
                   new SqlParameter("@Precio", pPublicacion.Precio),
                   new SqlParameter("@Descripcion", pPublicacion.Descripcion),
                   new SqlParameter("@Estado", pPublicacion.Estado),
                   new SqlParameter("@Permitir_Preguntas", pPublicacion.Permitir_Preguntas),
                   new SqlParameter("@Fecha_Venc", Convert.ToDateTime(pPublicacion.Fecha_Venc)),
                   new SqlParameter("@Publicador", pPublicacion.Publicador),
                   new SqlParameter("@Id", pPublicacion.Id));

                retorno = cmd.ExecuteNonQuery();
                conexion.Close();
            }

        }
        public static void EditarPublicacionBorrador(Entidades.Ent_Publicacion pPublicacion)
        {
            int retorno;
            using (SqlConnection conexion = DBConexion.obtenerConexion())
            {

                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.editarPublicacionBorrador", conexion,
                   new SqlParameter("@Visibilidad", pPublicacion.Visibilidad),
                   new SqlParameter("@Tipo", pPublicacion.Tipo),
                   new SqlParameter("@Rubro", pPublicacion.Rubro),
                   new SqlParameter("@Stock", pPublicacion.Stock),
                   new SqlParameter("@Precio", pPublicacion.Precio),
                   new SqlParameter("@Descripcion", pPublicacion.Descripcion),
                   new SqlParameter("@Estado", pPublicacion.Estado),
                   new SqlParameter("@Permitir_Preguntas", pPublicacion.Permitir_Preguntas),
                   new SqlParameter("@Fecha_Venc", Convert.ToDateTime(pPublicacion.Fecha_Venc)),
                   new SqlParameter("@Codigo", pPublicacion.Codigo));

                retorno = cmd.ExecuteNonQuery();
                conexion.Close();
            }

        }

        public static void EditarPublicacionPublicada(Entidades.Ent_Publicacion pPublicacion)
        {
            int retorno;
            using (SqlConnection conexion = DBConexion.obtenerConexion())
            {

                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.editarPublicacionPublicada", conexion,
                   
                   new SqlParameter("@Stock", pPublicacion.Stock),
                   
                   new SqlParameter("@Descripcion", pPublicacion.Descripcion),
                   new SqlParameter("@Estado", pPublicacion.Estado),
                   
                   new SqlParameter("@Codigo", pPublicacion.Codigo));

                retorno = cmd.ExecuteNonQuery();
                conexion.Close();
            }

        }

        public static Entidades.Ent_RolyId buscarPublicador(String usuario)
        {

            Decimal rolId;
            Entidades.Ent_RolyId rolIdEnt = new Entidades.Ent_RolyId();
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarPublicador", conn,
            new SqlParameter("@Usuario", usuario));

            SqlDataReader lectura = cmd.ExecuteReader();
            while (lectura.Read())
            {
                rolIdEnt.id = lectura.GetDecimal(2);
                rolId = lectura.GetDecimal(3);
                if (rolId == 1)
                {
                    rolIdEnt.rol = "C";
                }
                else if (rolId == 2)
                {
                    rolIdEnt.rol = "E";
                }

            }
            
            conn.Close();
            return rolIdEnt;
        
        }

        public static string obtenerDescripcionRubro(Decimal rubro)
        {

            string rubroDevuelvo;
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.obtenerDescripcionRubro", conn,

            new SqlParameter("@IdRubro", rubro));


            SqlDataReader lectura = cmd.ExecuteReader();
            
            lectura.Read();
            
            rubroDevuelvo = lectura.GetString(0);
                
            
            conn.Close();

            return rubroDevuelvo;

        }
        public static string obtenerVisibilidad(Decimal visib)
        {

            string visibilidadDevuelvo;
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.obtenerVisibilidad", conn,

            new SqlParameter("@Cod_visib", visib));


            SqlDataReader lectura = cmd.ExecuteReader();

            lectura.Read();

            visibilidadDevuelvo = lectura.GetString(0);


            conn.Close();

            return visibilidadDevuelvo;
            
        }
        
        public static Entidades.Ent_Publicacion buscarDatosPublicacion(Decimal codigoPk)
        {
            Entidades.Ent_Publicacion pPublicacion = new Entidades.Ent_Publicacion();

            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarDatosPublicacion", conn,

            new SqlParameter("@Codigo", codigoPk));


            SqlDataReader lectura = cmd.ExecuteReader();
            while (lectura.Read())
            {
                pPublicacion.Visibilidad = lectura.GetDecimal(7);
                pPublicacion.Tipo = lectura.GetString(6);
                pPublicacion.Stock = lectura.GetDecimal(2);
                pPublicacion.Descripcion = lectura.GetString(1);
                pPublicacion.Precio = lectura.GetDecimal(5);
                pPublicacion.Rubro = lectura.GetDecimal(9);
                pPublicacion.Publicador = lectura.GetString(10);
                pPublicacion.Id = lectura.GetDecimal(12);
            }
            conn.Close();
           return pPublicacion;
        }

        public static Entidades.Ent_Fecha buscarDuracionVisibilidad(Decimal visibilidad)
        {

            Decimal duracion;
            Entidades.Ent_Fecha entFecha = new Entidades.Ent_Fecha();

            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarDuracionVisibilidad", conn,
            new SqlParameter("@Visibilidad", visibilidad));


            SqlDataReader lectura = cmd.ExecuteReader();
            while (lectura.Read())
            {
                duracion = lectura.GetInt16(5);
                entFecha.fecha = DateTime.Now.AddDays(Convert.ToDouble(duracion));
            }
            conn.Close();
            return entFecha;
        }


        public static void filtarListaDeRubros(string descripcionRubro, DataGridView dataGridView1)
        {
            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.filtrarRubro", conexion,
           new SqlParameter("@Descripcion", descripcionRubro));
            Utiles.SQL.llenarDataGrid(dataGridView1, conexion, cmd);

            dataGridView1.Columns["Codigo"].Visible = false;
        }

    }
}
 
//       public static void buscarListaDeCliente(Entidades.Ent_ListadoCliente pListado, DataGridView dataGridView1)
//        {


//            SqlConnection conn = DBConexion.obtenerConexion();
//            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.listaDeCliente", conn,
//            new SqlParameter("@Nombre", pListado.Nombre),
//            new SqlParameter("@Apellido", pListado.Apellido),
//            new SqlParameter("@Dni", pListado.Dni),
//            new SqlParameter("@Mail", pListado.Mail),
//            new SqlParameter("@Tipo_dni", pListado.Tipo_dni));

//            Utiles.SQL.llenarDataGrid(dataGridView1, conn, cmd);


//            dataGridView1.Columns["Id"].Visible = false;

//        }

//        public static Entidades.Ent_Cliente buscarCliente(Int32 id)
//        {

//            Entidades.Ent_Cliente pcliente = new Entidades.Ent_Cliente();

//            SqlConnection conn = DBConexion.obtenerConexion();
//            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarUnSoloCliente", conn,
//            new SqlParameter("@Id", id));

//            SqlDataReader lectura = cmd.ExecuteReader();
//            while (lectura.Read())
//            {
//                pcliente.Dni = lectura.GetDecimal(1);
//                pcliente.Nombre = lectura.GetString(2);
//                pcliente.Apellido = lectura.GetString(3);
//                pcliente.Fecha_Nac = Convert.ToString(lectura.GetDateTime(4));
//                pcliente.Mail = lectura.GetString(5);
//                pcliente.Dom_Calle = lectura.GetString(6);
//                pcliente.Nro_Calle = lectura.GetDecimal(7);
//                pcliente.Piso = lectura.GetDecimal(8);
//                pcliente.Dpto = lectura.GetString(9);
//                pcliente.Cod_Postal = lectura.GetString(10);
//                pcliente.Localidad = lectura.GetString(11);
//                pcliente.Tipo_dni = lectura.GetInt16(12);
//                pcliente.Telefono = lectura.GetString(13);
//            }
//            conn.Close();
//            return pcliente;
//        }

//        public static Decimal buscarIdCliente(string pw)
//        {
//            Decimal idObtenido = 0;

//            SqlConnection conn = DBConexion.obtenerConexion();
//            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarIdCliente", conn,
//            new SqlParameter("@Dni", pw));
//            SqlDataReader lectura = cmd.ExecuteReader();
//            while (lectura.Read())
//            {
//                idObtenido = lectura.GetDecimal(0);
//            }
//            conn.Close();


//            if (idObtenido != 0)
//            {
//                return (idObtenido);
//            }
//            else
//            {
//                throw new Excepciones.InexistenciaUsuario("Error al obtener Id");
//            }


//        }

//        public static void actualizarCamposACliente(Entidades.Ent_Cliente pCliente, int clienteAModificar)
//        {
//            int retorno;
//            using (SqlConnection conn = DBConexion.obtenerConexion())
//            {
//                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.ActualizarCliente", conn,
//                new SqlParameter("@Id", clienteAModificar),
//                new SqlParameter("@Dni", pCliente.Dni),
//                new SqlParameter("@Nombre", pCliente.Nombre),
//                new SqlParameter("@Apellido", pCliente.Apellido),
//                new SqlParameter("@Fecha_Nac", pCliente.Fecha_Nac),
//                new SqlParameter("@Mail", pCliente.Mail),
//                new SqlParameter("@Dom_Calle", pCliente.Dom_Calle),
//                new SqlParameter("@Nro_Calle", pCliente.Nro_Calle),
//                new SqlParameter("@Piso", pCliente.Piso),
//                new SqlParameter("@Depto", pCliente.Dpto),
//                new SqlParameter("@Cod_Postal", pCliente.Cod_Postal),
//                new SqlParameter("@Localidad", pCliente.Localidad),
//                new SqlParameter("@Tipo_dni", pCliente.Tipo_dni),
//                new SqlParameter("@Telefono", pCliente.Telefono));


//                retorno = cmd.ExecuteNonQuery();
//                conn.Close();
//            }

//            Mensajes.Generales.validarAlta(retorno);
//        }
//    }
//}

