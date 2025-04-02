using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace ticket_windows_form.DB
{
    internal class Connection
    {
        static String server = "localhost";
        static String bd = "BOLETERIA";
        static String user = "postgres";
        static String password = "1234";
        static String port = "5432";

        private static string conn = "server=" + server + ";" + "port=" + port + ";" + "user id=" + user + ";" + "password=" + password + ";" + "database=" + bd + ";";
        private static NpgsqlConnection connection = new NpgsqlConnection(conn);

        public static NpgsqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new NpgsqlConnection(conn);
                connection.Open();
            }
            else if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            return connection;
        }

        public static void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

    }
}
