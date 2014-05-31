using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Utiles
{
    class Inicializar
    {
        public static void comboBoxTipoDNI(ComboBox cmbTipoDoc)
        {
            cmbTipoDoc.DataSource = Datos.Dat_Cliente.ObtenerTipoDoc();
            cmbTipoDoc.DisplayMember = "tipo";
            cmbTipoDoc.ValueMember = "codigo";

        }
        internal static void comboBoxRol(ComboBox cmbRol)
        {
            cmbRol.DataSource = Datos.Dat_Rol.ObtenerRol();
            cmbRol.DisplayMember = "Nombre";
            cmbRol.ValueMember = "Id";

        }
    }

}
