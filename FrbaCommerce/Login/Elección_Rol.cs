﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Login
{
    public partial class Elección_Rol : Form
    {
        public Elección_Rol()
        {
            InitializeComponent();
            Utiles.Inicializar.comboBoxRol(cboRol);
        }

     
        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
