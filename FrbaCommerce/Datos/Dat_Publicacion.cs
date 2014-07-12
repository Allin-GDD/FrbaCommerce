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
            SqlCommand Comando = Utiles.SQL.crearProcedure("GD1C2014.dbo.seleccionVisibilidadNotNull", conexion);
            //SqlCommand Comando = new SqlCommand("Select Codigo, Descripcion from Visibilidad", conexion);
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

        public static void AgregarPublicacion(Entidades.Ent_Publicacion pPublicacion) //funca
        {
            int retorno;
            using (SqlConnection conexion = DBConexion.obtenerConexion())
            {

                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.agregarNuevaPublicacion", conexion,
                   new SqlParameter("@Visibilidad", pPublicacion.Visibilidad),
                   new SqlParameter("@Tipo", pPublicacion.Tipo),
                   new SqlParameter("@Fecha", pPublicacion.Fecha),
                   new SqlParameter("@Estado", pPublicacion.Estado),
                   new SqlParameter("@Stock", pPublicacion.Stock),
                   new SqlParameter("@Precio", pPublicacion.Precio),
                   new SqlParameter("@Rubro", pPublicacion.Rubro),
                   new SqlParameter("@Descripcion", pPublicacion.Descripcion),
                   new SqlParameter("@Permitir_Preguntas", pPublicacion.Permitir_Preguntas),
                   new SqlParameter("@Fecha_Venc", Convert.ToDateTime(pPublicacion.Fecha_Venc)),
                   new SqlParameter("@Usuario", pPublicacion.Usuario));

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
  
        public static Boolean verificarTresGratuitas(Decimal usuario)
        {

            Boolean seVerifica;
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.verificarTresGratuitas", conn,

            new SqlParameter("@Usuario",usuario));


            SqlDataReader lectura = cmd.ExecuteReader();

            lectura.Read();

            if (lectura.GetInt32(0) >= 3)
            {
                seVerifica = true;
            }
            else
            {
                seVerifica = false;
            }


            conn.Close();

            return seVerifica;
        
        }
        
        public static Decimal buscarUsuarioCod(Decimal codigo)
        {


            Decimal usuario;
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarUsuarioCod", conn,
            new SqlParameter("@Codigo", codigo));

            SqlDataReader lectura = cmd.ExecuteReader();
            lectura.Read();
          
            usuario = lectura.GetDecimal(0);


            conn.Close();
            return usuario;

        }

        public static string obtenerDescripcionRubro(Decimal rubro) //funca
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
        public static Decimal obtenerCodRubro(string descripcion)
        {

            Decimal rubroDevuelvo;
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.obtenerCodRubro", conn,

            new SqlParameter("@Descripcion", descripcion));


            SqlDataReader lectura = cmd.ExecuteReader();

            lectura.Read();

            rubroDevuelvo = lectura.GetDecimal(0);


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

        public static Boolean estaPausado(Decimal codigo)
        {

            Boolean verificado = false;
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.verificarEstado", conn,

            new SqlParameter("@Codigo", codigo));


            SqlDataReader lectura = cmd.ExecuteReader();

            lectura.Read();

            if (lectura.GetDecimal(0) == 3)
            {
                verificado = true;
            }


            conn.Close();

            return verificado;

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
                pPublicacion.Tipo = lectura.GetDecimal(6);
                pPublicacion.Stock = lectura.GetDecimal(2);
                pPublicacion.Descripcion = lectura.GetString(1);
                pPublicacion.Precio = lectura.GetDecimal(5);
                pPublicacion.Rubro = lectura.GetDecimal(12);
                pPublicacion.Permitir_Preguntas = lectura.GetBoolean(9);
                pPublicacion.Usuario = lectura.GetDecimal(10);
            }
            conn.Close();
           return pPublicacion;
        }

        public static Entidades.Ent_Fecha buscarDuracionVisibilidad(Decimal visibilidad) //funca
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
                entFecha.fecha = DBConexion.fechaIngresadaPorElAdministrador().AddDays(Convert.ToDouble(duracion));
            }
            conn.Close();
            return entFecha;
        }


        public static void filtarListaDeRubros(string descripcionRubro, DataGridView dataGridView1, Decimal codigo, String flag)
        {
            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.filtrarRubro", conexion,
           new SqlParameter("@codigo", codigo),
           new SqlParameter("@flag", flag),
           new SqlParameter("@Descripcion", descripcionRubro));
            Utiles.SQL.llenarDataGrid(dataGridView1, conexion, cmd);

            dataGridView1.Columns["Codigo"].Visible = false;
        }


        internal static decimal obtenerCodTipoPublicacion(string tipo)
        {
            decimal tipoDevuelvo;
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.obtenerCodTipoPublicacion", conn,

            new SqlParameter("@tipo", tipo));


            SqlDataReader lectura = cmd.ExecuteReader();

            lectura.Read();

            tipoDevuelvo = lectura.GetDecimal(0);


            conn.Close();

            return tipoDevuelvo;
        }

        internal static decimal obtenerCodEstadoPublicacion(string estado)
        {
            decimal estadoDevuelvo;
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.obtenerCodEstadoPublicacion", conn,

            new SqlParameter("@estado", estado));


            SqlDataReader lectura = cmd.ExecuteReader();

            lectura.Read();

            estadoDevuelvo = lectura.GetDecimal(0);


            conn.Close();

            return estadoDevuelvo;
        }

        internal static string obtenerNombreTipoPublicacion(decimal tipo)
        {
            string nombreTipoDevuelvo;
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.obtenerNombreTipoPublicacion", conn,

            new SqlParameter("@tipo", tipo));


            SqlDataReader lectura = cmd.ExecuteReader();

            lectura.Read();

            nombreTipoDevuelvo = lectura.GetString(0);


            conn.Close();

            return nombreTipoDevuelvo;
        }

        internal static void AgregarRubro(TextBox textBox1, Decimal codPublicacion)
        {
            int retorno;
            decimal rubro;
            using (SqlConnection conexion = DBConexion.obtenerConexion())
            {
                rubro = Datos.Dat_Publicacion.obtenerCodRubro(textBox1.Text);
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.agregarPublicacionRubro", conexion,
                new SqlParameter("@codigo", codPublicacion),
                new SqlParameter("@rubro", rubro));

                retorno = cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }

        internal static void QuitarRubro(TextBox textBox1, Decimal codPublicacion)
        {
            int retorno;
            decimal rubro;
            using (SqlConnection conexion = DBConexion.obtenerConexion())
            {
                rubro = Datos.Dat_Publicacion.obtenerCodRubro(textBox1.Text);
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.quitarPublicacionRubro", conexion,
                new SqlParameter("@codigo", codPublicacion),
                new SqlParameter("@rubro", rubro));

                retorno = cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }
    }
}

