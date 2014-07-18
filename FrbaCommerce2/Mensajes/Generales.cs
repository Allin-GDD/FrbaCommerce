using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace FrbaCommerce.Mensajes
{
    class Generales
    {
        public static void validarBaja(int retorno)
        {
            if (retorno > 0)
            {
                Mensajes.Exitos.ExitoAlBorrarLosDatos();
            }
            else { Mensajes.Errores.ErrorAlBorrarDatos(); }
        }

        public static void validarAlta(int retorno)
        {
            if (retorno > 0)
            {
                Mensajes.Exitos.ExitoAlGuardaLosDatos();
            }
            else
            {
                Mensajes.Errores.ErrorAlGuardarDatos();
            }
        }

        public static void valirUsuarioCliente(int retorno)
        {
            if (retorno == 0)
            {
                Mensajes.Errores.ErrorAlGuardarDatos();
            }
        }

        public static void evaluarErrores(List<string> errores)
        {
            errores.RemoveAll(string.IsNullOrEmpty);
            String mensajesDeError = Utiles.AyudaVarias.mensaje(errores);

            if (errores.Count > 0)
            {
                errores.Clear();
                throw new Excepciones.ValoresConTiposDiferentes(mensajesDeError);
            }
        }

        public static String evaluarNroPiso(TextBox textBox)
        {
            String ii = null;
            if ((!string.IsNullOrEmpty(textBox.Text)) && Utiles.Validaciones.ValidarTipoDecimal(textBox))
            {
                ii = ("El tipo del número del piso no es válido");
            }
            return ii;
        }

        public static String evaluarNroCalle(TextBox textBox)
        {
            String ii = null;
            if (!string.IsNullOrEmpty(textBox.Text) && Utiles.Validaciones.ValidarTipoDecimal(textBox))
            {
                ii = ("El tipo del número del calle no es válido");
            }
            return ii;
        }

        public static String evaluarMail(TextBox textBox)
        {
            String ii = null;
            string st = Convert.ToString(textBox);
            if (st.IndexOf('@')==0)
            {
                ii = ("El tipo de mail no es valido");
            }
            return ii;
        }

        public static String evaluarFecha(MaskedTextBox Fecha)
        {
            String ii = null;

            try
               
            {
                if (Fecha.MaskCompleted && Utiles.Validaciones.ValidarFechaParaUsuario(Fecha)) {
                    ii = ("La fecha deberá ser menor a la fecha del sistema"); }
                
                else if (Fecha.MaskCompleted && Utiles.Validaciones.ValidarFecha(Fecha))
                { ii = ("La fecha está fuera del rango disponible"); }
                return ii;
            }
            catch (Exception)
            {
                ii = ("La fecha ingresada no es válida");
                Fecha.BackColor = Color.Coral;
                return ii;
            }
        }

        public static String evaluarTel(MaskedTextBox Telefono, String TelefonoAnt,bool isCliente)
        {
            String ii = null;
           if(TelefonoAnt == null || TelefonoAnt != Telefono.Text)

           {
                if(Datos.Dat_Telefonos.validarTelefono(Telefono.Text,isCliente)){
                Telefono.BackColor = Color.Coral;
                ii = ("El teléfono ingresado pertenece a otro usuario");
            }
            }
            
            return ii;
        }



        public static List<String> evaluarCodVisibilidad(TextBox codigo, String codigoAnt)
        {
            List<String> errores = new List<string>();
            if (!string.IsNullOrEmpty(codigo.Text) && Utiles.Validaciones.ValidarTipoDecimal(codigo))
            {
                errores.Add("El tipo de Código no es válido");
            }

            if (!string.IsNullOrEmpty(codigo.Text) && !Utiles.Validaciones.ValidarTipoDecimal(codigo))
            {
                if (codigoAnt == null || (codigoAnt != codigo.Text))
                {
                    if (Datos.Dat_Visibilidad.validarCodigoDeVis(codigo))
                    {
                        errores.Add("El código ya es utilizado por otro rol");
                    }
                }
            }
            return errores;
        }

        public static List<String> evaluarPorcentajeVisib(TextBox promedio)
        {
            List<String> errores = new List<string>();
            Decimal expectedDecimal;
            Double valor = 1.00;

            if (!string.IsNullOrEmpty(promedio.Text) && !Decimal.TryParse(promedio.Text, out expectedDecimal))
            {
                promedio.BackColor = Color.Coral;
                errores.Add("El tipo de promedio no es válido");
            }
            if (!string.IsNullOrEmpty(promedio.Text) && Decimal.TryParse(promedio.Text, out expectedDecimal) && Convert.ToDouble(promedio.Text) > valor)
            {
                promedio.BackColor = Color.Coral;
                errores.Add("El valor ingresado en promedio tiene que ser menor a 1");
            }
            return errores;
        }

        public static String evaluarVencimientoVisib(TextBox Venc)
        {
            int expectedInt;
            String ii = null;
            if (!string.IsNullOrEmpty(Venc.Text) && !int.TryParse(Venc.Text, out expectedInt))
            {
                ii = "El valor ingresado en vencimiento no es válido";
                Venc.BackColor = Color.Coral;
            }
            return ii;
        }

        public static String evaluarDescripVisib(TextBox descp, String descpAnt)
        {
            String ii = null;
            if (!string.IsNullOrEmpty(descp.Text) && (descpAnt == null || (descpAnt != null && descpAnt != descp.Text)))
            {
                if (Datos.Dat_Visibilidad.validarDescripcion(descp))
                {
                    ii = ("La descipción que quiere agregar ya le pertenece a otra visibilidad");
                }
            }
            return ii;
        }

        public static String evaluarPrecioVisib(TextBox Precio)
        {
            String ii = null;
            if (!string.IsNullOrEmpty(Precio.Text) && Utiles.Validaciones.ValidarTipoDecimal(Precio))
            {
                ii = ("El tipo de precio no es válido");
            }
            return ii;
        }

        internal static String evaluarDocumento(short tipo, MaskedTextBox Doc, String DocAnt)
        {
            String ii = null;

               if ((DocAnt == null || DocAnt != Doc.Text )&& Datos.Dat_Dni.validarDni(Doc, tipo))
                {
                    ii = ("El número de documento ingresado ya pertenece a otra Cliente");
                }

                return ii;

            
        }

        internal static string evaluarCUIT(MaskedTextBox cuit, String cuitAnt)
        {
            String ii = null;
            if ((cuitAnt == null ||cuitAnt != cuit.Text ) && Datos.Dat_Cuit.validarCuit(cuit))
            {
                ii = ("El número de documento ingresado ya pertenece a otra Empresa");
            }
            return ii;
        }





        internal static string evaluarRazonSocial(TextBox razonSocial, String razonSocialAnt)
        {    
            String ii = null;
            if ((razonSocialAnt == null || razonSocialAnt != razonSocial.Text) && Datos.Dat_Empresa.validarRazonSocial(razonSocial))
            {
                ii = ("La razón social ingresada pertenece a otra Empresa");
            }
            return ii;
        }
    }
}