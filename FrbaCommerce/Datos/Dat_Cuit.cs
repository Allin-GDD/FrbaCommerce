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
        public static bool validarCuit(MaskedTextBox txtCUIT, short tipoDoc)
        {

            List<Entidades.Ent_Doc> listaCuit = Datos.Dat_Empresa.obtenerTodosLosCuit();

            foreach (Entidades.Ent_Doc cuit in listaCuit)
            {
                if (txtCUIT != null && txtCUIT.Text == cuit.Dni && cuit.tipoDni == tipoDoc)
                {
                    txtCUIT.BackColor = Color.Coral;
                    return true;
                }
            }
            return false;

        }
    }
}
