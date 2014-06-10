using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

        internal static void validarAlta(int retorno)
        {
            if (retorno > 0)
            {
                Mensajes.Exitos.ExitoAlGuardaLosDatos();
            }
            else { 
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

        
    }
}
