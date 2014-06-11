using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Utiles
{
    class AyudaVarias
    {
        public static string mensaje(List<string> errores)
        {
            string mensajeError = "";
            foreach (string error in errores)
            {
                mensajeError += error + Environment.NewLine;
            }
            return mensajeError;
        }
    }
}
