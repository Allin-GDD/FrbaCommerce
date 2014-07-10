using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Utiles.Ventanas
{
    class Opciones
    {

        internal static void AbrirVentanas(decimal rol, Form login,decimal id)
        {
            switch (Convert.ToInt16(rol))
            {
                case 3:

                    Roles.Rol_Admin admin = new Roles.Rol_Admin();
                    admin.ShowDialog();
                    login.Close();

                    break;


                case 2:

                    Roles.Rol_Empresa empresa = new Roles.Rol_Empresa(id);
                    empresa.ShowDialog();
                    login.Close();

                    break;


                case 1:

                    Roles.Rol_Cliente cliente = new Roles.Rol_Cliente(id);
                    cliente.ShowDialog();
                    login.Close();

                    break;

            }
        }

       }
}