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
        public string ObtenerNombreConcierto(int conciertoId)
        {
            string ubicacionConcierto = string.Empty;
            string query = "SELECT ubicacion_concierto FROM CONCIERTO WHERE id_concierto = @conciertoId";

            try
            {
                using (NpgsqlConnection connection = Connection.GetConnection())
                {
                    connection.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@conciertoId", conciertoId);
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            ubicacionConcierto = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el concierto con el ID proporcionado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el nombre del concierto: " + ex.Message);
            }

            return ubicacionConcierto;
        }
    }
}
