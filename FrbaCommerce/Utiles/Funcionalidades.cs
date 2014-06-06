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


            Ent_Funcionalidad altaCliente = crearFuncionabilidad("Dar de alta un cliente", 1);
            listaFunc.Add(altaCliente);
            Ent_Funcionalidad altaEmpresa = crearFuncionabilidad("Dar de alta una empresa", 2);
            listaFunc.Add(altaEmpresa);
            Ent_Funcionalidad bajaCliente = crearFuncionabilidad("Dar de baja un cliente", 3);
            listaFunc.Add(bajaCliente);
            Ent_Funcionalidad bajaEmpresa = crearFuncionabilidad("Dar de baja una empresa", 4);
            listaFunc.Add(bajaEmpresa);
            Ent_Funcionalidad listSelecionad = crearFuncionabilidad("Listado de usuario seleccionado", 5);
            listaFunc.Add(listSelecionad);
            Ent_Funcionalidad modEmpresa = crearFuncionabilidad("Modificar datos de empresa", 6);
            listaFunc.Add(modEmpresa);
            Ent_Funcionalidad modifCliente = crearFuncionabilidad("Modificar datos de cliente", 7);
            listaFunc.Add(modifCliente);
            Ent_Funcionalidad bajaRol = crearFuncionabilidad("Dar de baja un rol", 2);
            listaFunc.Add(bajaRol);
            Ent_Funcionalidad listRol = crearFuncionabilidad("Listado de un rol seleccionado", 8);
            listaFunc.Add(listRol);
            Ent_Funcionalidad modifRol = crearFuncionabilidad("Modificar datos de rol", 9);
            listaFunc.Add(modifRol);


            //LO QUE HACE EL USUARIO(CLIENTE, EMPRESA)
            Ent_Funcionalidad subasta = crearFuncionabilidad("Publicar subasta", 10);
            listaFunc.Add(subasta);
            Ent_Funcionalidad compraInmediata = crearFuncionabilidad("Publicar compra inmediata", 11);
            listaFunc.Add(compraInmediata);
            Ent_Funcionalidad facturarPubli = crearFuncionabilidad("Facturar publicaciones", 12);
            listaFunc.Add(facturarPubli);
            Ent_Funcionalidad mostrarHistorial = crearFuncionabilidad("Mostrar historial", 13);
            listaFunc.Add(mostrarHistorial);
            
           


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
