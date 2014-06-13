﻿using System;
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
            if (retorno > 0)
            {
                MessageBox.Show("El usuario por default es su mail y la contraseña el número de documento ingresado", "Guardar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Mensajes.Errores.ErrorAlGuardarDatos();
            }
        }

        public static void evaluarErrores(List<string> errores)
        {
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

        public static List<String> evaluarDNI(TextBox DNI, TextBox DNIant)
        {
            List<String> errores = new List<string>();

            if ((DNI != null) && !string.IsNullOrEmpty(DNI.Text) && Utiles.Validaciones.ValidarTipoDecimal(DNI))
            {
                errores.Add("El tipo del número del DNI no es válido");
            }
            if ((DNI != null) && (!string.IsNullOrEmpty(DNI.Text) && (DNIant == null)) || ((DNIant != null) && (DNI.Text != DNIant.Text)))
            {
                if (!Utiles.Validaciones.ValidarTipoDecimal(DNI) && Datos.Dat_Dni.validarDni(DNI))
                {
                    errores.Add("El número de documento ingresado ya pertenece a otro cliente");
                }
            }

            return errores;
        }

        public static String evaluarFecha(MaskedTextBox Fecha)
        {
            String ii = null;
            if (Fecha.MaskCompleted && Utiles.Validaciones.ValidarFecha(Fecha))
            { ii = ("La Fecha ingresada no es válida. Está fuera del rango disponible"); }
            return ii;
        }

        public static String evaluarTel(MaskedTextBox Telefono, MaskedTextBox TelefonoAnt)
        {
            String ii = null;
            if ((TelefonoAnt == null) && Datos.Dat_Telefonos.validarTelefono(Telefono.Text))
            {
                Telefono.BackColor = Color.Coral;
                ii = ("El teléfono ingresado pertenece a otro usuario");
            }
            return ii;
        }

        public static String evaluarCUIT(MaskedTextBox CUIT, MaskedTextBox CUITAnt)
        {
            String ii = null;

            if ((CUIT != null) && (!string.IsNullOrEmpty(CUIT.Text) && (CUITAnt == null)) || ((CUITAnt != null) && (CUIT.Text != CUITAnt.Text)))
            {
                if (Datos.Dat_Cuit.validarCuit(CUIT))
                { ii = ("El número de CUIT ingresado ya pertenece a otra empresa"); }
            }
            return ii;
        }

        public static List<String> evaluarCodVisibilidad(TextBox codigo,TextBox codigoAnt)
        {
            List<String> errores = new List<string>();
            if (!string.IsNullOrEmpty(codigo.Text) && Utiles.Validaciones.ValidarTipoDecimal(codigo))
            {
                errores.Add("El tipo de Código no es válido");
            }
            if (!string.IsNullOrEmpty(codigo.Text) && !Utiles.Validaciones.ValidarTipoDecimal(codigo) && (codigoAnt == null || (codigoAnt != null && codigoAnt.Text != codigo.Text)))
            {
                if(Datos.Dat_Visibilidad.buscarVisibilidad(Convert.ToInt32(codigo.Text)) != null){
                errores.Add("El código ya es utilizado por otro rol");
            }
            }
             
            return errores;
        }

        public static List<String> evaluarPorcentajeVisib(TextBox promedio)
        {
            List<String> errores = new List<string>();
            Decimal expectedDecimal;
            Double valor = 1.00;

            if (!string.IsNullOrEmpty(promedio.Text)&& !Decimal.TryParse(promedio.Text, out expectedDecimal))
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

        public static String evaluarDescripVisib(TextBox descp, TextBox descpAnt)
        {
            String ii = null;
            if (!string.IsNullOrEmpty(descp.Text)&& (descpAnt == null ||( descpAnt != null && descpAnt.Text != descp.Text)))
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
    }
}