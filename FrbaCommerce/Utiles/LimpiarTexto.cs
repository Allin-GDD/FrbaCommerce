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
                        control.Font = new Font(control.Font, FontStyle.Regular);
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

        public static void LimpiarDataGrid(DataGridView dataGridView1)
        {
            dataGridView1.DataSource = null;

        }

        public static bool LimpiarDataGridBoton(DataGridView dataGridView1, int pos)
        {
            if (dataGridView1.DataSource != null) {
                dataGridView1.Columns.RemoveAt(pos);
                dataGridView1.Columns.RemoveAt(pos);
                return false;
             }
            return true;
        }
    }
}
