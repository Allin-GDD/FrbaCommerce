using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace FrbaCommerce.Datos
{
    class Dat_Dni
    {
        public static bool validarDni(TextBox txtDni)
        {
            Decimal pdni = Convert.ToDecimal(txtDni.Text);


           List<Entidades.Ent_Dni> listaDnies = Datos.Dat_Cliente.obtenerTodosLosDni();

            foreach (Entidades.Ent_Dni dni in listaDnies)
            {
                if (pdni == dni.Dni)
                {
                    txtDni.BackColor = Color.Coral;
                    return true;
                }
            }
            return false;

        }
    }
}
