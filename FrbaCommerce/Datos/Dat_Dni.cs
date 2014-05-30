﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Datos
{
    class Dat_Dni
    {
        public static void validarDni(Entidades.Ent_Dni pdni)
        {
           List<Entidades.Ent_Dni> listaDnies = Datos.Dat_Cliente.obtenerTodosLosDni();

            foreach (Entidades.Ent_Dni dni in listaDnies)
            {
                if (pdni.Dni == dni.Dni)
                {
                    throw new Excepciones.DuplicacionDeDatos("El número de documento ingresado ya pertenece a otro cliente");
                }
            }


        }
    }
}