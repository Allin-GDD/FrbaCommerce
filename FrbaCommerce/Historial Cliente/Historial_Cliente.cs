using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Historial_Cliente
{
    public partial class Historial_Cliente : Form
    {
        Decimal idCliente;
        public Historial_Cliente(Decimal id)
        {
            InitializeComponent();
            idCliente = id;
        }

        private void HistorialCompras_Click(object sender, EventArgs e)
        {
            Historial_Compras hisCo = new Historial_Compras(idCliente);
            hisCo.Show();

        }

        private void HistorialOfertas_Click(object sender, EventArgs e)
        {
            Historial_Ofertas hisO = new Historial_Ofertas(idCliente);
            hisO.Show();
        }

        private void HistorialCalificaciones_Click(object sender, EventArgs e)
        {
            Historial_Calificaciones hisCa = new Historial_Calificaciones(idCliente);
            hisCa.Show();
        }

       
    }
}
