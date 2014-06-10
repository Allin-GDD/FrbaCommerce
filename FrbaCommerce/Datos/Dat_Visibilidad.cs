﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Datos
{
    class Dat_Visibilidad
    {
        public static void AgregarVisibilidad(Entidades.Ent_Visibilidad pvisibilidad)
        {
            int retorno;
            using (SqlConnection conexion = DBConexion.obtenerConexion())
            {

                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.agregarNuevaVisibilidad", conexion,
                   new SqlParameter("@Codigo", pvisibilidad.Codigo),
                   new SqlParameter("@Descripcion", pvisibilidad.Descripcion),
                   new SqlParameter("@Precio", pvisibilidad.Precio),
                   new SqlParameter("@Porcentaje", pvisibilidad.Porcentaje),
                   new SqlParameter("@Estado", 1) ,
                   new SqlParameter("@Vencimiento", pvisibilidad.Vencimiento));
               
                retorno = cmd.ExecuteNonQuery();
                conexion.Close();
            }


            Mensajes.Generales.validarAlta(retorno);

        }
       

        public static Entidades.Ent_Visibilidad buscarVisibilidad(Int32 codigo)
        {
            Entidades.Ent_Visibilidad pVis = new Entidades.Ent_Visibilidad();
                pVis.Codigo = codigo;

                SqlConnection conn = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarUnaVisibilidad", conn,
                new SqlParameter("@Codigo", Convert.ToDecimal(codigo)));

                SqlDataReader lectura = cmd.ExecuteReader();
              
                while (lectura.Read())
                {
                    pVis.Descripcion = lectura.GetString(1);
                    pVis.Precio = Convert.ToDouble(lectura.GetDecimal(2));
                    pVis.Porcentaje = Convert.ToDouble(lectura.GetDecimal(3));
                    pVis.Vencimiento = lectura.GetInt16(5);

               }
                conn.Close();
          
            return pVis;
        }


    
           public static void ActualizarCamposAVisibilidad(Entidades.Ent_Visibilidad pvisibilidad,int visibilidadAModificar,Int16 estado)
        {
            int retorno;
            using (SqlConnection conn = DBConexion.obtenerConexion())
            {
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.ActualizarVisibilidad", conn,
                new SqlParameter("@Codigo", visibilidadAModificar),
                new SqlParameter("@Descripcion", pvisibilidad.Descripcion),
                new SqlParameter("@Precio", pvisibilidad.Precio),
                new SqlParameter("@Porcentaje", pvisibilidad.Porcentaje),
                new SqlParameter("@Estado", estado),
                new SqlParameter("@Vencimiento", pvisibilidad.Vencimiento));
               

                retorno = cmd.ExecuteNonQuery();
                conn.Close();
            }

            Mensajes.Generales.validarAlta(retorno);
        }
           public static void buscarListaDeVisibilidades(Entidades.Ent_ListadoVisibilidad pListado, DataGridView dataGridView1)
           {
               try
               {

                   SqlConnection conn = DBConexion.obtenerConexion();
                   SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.listaDeVisibilidades", conn,
                   new SqlParameter("@Codigo", pListado.Codigo),
                   new SqlParameter("@Descripcion", pListado.Descripcion),
                   new SqlParameter("@Precio", pListado.Precio),
                   new SqlParameter("@Porcentaje", pListado.Porcentaje));

                   Utiles.SQL.llenarDataGrid(dataGridView1, conn, cmd);
               }

               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
         
               }

           }

          
    
    }

}