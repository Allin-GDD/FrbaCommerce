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
        }
        
        private Decimal idEmpresa;
     

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Comprar_Ofertar.Buscar_Publicacion co = new FrbaCommerce.Comprar_Ofertar.Buscar_Publicacion(idEmpresa, rol);
            Hide();
            co.ShowDialog();
            Show();
        }

        private void GnerarPubl_Click(object sender, EventArgs e)
        {
            String user = Datos.Dat_Usuario.getNameUser(idEmpresa, 2);
            Generar_Publicacion.Generar_Publi grPub = new FrbaCommerce.Generar_Publicacion.Generar_Publi(user);
            Hide();
            grPub.ShowDialog();
            Show();
        }

        private void Historial_Click(object sender, EventArgs e)
        {
            
        }

             
    }
}
