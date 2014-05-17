﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Abm_Cliente
{
    class Cliente
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Mail { get; set; }
        public Int64 Id { get; set; }
        public Int64 Dni { get; set; }
        public String Fecha_Nac { get; set; }
        public String Dom_Calle { get; set; }
        public Int64 Nro_Calle { get; set; }
        public Int64 Piso { get; set; }
        public String Dpto { get; set; }
        public String Cod_Postal { get; set; }
        public Int16 Tipo_dni { get; set; }
        public String Telefono { get; set; }
    
    public Cliente() {}
    public Cliente(Int64 pId,String pNombre, String pApellido, Int64 pDni, Int16 pTipo_dni, String pMail,String pFecha_Nac,
        String pDom_Calle, Int64  pNro_Calle, Int64 pPiso, String pDpto, String pCod_Postal, String pTelefono ){

            this.Id = pId;
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

    }
}
}