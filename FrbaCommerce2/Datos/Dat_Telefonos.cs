using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Datos
{
    class Dat_Telefonos
    {
        public static bool validarTelefono(string ptelefono,bool isCliente)
        {
            List<Entidades.Ent_Telefono> listaDeTelefonos;

            if (isCliente)
            {
                 listaDeTelefonos= Datos.Dat_Cliente.obtenerTodosLosTelefonos();
            }
            else {
                listaDeTelefonos = Datos.Dat_Empresa.obtenerTodosLosTelefonos();
            }

            foreach (Entidades.Ent_Telefono telefono in listaDeTelefonos){

                if (ptelefono == telefono.Telefono) {
                    return true;
                }
                }
            return false;

        }
    }
}
