using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Utiles
{
    class Funcionalidades
    {
        public static List<Entidades.Ent_Funcionalidad> listaDeFuncionalidades()
        {
            List<Entidades.Ent_Funcionalidad> listaFunc = new List<Entidades.Ent_Funcionalidad>();


            Entidades.Ent_Funcionalidad altaEmpresa = crearFuncionabilidad("Dar de Alta Empresa", 2);
            listaFunc.Add(altaEmpresa);
            Entidades.Ent_Funcionalidad altaCliente = crearFuncionabilidad("Dar de Alta Cliente", 1);
            listaFunc.Add(altaCliente);

            return listaFunc;
        }

        private static Entidades.Ent_Funcionalidad crearFuncionabilidad(string campo, int id)
        {
            Entidades.Ent_Funcionalidad funcionabilidad = new Entidades.Ent_Funcionalidad();
            funcionabilidad.id = id;
            funcionabilidad.funcionalidad = campo;
            return funcionabilidad;
        }
      
    }
}
