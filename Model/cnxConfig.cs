using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HotelManag.Model
{
  
    public class cnxConfig
    {  
        static string mycon = "server =localhost; Uid=root; password = ; persistsecurityinfo = True; database =hotelman; SslMode = none";
        static MySqlConnection con = new MySqlConnection(mycon);
        static DataTable dt = new DataTable();
        static MySqlCommand cmd = null;
        public static MySqlConnection Connect()
        {
            var server = "localhost";
            var database = " hotelman";
            var user = "root";
            var password = "";
            var port = "3306";
            var sslM = "none";

            var connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
     
    }
}
