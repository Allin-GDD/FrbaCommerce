using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Entidades
{
    class Ent_ListFactura
    {
        public Decimal Codigo { get; set; }
        public Decimal Cantidad { get; set; }       
        public Double Porcentaje { get; set; }
        public Double Precio { get; set; }
        public Double PrecioVis { get; set; }
    }
}
