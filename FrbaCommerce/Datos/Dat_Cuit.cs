using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Datos


{
    class Dat_Cuit
    {
        public static void validarCuit(string pCuit)
        {
           List<Entidades.Ent_Cuit> listaCuit = Datos.Dat_Empresa.obtenerTodosLosCuit();

            foreach (Entidades.Ent_Cuit cuit in listaCuit)
            {
                if (pCuit == cuit.CUIT)
                {
                    throw new Excepciones.DuplicacionDeDatos("El número de Cuit ingresado ya pertenece a otra Empresa");
                }
            }


        }
    }
}
