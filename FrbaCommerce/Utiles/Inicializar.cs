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
    }

}