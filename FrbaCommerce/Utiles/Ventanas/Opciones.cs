﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Utiles.Ventanas
{
    class Opciones
    {

        internal static void AbrirVentanas(decimal rol, Form login)
        {
            switch (Convert.ToInt16(rol))
            {
                case 3:

                    Roles.Rol_Admin admin = new Roles.Rol_Admin();
                    admin.Show();
                    login.Close();

                    break;


                case 2:

                    Roles.Rol_Empresa empresa = new Roles.Rol_Empresa();
                    empresa.Show();
                    login.Close();

                    break;


                case 1:

                    Roles.Rol_Cliente cliente = new Roles.Rol_Cliente();
                    cliente.Show();
                    login.Close();

                    break;

            }
        }
    }
}