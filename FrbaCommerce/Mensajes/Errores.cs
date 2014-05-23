using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Mensajes
{
    class Errores
    {
        public static void ErrorAlIngresarDatos()
        {
            MessageBox.Show("Error al ingresar los datos", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
