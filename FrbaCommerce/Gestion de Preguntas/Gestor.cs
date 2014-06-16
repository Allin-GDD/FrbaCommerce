﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Gestion_de_Preguntas
{
    public partial class Gestor : Form
    {
        public Gestor(String usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

        }
        private String usuario;

        private void button1_Click(object sender, EventArgs e)
        {
            Gestion_de_Preguntas.ResponderPregunta resp = new ResponderPregunta(usuario);
            resp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gestion_de_Preguntas.VerRespuestas verRes = new VerRespuestas(usuario);
            verRes.Show();
            this.Hide();
        }
    }
}
