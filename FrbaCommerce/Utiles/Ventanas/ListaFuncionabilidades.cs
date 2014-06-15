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
    public partial class ListaFuncionabilidades : Form
    {
        //public Entidades.Ent_Funcionalidad ResultCodigo;
        public String ResultShow;
        public ListaFuncionabilidades()
        {
            InitializeComponent();
            listBox1.DataSource = Utiles.Funcionalidades.listaDeFuncionalidades();
            listBox1.DisplayMember = "funcionalidad";
            listBox1.ValueMember = "id";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResultShow = listBox1.GetItemText(listBox1.SelectedItem);


            //  ResultCodigo = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        }


    }
}
