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
            string[] lines = File.ReadAllLines(@"config.txt");

            string ConnectionString = lines[0];
            string fecha = lines[1];

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn;

            
        }

    }
}