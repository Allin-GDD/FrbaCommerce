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
            cmbRol.DataSource = Datos.Dat_Rol.ObtenerTodosLosRoles();
            cmbRol.DisplayMember = "Nombre";
            cmbRol.ValueMember = "Id";

        }
        public static void comboBoxVisibilidad(ComboBox cmbVisib)
        {
            cmbVisib.DataSource = Datos.Dat_Publicacion.ObtenerVisibilidades();
            cmbVisib.DisplayMember = "Descripcion";
            cmbVisib.ValueMember = "Codigo";

        }

        public static void comboBoxHabilitado(ComboBox cmbHabilitado, Int32 id, Int16 rol)
        {
            List<Entidades.Ent_Habilitado> lista = new List<Entidades.Ent_Habilitado>();

            Entidades.Ent_Habilitado valorSi = new Entidades.Ent_Habilitado();
            Entidades.Ent_Habilitado valorNo = new Entidades.Ent_Habilitado();
            valorSi.estado = 1;
            valorSi.valor = "Si";
            valorNo.estado = 0;
            valorNo.valor = "No";

            Int16 i = Datos.Dat_Usuario.obtenerEstado(id, rol);
            if (i == 0)
            {
                lista.Add(valorNo);
                lista.Add(valorSi);
            }
            else
            {
                lista.Add(valorSi);
                lista.Add(valorNo);
            }
            cmbHabilitado.DataSource = lista;
            cmbHabilitado.DisplayMember = "valor";
            cmbHabilitado.ValueMember = "estado";

        }

        public static void comboBoxFuncionalidades(ComboBox cmbFuncionalidad)
        {


            List<Entidades.Ent_Funcionalidad> lista = Utiles.Funcionalidades.listaDeFuncionalidades();
            cmbFuncionalidad.DataSource = lista;
            cmbFuncionalidad.DisplayMember = "funcionalidad";
            cmbFuncionalidad.ValueMember = "id";
        }


        


        public static void comboBoxFuncionalidadesPropias(ComboBox cmbPropias, Decimal idSeleccionado)
        {
            List<int> funcionalidades = Datos.Dat_Rol.buscarFuncDe(idSeleccionado);
            List<Entidades.Ent_Funcionalidad> lista = Utiles.Funcionalidades.listaDeFuncionalidades();
            List<Entidades.Ent_Funcionalidad> listaAAgregar = new List<Entidades.Ent_Funcionalidad>();

            foreach (Entidades.Ent_Funcionalidad listaVieja in lista)
            {
                foreach (int func in funcionalidades)
                {
                    if (func == listaVieja.id)
                    {
                        Entidades.Ent_Funcionalidad funcNueva = new Entidades.Ent_Funcionalidad();
                        funcNueva.id = func;
                        funcNueva.funcionalidad = listaVieja.funcionalidad;
                        listaAAgregar.Add(funcNueva);
                    }
                }
            }
            cmbPropias.DataSource = listaAAgregar;
            cmbPropias.DisplayMember = "funcionalidad";
            cmbPropias.ValueMember = "id";


        }

        public static void comboBoxHabilitadoRol(ComboBox cmbHabilitado, decimal idSeleccionado)
        {
            List<Entidades.Ent_Habilitado> lista = new List<Entidades.Ent_Habilitado>();

            Entidades.Ent_Habilitado valorSi = new Entidades.Ent_Habilitado();
            Entidades.Ent_Habilitado valorNo = new Entidades.Ent_Habilitado();
            valorSi.estado = 1;
            valorSi.valor = "Si";
            valorNo.estado = 0;
            valorNo.valor = "No";

            int estado = Datos.Dat_Rol.obtenerEstado(idSeleccionado);

            if (estado == 0)
            {
                lista.Add(valorNo);
                lista.Add(valorSi);
            }
            else
            {
                lista.Add(valorSi);
                lista.Add(valorNo);
            }
            cmbHabilitado.DataSource = lista;
            cmbHabilitado.DisplayMember = "valor";
            cmbHabilitado.ValueMember = "estado";
        }

        public static bool AgregarColumnaEliminar(bool botonDelete, DataGridView dataGridView1)
        {
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
            return botonDelete;
        }

        public static bool agregarColumnaModificar(bool botonModificar, DataGridView dataGridView1)
        {
            if (!botonModificar)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                dataGridView1.Columns.Add(btn);
                btn.HeaderText = "Modificar";
                btn.Text = "";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
                botonModificar = true;//no devuelve el boolean cambiar
           
            }
            return botonModificar;
        }

        public static bool agregarColumnaCompraOferta(bool botonCompraOferta, DataGridView dataGridView1)
        {
            if (!botonCompraOferta)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                dataGridView1.Columns.Add(btn);
                btn.HeaderText = "Compra/Oferta";
                btn.Text = "";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
                botonCompraOferta = true;//no devuelve el boolean cambiar
                
            }   
            return botonCompraOferta;
        }

        public static bool agregarColumnaEditarPublicacion(bool botonEditarPublicacion, DataGridView dataGridView1)
        {
            if (!botonEditarPublicacion)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                dataGridView1.Columns.Add(btn);
                btn.HeaderText = "Editar";
                btn.Text = "";
                btn.Name = "btnEditar";
                btn.UseColumnTextForButtonValue = true;
                botonEditarPublicacion = true;//no devuelve el boolean cambiar

            }
            return botonEditarPublicacion;
        }

        public static void comboBoxRubro(ComboBox cmbRubro)
        {
            cmbRubro.DataSource = Datos.Dat_Publicacion.ObtenerRubros();
            cmbRubro.DisplayMember = "rubro";
            cmbRubro.ValueMember = "codigo";

        }


        public static bool agregarColumnaPregunta(bool botonPregunta, DataGridView dataGridView1)
        {
            if (!botonPregunta)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                dataGridView1.Columns.Add(btn);
                btn.HeaderText = "Pregunta";
                btn.Text = "";
                btn.Name = "btnPregunta";
                btn.UseColumnTextForButtonValue = true;
                botonPregunta = true;//no devuelve el boolean cambiar

            }
            return botonPregunta;
        }

        public static void comboBoxTrimestre(ComboBox cmbTrimestre)
        {
            List<Entidades.Ent_Funcionalidad> lista = new List<FrbaCommerce.Entidades.Ent_Funcionalidad>();
            lista.Add(agregaCampoNombreYId("Primer Trimestre (Enero a Marzo)", 1));
            lista.Add(agregaCampoNombreYId("Segundo Trimestre (Abril a Junio)", 2));
            lista.Add(agregaCampoNombreYId("Tercer Trimestre (Julio a Septiembre)", 3));
            lista.Add(agregaCampoNombreYId("Cuarto Trimestre (Octubre a Diciembre)", 4));

            cmbTrimestre.DataSource = lista;
            cmbTrimestre.DisplayMember = "funcionalidad";
            cmbTrimestre.ValueMember = "id";
         

            
        }

        private static Entidades.Ent_Funcionalidad agregaCampoNombreYId(string p, int num)
        {
            Entidades.Ent_Funcionalidad trimestre = new FrbaCommerce.Entidades.Ent_Funcionalidad();
            trimestre.funcionalidad = p;
            trimestre.id = num;
            return trimestre;
        }

        internal static void comboBoxTipoListado(ComboBox cmbTipolist)
        {            List<Entidades.Ent_Funcionalidad> lista = new List<FrbaCommerce.Entidades.Ent_Funcionalidad>();
            lista.Add(agregaCampoNombreYId("Vendedores con mayor cantidad de productos no vendidos", 1));
            lista.Add(agregaCampoNombreYId("Vendedores con mayor facturación", 2));
            lista.Add(agregaCampoNombreYId("Vendedores con mayores calificaciones", 3));
            lista.Add(agregaCampoNombreYId("Clientes con mayor cantidad de publicaciones en calificar", 4));

            cmbTipolist.DataSource = lista;
            cmbTipolist.DisplayMember = "funcionalidad";
            cmbTipolist.ValueMember = "id";
         
        }


        internal static void comboBoxMes(ComboBox cmbMes, int p)
        {
            List<Entidades.Ent_Funcionalidad> lista = new List<FrbaCommerce.Entidades.Ent_Funcionalidad>();

            if (p == 1) {
                lista.Add(agregaCampoNombreYId("Enero", 1));
                lista.Add(agregaCampoNombreYId("Febrero", 2));
                lista.Add(agregaCampoNombreYId("Marzo", 3));

            }
            if (p == 2) {
                lista.Add(agregaCampoNombreYId("Abril", 4));
                lista.Add(agregaCampoNombreYId("Mayo", 5));
                lista.Add(agregaCampoNombreYId("Junio", 6));
            
            }
            if (p == 3) {
                lista.Add(agregaCampoNombreYId("Julio", 7));
                lista.Add(agregaCampoNombreYId("Agosto", 8));
                lista.Add(agregaCampoNombreYId("Septiembre", 9));
            }
            if (p == 4) {
                lista.Add(agregaCampoNombreYId("Octubre", 10));
                lista.Add(agregaCampoNombreYId("Noviembre", 11));
                lista.Add(agregaCampoNombreYId("Diciembre", 12));

            }

            cmbMes.DataSource = lista;
            cmbMes.DisplayMember = "funcionalidad";
            cmbMes.ValueMember = "id";
        }
    }

}