using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Mensajes
{
    class Cliente
    {
        internal static void ValidarNombre(string p)
        {
            if (string.IsNullOrEmpty(p))
            {
                throw new Excepciones.NulidadDeCamposACompletar("Falta el dato: Nombre");
            }
        }

        internal static void ValidarApellido(string p)
        {
            if (string.IsNullOrEmpty(p))
            {
                throw new Excepciones.NulidadDeCamposACompletar("Falta el dato: Apellido");
            }
        }

        internal static void ValidarDNI(string p)
        {
            if (string.IsNullOrEmpty(p))
            {
                throw new Excepciones.NulidadDeCamposACompletar("Falta el dato: DNI");
            }
        }

        internal static void ValidarLocalidad(string p)
        {
            if (string.IsNullOrEmpty(p))
            {
                throw new Excepciones.NulidadDeCamposACompletar("Falta el dato: Localidad");
            }
        }

        internal static void ValidarDomicilio(string p)
        {
            if (string.IsNullOrEmpty(p))
            {
                throw new Excepciones.NulidadDeCamposACompletar("Falta el dato: Domicilio");
            }
        }

        internal static void ValidarNroCalle(string p)
        {
            if (string.IsNullOrEmpty(p))
            {
                throw new Excepciones.NulidadDeCamposACompletar("Falta el dato: Número de Calle");
            }
        }

        internal static void ValidarFechaNac(string p)
        {
            if (string.IsNullOrEmpty(p))
            {
                throw new Excepciones.NulidadDeCamposACompletar("Falta el dato: Fecha de Nacimiento");
            }
        }

        internal static void ValidarCodPostal(string p)
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
    }
}

