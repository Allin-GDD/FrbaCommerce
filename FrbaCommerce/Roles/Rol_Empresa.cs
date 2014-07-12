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
    public partial class Rol_Empresa : Form
    {
        string rol = "E";
       
        public Rol_Empresa(Decimal id)
        {
            InitializeComponent();
            this.idEmpresa = id;
            funcionalidades = Datos.Dat_Usuario.validarFuncionalidades("Cliente");
        }
        
        private Decimal idEmpresa;
        private List<int> funcionalidades = new List<int>();
        private Int32 i;

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        { i = 17;
            if (funcionalidades.Any(x => x == i))
            {
         //   Comprar_Ofertar.Buscar_Publicacion co = new FrbaCommerce.Comprar_Ofertar.Buscar_Publicacion(idEmpresa, rol);
            Hide();
            //co.ShowDialog();
            Show();
            }
            else
            {
                Mensajes.Errores.UsuarioNoTienePermisos();
            }
        }

        private void GnerarPubl_Click(object sender, EventArgs e)
        {i = 10;
            if (funcionalidades.Any(x => x == i))
            {
            String user = Datos.Dat_Usuario.getNameUser(idEmpresa, 'E');
            Generar_Publicacion.Generar_Publi grPub = new FrbaCommerce.Generar_Publicacion.Generar_Publi(idEmpresa);
            Hide();
            grPub.ShowDialog();
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
             bool isEmpresa = true;
            Abm_Empresa.Modificación modif = new FrbaCommerce.Abm_Empresa.Modificación(idEmpresa,isEmpresa);
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
            Facturar_Publicaciones.Facturar fac = new FrbaCommerce.Facturar_Publicaciones.Facturar(idEmpresa,rol);
            Hide();
            fac.ShowDialog();
            Show();}
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
            Gestion_de_Preguntas.ResponderPregunta resp = new FrbaCommerce.Gestion_de_Preguntas.ResponderPregunta(idEmpresa);
            Hide();
            resp.ShowDialog();
            Show();
            }
            else
            {
                Mensajes.Errores.UsuarioNoTienePermisos();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i = 18;
            if (funcionalidades.Any(x => x == i))
            {
            Comprar_Ofertar.ListadoSubastasPendientes listSub = new FrbaCommerce.Comprar_Ofertar.ListadoSubastasPendientes(idEmpresa);
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
