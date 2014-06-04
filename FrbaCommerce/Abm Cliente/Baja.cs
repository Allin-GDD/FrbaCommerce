﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using FrbaCommerce.Entidades;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class Baja : Form
    {



        public Baja(Int32 idSeleccionado)
        {
            InitializeComponent();
            this.clienteADarDeBaja = idSeleccionado;
            Utiles.Inicializar.comboBoxTipoDNI(cboTipoDoc);
            cargarDatosDelClienteSeleccionado();

        }
        public Int32 clienteADarDeBaja;

        private void cargarDatosDelClienteSeleccionado()
        {
            Ent_Cliente pcliente = new Ent_Cliente();
            pcliente = Datos.Dat_Cliente.buscarCliente(clienteADarDeBaja);

            txtNombre2.Text = pcliente.Nombre;
            txtApellido.Text = pcliente.Apellido;
            txtDNI.Text = Convert.ToString(pcliente.Dni);
            txtNroCalle.Text = Convert.ToString(pcliente.Nro_Calle);
            txtCodPostal.Text = pcliente.Cod_Postal;
            txtCalle.Text = pcliente.Dom_Calle;
            txtDpto.Text = pcliente.Dpto;
            txtFechaNac.Text = Convert.ToString(pcliente.Fecha_Nac);
            txtNroPiso.Text = Convert.ToString(pcliente.Piso);
            txtMail.Text = pcliente.Mail;
            txtTelefono.Text = pcliente.Telefono;
            txtLocalidad.Text = pcliente.Localidad;

            //if (string.IsNullOrEmpty(pcliente.Telefono))
            //{
            //    txtTelefono.Text = "-";
            //}
            //else
            //{
            //    txtTelefono.Text = pcliente.Telefono;
            //}




        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.darDeBajaAlCliente", conn,
                new SqlParameter("@Id_Cliente", clienteADarDeBaja));
                int retorno = cmd.ExecuteNonQuery();

                Mensajes.Generales.validarBaja(retorno);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}