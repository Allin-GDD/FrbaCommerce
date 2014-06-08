using System;
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
                Mensajes.Errores.FaltaDeCampos();

            }
        }

        public static void NulidadDeDatosIngresadosVisibilidad(Form ofrm, params MaskedTextBox[] parametrosDeMask)
        {
            int i = 0;

            Utiles.LimpiarTexto.BlanquearControls(ofrm);

            i = validarDatosVisibilidad(ofrm);

            if (i > 0)
            {
                throw new Excepciones.NulidadDeCamposACompletar("Faltan completar los siguientes campos");
            }
        }

        public static int validarDatosText(TextBox Dpto, TextBox NroPiso, Form ofrm)
        {//VALIDA TODOS LOS TXT MENOS EL DEPTO Y EL PISO
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

        public static int validarDatosVisibilidad(Form ofrm)
        {
            {
                int i = 0;
                Action<Control.ControlCollection> func = null;
                func = (controls) =>
                {
                    foreach (Control control in controls)
                        if (control is TextBox)
                        {
                            if (string.IsNullOrEmpty(control.Text))
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

        public static int validarDatosMask(MaskedTextBox[] parametrosDeMask)
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

   
        public static void ValidarFuncionablidadRepetida(decimal rol, int func)
        {
            List<int> listaDeFunc = new List<int>();

            listaDeFunc = Datos.Dat_Rol.buscarFuncDe(rol);

            foreach (int funcional in listaDeFunc)
                if (func == funcional)
                {
                    throw new Excepciones.DuplicacionDeDatos("La funcionalidad que intenta agregar ya la posee el rol");
                }

        }

        public static void validarDatosText(TextBox[] parametrosTB)
        {//Todavia no lo use, lo dejo por las dudas
            int i = 0;
            foreach (TextBox param in parametrosTB)
            {
                if (String.IsNullOrEmpty(param.Text))
                {
                    param.BackColor = Color.Coral;
                    i++;

                }
            }
            if (i > 0)
            {
                Mensajes.Errores.FaltaDeCampos();
            }
        }

        public static void validarUnaSolaNulidad(TextBox txt)
        {
            if (String.IsNullOrEmpty(txt.Text))
            {
                txt.BackColor = Color.Coral;
                Mensajes.Errores.FaltaDeCampos();
            }
        }

        public static void validarUsuario(int retorno)
        {
            if (retorno != 1) {
                throw new Excepciones.InexistenciaUsuario("Usuario no válido");
            }
        }
        
        
        public static void ValidarTipoDecimal(params TextBox[] parametroTxtBox)
        {
            int i = 0;
            Decimal expectedDecimal;
            foreach (TextBox parametro in parametroTxtBox)
            {
                if (!Decimal.TryParse(parametro.Text, out expectedDecimal))
                {
                    parametro.BackColor = Color.Coral;
                    i++;
                }
            }
            if (i > 0)
            {
                throw new Excepciones.ValoresConTiposDiferentes("Se están ingresando datos no válidos en el campo señalados");
            }
        }

    }
}
