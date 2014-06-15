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
        Decimal idEmpresa = 1;
        public Rol_Empresa()
        {
            InitializeComponent();
        }

        private void Rol_Empresa_Load(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Comprar_Ofertar.Buscar_Publicacion co = new FrbaCommerce.Comprar_Ofertar.Buscar_Publicacion(idEmpresa, rol);
            co.Show();
        }
    }
}
