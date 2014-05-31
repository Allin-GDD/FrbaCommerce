using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using FrbaCommerce.Entidades;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class Baja : Form
    {
     

             
        public Baja(Entidades.Ent_Cliente pCliente)
        {
            InitializeComponent();
            this.clienteADarDeBaja = pCliente;
            cargarDatosDelClienteSeleccionado();

        }
        private Entidades.Ent_Cliente clienteADarDeBaja;

        private void cargarDatosDelClienteSeleccionado()
        {
            
            txtApellido.Text = clienteADarDeBaja.Apellido;
            textBox1.Text = clienteADarDeBaja.Nombre;
        }
        
     
        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.darDeBajaAlCliente", conn,
                new SqlParameter("@Dni", clienteADarDeBaja.Dni));
        }
     
        
    }
}
