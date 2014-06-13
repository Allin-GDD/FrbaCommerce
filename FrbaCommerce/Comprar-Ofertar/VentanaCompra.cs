using System;
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
        public VentanaCompra(decimal codigo,decimal clienteABuscar)
        {
            InitializeComponent();
            cargarDatosDelVendedor();
            Utiles.Inicializar.comboBoxTipoDNI(comboBox1);
            cargarUsuario(clienteABuscar);
    
        }

        private Int32 clienteABuscar;

        private void cargarUsuario(decimal id)
        {
        
        }

        private void cargarDatosDelVendedor()
        {
            Entidades.Ent_Cliente pcliente = new Entidades.Ent_Cliente();
            pcliente = buscarCliente(clienteABuscar);

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
            

        }

        public static Entidades.Ent_Cliente buscarCliente(Int32 id)
        {

            Entidades.Ent_Cliente pcliente = new Entidades.Ent_Cliente();

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

        }

        
    }
}
