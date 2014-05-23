using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Excepciones
{
    public class NulidadDeCamposACompletar : System.Exception
    {
        public NulidadDeCamposACompletar() 
        { 
            }
        public NulidadDeCamposACompletar(string message)
            : base (message)
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
            : base (message)
        {
            }
        public DuplicacionDeDatos(string message, Exception inner)

            : base(message, inner)
        {
            }
    }
}
