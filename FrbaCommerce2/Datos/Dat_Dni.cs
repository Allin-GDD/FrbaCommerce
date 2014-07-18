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
        public static bool validarDni(MaskedTextBox txtDoc, short tipoDoc)
        {
            List<Entidades.Ent_Doc> listaDnies = Datos.Dat_Cliente.obtenerTodosLosDocCliente();

            foreach (Entidades.Ent_Doc dni in listaDnies)
            {
                if (txtDoc != null && txtDoc.Text == dni.Dni && tipoDoc == dni.tipoDni)
                {
                    txtDoc.BackColor = Color.Coral;
                    return true;
                }
            }
            return false;

        }
    }
}
