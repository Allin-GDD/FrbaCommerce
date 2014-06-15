using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Roles
{
    public partial class Rol_Cliente : Form
    {
        string rol = "C";
        Decimal idcliente;
        public Rol_Cliente(decimal id)
        {
            InitializeComponent();
            decimal idcliente = id;
        }


        private void Salir_Click(object sender, EventArgs e)
        {
       
            this.Close();

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            Comprar_Ofertar.Buscar_Publicacion co = new FrbaCommerce.Comprar_Ofertar.Buscar_Publicacion(idcliente,rol);
            co.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calificar_Vendedor.listadoDePublicaciones cal = new FrbaCommerce.Calificar_Vendedor.listadoDePublicaciones(idcliente);
            cal.Show();
        }

    }
}
