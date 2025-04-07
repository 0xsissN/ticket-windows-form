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
    internal class Receipt
    {
        public static void GenerateReceipt(
            int sale_ticket_id,
            string payment_method)
        {
            try
            {
                NpgsqlConnection connection = Connection.GetConnection();
                {
                    string query = "INSERT INTO RECIBO (fecha_emision, metodo_pago, venta_boleto_id) VALUES (@issue_date, @payment_method, @sale_ticket_id)";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@issue_date", DateTime.Now.Date); 
                        cmd.Parameters.AddWithValue("@payment_method", payment_method);  
                        cmd.Parameters.AddWithValue("@sale_ticket_id", sale_ticket_id);  
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el recibo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static int GetLastReceiptID()
        {
            int last_receipt_id = 0;

            try
            {
                NpgsqlConnection connection = Connection.GetConnection();
                {
                    string query = "SELECT COALESCE(MAX(id_recibo), 0) FROM recibo;";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            last_receipt_id = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el último id_recibo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return last_receipt_id;
        }
    }
}
