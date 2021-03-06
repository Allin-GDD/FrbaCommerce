﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Roles
{
    public partial class VentanaEmpresa : Form
    {
        public VentanaEmpresa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abm_Empresa.Alta empresa = new FrbaCommerce.Abm_Empresa.Alta(0);
            Hide();
            empresa.ShowDialog();
            Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Abm_Empresa.Listado_de_selección empresa = new FrbaCommerce.Abm_Empresa.Listado_de_selección();
            Hide();
            empresa.ShowDialog();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Abm_Empresa.Listado empresa = new FrbaCommerce.Abm_Empresa.Listado();
            Hide();
            empresa.ShowDialog();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
