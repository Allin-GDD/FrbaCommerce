using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Mensajes
{
    class Cliente
    {
        internal static void ValidarNulidadNombre(string p)
        {
            if (string.IsNullOrEmpty(p))
            {
                throw new Excepciones.NulidadDeCamposACompletar("Falta el dato: Nombre");
            }
        }

        internal static void ValidarNulidadApellido(string p)
        {
            if (string.IsNullOrEmpty(p))
            {
                throw new Excepciones.NulidadDeCamposACompletar("Falta el dato: Apellido");
            }
        }

        internal static void ValidarNulidadDNI(string p)
        {
            if (string.IsNullOrEmpty(p))
            {
                throw new Excepciones.NulidadDeCamposACompletar("Falta el dato: DNI");
            }
        }

        internal static void ValidarNulidadLocalidad(string p)
        {
            if (string.IsNullOrEmpty(p))
            {
                throw new Excepciones.NulidadDeCamposACompletar("Falta el dato: Localidad");
            }
        }

        internal static void ValidarNulidadDomicilio(string p)
        {
            if (string.IsNullOrEmpty(p))
            {
                throw new Excepciones.NulidadDeCamposACompletar("Falta el dato: Domicilio");
            }
        }

        internal static void ValidarNulidadNroCalle(string p)
        {
            if (string.IsNullOrEmpty(p))
            {
                throw new Excepciones.NulidadDeCamposACompletar("Falta el dato: Número de Calle");
            }
        }

        internal static void ValidarNulidadFechaNac(string p)
        {
            if (string.IsNullOrEmpty(p))
            {
                throw new Excepciones.NulidadDeCamposACompletar("Falta el dato: Fecha de Nacimiento");
            }
        }

        internal static void ValidarNulidadCodPostal(string p)
        {
            if (string.IsNullOrEmpty(p))
            {
                throw new Excepciones.NulidadDeCamposACompletar("Falta el dato: Código Postal");
            }
        }

        internal static void ValidarTipoNroCalle(string p)
        {
            Decimal expectedDecimal;
            if (!Decimal.TryParse(p, out expectedDecimal))
            {
                throw new Excepciones.ValoresConTiposDiferentes("Se están ingresando datos no validos en el campo Número de Calle");

            }
        }

        internal static void ValidarTipoDni(string p)
        {
            Decimal expectedDecimal;
            if (!Decimal.TryParse(p, out expectedDecimal))
            {
                throw new Excepciones.ValoresConTiposDiferentes("Se están ingresando datos no validos en el campo DNI");
            }
        }

        internal static void ValidarTipoPiso(string p)
        {
            Decimal expectedDecimal;
            if (!Decimal.TryParse(p, out expectedDecimal))
            {
                throw new Excepciones.ValoresConTiposDiferentes("Se están ingresando datos no validos en el campo Piso");
            }

        }

        internal static void ValidarFecha(string p)
        {
            DateTime fechaLimiteInferior = new DateTime(1900, 1, 1, 0, 0, 0);
            DateTime fechaLimiteSuperior = new DateTime(3000, 1, 1, 0, 0, 0);
            DateTime time = DateTime.Parse(p);

           /*ESTO ES REBUSCADO, COMPARAR SI ESTA INGRESANDO BIEN EL DÍA Y FECHA. 
            * if(time.Month > 12) {
                throw new Excepciones.ValoresConTiposDiferentes("El mes ingresado no es válido");
            }

            if (time.Day > 31) {
                throw new Excepciones.ValoresConTiposDiferentes("El día ingresado no es válido");  
            }
            */

            int i = time.CompareTo(fechaLimiteInferior);
            int j = time.CompareTo(fechaLimiteSuperior);

            if( (i <= 0) || (j >= 0))
            {
                throw new Excepciones.ValoresConTiposDiferentes("La Fecha ingresada no es valida. Estas fuera del rango disponible");

            }


        }
    }
}

