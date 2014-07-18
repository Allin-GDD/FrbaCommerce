using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Entidades
{
   public class Ent_Empresa
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
        public DateTime Fecha_Creacion { get; set; }
        public Int16 Tipo_Doc { get; set; }
        public String Tipo_DocNombre { get; set; }
       
       
    
    public Ent_Empresa() {}
    public Ent_Empresa(String pNombreContacto, String pRazonSocial, String pCUIT, 
        String pMail, String pTelefono, String pDom_Calle, Decimal pNro_Calle,
        Decimal pPiso, String pDpto,
        String pLocalidad, String pCod_Postal, String pCiudad, DateTime pFecha_Creacion, Int16 pTipo_Doc, String pTipo_DocNombre)
    {


            this.NombreContacto = pNombreContacto;
            this.RazonSocial = pRazonSocial;
            this.CUIT = pCUIT;
            this.Mail = pMail;
            this.Telefono = pTelefono;
            this.Dom_Calle = pDom_Calle;
            this.Nro_Calle = pNro_Calle;
            this.Piso = pPiso;
            this.Localidad = pLocalidad;
            this.Cod_Postal = pCod_Postal;
            this.Ciudad = pCiudad;
            this.Fecha_Creacion = pFecha_Creacion;
            this.Tipo_Doc = pTipo_Doc;
            this.Tipo_DocNombre = pTipo_DocNombre;
    }
}
}