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
    internal class SellDetails
    {
        public static void AddDetailSale(
            int sale_ticket_id, 
            string chosen_zone, 
            decimal unit_price)
        {
            try
            {
                NpgsqlConnection connection = Connection.GetConnection();
                {
                    string query = "INSERT INTO DETALLE_BOLETO (fecha_compra, zona_elegida, precio_unitario, venta_boleto_id) VALUES (@purchase_date, @chosen_zone, @unit_price, @sale_ticket_id)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@purchase_date", DateTime.Now.Date); 
                        cmd.Parameters.AddWithValue("@chosen_zone", chosen_zone);  
                        cmd.Parameters.AddWithValue("@unit_price", unit_price);  
                        cmd.Parameters.AddWithValue("@sale_ticket_id", sale_ticket_id);  
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el detalle del boleto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
