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
        Boolean esCliente = true;
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
            Comprar_Ofertar.Buscar_Publicacion co = new FrbaCommerce.Comprar_Ofertar.Buscar_Publicacion(idcliente,esCliente);
            co.Show();
        }

    }
}
