using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Npgsql;

namespace ticket_windows_form.DB
{
    internal class Zona
    {
        public static int GetZona(NpgsqlConnection connection)
        {
            int id_zona = 0;
            try
            {
                string query_zona = "SELECT id_zona FROM zona ORDER BY RANDOM() LIMIT 1";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query_zona, connection))
                {
                    object result = cmd.ExecuteScalar();
                    id_zona = result != null ? Convert.ToInt32(result) : 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener ID de empleado o zona: " + ex.Message);
            }
            return id_zona;
        }
    }
}
