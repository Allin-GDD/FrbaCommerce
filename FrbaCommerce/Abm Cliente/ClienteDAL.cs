using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace FrbaCommerce.Abm_Cliente
{
    class ClienteDAL
    {
        public static int AgregarCliente(Cliente pCliente) {
            int retorno = 0;
            using (SqlConnection conexion = DBConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert into Clientes(Id, Nombre, Apellido, Dni, Tipo_dni, Fecha_Nac, Mail, Dom_Calle, Nro_Calle, Piso, Dpto, Cod_Postal, Telefono) values({0},'{1}','{2}',{3},{4},'{5}','{6}','{7}',{8},{9},'{10}','{11}','{12}')",
                    pCliente.Id, pCliente.Nombre, pCliente.Apellido, pCliente.Dni, pCliente.Tipo_dni, pCliente.Fecha_Nac, pCliente.Mail, pCliente.Dom_Calle, pCliente.Nro_Calle, pCliente.Piso, pCliente.Dpto, pCliente.Cod_Postal, pCliente.Telefono), conexion);

                retorno = Comando.ExecuteNonQuery();
            }

            return retorno;
        }
    }
}
