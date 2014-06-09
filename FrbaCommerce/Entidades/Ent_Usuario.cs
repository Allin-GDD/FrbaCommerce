using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Entidades
{
    class Ent_Usuario
    {
        public String Usuario { get; set; }
        public String Contraseña { get; set; }
        public Decimal Rol { get; set; }
        public Decimal IdUsuario { get; set; }
        public Int16 Intentos { get; set; }
        public Int16 Estado { get; set; }

    }
}
