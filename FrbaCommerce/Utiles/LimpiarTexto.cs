using System;
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


        public static void LimpiarMaskedTextBox(Form ofrm)
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
                    if ((control is TextBox || control is MaskedTextBox) && control.BackColor == Color.Coral)
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

        public static void SacarCheckBox(Form ofrm)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                    {
                        (control as CheckBox).Checked = false;
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
