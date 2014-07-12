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
            Registro_de_Usuario.Registro_De_Usuario Reg1 = new Registro_de_Usuario.Registro_De_Usuario();
            this.Hide();
            Reg1.ShowDialog();
            this.Show();
        }

        private void btnLoginUser_Click(object sender, EventArgs e)
        {
            Login.Login Log1 = new Login.Login();
            this.Hide();
            Log1.ShowDialog();
            this.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
        
        private void button2_Click_2(object sender, EventArgs e)
        {
            Utiles.Ventanas.CambiarPw newPw = new FrbaCommerce.Utiles.Ventanas.CambiarPw(false);
            newPw.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Abm_Cliente.Alta al = new FrbaCommerce.Abm_Cliente.Alta(0);
            al.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Calificar_Vendedor.listadoDePublicaciones emp = new Calificar_Vendedor.listadoDePublicaciones(2);
            emp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Generar_Publicacion.Generar_Publi genpub = new Generar_Publicacion.Generar_Publi(1);
            genpub.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Editar_Publicacion.Editar_Publicacion_Borrada ediborr = new Editar_Publicacion.Editar_Publicacion_Borrada(68390);
            ediborr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Comprar_Ofertar.Buscar_Publicacion buspub = new Comprar_Ofertar.Buscar_Publicacion(1, 'C');
            buspub.Show();
        }

    }
}




