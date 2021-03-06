﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Entidades
    {
    public class Ent_Cliente
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Mail { get; set; }
        public String Dni { get; set; }
        public DateTime Fecha_Nac { get; set; }
        public String Dom_Calle { get; set; }
        public Decimal Nro_Calle { get; set; }
        public Decimal Piso { get; set; }
        public String Dpto { get; set; }
        public String Cod_Postal { get; set; }
        public Int16 Tipo_dni { get; set; }
        public String Telefono { get; set; }
        public String Localidad { get; set; }
        public String Tipo_DocNom { get; set; }
    
    public Ent_Cliente() {}
    public Ent_Cliente(String pNombre, String pApellido, String pDni, Int16 pTipo_dni, String pMail, DateTime pFecha_Nac, String pDom_Calle, Decimal pNro_Calle, Decimal pPiso, String pDpto, String pCod_Postal, String pTelefono, String pLocalidad, String pTipo_DocNom)
    {

      
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Dni = pDni;
            this.Tipo_dni = pTipo_dni;
            this.Mail = pMail;
            this.Fecha_Nac = pFecha_Nac;
            this.Dom_Calle = pDom_Calle;
            this.Nro_Calle = pNro_Calle;
            this.Piso = pPiso;
            this.Cod_Postal = pCod_Postal;
            this.Telefono = pTelefono;
            this.Localidad = pLocalidad;
            this.Tipo_DocNom = pTipo_DocNom;

    }
}
}