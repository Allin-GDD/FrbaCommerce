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
        public Rol_Cliente(decimal id)
        {
            InitializeComponent();
            decimal idcliente = id;
        }
        private decimal idcliente;

        private void Salir_Click(object sender, EventArgs e)
        {
       
            this.Close();

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            Comprar_Ofertar.Form1 co = new FrbaCommerce.Comprar_Ofertar.Form1(idcliente);
            co.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Editar_Publicacion.Buscar_Publicacion list = new Editar_Publicacion.Buscar_Publicacion(usuario);
            list.Show();
        }
    }
}
