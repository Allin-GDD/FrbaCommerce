using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Datos
{
    class Dat_Funcionalidad
    {
         //agrega una funcionalidad con su rol

        public static void chequeoDeAddFuncionalidad(CheckBox chkAgregar, decimal rol, int func)
        {
            if (chkAgregar.Checked)
            {
                Datos.Dat_Rol.agregarFuncionalidad(rol, func);
            }
        }

        // remueve una funcionalidad con su rol
        public static void chequeoRemoveFuncioalidad(CheckBox chkQuitar, decimal rol, int func)
        {
            if (chkQuitar.Checked)
            {
                Datos.Dat_Rol.removerFuncionalidad(rol, func);
               
            }
        }

        internal static List<Entidades.Ent_Funcionalidad> listadoDeFuncionalidades(decimal IdRol)
        {
            List<Entidades.Ent_Funcionalidad> func = new List<FrbaCommerce.Entidades.Ent_Funcionalidad>();

            using (SqlConnection conn = DBConexion.obtenerConexion())
         
            {
                SqlCommand cmd = Utiles.SQL.crearProcedure("GD1C2014.dbo.listadodeFunc", conn,
                new SqlParameter("@Id_Rol", IdRol));
                SqlDataReader lectura = cmd.ExecuteReader();

                while (lectura.Read())
                {
                    Entidades.Ent_Funcionalidad entidad_func = new FrbaCommerce.Entidades.Ent_Funcionalidad();

                    entidad_func.id = lectura.GetInt32(0);
                    entidad_func.funcionalidad = lectura.GetString(1);
                    func.Add(entidad_func);
                }
                conn.Close();
                return func;
            }
           
        }

     
    }
}
