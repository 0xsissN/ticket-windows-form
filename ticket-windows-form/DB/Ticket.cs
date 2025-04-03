using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Npgsql;

namespace ticket_windows_form.DB
{
    internal class Ticket
    {
        public static DataTable GetSellTicket()
        {
            DataTable dt = new DataTable();

            try
            {
                NpgsqlConnection connection = Connection.GetConnection();
                {
                    string query = "SELECT * FROM VENTA_BOLETO";
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                    adapter.Fill(dt);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
            }

            return dt;
        }

        public static DataTable GetDetailTicket()
        {
            DataTable dt = new DataTable();

            try
            {
                NpgsqlConnection connection = Connection.GetConnection();
                {
                    string query = "SELECT * FROM RECIBO";
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
            }

            return dt;
        }
    }
}
