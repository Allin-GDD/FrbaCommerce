using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Empresa
{
    public partial class Modificación : Form
    {
        public Modificación(Int32 idSeleccionado)
        {
            InitializeComponent();
            this.clienteAModificar = idSeleccionado;
        }
        public Int32 clienteAModificar;
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
