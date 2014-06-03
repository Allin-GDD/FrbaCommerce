﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace FrbaCommerce.Utiles
{
    class Validaciones
    {
        public static void NulidadDeDatosIngresados(Form ofrm, TextBox Dpto, TextBox NroPiso, params MaskedTextBox[] parametrosDeMask)
        {
            int i = 0;

            Utiles.LimpiarTexto.BlanquearControls(ofrm);
   
            i = validarDatosText(Dpto, NroPiso, ofrm) + validarDatosMask(parametrosDeMask);

            if (i > 0)
            {
                throw new Excepciones.NulidadDeCamposACompletar("Faltan completar los siguientes campos");
            }
        }

        private static int validarDatosText(TextBox Dpto,TextBox NroPiso,Form ofrm)
{
 	       {
            int i = 0;
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                    {
                        if (string.IsNullOrEmpty(control.Text) && (control != Dpto) && (control != NroPiso))
                        {
                            control.BackColor = Color.Coral;
                            i++;
                        }

                    }

                    else { func(control.Controls); }
            };
           
            func(ofrm.Controls);
            return i;
        }
}

        private static int validarDatosMask(MaskedTextBox[] parametrosDeMask)
        {
            int i = 0;
            foreach (MaskedTextBox parametro in parametrosDeMask)
            {
                if (!parametro.MaskCompleted)
                {
                    parametro.BackColor = Color.Coral;
                    i++;
                }
            }
            return i;
        }


        public static void ValidarFecha(string p)
        {
            DateTime fechaLimiteInferior = new DateTime(1800, 1, 1, 0, 0, 0);
            DateTime fechaLimiteSuperior = new DateTime(3000, 1, 1, 0, 0, 0);
            DateTime time = DateTime.Parse(p);


            int i = time.CompareTo(fechaLimiteInferior);
            int j = time.CompareTo(fechaLimiteSuperior);

            if ((i <= 0) || (j >= 0))
            {
                throw new Excepciones.ValoresConTiposDiferentes("La Fecha ingresada no es valida. Estas fuera del rango disponible");

            }


        }


        public static void ValidarTipoDni(string p)
        {
            Decimal expectedDecimal;
            if (!Decimal.TryParse(p, out expectedDecimal))
            {
                throw new Excepciones.ValoresConTiposDiferentes("Se están ingresando datos no validos en el campo DNI");
            }
        }

        public static void ValidarTipoNroCalle(string p)
        {
            Decimal expectedDecimal;
            if (!Decimal.TryParse(p, out expectedDecimal))
            {
                throw new Excepciones.ValoresConTiposDiferentes("Se están ingresando datos no validos en el campo Número de Calle");

            }
        }

        public static void ValidarTipoPiso(string p)
        {
            Decimal expectedDecimal;
            if (!Decimal.TryParse(p, out expectedDecimal))
            {
                throw new Excepciones.ValoresConTiposDiferentes("Se están ingresando datos no validos en el campo Piso");
            }

        }

      
    }

 
 

      
    }
