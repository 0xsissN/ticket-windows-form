using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace ticket_windows_form.DB
{
    internal class SellTickets
    {
        public static void AddTicket(int concert_id, int client_id, decimal total_cost)
        {
            try
            {
                NpgsqlConnection connection = Connection.GetConnection();
                {
                    string query = "INSERT INTO VENTA_BOLETO (concierto_id, cliente_id, costo_total) VALUES (@concert_id, @client_id, @total_cost)";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@concert_id", concert_id);
                        cmd.Parameters.AddWithValue("@client_id", client_id);
                        cmd.Parameters.AddWithValue("@total_cost", total_cost);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el boleto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static int GetLastTicketId()
        {
            int last_ticket_id = 0;
            try
            {
                NpgsqlConnection connection = Connection.GetConnection();
                {
                    string query = "SELECT currval(pg_get_serial_sequence('venta_boleto', 'id_venta'))";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            last_ticket_id = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el último boleto insertado o la secuencia no ha sido utilizada en esta sesión.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el último ID de boleto: " + ex.Message);
            }

            return last_ticket_id;
        }
    }
}
