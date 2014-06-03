using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Utiles
{
    class Inicializar
    {
        public static void comboBoxTipoDNI(ComboBox cmbTipoDoc)
        {
            cmbTipoDoc.DataSource = Datos.Dat_Cliente.ObtenerTipoDoc();
            cmbTipoDoc.DisplayMember = "tipo";
            cmbTipoDoc.ValueMember = "codigo";

        }
        public static void comboBoxRol(ComboBox cmbRol)
        {
            cmbRol.DataSource = Datos.Dat_Rol.ObtenerRol();
            cmbRol.DisplayMember = "Nombre";
            cmbRol.ValueMember = "Id";

        }

        public static void AgregarColumnaEliminarYSeleccionar(bool botonDelete, bool botonModificar, DataGridView dataGridView1)
        {
            if (!botonModificar)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                dataGridView1.Columns.Add(btn);
                btn.HeaderText = "Modificar";
                btn.Text = "";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
                botonModificar = true;
            }

            if (!botonDelete)
            {
                DataGridViewButtonColumn btnD = new DataGridViewButtonColumn();
                dataGridView1.Columns.Add(btnD);
                btnD.HeaderText = "Eliminar";
                btnD.Text = "";
                btnD.Name = "btn";
                btnD.UseColumnTextForButtonValue = true;
                botonDelete = true;
            }
        }
    }

}
