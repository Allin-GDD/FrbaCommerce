using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Entidades
{
    public class Ent_VendedorEmpresa
    {
        public String NombreContacto { get; set; }
        public String RazonSocial { get; set; }
        public String CUIT { get; set; }
        public String Mail { get; set; }
        public String Telefono { get; set; }
        public String Dom_Calle { get; set; }
        public Decimal Nro_Calle { get; set; }
        public Decimal Piso { get; set; }
        public String Dpto { get; set; }
        public String Localidad { get; set; }
        public String Cod_Postal { get; set; }
        public String Ciudad { get; set; }
        public String Fecha_Creacion { get; set; }
        public Int16 Tipo_Doc { get; set; }
        public String Usuario { get; set; }
    }
}
