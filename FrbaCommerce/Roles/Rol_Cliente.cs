using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Roles
{
    public partial class Rol_Cliente : Form
    {
        string rol = "C";
        
        public Rol_Cliente(decimal id)
        {
            InitializeComponent();
            idcliente = id;
        }
        private Decimal idcliente;

        private void Salir_Click(object sender, EventArgs e)
        {
       
            this.Close();

        }

        private void Buscar_Click(object sender, EventArgs e)
        {

            short estado = Datos.Dat_Usuario.obtenerEstado(idcliente);
            Datos.Dat_Usuario.validarEstado(estado);

            Comprar_Ofertar.Buscar_Publicacion co = new FrbaCommerce.Comprar_Ofertar.Buscar_Publicacion(idcliente,rol);
             Hide();
            co.ShowDialog();
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calificar_Vendedor.listadoDePublicaciones cal = new FrbaCommerce.Calificar_Vendedor.listadoDePublicaciones(idcliente);
            Hide();
            cal.ShowDialog();
            Show();
        }

        private void GenerarPubl_Click(object sender, EventArgs e)
        {
            String user = Datos.Dat_Usuario.getNameUser(idcliente, 1);
            Generar_Publicacion.Generar_Publi genPub = new FrbaCommerce.Generar_Publicacion.Generar_Publi(user);
            this.Hide();
            genPub.ShowDialog();
            Show();
        }

        private void Historial_Click(object sender, EventArgs e)
        {
            Historial_Cliente.Historial_Cliente hist = new FrbaCommerce.Historial_Cliente.Historial_Cliente(idcliente);
            this.Hide();
            hist.ShowDialog();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isUsuario = true;
            Abm_Cliente.Modificación modif = new FrbaCommerce.Abm_Cliente.Modificación(idcliente, isUsuario);
            Hide();
            modif.ShowDialog();
            Show();

        }

        private void FacturarPublicaciones_Click(object sender, EventArgs e)
        {
            Facturar_Publicaciones.Facturar fac = new FrbaCommerce.Facturar_Publicaciones.Facturar(idcliente,rol);
            Hide();
            fac.ShowDialog();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String user = Datos.Dat_Usuario.getNameUser(idcliente, 1);
            Gestion_de_Preguntas.Gestor gestor = new FrbaCommerce.Gestion_de_Preguntas.Gestor(user);
            Hide();
            gestor.ShowDialog();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Comprar_Ofertar.ListadoSubastasPendientes listSub = new FrbaCommerce.Comprar_Ofertar.ListadoSubastasPendientes(idcliente);
            Hide();
            listSub.ShowDialog();
            Show();
        }


            }
}
