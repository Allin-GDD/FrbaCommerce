﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace FrbaCommerce.Datos
{
    class Dat_Cliente
    {


        public static List<Entidades.Ent_Telefono> obtenerTodosLosTelefonos()
        {
            List<Entidades.Ent_Telefono> listaDeTelefonos = new List<Entidades.Ent_Telefono>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("Select Telefono from Clientes", conexion);
            SqlDataReader lectura = Comando.ExecuteReader();


            while (lectura.Read())
            {
                Entidades.Ent_Telefono pTelefono = new Entidades.Ent_Telefono();

                pTelefono.Telefono = lectura.GetString(0);

                listaDeTelefonos.Add(pTelefono);
            }
            return listaDeTelefonos;



        }

        public static List<Entidades.Ent_TipoDeDoc> ObtenerTipoDoc()
        {

            List<Entidades.Ent_TipoDeDoc> listaDeTipos = new List<Entidades.Ent_TipoDeDoc>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("Select Codigo, Nombre from Tipo_Doc", conexion);
            SqlDataReader lectura = Comando.ExecuteReader();

            while (lectura.Read())
            {
                Entidades.Ent_TipoDeDoc pTipoDeDoc = new Entidades.Ent_TipoDeDoc();
                pTipoDeDoc.codigo = lectura.GetInt16(0);
                pTipoDeDoc.tipo = lectura.GetString(1);

                listaDeTipos.Add(pTipoDeDoc);
            }
            return listaDeTipos;
        }

        public static List<Entidades.Ent_Dni> obtenerTodosLosDni()
        {

            List<Entidades.Ent_Dni> listaDeDni = new List<Entidades.Ent_Dni>();

            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand("Select Dni from Clientes", conexion);
            SqlDataReader lectura = Comando.ExecuteReader();

            while (lectura.Read())
            {
                Entidades.Ent_Dni pDni = new Entidades.Ent_Dni();

                pDni.Dni = lectura.GetDecimal(0);
               

                listaDeDni.Add(pDni);
            }


            return listaDeDni;
        }

        public static int AgregarCliente(Entidades.Ent_Cliente pCliente)
        {
            int retorno = 0;
            using (SqlConnection conexion = DBConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert into Clientes(Nombre, Apellido, Dni, Tipo_dni, Fecha_Nac, Mail, Dom_Calle, Nro_Calle, Piso, Depto, Cod_Postal, Telefono, Localidad) values('{0}','{1}',{2},{3},'{4}','{5}','{6}',{7},{8},'{9}','{10}','{11}','{12}')",
                     pCliente.Nombre, pCliente.Apellido, pCliente.Dni, pCliente.Tipo_dni, pCliente.Fecha_Nac, pCliente.Mail, pCliente.Dom_Calle, pCliente.Nro_Calle, pCliente.Piso, pCliente.Dpto, pCliente.Cod_Postal, pCliente.Telefono, pCliente.Localidad), conexion);


                retorno = Comando.ExecuteNonQuery();
            }

            return retorno;
        }






        public static Entidades.Ent_Cliente obtenerDatosDelCliente(Int32 pIdCliente)
        {

            Entidades.Ent_Cliente pCliente = new Entidades.Ent_Cliente();
            SqlConnection conexion = DBConexion.obtenerConexion();
            SqlCommand Comando = new SqlCommand(string.Format("Select * from Clientes where Clientes.Id = {0}", pIdCliente), conexion);
            SqlDataReader lectura = Comando.ExecuteReader();

            pCliente.Dni = lectura.GetDecimal(1);
            pCliente.Nombre = lectura.GetString(2);
            pCliente.Apellido = lectura.GetString(3);
            pCliente.Fecha_Nac = Convert.ToString(lectura.GetDateTime(4));
            pCliente.Mail = lectura.GetString(5);
            pCliente.Dom_Calle = lectura.GetString(6);
            pCliente.Nro_Calle = lectura.GetDecimal(7);
            pCliente.Piso= lectura.GetDecimal(8);
            pCliente.Dpto = lectura.GetString(9);
            pCliente.Cod_Postal = lectura.GetString(10);
            pCliente.Localidad = lectura.GetString(11);
            pCliente.Tipo_dni = lectura.GetInt16(12);
            pCliente.Telefono = lectura.GetString(13);

            return pCliente;
            ;

        }



        public static List<Entidades.Ent_Cliente> buscarLosClientes(Entidades.Ent_Cliente pCliente)
        {
          
            List<Entidades.Ent_Cliente> listaDeClientes = new List<Entidades.Ent_Cliente>();
            
            SqlConnection conexion = DBConexion.obtenerConexion();

            SqlCommand Comando = new SqlCommand(string.Format("Select * from Clientes where Nombre like '%{0}%' AND  Apellido like '%{1}%' AND Dni like '%{2}%' AND Tipo_dni like '%{3}%' AND Mail like '%{4}%'", pCliente.Nombre, pCliente.Apellido, pCliente.Dni, pCliente.Tipo_dni, pCliente.Mail), conexion);

            SqlDataReader lectura = Comando.ExecuteReader();
       
            while (lectura.Read()){
         Entidades.Ent_Cliente clienteTentativo = new Entidades.Ent_Cliente();

         clienteTentativo.Dni = lectura.GetDecimal(1);
         clienteTentativo.Nombre = lectura.GetString(2);
         clienteTentativo.Apellido = lectura.GetString(3);
         clienteTentativo.Fecha_Nac = Convert.ToString(lectura.GetDateTime(4));
         clienteTentativo.Mail = lectura.GetString(5);
         clienteTentativo.Dom_Calle = lectura.GetString(6);
         clienteTentativo.Nro_Calle = lectura.GetDecimal(7);
         clienteTentativo.Piso = lectura.GetDecimal(8);
         clienteTentativo.Dpto = lectura.GetString(9);
         clienteTentativo.Cod_Postal = lectura.GetString(10);
         clienteTentativo.Localidad = lectura.GetString(11);
         clienteTentativo.Tipo_dni = lectura.GetInt16(12);
         clienteTentativo.Telefono = lectura.GetString(13);

                   listaDeClientes.Add(clienteTentativo);
           
        }

            return listaDeClientes;
        }
    }

}