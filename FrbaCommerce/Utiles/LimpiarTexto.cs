﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace FrbaCommerce.Utiles
{
    class LimpiarTexto
    {
        public static void LimpiarTextBox(Form ofrm)
         {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else
                    {
                        func(control.Controls);
                    }
            };

            func(ofrm.Controls);
        }


        public static void LimpiarDateTime(Form ofrm)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is MaskedTextBox)
                    {
                        (control as MaskedTextBox).Clear();
                    }
                    else
                    {
                        func(control.Controls);
                    }
            };

            func(ofrm.Controls);
        }

        public static void BlanquearControls(Form ofrm)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                    {
                        control.BackColor = Color.White;
                    }
                    else
                    {
                        func(control.Controls);
                    }
            };

            func(ofrm.Controls);
        }
   }
}
