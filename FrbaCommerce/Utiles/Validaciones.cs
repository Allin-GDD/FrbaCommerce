﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;


namespace FrbaCommerce.Utiles
{
    class Validaciones
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //NOSE
        public static void validarUsuario(int retorno)
        {
            if (retorno != 1)
            {
                throw new Excepciones.InexistenciaUsuario("Usuario no válido");
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
        public static void ValidarTipoDecimalPublicacion(params TextBox[] parametroTxtBox)
        {
            int i = 0;
            Decimal expectedDecimal;
            foreach (TextBox parametro in parametroTxtBox)
            {
                if ((!Decimal.TryParse(parametro.Text, out expectedDecimal) && parametro.Enabled == true && parametro.Name != "textBox5" && parametro.Name != "textBox1") || (string.IsNullOrEmpty(parametro.Text) && parametro.Name != "textBox1" && parametro.Enabled == true) || (string.IsNullOrEmpty(parametro.Text) && parametro.Name == "textBox1"))
                {
                    parametro.BackColor = Color.Coral;
                    i++;
                }
                else if (parametro.BackColor == Color.Coral)
                {
                    parametro.BackColor = Color.White;
                }
            }
            if (i > 0)
            {
                throw new Excepciones.ValoresConTiposDiferentes("Complete los campos señalados con datos válidos");
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////
        //USADOS EN evaluarUsuario()

        public static int validarDatosText(Form ofrm)
        {//VALIDA TODOS LOS TXT MENOS EL DEPTO Y EL PISO
            {
                int i = 0;
                Action<Control.ControlCollection> func = null;
                func = (controls) =>
                {
                    foreach (Control control in controls)
                        if (control is TextBox)
                        {
                            if (string.IsNullOrEmpty(control.Text) && (control.Name != "txtNroPiso") && (control.Name != "txtDpto"))
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
        public static int validarDatosMask2(Form ofrm)
        {
            int i = 0;
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is MaskedTextBox)
                    {
                        if (!(control as MaskedTextBox).MaskCompleted)
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
        public static bool ValidarFecha(MaskedTextBox fecha)
        {
            DateTime fechaLimiteInferior = new DateTime(1800, 1, 1, 0, 0, 0);
            DateTime fechaLimiteSuperior = new DateTime(3000, 1, 1, 0, 0, 0);
            DateTime time = DateTime.Parse(fecha.Text);


            int i = time.CompareTo(fechaLimiteInferior);
            int j = time.CompareTo(fechaLimiteSuperior);

            if ((i <= 0) || (j >= 0))
            {
                return true;
                //throw new Excepciones.ValoresConTiposDiferentes("La Fecha ingresada no es valida. Estas fuera del rango disponible"); 

            }
            return false;


        }
        public static bool ValidarTipoDecimal(TextBox txt)
        {
            Decimal expectedDecimal;
            if (!Decimal.TryParse(txt.Text, out expectedDecimal))
            {
                return true;
            }
            return false;
        }


        //////////////////////////////////////////////////////////////////////////////////////////////
        //EL CAPO
        public static void evaluarUsuario(Entidades.Ent_ValidacionesUtil txtUtil, Form ofrm)
        {
            List<String> errores = new List<string>();
            Utiles.LimpiarTexto.BlanquearControls(ofrm);

            if (validarDatosText(ofrm) + validarDatosMask2(ofrm) > 0)
            { errores.Add("Los datos marcados son obligatorios"); }

            { errores.Add("Los datos en 'negrita' no son correctos para ese tipo de campo"); }

            if (!string.IsNullOrEmpty(txtUtil.Piso.Text) && Utiles.Validaciones.ValidarTipoDecimal(txtUtil.Piso))
            { errores.Add("El tipo del número del piso no es válido"); }

            if (!string.IsNullOrEmpty(txtUtil.NroCalle.Text) && Utiles.Validaciones.ValidarTipoDecimal(txtUtil.NroCalle))
            { errores.Add("El tipo del número del calle no es válido"); }

            if ((txtUtil.DNI != null) && !string.IsNullOrEmpty(txtUtil.DNI.Text) && Utiles.Validaciones.ValidarTipoDecimal(txtUtil.DNI))
            { errores.Add("El tipo del número del DNI no es válido"); }


            if (txtUtil.Fecha.MaskCompleted && Utiles.Validaciones.ValidarFecha(txtUtil.Fecha))
            { errores.Add("La Fecha ingresada no es válida. Está fuera del rango disponible"); }


            if ((txtUtil.TelefonoAnt == null) && Datos.Dat_Telefonos.validarTelefono(txtUtil.Telefono.Text))
            { errores.Add("El teléfono ingresado pertenece a otro usuario"); }


            if ((txtUtil.DNI != null) && (!string.IsNullOrEmpty(txtUtil.DNI.Text) && (txtUtil.DNIAnt == null)) || ((txtUtil.DNIAnt != null) && (txtUtil.DNI.Text != txtUtil.DNIAnt.Text)))
            {
                if (Datos.Dat_Dni.validarDni(txtUtil.DNI))
                {
                    errores.Add("El número de documento ingresado ya pertenece a otro cliente");
                }
            }

            if ((txtUtil.CUIT != null) && (!string.IsNullOrEmpty(txtUtil.CUIT.Text) && (txtUtil.CUITAnt == null)) || ((txtUtil.CUITAnt != null) && (txtUtil.CUIT.Text != txtUtil.CUITAnt.Text)))
            {
                if (Datos.Dat_Cuit.validarCuit(txtUtil.CUIT))
                { errores.Add("El número de CUIT ingresado ya pertenece a otra empresa"); }
            }



            String mensajesDeError = Utiles.AyudaVarias.mensaje(errores);

            if (errores.Count > 0)
            {
                errores.Clear();
                throw new Excepciones.ValoresConTiposDiferentes(mensajesDeError);
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////

        public static void evaluarRol(TextBox txtNombre, Form ofrm)
        {
            List<String> errores = new List<string>();
            Utiles.LimpiarTexto.BlanquearControls(ofrm);

            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                errores.Add("Los datos marcados son obligatorios");

                if (Datos.Dat_Rol.verificarSiElRolYaExiste(txtNombre.Text))
                {
                    errores.Add("El nombre del rol ya pertenece a otro rol existente");
                }
            }
            String mensajesDeError = Utiles.AyudaVarias.mensaje(errores);

            if (errores.Count > 0)
            {
                errores.Clear();
                throw new Excepciones.ValoresConTiposDiferentes(mensajesDeError);
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

        //////////////////////////////////////////////////////////////////////////////////////////////

        public static void validarVisibilidad(Form ofrm)
        {
            int i = validarDatosVisibilidad(ofrm);
        }

        public static bool ValidarTipoDouble(TextBox txt)
        {
            Double expectedDouble;
            if (!Double.TryParse(txt.Text, out expectedDouble))
            {
                return true;
            }
            return false;
        }
        public static void validarValorMayorAPrecio(decimal codigoPub, double precioOfertado)
        {

            double precioBase = 0;


            using (SqlConnection conn = DBConexion.obtenerConexion())
            {
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarPrecio", conn,
                    new SqlParameter("@Cod_Pub", codigoPub));
                SqlDataReader lectura = cmd.ExecuteReader();
                while (lectura.Read())
                {

                    precioBase = Convert.ToDouble(lectura.GetDecimal(0));
                }


                if (precioOfertado <= precioBase)
                {
                    throw new Excepciones.ValorMenor("El valor ingresado es menor al precio base");

                }
                conn.Close();
            }
        }


        public static void validarValorMayorAUltOferta(decimal codigoPub, double precioOfertado)
        {
            double precioMayorOferta = 0;
            using (SqlConnection conn2 = DBConexion.obtenerConexion())
            {

                SqlCommand cmd2 = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarMaximaOferta", conn2,
                      new SqlParameter("@Cod_Pub", codigoPub));
                SqlDataReader lectura2 = cmd2.ExecuteReader();

                if (lectura2!= null)
                {
                     while (lectura2.Read())
                  {
                 precioMayorOferta = Convert.ToDouble(lectura2.GetDecimal(0));


                 }
                }
                if (precioOfertado <= precioMayorOferta)
                {
                    throw new Excepciones.ValorMenor("El valor ingresado es menor a la última oferta realizada");

                }
                conn2.Close();
            }

        }

        public static void verificarMismoUsuario(decimal codigo, decimal id)
        {
            decimal idusuario = 0;
            
            using (SqlConnection conexion = DBConexion.obtenerConexion())
            {

                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarIdUsuario", conexion,
                   new SqlParameter("@Cod_Pub", codigo));
                SqlDataReader lectura = cmd.ExecuteReader();
                string publicador ;
                publicador = "E";
                while (lectura.Read())
                {

                    idusuario = lectura.GetDecimal(0);
                    publicador = lectura.GetString(1);
                }


                if (id == idusuario && publicador == "C")
                {
                     throw new Excepciones.DuplicacionDeDatos("No se puede realizar una oferta a una publicacion propia");

                }
                conexion.Close();
            }

        }
    }
}
        