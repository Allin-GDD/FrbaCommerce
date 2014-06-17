﻿using System;
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
    public partial class Buscar_Publicacion : Form
    {
        DataTable dtSource;
        int PageCount;
        int maxRec;
        int pageSize;
        int currentPage;
        int recNo;
        Boolean primeraVez;
        string rolDeEste;

        public Buscar_Publicacion(decimal id, string rol)
        {
            InitializeComponent();
            Utiles.Inicializar.comboBoxVisibilidad(cmbVisib);
            cmbEstado.Text = "Publicada";
            cmbTipoPub.Text = "Subasta";
            rolDeEste = rol;
            botonCompraOferta = false;
            editarPublicacion = false;
            if (rol == "E")
            {
                checkBox1.Checked = true;
                checkBox1.Enabled = false;
                checkBox1.Visible = false;
            }
            idusuario = id;
            primeraVez = true;

        }
        private decimal idusuario;
        private bool botonCompraOferta;
        private bool botonPregunta;
        private bool editarPublicacion;
        private string codRubro;
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



        private void btnFillGrid_Click(object sender, EventArgs e)
        {
            // Display the content of the current page.
            Entidades.Ent_ListadoPublicacion pCO = new Entidades.Ent_ListadoPublicacion();


            try
            {
  
                pCO.Descripcion = textBox1.Text;
                pCO.Rubro = "";
                if (txtRubro.Enabled)
                {
                    pCO.Rubro = Convert.ToString(Datos.Dat_Publicacion.obtenerCodRubro(txtRubro.Text));
                }
                pCO.Visibilidad = Convert.ToString(cmbVisib.SelectedValue);
                pCO.Estado = cmbEstado.Text;
                pCO.Tipo = cmbTipoPub.Text;
                pCO.MisPublicaciones = checkBox1.Checked;
                DataTable tabla = new DataTable();

                SqlConnection conn = DBConexion.obtenerConexion();
                if (pCO.MisPublicaciones == false)
                {
                    SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.listaDePublicaciones", conn,
                    new SqlParameter("@Descripcion", pCO.Descripcion),
                    new SqlParameter("@Rol", rolDeEste),
                    new SqlParameter("@Estado", pCO.Estado),
                    new SqlParameter("@Tipo", pCO.Tipo),
                    new SqlParameter("@Visibilidad", pCO.Visibilidad),
                    new SqlParameter("@Id", Convert.ToString(idusuario)),
                    new SqlParameter("@Rubro", pCO.Rubro));
                    SqlDataAdapter da = new SqlDataAdapter { SelectCommand = cmd };
                    da.Fill(tabla);
                    conn.Close();
                }
                else
                {
                    SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.listaDeMisPublicaciones", conn,
                    new SqlParameter("@Descripcion", pCO.Descripcion),
                    new SqlParameter("@Rol", rolDeEste),
                    new SqlParameter("@Estado", pCO.Estado),
                    new SqlParameter("@Tipo", pCO.Tipo),
                    new SqlParameter("@Visibilidad", pCO.Visibilidad),
                    new SqlParameter("@Id", Convert.ToString(idusuario)),
                    new SqlParameter("@Rubro", pCO.Rubro));
                    SqlDataAdapter da = new SqlDataAdapter { SelectCommand = cmd };
                    da.Fill(tabla);
                    conn.Close();
                }


                dataGridView1.DataSource = tabla;
                dataGridView1.Columns["Codigo"].Visible = false;
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["Visibilidad_Cod"].Visible = false;
                dataGridView1.Columns["Preguntas_permitidas"].Visible = false;
                dataGridView1.Columns["Publicador"].Visible = false;
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


                agregarColumnas();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void agregarColumnas()
        {
            if (checkBox1.Checked == false)
            {
                if (editarPublicacion == true && primeraVez == false)
                {
                    dataGridView1.Columns.Remove("btnEditar");

                }
                primeraVez = false;
                editarPublicacion = false;
                this.botonCompraOferta = Utiles.Inicializar.agregarColumnaCompraOferta(botonCompraOferta, dataGridView1);
                this.botonPregunta = Utiles.Inicializar.agregarColumnaPregunta(botonPregunta, dataGridView1);
            }
            else
            {
                if (botonCompraOferta == true && primeraVez == false)
                {
                    dataGridView1.Columns.Remove("btnPregunta");
                    dataGridView1.Columns.Remove("btn");
                    
                    botonPregunta = false;

                }
                primeraVez = false;

                botonCompraOferta = false;
                this.editarPublicacion = Utiles.Inicializar.agregarColumnaEditarPublicacion(editarPublicacion, dataGridView1);
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
            agregarColumnas();

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
            agregarColumnas();
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
            agregarColumnas();
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
            agregarColumnas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Generar_Publicacion.BuscarRubro list = new Generar_Publicacion.BuscarRubro();
            list.ShowDialog();
            txtRubro.Enabled = true;
            txtRubro.Text = list.Result;
            codRubro = Convert.ToString(list.ResultCodigo);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            decimal codigoSeleccionado = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Codigo"].Value);
            decimal idvendedor = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Id"].Value);
            char publicador = Convert.ToChar(dataGridView1.CurrentRow.Cells["Publicador"].Value);
            string tipo = Convert.ToString(dataGridView1.CurrentRow.Cells["Tipo"].Value);
            if(botonCompraOferta)
            {
                if (e.ColumnIndex == dataGridView1.CurrentRow.Cells["btn"].ColumnIndex && checkBox1.Checked == false)
                {//11 es la pocision del boton 
                    if (idusuario != idvendedor || (idusuario == idvendedor && publicador == 'E'))
                    {
                        if (tipo == "Subasta")
                        {

                            Comprar_Ofertar.VentanaOferta oferta = new Comprar_Ofertar.VentanaOferta(codigoSeleccionado, idusuario);
                            oferta.Show();
                            if (tipo == "CompraInmediata")
                            {
                                if (publicador == 'E')
                                {
                                    VentanaCompraEmpresa ventana = new VentanaCompraEmpresa(codigoSeleccionado, idusuario);
                                    ventana.Show();
                                }

                                if (publicador == 'C')
                                {
                                    VentanaCompra ventana = new VentanaCompra(codigoSeleccionado, idusuario);
                                    ventana.Show();
                                }
                            }
                        }
                    }
                }
                if (e.ColumnIndex == dataGridView1.CurrentRow.Cells["btnPregunta"].ColumnIndex)
                {
                    try
                    {
                        if ((!Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Preguntas_permitidas"].Value)))
                        {
                            throw new Excepciones.InexistenciaUsuario("La publicación no permite preguntas");
                        }
                        decimal rolAsignado;
                        if (publicador == 'E')
                        {
                            rolAsignado = 2;
                        }
                        else
                        {
                            rolAsignado = 1;
                        }

                        String vendedor = Datos.Dat_Usuario.getNameUser(idvendedor, rolAsignado);
                        Utiles.Ventanas.Pregunta preg = new FrbaCommerce.Utiles.Ventanas.Pregunta(idusuario, rolDeEste, codigoSeleccionado, vendedor);
                        preg.ShowDialog();

                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                
                }
            }
            else if (e.ColumnIndex == dataGridView1.CurrentRow.Cells["btnEditar"].ColumnIndex && checkBox1.Checked && obtenerEstadoPub(codigoSeleccionado) != "Finalizada")
            {
                if (obtenerEstadoPub(codigoSeleccionado) == "Publicada" || obtenerEstadoPub(codigoSeleccionado) == "Pausada")
                {
                    Editar_Publicacion.Editar_Publicacion_Publicada ventana = new Editar_Publicacion.Editar_Publicacion_Publicada(codigoSeleccionado);
                    ventana.Show();
                }
                else if (obtenerEstadoPub(codigoSeleccionado) == "Borrador")
                {
                    Editar_Publicacion.Editar_Publicacion_Borrada ventana = new Editar_Publicacion.Editar_Publicacion_Borrada(codigoSeleccionado);
                    ventana.Show();
                }
            }
        
            
        }

        private string obtenerEstadoPub(Decimal codigo)
        {
            string estado;
            SqlConnection conn = DBConexion.obtenerConexion();
            SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.verificarEstado", conn,

            new SqlParameter("@Codigo", codigo));


            SqlDataReader lectura = cmd.ExecuteReader();

            lectura.Read();

            estado = lectura.GetString(0);


            conn.Close();

            return estado;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                cmbEstado.Items.Add("Borrador");
                cmbEstado.Items.Add("Pausada");
                cmbEstado.Items.Add("Finalizada");

            }
            else
            {
                cmbEstado.Items.Remove("Borrador");
                cmbEstado.Items.Remove("Pausada");
                cmbEstado.Items.Remove("Finalizada");
                cmbEstado.Text = "Publicada";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utiles.LimpiarTexto.LimpiarTextBox2(this);
            if (rolDeEste == "C")
            {
                Utiles.LimpiarTexto.SacarCheckBox(this);
            }
            txtRubro.Enabled = false;
            txtRubro.BackColor = Color.WhiteSmoke;
        }

   }
}