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
            funcionalidades = Datos.Dat_Usuario.validarFuncionalidades("Cliente");
            idcliente = id;
        }
        private Decimal idcliente;
        private List<int> funcionalidades = new List<int>();
        private Int32 i;

        private void Salir_Click(object sender, EventArgs e)
        {
       
            this.Close();

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
             i = 12;
             if (funcionalidades.Any(x => x == i))
             {
            short estado = Datos.Dat_Usuario.obtenerEstado(idcliente);
            Datos.Dat_Usuario.validarEstado(estado);

          //  Comprar_Ofertar.Buscar_Publicacion co = new FrbaCommerce.Comprar_Ofertar.Buscar_Publicacion(idcliente,rol);
             Hide();
            //co.ShowDialog();
            Show();
             }
             else
             {
                 Mensajes.Errores.UsuarioNoTienePermisos();
             }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             i = 14;
             if (funcionalidades.Any(x => x == i))
             {
            Calificar_Vendedor.listadoDePublicaciones cal = new FrbaCommerce.Calificar_Vendedor.listadoDePublicaciones(idcliente);
            Hide();
            cal.ShowDialog();
            Show();
             }
             else
             {
                 Mensajes.Errores.UsuarioNoTienePermisos();
             }
        }

        private void GenerarPubl_Click(object sender, EventArgs e)
        {
             i = 10;
             if (funcionalidades.Any(x => x == i))
             {
                 Generar_Publicacion.Generar_Publi genPub = new FrbaCommerce.Generar_Publicacion.Generar_Publi(idcliente);
                 this.Hide();
                 genPub.ShowDialog();
                 Show();
             }
             else
             {
                 Mensajes.Errores.UsuarioNoTienePermisos();
             }
        }

        private void Historial_Click(object sender, EventArgs e)
        {
            i = 11;
            if (funcionalidades.Any(x => x == i))
            {
                Historial_Cliente.Historial_Cliente hist = new FrbaCommerce.Historial_Cliente.Historial_Cliente(idcliente);
            this.Hide();
            hist.ShowDialog();
            Show(); 
        }
             else
             {
                 Mensajes.Errores.UsuarioNoTienePermisos();
             }
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            i = 16;
            if (funcionalidades.Any(x => x == i))
            {
                bool isUsuario = true;
                Abm_Cliente.Modificación modif = new FrbaCommerce.Abm_Cliente.Modificación(idcliente, isUsuario);
                Hide();
                modif.ShowDialog();
                Show();
            }
            else
            {
                Mensajes.Errores.UsuarioNoTienePermisos();
            }
        }

        private void FacturarPublicaciones_Click(object sender, EventArgs e)
        {
            i = 13;
            if (funcionalidades.Any(x => x == i))
            {
                Facturar_Publicaciones.Facturar fac = new FrbaCommerce.Facturar_Publicaciones.Facturar(idcliente,rol);
            Hide();
            fac.ShowDialog();
            Show();
            }
            else
            {
                Mensajes.Errores.UsuarioNoTienePermisos();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i = 14;
            if (funcionalidades.Any(x => x == i))
            {
            String user = Datos.Dat_Usuario.getNameUser(idcliente, 1);
         //   Gestion_de_Preguntas.Gestor gestor = new FrbaCommerce.Gestion_de_Preguntas.Gestor(user);
            Hide();
          //  gestor.ShowDialog();
            Show();
        }
            else
            {
                Mensajes.Errores.UsuarioNoTienePermisos();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        { i = 15;
        if (funcionalidades.Any(x => x == i))
        {
            Comprar_Ofertar.ListadoSubastasPendientes listSub = new FrbaCommerce.Comprar_Ofertar.ListadoSubastasPendientes(idcliente);
            Hide();
            listSub.ShowDialog();
            Show();
        }
        else
        {
            Mensajes.Errores.UsuarioNoTienePermisos();
        }
        }


            }
}
