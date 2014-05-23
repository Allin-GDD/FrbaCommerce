using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Datos
{
    class Dat_Dni
    {
        public static void validarDni(Entidades.Ent_Dni pdni)
        {
            List<Entidades.Ent_Dni> listaDni = Datos.Dat_Cliente.obtenerTodosLosDni();

            foreach (Entidades.Ent_Dni dni in listaDni)
            {
                if (pdni == dni)
                {
                    throw new Excepciones.DuplicacionDeDatos("El documento ingresado ya pertenece a otro cliente");
                }
            }


        }
    }
}
