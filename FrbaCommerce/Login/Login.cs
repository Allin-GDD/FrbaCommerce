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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.idCliente = Datos.Dat_Login.buscarId();
            Fronts_Utiles.ClienteOpciones Opc1 = new Fronts_Utiles.ClienteOpciones();
            Opc1.idCliente = this.idCliente;
            Opc1.Show();
    
        }
        public Int32 idCliente { get; set; }
    }
}
