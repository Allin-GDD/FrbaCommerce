using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class Listado : Form
    {
        public Listado()
        {
            InitializeComponent();
            List<Entidades.Ent_TipoDeDoc> listaDeDoc = new List<Entidades.Ent_TipoDeDoc>();
            listaDeDoc = Datos.Dat_Cliente.ObtenerTipoDoc();

            Entidades.Ent_TipoDeDoc entDoc = new Entidades.Ent_TipoDeDoc();
            entDoc.codigo = 0;
            entDoc.tipo = "";

            listaDeDoc.Insert(0, entDoc);

            cmbTipoDoc.DataSource = listaDeDoc;
            cmbTipoDoc.DisplayMember = "tipo";
            cmbTipoDoc.ValueMember = "codigo";
      
            
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Ent_ListadoCliente pCliente = new Entidades.Ent_ListadoCliente();
                
                pCliente.Nombre = txtNombre.Text;
                pCliente.Apellido = txtApellido.Text;
                pCliente.Dni = txtDNI.Text;
                pCliente.Mail = txtMail.Text;
                pCliente.Tipo_dni = Convert.ToString(cmbTipoDoc.SelectedValue);
                if (cmbTipoDoc.SelectedValue == "0")
                {
                    Datos.Dat_Cliente.buscarListaDeCliente2(pCliente, dataGridView1);
                }
                else
                {
                    Datos.Dat_Cliente.buscarListaDeCliente(pCliente, dataGridView1);
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Utiles.LimpiarTexto.LimpiarTextBox(this);
            Utiles.LimpiarTexto.LimpiarDataGrid(dataGridView1);
        }

        
    }
}