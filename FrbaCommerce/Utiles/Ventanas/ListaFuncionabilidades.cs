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
        public string Result = string.Empty;
        public Int32 ResultCodigo;
        public ListaFuncionabilidades(Decimal IdRol)
        {
            InitializeComponent();


            dataGridView1.DataSource = Datos.Dat_Funcionalidad.listadoDeFuncionalidades(IdRol);
            dataGridView1.Columns["ID"].Visible = false;

         }

       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Result = dataGridView1.Rows[e.RowIndex].Cells["funcionalidad"].Value.ToString();
                ResultCodigo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                Close();
            }

                   }


    }
