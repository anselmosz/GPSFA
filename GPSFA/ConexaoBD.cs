using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GPSFA
{
    public class ConexaoBD
    {
        private static string connString = "Server=localhost;Port=3306;Database=dbgpfsa;Uid=root;Pwd=''";

        private static MySqlConnection conn = null;

        public static MySqlConnection abrirConexao()
        {
            conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
            }
            catch (MySqlException)
            {
                return conn = null;
            }
            return conn;
        }

        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
