﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Abm_Empresa
{
    public partial class Baja : Form
    {
        public Baja(Decimal idSeleccionado)
        {
            InitializeComponent();
            this.empresaADarDeBaja = idSeleccionado;
            cargarDatosDelClienteSeleccionado();
        }
        public Decimal empresaADarDeBaja;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.darDeBajaAUsuario", conn,
                new SqlParameter("@Id_Usuario", empresaADarDeBaja),
                new SqlParameter("@Id_Rol",2));
                int retorno = cmd.ExecuteNonQuery();

                Mensajes.Generales.validarBaja(retorno);
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void cargarDatosDelClienteSeleccionado()
        {
            Entidades.Ent_Empresa pEmpresa = new Entidades.Ent_Empresa();
            pEmpresa = Datos.Dat_Empresa.buscarEmpresa(empresaADarDeBaja);

            Telefono.Text = pEmpresa.Telefono;
            RazonSocial.Text = pEmpresa.RazonSocial;
            NombreContacto.Text = pEmpresa.NombreContacto;
            CUIT.Text = pEmpresa.CUIT;
            Mail.Text = pEmpresa.Mail;
            Calle.Text = pEmpresa.Dom_Calle;
            NCalle.Text = Convert.ToString(pEmpresa.Nro_Calle);
            NroPiso.Text = Convert.ToString(pEmpresa.Piso);
            Dpto.Text = pEmpresa.Dpto;
            Localidad.Text = pEmpresa.Localidad;
            CodPostal.Text = pEmpresa.Cod_Postal;
            Ciudad.Text = pEmpresa.Ciudad;
            FecCre.Text = Convert.ToString(pEmpresa.Fecha_Creacion);
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      }
}
