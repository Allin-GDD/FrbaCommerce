using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Registro_de_Usuario
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            Utiles.Inicializar.comboBoxRol(cboRol);
        }

      

        private void button1_Click(object sender, EventArgs e)
        {

            if(cboRol.Text == "Cliente"){
            
                Abm_Cliente.Alta nuevaAlt = new Abm_Cliente.Alta(false);
                nuevaAlt.Show();
                this.Close();
            }

            if (cboRol.Text == "Empresa")
            {

                Abm_Empresa.Alta nuevaAlt = new Abm_Empresa.Alta(false);
                nuevaAlt.Show();
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ABM_Rol.Alta alt = new ABM_Rol.Alta();
            alt.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ABM_Rol.Listado lis = new ABM_Rol.Listado();
            lis.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ABM_Rol.Listado_de_selección listS = new ABM_Rol.Listado_de_selección();
            listS.Show();
        }

               private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

        }
}
