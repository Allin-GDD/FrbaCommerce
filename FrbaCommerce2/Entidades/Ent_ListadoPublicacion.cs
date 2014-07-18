using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Entidades
{
    class Ent_ListadoPublicacion
    {
        public String Descripcion { get; set; }
        public Decimal Rubro { get; set; }
        public Boolean MisPublicaciones { get; set; }
        public String Visibilidad { get; set; }
        public String Estado { get; set; }
        public String Tipo { get; set; }
    }
}
