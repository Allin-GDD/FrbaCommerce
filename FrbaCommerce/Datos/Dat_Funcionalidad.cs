using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Datos
{
    class Dat_Funcionalidad
    {
        internal static void chequeoDeAddFuncionalidad(CheckBox chkAgregar, decimal rol)
        {
            if (chkAgregar.Checked){
                 //Datos.Dat_Rol.agregarFuncionabilidad(rol, Convert.ToInt32(cmbFuncionalidad.SelectedValue));
            }
        }

        internal static void chequeoRemoveFuncioalidad(CheckBox chkQuitar, decimal rol)
        {
            throw new NotImplementedException();
        }
    }
}
