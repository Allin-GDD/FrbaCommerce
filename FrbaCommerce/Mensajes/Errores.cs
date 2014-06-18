using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Mensajes
{
    class Errores
    {
       
        public static void ErrorAlGuardarDatos()
        {
            MessageBox.Show("Los datos no se han podido guardar", "Guardar Cliente", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
         
        }

        public static void ErrorAlBorrarDatos()
        {
            MessageBox.Show("Ha ocurrido un error al intentar borrar los datos", "Baja", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error); 
        }

        public static void ErrorAlGuardarDatos(int retorno)
        {
            if (retorno == 0) {
                MessageBox.Show("Error al guardar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void NoHayConexion()
        {
            MessageBox.Show("No se puedo obtener conexión con el servidor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        internal static void FaltaDeCampos()
        {
            throw new Excepciones.NulidadDeCamposACompletar("Faltan completar los siguientes campos");
        }

        internal static void ErrorEnlaContraseña(int intentosFallidos)
        {
            if (intentosFallidos <= 3)
            {
                int intentosPosibles = 3 - intentosFallidos;
                throw new Excepciones.InexistenciaUsuario("La contraseña ingresada no es válida. Le quedan: " + intentosPosibles + " intentos");
            }
        }

        internal static void NoHayDatosAmodificar()
        {
            MessageBox.Show("Los datos a modificar no son válidos", "Modificación", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }
    }
}
