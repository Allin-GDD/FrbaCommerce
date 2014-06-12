using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Datos


{
    class Dat_Cuit
    {
        public static bool validarCuit(MaskedTextBox txtCUIT)
        {
            
           List<Entidades.Ent_Cuit> listaCuit = Datos.Dat_Empresa.obtenerTodosLosCuit();

            foreach (Entidades.Ent_Cuit cuit in listaCuit)
            {
                if (txtCUIT != null && txtCUIT.Text == cuit.CUIT)
                {
                    return true;
                }
            }
            return false;

        }
    }
}
