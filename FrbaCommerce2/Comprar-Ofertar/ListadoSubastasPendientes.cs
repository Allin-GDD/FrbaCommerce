﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Comprar_Ofertar
{
    public partial class ListadoSubastasPendientes : Form
    {
        public ListadoSubastasPendientes(decimal id)
        {
            InitializeComponent();
            idUsuario = id;
            botonAceptar = false;
            
        }

        decimal idUsuario;
        private bool botonAceptar;

        //busca las subastas que están pendientes
        private void button1_Click(object sender, EventArgs e)
        {
            buscarSubastasSinConfirmarGanador(idUsuario, dataGridView1);
            this.botonAceptar = Utiles.Inicializar.agregarColumnaModificar(botonAceptar, dataGridView1);

        }
        
        //Actualiza los datos de la compra
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Decimal codigo = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Codigo_Pub"].Value);
                Decimal idSeleccionado = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Id_Cliente"].Value);
                
        

                if (e.ColumnIndex == dataGridView1.CurrentRow.Cells["btnEdit"].ColumnIndex)
                {
                    if (idSeleccionado != 0)
                    {
                        agregarCompra(codigo, idSeleccionado);
                    }
                    cambiar_ganador(codigo);
                }
                buscarSubastasSinConfirmarGanador(idUsuario, dataGridView1);

                Mensajes.Exitos.ExitoAlGuardaLosDatos();
            }
                catch (Exception)
            {

                Mensajes.Errores.NoHayDatosAmodificar();
            }
        }
     
        private static void buscarSubastasSinConfirmarGanador(decimal idUsuario, DataGridView dataGridView1)
        {

            try
            {
                
                SqlConnection conn = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.allin.listaSubastasSinConfirmarGanador", conn,
                new SqlParameter("@id_Cliente", idUsuario),
                new SqlParameter("Fecha", DBConexion.fechaIngresadaPorElAdministrador()));

                
                Utiles.SQL.llenarDataGrid(dataGridView1, conn, cmd);
            }
            catch (Exception)
            {
                Mensajes.Errores.NoHayConexion();
            }

        }
        
        //modifica el con ganador osea el valor que indica si termino o no la subasta.
        private static void cambiar_ganador(decimal codigo)
        {
                SqlConnection conn2 = DBConexion.obtenerConexion();
                SqlCommand cmd2 = Utiles.SQL.crearProcedure("GD1C2014.allin.cambiarConGanador", conn2,
                    new SqlParameter("@Codigo", codigo));
                int retorno = cmd2.ExecuteNonQuery();
                conn2.Close();
            
        }
        private static void agregarCompra(decimal codigo,decimal idSeleccionado)
        {

            decimal i = 1;            
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.allin.agregarCompra", conn,
                    new SqlParameter("@Codigo", codigo),
                    new SqlParameter("@Id", idSeleccionado),
                    new SqlParameter("@Stock", i),
                    new SqlParameter("@Fecha", DBConexion.fechaIngresadaPorElAdministrador()));

                    int retorno = cmd.ExecuteNonQuery();
                      conn.Close();
        }
    }
}
