using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Utiles.Ventanas
{
    public partial class ListaFuncionabilidades : Form
    {
        //public Entidades.Ent_Funcionalidad ResultCodigo;
        public String ResultShow;
        public String Result;
        public ListaFuncionabilidades(Decimal IdRol)
        {
            InitializeComponent();
            if (IdRol == 0)
            {
                listBox1.DataSource = Utiles.Funcionalidades.listaDeFuncionalidades();
            }
            else {
                   List<Entidades.Ent_Funcionalidad> lista = Utiles.Funcionalidades.listaDeFuncionalidades();
                   List<int> funcionalidades = Datos.Dat_Rol.buscarFuncDe(IdRol);
                   List<Entidades.Ent_Funcionalidad> listaAAgregar = new List<Entidades.Ent_Funcionalidad>();

                   foreach (Entidades.Ent_Funcionalidad listaVieja in lista)
                   {
                       foreach (int func in funcionalidades)
                       {
                           if (func == listaVieja.id)
                          {
                               Entidades.Ent_Funcionalidad funcNueva = new Entidades.Ent_Funcionalidad();
                               funcNueva.id = func;
                               funcNueva.funcionalidad = listaVieja.funcionalidad;
                               listaAAgregar.Add(funcNueva);
                           }
                       }
                   }
                        listBox1.DataSource = listaAAgregar;
            }
         
            listBox1.DisplayMember = "funcionalidad";
            listBox1.ValueMember = "id";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResultShow = listBox1.GetItemText(listBox1.SelectedItem);
            Result = listBox1.GetItemText(listBox1.SelectedValue);
}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
