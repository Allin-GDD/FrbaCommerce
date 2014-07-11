using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Entidades
{
    public class Ent_Publicacion
    {
        public Decimal Visibilidad { get; set; }
        public Decimal Tipo { get; set; }
        public Decimal Rubro { get; set; }
        public Decimal Stock  { get; set; }
        public Decimal Precio { get; set; }
        public String Descripcion { get; set; }
        public Decimal Estado { get; set; }
        public Boolean Permitir_Preguntas { get; set; }
        public Decimal Usuario { get; set; }
        public DateTime Fecha_Venc { get; set; }
        public Decimal Codigo { get; set; }

        public Ent_Publicacion() { }
        public Ent_Publicacion(Decimal pVisibilidad, Decimal pTipo, Decimal pRubro, Decimal pStock, Decimal pPrecio, String pDescripcion, Decimal pEstado, Boolean pPermitir_Preguntas, Decimal pUsuario, DateTime pFecha_Venc, Decimal pCodigo)
        {


            this.Visibilidad = pVisibilidad;
            this.Tipo = pTipo;
            this.Rubro = pRubro;
            this.Stock = pStock;
            this.Precio = pPrecio;
            this.Descripcion = pDescripcion;
            this.Estado = pEstado;
            this.Permitir_Preguntas = pPermitir_Preguntas;
            this.Usuario = pUsuario;
            this.Fecha_Venc = pFecha_Venc;
            this.Codigo = pCodigo;
        }
    }
}