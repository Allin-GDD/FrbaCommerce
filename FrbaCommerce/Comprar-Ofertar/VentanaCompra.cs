﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Comprar_Ofertar
{
    partial class VentanaCompra : Form
    {
        private decimal codigo;
        private decimal idusuario;
        

        public VentanaCompra(decimal codigoPub,decimal idUsuario)
        {
            InitializeComponent();
            idusuario = idUsuario;
            this.codigo = codigoPub;
            cargarDatosDelVendedor();
            Utiles.Inicializar.comboBoxTipoDNI(comboBox1);
            
    
        }
        
        
        

        private string cargarUsuario(decimal id)
        {
           string usuario = "";
           using (SqlConnection conexion = DBConexion.obtenerConexion())
           {
               
               SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarUsuarioCliente", conexion,
               new SqlParameter("@Id", id));

               SqlDataReader lectura = cmd.ExecuteReader();
               while (lectura.Read())
               {

                   usuario = lectura.GetString(0);

               }
               conexion.Close();
           }
            return usuario;
            }
        

        private void cargarDatosDelVendedor()
        {
            

            Entidades.Ent_Vendedor pcliente = new Entidades.Ent_Vendedor();
            decimal clienteABuscar = buscaridVendedor(codigo);
            pcliente = buscarCliente(clienteABuscar);
            pcliente.Usuario = cargarUsuario(clienteABuscar);
            

            txtnombre.Text = pcliente.Nombre;
            txtapellido.Text = pcliente.Apellido;
            txtdoc.Text = Convert.ToString(pcliente.Dni);
            txtcalle.Text = pcliente.Dom_Calle;
            txtcp.Text = pcliente.Cod_Postal;
            txtdpto.Text = pcliente.Dpto;
            txtmail.Text = pcliente.Mail;
            txtnum.Text = Convert.ToString(pcliente.Nro_Calle);
            txtpiso.Text = Convert.ToString(pcliente.Piso);  
            txtlocalidad.Text = pcliente.Localidad;
            txtusuario.Text = pcliente.Usuario;
            txttel.Text = Convert.ToString(pcliente.Telefono);
        

        }
        public decimal buscaridVendedor(decimal codigo)
        {


            SqlConnection conn = DBConexion.obtenerConexion();
            
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarIdPorPublicacion", conn,
                new SqlParameter("@Codigo", codigo));
                SqlDataReader lectura = cmd.ExecuteReader();

                lectura.Read();
                
                decimal  id = lectura.GetDecimal(0);
                
                conn.Close();
                return id;
            
            
            
        }

        public static Entidades.Ent_Vendedor buscarCliente(decimal id)
        {

            Entidades.Ent_Vendedor pcliente = new Entidades.Ent_Vendedor();

            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarUnSoloCliente", conn,
            new SqlParameter("@Id", id));

            SqlDataReader lectura = cmd.ExecuteReader();
            while (lectura.Read())
            {
                pcliente.Dni = lectura.GetDecimal(1);
                pcliente.Nombre = lectura.GetString(2);
                pcliente.Apellido = lectura.GetString(3);
                pcliente.Fecha_Nac = Convert.ToString(lectura.GetDateTime(4));
                pcliente.Mail = lectura.GetString(5);
                pcliente.Dom_Calle = lectura.GetString(6);
                pcliente.Nro_Calle = lectura.GetDecimal(7);
                pcliente.Piso = lectura.GetDecimal(8);
                pcliente.Dpto = lectura.GetString(9);
                pcliente.Cod_Postal = lectura.GetString(10);
                pcliente.Localidad = lectura.GetString(11);
                pcliente.Tipo_dni = lectura.GetInt16(12);
                pcliente.Telefono = lectura.GetString(13);
            }
            conn.Close();
            return pcliente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   decimal stock = Convert.ToDecimal(txtvalor.Text);
                Utiles.Validaciones.ValidarTipoDecimal(txtvalor);
                validarStock(stock, codigo);

                SqlConnection conn = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.agregarCompra", conn,
                new SqlParameter("@Codigo", codigo),
                new SqlParameter("@Id",idusuario ),
                new SqlParameter("@Stock",stock));
                int retorno = cmd.ExecuteNonQuery();

               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private static void validarStock(decimal valor, decimal codigo)
        {
            decimal stock;
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.averiguarStock", conn,
            new SqlParameter("@Codigo", codigo));
            SqlDataReader lectura = cmd.ExecuteReader();
            lectura.Read();

            stock = lectura.GetDecimal(0);

            if (valor > stock)
            {
                throw new Excepciones.ValorMenor("No hay suficiente stock disponible");
            }
            
        }
    }
}
