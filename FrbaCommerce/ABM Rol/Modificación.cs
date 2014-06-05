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
    public partial class Modificación : Form
    {
        public Modificación(Decimal idSeleccionado)
        {
            InitializeComponent();
            Utiles.Inicializar.comboBoxFuncionalidades(cmbTodaFunc);
            Utiles.Inicializar.comboBoxFuncionalidadesPropias(cmbPropias, idSeleccionado);
        }

            private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

     
    }
}
