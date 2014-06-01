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
            
                Abm_Cliente.Alta nuevaAlt = new Abm_Cliente.Alta();
                nuevaAlt.Show();
                this.Close();
            }

            if (cboRol.Text == "Empresa")
            {

                Abm_Empresa.Alta nuevaAlt = new Abm_Empresa.Alta();
                nuevaAlt.Show();
                this.Close();
            }
        }

       

        }
}
