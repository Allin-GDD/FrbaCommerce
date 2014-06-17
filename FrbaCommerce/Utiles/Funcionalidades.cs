using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.Entidades;

namespace FrbaCommerce.Utiles
{
    class Funcionalidades
    {
        public static List<Ent_Funcionalidad> listaDeFuncionalidades()
        {
            List<Ent_Funcionalidad> listaFunc = new List<Ent_Funcionalidad>();


            listaFunc.Add(crearFuncionabilidad("Ejecutar ABM Cliente", 1));
            listaFunc.Add(crearFuncionabilidad("Ejecutar ABM Empresa", 2));
            listaFunc.Add(crearFuncionabilidad("Ejecutar ABM Rol", 3));
            listaFunc.Add(crearFuncionabilidad("Ejecutar ABM Visibilidad", 4));
            listaFunc.Add(crearFuncionabilidad("Cambiar contraseña a los usuarios", 5));
            listaFunc.Add(crearFuncionabilidad("Mostrar listado estadístico", 6));
 
            //LO QUE HACE EL USUARIO(CLIENTE, EMPRESA)
            listaFunc.Add(crearFuncionabilidad("Publicar subasta", 10));
            listaFunc.Add(crearFuncionabilidad("Publicar compra inmediata", 11));
            listaFunc.Add(crearFuncionabilidad("Facturar publicaciones", 12));
            listaFunc.Add(crearFuncionabilidad("Mostrar historial", 13));
            listaFunc.Add(crearFuncionabilidad("calificar Vendedor", 14));
            listaFunc.Add(crearFuncionabilidad("Ejecutar gestor de preguntas", 15));
            
           


            return listaFunc;
        }

        private static Ent_Funcionalidad crearFuncionabilidad(string campo, int id)
        {
            Ent_Funcionalidad funcionabilidad = new Ent_Funcionalidad();
            funcionabilidad.id = id;
            funcionabilidad.funcionalidad = campo;
            return funcionabilidad;
        }
      
    }
}
