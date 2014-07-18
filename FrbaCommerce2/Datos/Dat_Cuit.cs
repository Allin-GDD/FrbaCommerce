using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace FrbaCommerce.Datos


{
    class Dat_Cuit
    {
        public static bool validarCuit(MaskedTextBox txtCUIT)
        {

            List<String> listaCuit = Datos.Dat_Empresa.obtenerTodosLosCuit();

            foreach (String cuit in listaCuit)
            {
                if (txtCUIT != null && txtCUIT.Text == cuit)
                {
                    txtCUIT.BackColor = Color.Coral;
                    return true;
                }
            }
            return false;

        }
    }
}
