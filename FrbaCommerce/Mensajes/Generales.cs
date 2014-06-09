using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Mensajes
{
    class Generales
    {
        public static void validarBaja(int retorno)
        {
            if (retorno > 0)
            {
                Mensajes.Exitos.ExitoAlBorrarLosDatos();
            }
            else { Mensajes.Errores.ErrorAlBorrarDatos(); }
        }

        internal static void validarAlta(int retorno)
        {
            if (retorno > 0)
            {
                Mensajes.Exitos.ExitoAlGuardaLosDatos();
            }
            else { 
                Mensajes.Errores.ErrorAlGuardarDatos(); 
            }
        }

    }
}
