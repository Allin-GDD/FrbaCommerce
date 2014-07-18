using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Utiles.Ventanas
{
    public partial class ElegirRol : Form
    {
        public ElegirRol(List<Entidades.Entidad_Rol> list, Decimal id, Form login)
        {
            InitializeComponent();
            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "id";
            IdUser = id;
            login2 = login;
        }

        private Decimal IdUser;
        private Form login2;
        private void button1_Click(object sender, EventArgs e)
        {
            Utiles.Ventanas.Opciones.AbrirVentanas(Convert.ToDecimal(comboBox1.SelectedValue), IdUser,login2);
            this.Close();
        }
    }
}
