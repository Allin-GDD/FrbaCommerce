using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Excepciones
{
    // todas hacen los mismo pero se crearon diferentes para poder darse cuenta cual usar

    public class NulidadDeCamposACompletar : System.Exception
    {
        public NulidadDeCamposACompletar()
        {
        }
        public NulidadDeCamposACompletar(string message)
            : base(message)
        {
        }
        public NulidadDeCamposACompletar(string message, Exception inner)

            : base(message, inner)
        {
        }
    }
    public class DuplicacionDeDatos : System.Exception
    {
        public DuplicacionDeDatos()
        {
        }
        public DuplicacionDeDatos(string message)
            : base(message)
        {
        }
        public DuplicacionDeDatos(string message, Exception inner)

            : base(message, inner)
        {
        }
    }
    public class ValoresConTiposDiferentes : System.Exception
    {
        public ValoresConTiposDiferentes()
        {
        }
        public ValoresConTiposDiferentes(string message)
            : base(message)
        {
        }
        public ValoresConTiposDiferentes(string message, Exception inner)

            : base(message, inner)
        {
        }
    }
    public class ValorMenor : System.Exception
    {
        public ValorMenor()
        {
        }
        public ValorMenor(string message)
            : base(message)
        {
        }
        public ValorMenor(string message, Exception inner)

            : base(message, inner)
        {
        }
    }
    public class InexistenciaUsuario : System.Exception
    {
        public InexistenciaUsuario()
        {
        }
        public InexistenciaUsuario(string message)
            : base(message)
        {
        }
        public InexistenciaUsuario(string message, Exception inner)

            : base(message, inner)
        {
        }

    }
    public class ElUsuarioSeBloqueo : System.Exception
    {
        public ElUsuarioSeBloqueo()
        {
        }
        public ElUsuarioSeBloqueo(string message)
            : base(message)
        {
        }
        public ElUsuarioSeBloqueo(string message, Exception inner)

            : base(message, inner)
        {
        }
        public class InexistenciaUsuario : System.Exception
        {
            public InexistenciaUsuario()
            {
            }
            public InexistenciaUsuario(string message)
                : base(message)
            {
            }
            public InexistenciaUsuario(string message, Exception inner)

                : base(message, inner)
            {
            }
        }


    }
}
