using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.Entidades;

namespace FrbaCommerce.Utiles
{
    class Tipo_Publicaciones
    {
        public static List<Ent_TipoPub> listaPublicacion()
        {
            List<Ent_TipoPub> listaPub = new List<Ent_TipoPub>();

            Ent_TipoPub tipoSubasta = new Ent_TipoPub();
            tipoSubasta.tipo = "Subasta";


            Ent_TipoPub tipoInmediato = new Ent_TipoPub();
            tipoInmediato.tipo = "Compra inmediata";

            listaPub.Add(tipoSubasta);

            listaPub.Add(tipoInmediato);

            return listaPub;
        }
    }
}