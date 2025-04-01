using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ticket_windows_form.DB
{
    internal class Client
    {
        public static bool InsertClient(string name, string paternal, string maternal, DateTime birthdate, string email, string phone_number, string password) { 
            bool res = false;
            try
            {
                NpgsqlConnection connection = Connection.GetConnection();
                {
                    string query = "INSERT INTO cliente (nombre, ap_paterno, ap_materno, fecha_nacimiento, correo_electronico, telefono, contrasena) VALUES (@name, @paternal, @maternal, @birthdate, @email, @phone_number, @password)";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@paternal", paternal);
                        cmd.Parameters.AddWithValue("@maternal", maternal);
                        cmd.Parameters.AddWithValue("@birthdate", birthdate);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@phone_number", phone_number);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.ExecuteNonQuery();
                        res = true;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.Message);
            }

            return res;
        }

        public static bool ValidateCredential(string email, string password) {
            bool res = false;
            try
            {
                NpgsqlConnection connection = Connection.GetConnection();
                {
                    string query = "SELECT COUNT(*) FROM cliente WHERE correo_electronico = @email AND contrasena = @password";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection)) 
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.ExecuteNonQuery();
                        res = true;
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
            }

            return res;
        }
    }
}
