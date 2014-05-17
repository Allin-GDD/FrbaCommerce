using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace FrbaCommerce
{
    public class DBConexion
    {
        public static SqlConnection obtenerConexion() 
        {
            SqlConnection conn = new SqlConnection(@"Data source = MATÍAS-PC\SQLSERVER2008; Initial catalog = GD1C2014; User Id = gd; Password = gd2014 ");
            conn.Open();
            return conn;
        }
    }
}
