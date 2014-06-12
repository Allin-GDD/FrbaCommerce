using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
				

namespace FrbaCommerce.Comprar_Ofertar
{
    public partial class Form1 : Form
    {
        DataTable dtSource;
        int PageCount;
        int maxRec;
        int pageSize;
        int currentPage;
        int recNo;

        public Form1()
        {
            InitializeComponent();
            botonCompraOferta = false;
        }

        private bool botonCompraOferta;
        private Decimal codRubro;
        private void LoadPage()
        {
            int i;
            int startRec;
            int endRec;
            DataTable dtTemp;
           

            //Clone the source table to create a temporary table.
            dtTemp = dtSource.Clone();

            if (currentPage == PageCount)
            {
                endRec = maxRec;
            }
            else
            {
                endRec = pageSize * currentPage;
            }
            startRec = recNo;

            //Copy rows from the source table to fill the temporary table.
            for (i = startRec; i < endRec; i++)
            {
                dtTemp.ImportRow(dtSource.Rows[i]);
                recNo += 1;
            }
            dataGridView1.DataSource = dtTemp;
            DisplayPageInfo();
        }

        private void DisplayPageInfo()
        {
            txtDisplayPageNo.Text = "Page " + currentPage.ToString() + "/ " + PageCount.ToString();
        }

        private bool CheckFillButton()
        {
            // Check if the user clicks the "Fill Grid" button.
            if (pageSize == 0)
            {
                MessageBox.Show("Set the Page Size, and then click the Fill Grid button!");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 codigoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);


            if (e.ColumnIndex == 13)
            {//11 es la pocision del boton 
               Abm_Cliente.Modificación mod = new Abm_Cliente.Modificación(codigoSeleccionado);
                mod.Show();

            }
          
        }

        private void btnFillGrid_Click(object sender, EventArgs e)
        {
            // Display the content of the current page.
            Entidades.Ent_ListadoPublicacion pCO = new Entidades.Ent_ListadoPublicacion();


            try
            {

                pCO.Descripcion = textBox1.Text;
                pCO.Rubro = Convert.ToString(this.codRubro);

                SqlConnection conn = DBConexion.obtenerConexion();
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.listaDePublicaciones", conn,
                new SqlParameter("@Descripcion", pCO.Descripcion),
                new SqlParameter("@Rubro", pCO.Rubro));


                SqlDataAdapter da = new SqlDataAdapter { SelectCommand = cmd };

                DataTable tabla = new DataTable();
                da.Fill(tabla);
                conn.Close();
                dataGridView1.DataSource = tabla;
                dataGridView1.Refresh();
                dataGridView1.ClearSelection();

                this.dtSource = tabla;

                // Set the start and max records. 
                pageSize = Convert.ToInt32(txtPageSize.Text);
                maxRec = dtSource.Rows.Count;
                PageCount = maxRec / pageSize;

                //Adjust the page number if the last page contains a partial page.
                if ((maxRec % pageSize) > 0)
                {
                    PageCount += 1;
                }

                // Initial seeings
                currentPage = 1;
                recNo = 0;

               LoadPage();

                this.botonCompraOferta = Utiles.Inicializar.agregarColumnaCompraOferta(botonCompraOferta, dataGridView1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            if (CheckFillButton() == false)
            {
                return;
            }

            //Check if you are already at the first page.
            if (currentPage == 1)
            {
                MessageBox.Show("Usted está en la primer página");
                return;
            }

            currentPage = 1;
            recNo = 0;
            LoadPage();
			
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            //If the user did not click the "Fill Grid" button, then return.
            if (CheckFillButton() == false)
            {
                return;
            }

            //Check if the user clicks the "Fill Grid" button.
            if (pageSize == 0)
            {
                MessageBox.Show("Set the Page Size, and then click the Fill Grid button!");
                return;
            }

            currentPage += 1;
            if (currentPage > PageCount)
            {
                currentPage = PageCount;
                //Check if you are already at the last page.
                if (recNo == maxRec)
                {
                    MessageBox.Show("Usted está en la última página");
                    return;
                }
            }
            LoadPage();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (CheckFillButton() == false)
            {
                return;
            }

            if (currentPage == PageCount)
            {
                recNo = pageSize * (currentPage - 2);
            }

            currentPage -= 1;
            //Check if you are already at the first page.
            if (currentPage < 1)
            {
                MessageBox.Show("Usted está en la primer página");
                currentPage = 1;
                return;
            }
            else
            {
                recNo = pageSize * (currentPage - 1);
            }
            LoadPage();
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            if (CheckFillButton() == false)
            {
                return;
            }

            //Check if you are already at the last page.
            if (recNo == maxRec)
            {
                MessageBox.Show("Usted está en la última página");
                return;
            }
            currentPage = PageCount;
            recNo = pageSize * (currentPage - 1);
            LoadPage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Generar_Publicacion.BuscarRubro list = new Generar_Publicacion.BuscarRubro();
            list.ShowDialog();
            txtRubro.Enabled = false;
            txtRubro.Text = list.Result;
            codRubro = list.ResultCodigo;
        }

           }
}
