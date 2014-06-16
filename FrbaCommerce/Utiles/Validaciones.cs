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


        public static void ValidarTipoDecimalPublicacion(Decimal stockInicial,params TextBox[] parametroTxtBox)

       {
           int i = 0;
           int j = 0;
           Decimal expectedDecimal;
           Decimal num = 0;
           foreach (TextBox parametro in parametroTxtBox)
           {
               if (parametro.Name == "textBox2" && parametro.Enabled)
               {
                   num = Convert.ToDecimal(parametro.Text);
               }
               if (num < stockInicial && parametro.Name == "textBox2" && parametro.Enabled == true)
               {
                   parametro.BackColor = Color.Coral;
                   j++;
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
           }
           if (j> 0)
           {
               throw new Excepciones.ValoresConTiposDiferentes("Complete los campos señalados con datos válidos, el stock no puede ser menor al publicado anteriormente");
           }
           else if(i>0 && j == 0)
           {
               throw new Excepciones.ValoresConTiposDiferentes("Complete los campos señalados con datos válidos");
           }
       }
        public static void ValidarVisibilidadGratuita(Decimal id,string publicador)
        {
            if (Datos.Dat_Publicacion.verificarTresGratuitas(id,publicador))
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

                fecha.BackColor = Color.Coral;
                return true;

            }
            return false;


        }
        public static bool ValidarTipoDecimal(TextBox txt)
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
            if (validarDatosMask(ofrm) + validarDatosText(ofrm) > 0)
            {
                errores.Add("Los datos marcados son obligatorios");
            }
            return errores;
        }


        //////////////////////////////////////////////////////////////////////////////////////////////
        //Evalua todas validaciones de los clientes y empresa
        public static void evaluarPersona(Entidades.Ent_TxtPersona txtUtil, Form ofrm)
        {
            List<String> errores = datosObligatorios(ofrm);
            //se fija si el tipo es correcto
            if ((Mensajes.Generales.evaluarNroPiso(txtUtil.Piso) != null)) errores.Add(Mensajes.Generales.evaluarNroPiso(txtUtil.Piso));

            if ((Mensajes.Generales.evaluarNroCalle(txtUtil.NroCalle) != null)) errores.Add(Mensajes.Generales.evaluarNroPiso(txtUtil.NroCalle));

            //Se fija si la fecha esta dentro del rango     
            if ((Mensajes.Generales.evaluarFecha(txtUtil.Fecha) != null)) errores.Add(Mensajes.Generales.evaluarFecha(txtUtil.Fecha));

            //se fija si no esta repetido
            if ((Mensajes.Generales.evaluarTel(txtUtil.Telefono, txtUtil.TelefonoAnt) != null)) errores.Add(Mensajes.Generales.evaluarTel(txtUtil.Telefono, txtUtil.TelefonoAnt));

            if ((Mensajes.Generales.evaluarCUIT(txtUtil.CUIT, txtUtil.CUITAnt) != null)) errores.Add(Mensajes.Generales.evaluarCUIT(txtUtil.CUIT, txtUtil.CUITAnt));

            //se fija si no esta repetido y si el DNI es de tipo decimal
            if ((Mensajes.Generales.evaluarDNI(txtUtil.DNI, txtUtil.DNIAnt).Count > 0)) errores.AddRange(Mensajes.Generales.evaluarDNI(txtUtil.DNI, txtUtil.DNIAnt));




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
        public static void controlDeUsuario(int retorno) {
            if (retorno != 0) {
                throw new Excepciones.InexistenciaUsuario("El usuario que está ingresando pertenece a otro usuario");
            }
        }
        public static void evaluarRol(TextBox txtNombre, Form ofrm)
        {
            List<String> errores = datosObligatorios(ofrm);


            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                errores.Add("Los datos marcados son obligatorios");

            if (Datos.Dat_Rol.verificarSiElRolYaExiste(txtNombre.Text))
            {
                errores.Add("El nombre del rol ya pertenece a otro rol existente");
            }


            Mensajes.Generales.evaluarErrores(errores);

        }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////

        public static void evaluarVisibilidad(Form ofrm, Entidades.Ent_TxtVisibilidad util, TextBox codigoAnt, TextBox descripcionAnt)
        {
            List<String> errores = datosObligatorios(ofrm);

            if ((Mensajes.Generales.evaluarCodVisibilidad(util.Codigo,codigoAnt).Count > 0)) errores.AddRange(Mensajes.Generales.evaluarCodVisibilidad(util.Codigo,codigoAnt));

            if ((Mensajes.Generales.evaluarPorcentajeVisib(util.Porcentaje).Count > 0)) errores.AddRange(Mensajes.Generales.evaluarPorcentajeVisib(util.Porcentaje));

            if ((Mensajes.Generales.evaluarVencimientoVisib(util.Vencimiento) != null)) errores.Add(Mensajes.Generales.evaluarVencimientoVisib(util.Vencimiento));

            if ((Mensajes.Generales.evaluarDescripVisib(util.Descripcion, descripcionAnt) != null)) errores.Add(Mensajes.Generales.evaluarDescripVisib(util.Descripcion, descripcionAnt));
            
            if((Mensajes.Generales.evaluarPrecioVisib(util.Precio) != null)) errores.Add(Mensajes.Generales.evaluarPrecioVisib(util.Precio));

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
