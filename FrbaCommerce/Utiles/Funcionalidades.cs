using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Utiles
{
    class Funcionalidades
    {
        public static List<String> listaDeFuncionalidades()
        {
            List<String> listaFunc = new List<string>();

            listaFunc.Add("Dar de Alta a cliente");
            listaFunc.Add("Dar de Alta a empresa");
            //HAY QUE MANDAR TODAS LAS FUNCIONALIDADES


            return listaFunc;
        }
        public static void agregarAListaDeFuncionalidades(string funcionalidad) {
            listaDeFuncionalidades().Add(funcionalidad);

        }
    }
}
