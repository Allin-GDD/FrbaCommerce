using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class Baja : Form
    {
        public Baja()
        {
            InitializeComponent();

            //dataGridView1.DataSource = Datos.Dat_Cliente.obtenerDatosDelCliente(this.idCliente);
        }

    
        private void button1_Click(object sender, EventArgs e)
        {

        }

        public Int32 idCliente { get; set; }

       
        
    }
}
