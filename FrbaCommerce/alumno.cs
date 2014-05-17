using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce
{
    public class alumno
    {
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String edad { get; set; }
   
        public alumno(){ }
        
            public alumno(String pnombre, String pApey, String pEdad)
            {
                this.nombre = pnombre;
                this.apellido = pApey;
                this.edad = pEdad;
            }
         }
}
