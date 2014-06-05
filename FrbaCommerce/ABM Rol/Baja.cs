using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.ABM_Rol
{
    public partial class Baja : Form
    {
        public Baja(Decimal idSeleccionado)
        {
            InitializeComponent();
            this.rolADarDeBaja = idSeleccionado;
            txtNombre.Text = Datos.Dat_Rol.obtenerNombreIdRol(rolADarDeBaja);
        }

        private Decimal rolADarDeBaja;
        private void button1_Click(object sender, EventArgs e)
        {
            Datos.Dat_Rol.darDeBajaRol(rolADarDeBaja);
        }

      
    }
}
