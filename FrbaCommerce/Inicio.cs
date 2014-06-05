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
<<<<<<< HEAD
=======
            
>>>>>>> b055948a8c900f7476f0ca06212c821b70489399
                  
        }

        private void btnLoginUser_Click(object sender, EventArgs e)
        {
            Login.Login Log1 = new Login.Login();
            Log1.Show();
<<<<<<< HEAD
=======
           
     
>>>>>>> b055948a8c900f7476f0ca06212c821b70489399


        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}


