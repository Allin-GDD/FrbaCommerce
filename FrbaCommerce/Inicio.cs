using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Login;
using FrbaCommerce.Registro_de_Usuario;


namespace FrbaCommerce
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnNuevoUser_Click(object sender, EventArgs e)
        {
           
            Registro_de_Usuario.Registro Reg1 = new Registro_de_Usuario.Registro();
            Reg1.Show();
                  
        }

        private void btnLoginUser_Click(object sender, EventArgs e)
        {
            Login.Login Log1 = new Login.Login();
            Log1.Show();
     


        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* pestaña1 pest = new pestaña1();
            pest.Show();
        
            */
        }
    }
}


