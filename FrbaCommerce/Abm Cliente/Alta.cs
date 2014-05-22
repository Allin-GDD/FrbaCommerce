using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FrbaCommerce.Abm_Cliente
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
            cboTipoDoc.Items.Add("DNI");
            cboTipoDoc.Items.Add("CUIT");


        }

        private void btmGuardar_Click(object sender, EventArgs e)
        {
            Entidades.Ent_Cliente cliente = new Entidades.Ent_Cliente();
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Dni = Convert.ToInt64(txtDNI.Text);
            cliente.Tipo_dni = Convert.ToInt16(cboTipoDoc.SelectedValue);
            cliente.Fecha_Nac = Convert.ToString(txtFechaNac.Text);
            cliente.Mail = txtMail.Text;
            cliente.Dom_Calle = txtCalle.Text;
            cliente.Nro_Calle = Convert.ToInt64(txtNroCalle.Text);
            cliente.Piso = Convert.ToInt64(txtNroPiso.Text);
            cliente.Dpto = txtDpto.Text;
            cliente.Cod_Postal = txtCodPostal.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Localidad = txtLocalidad.Text;

            //me dice cuales son los text box vacios
            var emptyTextboxes = from tb in this.Controls.OfType<TextBox>()
                                 where string.IsNullOrEmpty(tb.Text)
                                 select tb;


            if (emptyTextboxes.Any())
            {
                MessageBox.Show("Error al ingresar los datos", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int resultado = Datos.Dat_Cliente.AgregarCliente(cliente);

                if (resultado > 0)
                {
                    MessageBox.Show("Datos guardados exitosamente", "Guardar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los datos no se han podido guardar", "Guardar Cliente", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void btmLimpiar_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            ClearComboBoxes();
        }

        //funcion que limpia todos los text box con textos
      
        
        
        public void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        public void ClearComboBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is ComboBox)
                        (control as ComboBox).Items.Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }


        private void cboTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
   


        }
    }
}

       /* private void llenarComboBox(){
        //se declara una variable de tipo SqlConnection
            SqlConnection conexion = new SqlConnection();
               //se indica la cadena de conexion
            conexion.ConnectionString = @"Data source = MATÍAS-PC\SQLSERVER2008; Initial catalog = GD1C2014 ; User Id = gd; Password = gd2014 ";
            //código para llenar el comboBox
             DataSet ds = new DataSet();
             //indicamos la consulta en SQL
            SqlDataAdapter da = new SqlDataAdapter("SELECT Nombre FROM Tipo_Doc", conexion);
            //se indica el nombre de la tabla
             da.Fill(ds, "Tipo_Doc");
        cboTipoDoc.DataSource = ds.Tables[0].DefaultView;
             //se especifica el campo de la tabla
            cboTipoDoc.ValueMember = "Nombre";}

   
        */
       
   
            
            
            /*cboTipoDoc.DataSource = Datos.Dat_Cliente.ObtenerTipoDoc();
           cboTipoDoc.DisplayMember = "tipo";
           cboTipoDoc.ValueMember = "codigo";*/
 
    

    
      

