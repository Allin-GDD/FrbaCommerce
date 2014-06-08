using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Entidades
{
    public class Ent_Publicacion
    {
        public Decimal Visibilidad { get; set; }
        public String Tipo { get; set; }
        public Decimal Rubro { get; set; }
        public Decimal Stock  { get; set; }
        public Decimal Precio { get; set; }
        public String Descripcion { get; set; }
        public Boolean Permitir_Preguntas { get; set; }
      

        public Ent_Publicacion() { }
        public Ent_Publicacion(Decimal pVisibilidad, String pTipo, Decimal pRubro, Decimal pStock, Decimal pPrecio, String pDescripcion, Boolean pPermitir_Preguntas)
        {


            this.Visibilidad = pVisibilidad;
            this.Tipo = pTipo;
            this.Rubro = pRubro;
            this.Stock = pStock;
            this.Precio = pPrecio;
            this.Descripcion = pDescripcion;
            this.Permitir_Preguntas = pPermitir_Preguntas;
        }
    }
}