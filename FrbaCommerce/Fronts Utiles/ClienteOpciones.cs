using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Fronts_Utiles
{
    public partial class ClienteOpciones : Form
    {
        public ClienteOpciones()
        {
            InitializeComponent();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Datos.Dat_Cliente.obtenerDatosDelCliente();
            Abm_Cliente.Baja Baj1 = new Abm_Cliente.Baja();
            Baj1.Show();
        }

    
    }
}
