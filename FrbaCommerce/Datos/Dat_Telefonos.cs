using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Datos
{
    class Dat_Telefonos
    {
        public static void validarTelefono(Entidades.Ent_Telefono ptelefono)
        {
            List<Entidades.Ent_Telefono> listaDeTelefonos = Datos.Dat_Cliente.obtenerTodosLosTelefonos();

            foreach (Entidades.Ent_Telefono telefono in listaDeTelefonos){
                if (ptelefono == telefono) { 
                throw new Excepciones.DuplicacionDeDatos("El número ingresado ya pertenece a otro cliente");
                }
            }


        }
    }
}
