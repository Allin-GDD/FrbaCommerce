using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Datos
{
    class Dat_Telefonos
    {
        public static void validarTelefono(string ptelefono)
        {
            List<Entidades.Ent_Telefono> listaDeTelefonos = Datos.Dat_Cliente.obtenerTodosLosTelefonos();

            foreach (Entidades.Ent_Telefono telefono in listaDeTelefonos){

                if (ptelefono == telefono.Telefono) { 
                throw new Excepciones.DuplicacionDeDatos("El número de telefono ingresado ya pertenece a otro cliente");
                }
            }


        }
    }
}
