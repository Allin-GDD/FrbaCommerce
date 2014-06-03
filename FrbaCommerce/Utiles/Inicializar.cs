using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Utiles
{
    class Inicializar
    {
        public static void comboBoxTipoDNI(ComboBox cmbTipoDoc)
        {
            cmbTipoDoc.DataSource = Datos.Dat_Cliente.ObtenerTipoDoc();
            cmbTipoDoc.DisplayMember = "tipo";
            cmbTipoDoc.ValueMember = "codigo";

        }
        public static void comboBoxRol(ComboBox cmbRol)
        {
            cmbRol.DataSource = Datos.Dat_Rol.ObtenerRol();
            cmbRol.DisplayMember = "Nombre";
            cmbRol.ValueMember = "Id";

        }

        public static void AgregarColumnaEliminarYSeleccionar(bool botonDelete, bool botonModificar, DataGridView dataGridView1)
        {
            if (!botonModificar)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                dataGridView1.Columns.Add(btn);
                btn.HeaderText = "Modificar";
                btn.Text = "";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
                botonModificar = true;
            }

            if (!botonDelete)
            {
                DataGridViewButtonColumn btnD = new DataGridViewButtonColumn();
                dataGridView1.Columns.Add(btnD);
                btnD.HeaderText = "Eliminar";
                btnD.Text = "";
                btnD.Name = "btn";
                btnD.UseColumnTextForButtonValue = true;
                botonDelete = true;
            }
        }

        public static void comboBoxHabilitado(ComboBox cmbHabilitado, Int32 id)
        {
            List<Entidades.Ent_Habilitado> lista = new List<Entidades.Ent_Habilitado>();

            Entidades.Ent_Habilitado valorSi = new Entidades.Ent_Habilitado();
            valorSi.estado = 1;
            valorSi.valor = "Si";
            Entidades.Ent_Habilitado valorNo = new Entidades.Ent_Habilitado();
            valorNo.estado = 0;
            valorNo.valor = "No";
         
            Int16 i = obtenerEstado(id);
            if (i == 0)
            {
                lista.Add(valorNo);
                lista.Add(valorSi);
            }
            else {
                lista.Add(valorSi);
                lista.Add(valorNo);
            }
            cmbHabilitado.DataSource = lista;
            cmbHabilitado.DisplayMember = "valor";
            cmbHabilitado.ValueMember = "estado";

        }

        private static short obtenerEstado(int id)
        {
            Int16 estado = -1;
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.obtenerEstadoDelId", conn,
            new SqlParameter("@Id", id));
            SqlDataReader lectura = cmd.ExecuteReader();
            while (lectura.Read())
            {
                estado = lectura.GetInt16(0);
            }
            conn.Close();

            return estado;
        }
    }

}
