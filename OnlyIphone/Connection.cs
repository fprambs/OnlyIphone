using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlyIphone
{
    class Connection
    {
        public static MySqlConnection getConnection()
        {
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1; database=onlyiphone; Uid=root; pwd=;");

            connect.Open();
            return connect;
        }
    }
}
