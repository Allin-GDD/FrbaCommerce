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
        // SACARLOS 
        private void button2_Click(object sender, EventArgs e)
        {
            Abm_Visibilidad.Listado_de_selección l = new Abm_Visibilidad.Listado_de_selección();
            l.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Calificar_Vendedor.listadoDePublicaciones oferta = new Calificar_Vendedor.listadoDePublicaciones(1);
            oferta.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Abm_Cliente.Listado_de_selección lsi = new FrbaCommerce.Abm_Cliente.Listado_de_selección();
            lsi.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Comprar_Ofertar.Buscar_Publicacion co = new FrbaCommerce.Comprar_Ofertar.Buscar_Publicacion(11, "C");
            co.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Historial_Cliente.Historial_Cliente his = new FrbaCommerce.Historial_Cliente.Historial_Cliente(1);
            his.Show();
        }

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    Facturar_Publicaciones.Facturar n = new Facturar_Publicaciones.Facturar(1);
        //    n.Show();
        //}

        private void button7_Click(object sender, EventArgs e)
        {
            Generar_Publicacion.Generar_Publi co = new FrbaCommerce.Generar_Publicacion.Generar_Publi("ananquel_Sepúlveda@gmail.com");
            co.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Comprar_Ofertar.ListadoSubastasPendientes lsi = new FrbaCommerce.Comprar_Ofertar.ListadoSubastasPendientes(1);
            lsi.Show();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Utiles.Ventanas.CambiarPw newPw = new FrbaCommerce.Utiles.Ventanas.CambiarPw(false);
            newPw.ShowDialog();
            Close();
        }

    }
}




