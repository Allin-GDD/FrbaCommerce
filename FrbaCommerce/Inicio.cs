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


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

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
            Listado_Estadistico.ListadoEstadistico lsitas = new FrbaCommerce.Listado_Estadistico.ListadoEstadistico();
            lsitas.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Comprar_Ofertar.Buscar_Publicacion co = new FrbaCommerce.Comprar_Ofertar.Buscar_Publicacion(11, "E");
            co.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Historial_Cliente.Historial_Cliente his = new FrbaCommerce.Historial_Cliente.Historial_Cliente(1);
            his.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Facturar_Publicaciones.Facturar n = new Facturar_Publicaciones.Facturar(1);
            n.Show();
        }

    }
}




