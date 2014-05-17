using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce
{
    public partial class pestaña1 : Form
    {
        public pestaña1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            alumno cliente = new alumno();
            cliente.nombre = txtNombre.Text;
            cliente.apellido = txtApellido.Text;
            cliente.edad = txtEdad.Text;
            int resultado = alumnoDAL.Agregar(cliente);
            if (resultado > 0)
            {
                MessageBox.Show("Datos guardados correctamente", "Datos guardados", MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtNombre.Clear();
                txtApellido.Clear();
                txtEdad.Clear();
                }
            else { MessageBox.Show("Datos no guardados correctamente", "Error al guardar", MessageBoxButtons.OK,MessageBoxIcon.Error);
            } 
            }
        }
        
      
    }
