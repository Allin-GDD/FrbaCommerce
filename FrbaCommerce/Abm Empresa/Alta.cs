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
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
            
        }

        public Int32 rolDeUsuario = 2;
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Entidades.Ent_Empresa empresa = new Entidades.Ent_Empresa();

            try
            {
                //Verifica si los datos ingresados no son nulos
                validarNulidadDeDatosIngresados();

                //Verifica si lo que se estan ingresando es correcto
               // validarTipoDeDatosIngresados();
                //Verifica si la fecha está dentro del limite
                validarFecha();
                //Verifica si el DNI y Telefono ya no existen
                verificarCuityTelefono();

                //Inicializa el cliente con datos correctos
                inicializarEmpresa(empresa);

                //Agrega el cliente a la DB
                Datos.Dat_Empresa.AgregarEmpresa(empresa);
                Datos.Dat_Usuario.CrearNuevoUsuario(empresa.Mail, empresa.CUIT, rolDeUsuario);
                //el usuario va a ser el mail y la contraseña su cuit
                this.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inicializarEmpresa(Entidades.Ent_Empresa empresa)
        {


            empresa.NombreContacto = Convert.ToString(NombreContacto.Text);
            empresa.RazonSocial = Convert.ToString(RazonSocial.Text);
            empresa.CUIT = Convert.ToString(CUIT.Text);
            empresa.Mail = Convert.ToString(Mail.Text);
            empresa.Telefono = Convert.ToString(Telefono.Text);
            empresa.Dom_Calle = Convert.ToString(Calle.Text);
            empresa.Nro_Calle = Convert.ToDecimal(NCalle.Text);
            empresa.Dpto = Convert.ToString(Dpto.Text);
            empresa.Localidad = Convert.ToString(Localidad.Text);
            empresa.Cod_Postal = Convert.ToString(CodPostal.Text);
            empresa.Ciudad = Convert.ToString(Ciudad.Text);
            empresa.Fecha_Creacion = Convert.ToString(FecCre.Text);
            

            //hace esto para que pueda existir gente que no vive en edificio
            if (!string.IsNullOrEmpty(NroPiso.Text))
            {
                empresa.Piso = Convert.ToInt32(NroPiso.Text);
            }



        }




         private void validarNulidadDeDatosIngresados()
        {
            Action<Control.ControlCollection> func = null;
            int i = 0;

            Utiles.LimpiarTexto.BlanquearControls(this);
            //Se fija si la maskText es nula o no
            if (!FecCre.MaskCompleted)
            {
                FecCre.BackColor = Color.Coral;
                i++;
            }
         //Esto se fija si los datos cargados son nulos o no. Con la excepción de los campo depto y piso
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                    {
                        if (string.IsNullOrEmpty(control.Text) && (control != Dpto) && (control != NroPiso))
                        {
                            control.BackColor = Color.Coral;
                            i++;
                        }

                    }
                    else { func(control.Controls); }
            };

            func(Controls);


            if (i > 0)
            {
                throw new Excepciones.NulidadDeCamposACompletar("Faltan completar los siguientes campos");
            }
         }

         private void validarTipoDeDatosIngresados()
         {

             Mensajes.Cliente.ValidarTipoNroCalle(NroCalle.Text);
             if (!string.IsNullOrEmpty(NroPiso.Text))
             {
                 Mensajes.Cliente.ValidarTipoPiso(NroPiso.Text);
             }
         }

         private void validarFecha()
         {
             Mensajes.Cliente.ValidarFecha(FecCre.Text);
         }

         private void verificarCuityTelefono()
         {
             List<Entidades.Ent_Telefono> listaTelefonos = Datos.Dat_Empresa.obtenerTodosLosTelefonos();
             List<Entidades.Ent_Cuit> listaCuit = Datos.Dat_Empresa.obtenerTodosLosCuit();

             Entidades.Ent_Telefono ptelefono = new Entidades.Ent_Telefono();
             Entidades.Ent_Cuit pCuit = new Entidades.Ent_Cuit();
             ptelefono.Telefono = Telefono.Text;
             pCuit.CUIT = CUIT.Text;


             Datos.Dat_Telefonos.validarTelefono(ptelefono);
             Datos.Dat_Cuit.validarCuit(pCuit);
         }



       
    }
}
