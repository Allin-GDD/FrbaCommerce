using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Datos
{
    class Dat_Funcionalidad
    {
         //agrega una funcionalidad con su rol

        public static void chequeoDeAddFuncionalidad(CheckBox chkAgregar, decimal rol, int func)
        {
            if (chkAgregar.Checked)
            {
                Datos.Dat_Rol.agregarFuncionabilidad(rol, func);
            }
        }

        // remueve una funcionalidad con su rol
        public static void chequeoRemoveFuncioalidad(CheckBox chkQuitar, decimal rol, int func)
        {
            if (chkQuitar.Checked)
            {
                Datos.Dat_Rol.removerFuncionalidad(rol, func);
               
            }
        }
    }
}
