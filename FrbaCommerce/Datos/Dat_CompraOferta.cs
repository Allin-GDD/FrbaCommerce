﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace FrbaCommerce.Datos
{
    class Dat_CompraOferta
    {
        public static List<Entidades.Ent_Rubros> ObtenerRubros()
        {

            List<Entidades.Ent_Rubros> listaDeRubros = new List<Entidades.Ent_Rubros>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("Select Codigo, Descripcion from Rubro", conexion);
            SqlDataReader lectura = Comando.ExecuteReader();

            while (lectura.Read())
            {
                Entidades.Ent_Rubros pRubro = new Entidades.Ent_Rubros();
                pRubro.codigo = lectura.GetInt16(0);
                pRubro.rubro = lectura.GetString(1);

                listaDeRubros.Add(pRubro);
            }
            return listaDeRubros;
        }

        public static void buscarListado(Entidades.Ent_ListadoPublicacion pListado, DataGridView dataGridView1)
        {

            try
            {
                SqlConnection conn = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.listaDePublicaciones", conn,
                new SqlParameter("@Descripcion", pListado.Descripcion),
                new SqlParameter("@Rubro", pListado.Rubro))
                ;
                Utiles.SQL.llenarDataGrid(dataGridView1, conn, cmd);
            }
            catch (Exception)
            {
                Mensajes.Errores.NoHayConexion();
            }

        }


        

    }
}