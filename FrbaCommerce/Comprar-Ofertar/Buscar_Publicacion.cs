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
    public partial class Buscar_Publicacion : Form
    {
        DataTable dtSource;
        int PageCount;
        int maxRec;
        int pageSize;
        int currentPage;
        int recNo;
        Boolean primeraVez;
        char rolDeEste;

        public Buscar_Publicacion(decimal id, char rol)
        {
            InitializeComponent();
            //Inicializa el comboBox de visibilidades y le agrega la opción vacía para buscar sin el filtro
            List<Entidades.Ent_Visibilidad> listaDeVisibilidades = new List<Entidades.Ent_Visibilidad>();
            listaDeVisibilidades = Datos.Dat_Publicacion.ObtenerVisibilidades();

            Entidades.Ent_Visibilidad entVisibilidad = new Entidades.Ent_Visibilidad();
            entVisibilidad.Codigo = 0;
            entVisibilidad.Descripcion = "";

            listaDeVisibilidades.Insert(0, entVisibilidad);

            cmbVisib.DataSource = listaDeVisibilidades;
            cmbVisib.DisplayMember = "Descripcion";
            cmbVisib.ValueMember = "Codigo";
            
            rolDeEste = rol;

            botonCompraOferta = false;
            editarPublicacion = false;
            //Se fija si es empresa y le quita la posibilidad de buscar publicaciones de otros para comprar/ofertar, ya que solo puede editar sus publicaciones
            if (rol == 'E')
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


            //Clonar la tabla fuente para crear una tabla temporal.
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

            //Copia las filas de la tabla fuente para llenar la tabla temporal.
            for (i = startRec; i < endRec; i++)
            {
                dtTemp.ImportRow(dtSource.Rows[i]);
                recNo += 1;
            }
            dataGridView1.DataSource = dtTemp;
            DisplayPageInfo();
        }
        //Muestra información de la página actual y el total de páginas.
        private void DisplayPageInfo()
        {
            txtDisplayPageNo.Text = "Page " + currentPage.ToString() + "/ " + PageCount.ToString();
        }

        private bool CheckFillButton()
        {
            // Chequea si el usuario cliqueó el boton aceptar.
            if (pageSize == 0)
            {
                MessageBox.Show("Setee el tamaño de página y luego cliquee el boton");
                return false;
            }
            else
            {
                return true;
            }
        }



        private void btnFillGrid_Click(object sender, EventArgs e)
        {
            // Muestra los contenidos de la página actual.
            Entidades.Ent_ListadoPublicacion pCO = new Entidades.Ent_ListadoPublicacion();


            try
            {
  
                pCO.Descripcion = textBox1.Text;

                if (txtRubro.Enabled)
                {
                    pCO.Rubro = Datos.Dat_Publicacion.obtenerCodRubro(txtRubro.Text);
                }
                else { pCO.Rubro = 0; }
                pCO.Visibilidad = Convert.ToString(cmbVisib.SelectedValue);
                pCO.Estado = cmbEstado.Text;
                pCO.Tipo = cmbTipoPub.Text;
                pCO.MisPublicaciones = checkBox1.Checked;
                DataTable tabla = new DataTable();

                //Chequea el checkbox "Mis publicaciones" y trae las mías o las otras.
                SqlConnection conn = DBConexion.obtenerConexion();
                if (pCO.MisPublicaciones == false)
                {
                    SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.listaDePublicaciones", conn,
                    new SqlParameter("@Descripcion", pCO.Descripcion),
                    
                    new SqlParameter("@Estado", pCO.Estado),
                    new SqlParameter("@Tipo", pCO.Tipo),
                    new SqlParameter("@Visibilidad", pCO.Visibilidad),
                    new SqlParameter("@Id", Convert.ToString(idusuario)),
                    new SqlParameter("@Rubro", pCO.Rubro),
                    new SqlParameter("@FechaActual",DBConexion.fechaIngresadaPorElAdministrador()));
                    SqlDataAdapter da = new SqlDataAdapter { SelectCommand = cmd };
                    da.Fill(tabla);
                    conn.Close();
                }
                else
                {
                    SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.listaDeMisPublicaciones", conn,
                    new SqlParameter("@Descripcion", pCO.Descripcion),
                    //new SqlParameter("@Rol", rolDeEste),
                    new SqlParameter("@Estado", pCO.Estado),
                    new SqlParameter("@Tipo", pCO.Tipo),
                    new SqlParameter("@Visibilidad", pCO.Visibilidad),
                    new SqlParameter("@Id", Convert.ToString(idusuario)),
                    new SqlParameter("@Rubro", pCO.Rubro));
                    SqlDataAdapter da = new SqlDataAdapter { SelectCommand = cmd };
                    da.Fill(tabla);
                    conn.Close();
                }

                //llena el datagrid y deja invisibles algunas columnas.
                dataGridView1.DataSource = tabla;
                dataGridView1.Columns["Codigo"].Visible = false;
                dataGridView1.Columns["Usuario"].Visible = false;
                dataGridView1.Columns["Preguntas_permitidas"].Visible = false;
                dataGridView1.Columns["Tipo_Usuario"].Visible = false;
               // dataGridView1.Columns["Publicador"].Visible = false;
                dataGridView1.Refresh();
                dataGridView1.ClearSelection();

                this.dtSource = tabla;

                // Setea el comienzo y registros máximos.
                pageSize = Convert.ToInt32(txtPageSize.Text);
                maxRec = dtSource.Rows.Count;
                PageCount = maxRec / pageSize;

                //Ajusta el número de página si la última contiene una página parcial.
                if ((maxRec % pageSize) > 0)
                {
                    PageCount += 1;
                }

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

        //Agrega las columnas de editar o compra/oferta y preguntas.
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

            //Se fija si estas en la primer pagina
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
            //si el usuario no toca para llenar la datagrid
            if (CheckFillButton() == false)
            {
                return;
            }

            //Chequea si el usuario apreta.
            if (pageSize == 0)
            {
                MessageBox.Show("Set the Page Size, and then click the Fill Grid button!");
                return;
            }

            currentPage += 1;
            if (currentPage > PageCount)
            {
                currentPage = PageCount;
                //se fija si estas en la ultima pagina
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
            //se fija si estas en la primer pag
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

            //Se fija si ya estás en la última página.
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

        //Te lleva a la selección del filtro rubro.
        private void button1_Click(object sender, EventArgs e)
        {
            Generar_Publicacion.BuscarRubro list = new Generar_Publicacion.BuscarRubro(0,"buscar");
            list.ShowDialog();
            txtRubro.Enabled = true;
            txtRubro.Text = list.Result;
            codRubro = Convert.ToString(list.ResultCodigo);
        }

        //Cuando apretas uno de los botones del datagrid (compra/oferta, pregunta o editar) se fija cual es y muestra la ventana correspondiente.
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            decimal codigoSeleccionado = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Codigo"].Value);
            decimal idvendedor = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Usuario"].Value);
            char TipoUsuario = Convert.ToChar(dataGridView1.CurrentRow.Cells["Tipo_Usuario"].Value);
            string tipo = Convert.ToString(dataGridView1.CurrentRow.Cells["Tipo"].Value);
            if(botonCompraOferta)
            {
                if (e.ColumnIndex == dataGridView1.CurrentRow.Cells["btn"].ColumnIndex && checkBox1.Checked == false)
                {// es la pocision del boton 
                    if (idusuario != idvendedor)
                    {
                        if (tipo == "Subasta")
                        {

                            Comprar_Ofertar.VentanaOferta oferta = new Comprar_Ofertar.VentanaOferta(codigoSeleccionado, idusuario);
                            oferta.Show();
                            if (tipo == "CompraInmediata")
                            {
                                if (TipoUsuario == 'E')
                                {
                                    VentanaCompraEmpresa ventana = new VentanaCompraEmpresa(codigoSeleccionado, idusuario);
                                    ventana.Show();
                                }

                                if (TipoUsuario == 'C')
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

                        String vendedor = Datos.Dat_Usuario.getNameUser(idvendedor, TipoUsuario);
                        Utiles.Ventanas.Pregunta preg = new FrbaCommerce.Utiles.Ventanas.Pregunta(idusuario, rolDeEste, codigoSeleccionado);
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

        //Devuelve el estado a partir del código con un stored procedure.
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

        //Si está chequeado "Mis publicaciones" podés filtrar por otros estados ademas de publicada.
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
            }
        }

        //Limpia los filtros
        private void button2_Click(object sender, EventArgs e)
        {
            Utiles.LimpiarTexto.LimpiarTextBox2(this);
            if (rolDeEste == 'C')
            {
                Utiles.LimpiarTexto.SacarCheckBox(this);
            }
            txtRubro.Enabled = false;
            txtRubro.BackColor = Color.WhiteSmoke;
            cmbVisib.SelectedValue = "";
            cmbEstado.Text = "";
            cmbTipoPub.Text = "";
        }



   }
}