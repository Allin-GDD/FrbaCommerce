using System;
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

        //Publicacion


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

        public static void ValidarFuncionalidadRepetida(decimal rol, int func)
        {
            List<Entidades.Ent_Funcionalidad> listaDeFunc = Datos.Dat_Funcionalidad.listadoDeFuncionalidades(rol) ;

            foreach (Entidades.Ent_Funcionalidad funcional in listaDeFunc)
                if (func == funcional.id)
                {
                    throw new Excepciones.DuplicacionDeDatos("La funcionalidad que intenta agregar ya la posee el rol");
                }


        }


        public static void ValidarTipoDecimalPublicacion(Decimal stockInicial, params TextBox[] parametroTxtBox) //funca
        {
            int i = 0;
            int j = 0;
            Decimal expectedDecimal;
            Decimal num = 0;
            foreach (TextBox parametro in parametroTxtBox)
            {
                if (parametro.Name == "textBox2" && parametro.Enabled && Decimal.TryParse(parametro.Text, out expectedDecimal))
                {
                    num = Convert.ToDecimal(parametro.Text);
                    if (num < stockInicial)
                    {
                        parametro.BackColor = Color.Coral;
                        j++;
                    }
                }
                if ((!Decimal.TryParse(parametro.Text, out expectedDecimal) && parametro.Enabled == true && parametro.Name != "textBox5" && parametro.Name != "textBox1") || (string.IsNullOrEmpty(parametro.Text) && parametro.Name != "textBox1" && parametro.Enabled == true) || (string.IsNullOrEmpty(parametro.Text) && parametro.Name == "textBox1"))
                {
                    parametro.BackColor = Color.Coral;
                    i++;
                }
                else if (parametro.BackColor == Color.Coral && j == 0)
                {
                    parametro.BackColor = Color.White;
                }
            }if (i > 0 && j == 0)
            {
                throw new Excepciones.ValoresConTiposDiferentes("Complete los campos señalados con datos válidos");
            }

            else if (j > 0)
            {
                throw new Excepciones.ValoresConTiposDiferentes("Complete los campos señalados con datos válidos, el stock no puede ser menor al publicado anteriormente");
            }
        }
        public static void ValidarVisibilidadGratuita(Decimal usuario) //funca
        {
            if (Datos.Dat_Publicacion.verificarTresGratuitas(usuario))
            {
                throw new Excepciones.ValoresConTiposDiferentes("No puede tener más de tres publicaciones gratuitas activas a la vez.");
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

        public static int validarDatosMask(Form ofrm)
        {
            int i = 0;
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is MaskedTextBox)
                    {
                        if ((!(control as MaskedTextBox).MaskCompleted || !(control as MaskedTextBox).MaskFull)&& (control as MaskedTextBox).Enabled == true)
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

            DateTime fechaLimiteSuperior = new DateTime(4000,12,31,0,0,0);

            DateTime time = DateTime.Parse(fecha.Text);


            int i = time.CompareTo(fechaLimiteInferior);
            int j = time.CompareTo(fechaLimiteSuperior);

            if ((i <= 0) || (j >= 0))
            {

                fecha.BackColor = Color.Coral;
                return true;

            }
            return false;


        }
        public static bool ValidarTipoDecimal(Control txt)
        {
            Decimal expectedDecimal;
            if (!Decimal.TryParse(txt.Text, out expectedDecimal))
            {

                txt.BackColor = Color.Coral;

                return true;
            }
            return false;
        }
        public static List<String> datosObligatorios(Form ofrm)
        {
            List<String> errores = new List<string>();
            Utiles.LimpiarTexto.BlanquearControls(ofrm);
            if ((validarDatosMask(ofrm) + validarDatosText(ofrm) + validarDatosCombo(ofrm)) > 0)
            {
                errores.Add("Los datos marcados son obligatorios");
            }
            return errores;
        }

        private static int validarDatosCombo(Form ofrm)
        {
            int i = 0;
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is ComboBox)
                    {
                        if ((control as ComboBox).Text == "")
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

        public static void validarDatosObligatorios(Form ofrm)
        {
            if (datosObligatorios(ofrm).Count > 0)
            {
                throw new Excepciones.NulidadDeCamposACompletar("Los datos marcados son obligatorios");
            };
        }

        //////////////////////////////////////////////////////////////////////////////////////////////
        //Evalua todas validaciones de los clientes y empresa
        public static void evaluarPersona(Entidades.Ent_TxtPersona txtUtil, Form ofrm)
        {
            bool isCliente = false;
            if (txtUtil.CUIT == null) isCliente = true;

            List<String> errores = datosObligatorios(ofrm);
            //se fija si el tipo es correcto
            if ((Mensajes.Generales.evaluarNroPiso(txtUtil.Piso) != null)) errores.Add(Mensajes.Generales.evaluarNroPiso(txtUtil.Piso));
            if ((Mensajes.Generales.evaluarNroCalle(txtUtil.NroCalle) != null)) errores.Add(Mensajes.Generales.evaluarNroCalle(txtUtil.NroCalle));

            //Se fija si la fecha esta dentro del rango     
            if ((Mensajes.Generales.evaluarFecha(txtUtil.Fecha) != null)) errores.Add(Mensajes.Generales.evaluarFecha(txtUtil.Fecha));
            
            // Se fija si el mail tiene un @
            if ((Mensajes.Generales.evaluarMail(txtUtil.Mail) != null)) errores.Add(Mensajes.Generales.evaluarMail(txtUtil.Mail));
            //se fija si no esta repetido
            if ((Mensajes.Generales.evaluarRazonSocial(txtUtil.RazonSocial, txtUtil.RazonSocialAnt) != null)) errores.Add(Mensajes.Generales.evaluarRazonSocial(txtUtil.RazonSocial,txtUtil.RazonSocialAnt));
            if ((Mensajes.Generales.evaluarTel(txtUtil.Telefono, txtUtil.TelefonoAnt,isCliente) != null)) errores.Add(Mensajes.Generales.evaluarTel(txtUtil.Telefono, txtUtil.TelefonoAnt,isCliente));
            if ((Mensajes.Generales.evaluarDocumento(txtUtil.TipoDoc, txtUtil.DNI, txtUtil.DNIAnt) != null)) errores.Add(Mensajes.Generales.evaluarDocumento(txtUtil.TipoDoc, txtUtil.DNI, txtUtil.DNIAnt));
            if ((Mensajes.Generales.evaluarCUIT(txtUtil.CUIT, txtUtil.CUITAnt) != null)) errores.Add(Mensajes.Generales.evaluarCUIT(txtUtil.CUIT, txtUtil.CUITAnt));

          

            Mensajes.Generales.evaluarErrores(errores);




        }
        //////////////////////////////////////////////////////////////////////////////////////////////
        //Cuando crear un usuario
        public static void validarUsuario(int retorno)
        {
            if (retorno != 1)
            {
                throw new Excepciones.InexistenciaUsuario("Usuario no válido");
            }
        }
        public static void controlDeUsuario(int retorno)
        {
            if (retorno != 0)
            {
                throw new Excepciones.InexistenciaUsuario("El usuario que está ingresando pertenece a otro usuario");
            }
        }

        public static String validarUnSoloTxt(TextBox txt) {

            String ii = null;

            if (string.IsNullOrEmpty(txt.Text))
            {
                txt.BackColor = Color.Coral;
                ii = "Los datos seleccionados son obligatorios";
                
            }
            return ii;
        }
        public static void evaluarRol(TextBox txtNombre, Form ofrm)
        {
            List<String> errores = datosObligatorios(ofrm);


            if (Datos.Dat_Rol.verificarSiElRolYaExiste(txtNombre.Text))
            {
                errores.Add("El nombre del rol ya pertenece a otro rol existente");
            }


            Mensajes.Generales.evaluarErrores(errores);


        }

        //////////////////////////////////////////////////////////////////////////////////////////////

        public static void evaluarVisibilidad(Form ofrm, Entidades.Ent_TxtVisibilidad util, String codigoAnt, String descripcionAnt)
        {
            List<String> errores = datosObligatorios(ofrm);

            if ((Mensajes.Generales.evaluarCodVisibilidad(util.Codigo, codigoAnt).Count > 0)) errores.AddRange(Mensajes.Generales.evaluarCodVisibilidad(util.Codigo, codigoAnt));

            if ((Mensajes.Generales.evaluarPorcentajeVisib(util.Porcentaje).Count > 0)) errores.AddRange(Mensajes.Generales.evaluarPorcentajeVisib(util.Porcentaje));

            if ((Mensajes.Generales.evaluarVencimientoVisib(util.Vencimiento) != null)) errores.Add(Mensajes.Generales.evaluarVencimientoVisib(util.Vencimiento));

            if ((Mensajes.Generales.evaluarDescripVisib(util.Descripcion, descripcionAnt) != null)) errores.Add(Mensajes.Generales.evaluarDescripVisib(util.Descripcion, descripcionAnt));

            if ((Mensajes.Generales.evaluarPrecioVisib(util.Precio) != null)) errores.Add(Mensajes.Generales.evaluarPrecioVisib(util.Precio));

            Mensajes.Generales.evaluarErrores(errores);
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
        public static void validarDistintoOfertadorUltOferta(decimal codigoPub, decimal id)
        {
            decimal idultofertador = 0;
            string s = "";
            using (SqlConnection conn2 = DBConexion.obtenerConexion())
            {

                SqlCommand cmd2 = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarIdMaximaOferta", conn2,
                      new SqlParameter("@Cod_Pub", codigoPub));
                SqlDataReader lectura2 = cmd2.ExecuteReader();

                //   if (lectura2 != null)
                {
                    while (lectura2.Read())
                    {


                        s = lectura2.IsDBNull(0) ? "" : Convert.ToString(lectura2.GetValue(0));



                    }
                    if (s.Equals("")) { } else { idultofertador = Convert.ToDecimal(s); }
                }
                if (id == idultofertador)
                {
                    throw new Excepciones.ValorMenor("Usted posee la oferta ganadora hasta el momento");

                }
                conn2.Close();
            }

        }
        public static void validarValorMayorAUltOferta(decimal codigoPub, double precioOfertado)
        {
            double precioMayorOferta = 0;
            string s = "";
            using (SqlConnection conn2 = DBConexion.obtenerConexion())
            {

                SqlCommand cmd2 = Utiles.SQL.crearProcedure("GD1C2014.dbo.buscarMaximaOferta", conn2,
                      new SqlParameter("@Cod_Pub", codigoPub));
                SqlDataReader lectura2 = cmd2.ExecuteReader();

        
                {
                    while (lectura2.Read())
                    {
                       
                        
                         s = lectura2.IsDBNull(0) ? "" : Convert.ToString(lectura2.GetValue(0));
                       


                    }
                    if (s.Equals("")) { } else { precioMayorOferta = Convert.ToDouble(s); }
               }
                if (precioOfertado <= precioMayorOferta)
                {
                    throw new Excepciones.ValorMenor("El valor ingresado es menor a la última oferta realizada");

                }
                conn2.Close();
            }

        }

         internal static string evaluarCheck(CheckBox chk, TextBox txt)
        {
            String ii = null;
            if (chk.Checked) {
                ii =  Utiles.Validaciones.validarUnSoloTxt(txt);
            }
            return ii;
        }



         internal static bool ValidarFechaParaUsuario(MaskedTextBox fecha)
         {
             DateTime fechaLimite = DBConexion.fechaIngresadaPorElAdministrador();
             DateTime time = DateTime.Parse(fecha.Text);


             int i = time.CompareTo(fechaLimite);
             if (i >= 0)
             {

                 fecha.BackColor = Color.Coral;
                 return true;

             }
             return false;

         }

         internal static bool ValidarFechaParaEmpresa(MaskedTextBox Fecha)
         {
             throw new NotImplementedException();
         }
    }
}

          