using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace login
{
    internal class connectionservice
    {
        public static MySqlConnection getConnection()
        {
            MySqlConnection conn = null;

            try
            {
                string sConnstring = "server = localhost;database= db_sekolah;uid=root;password=;";
                conn = new MySqlConnection(sConnstring);
            }
            catch (MySqlException sqlex)
            {
                throw new Exception(sqlex.Message.ToString());
            }
            return conn;
        }
    }
}
