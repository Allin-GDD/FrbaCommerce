using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace FrbaCommerce
{
    public class DBConexion
    {
        public static SqlConnection obtenerConexion() 
        {
            string ConnectionString = System.IO.File.ReadAllText(@"Config.txt");

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }

    }
}