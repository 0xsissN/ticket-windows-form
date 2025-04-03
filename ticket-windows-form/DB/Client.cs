using System;
using System.Collections.Generic;
using System.Data;
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

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        res = count > 0; 
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
            }

            return res;
        }

        public static DataTable GetClient()
        {
            DataTable dt = new DataTable();
            try
            {
                NpgsqlConnection connection = Connection.GetConnection();
                string query = @"SELECT * FROM cliente
                         ORDER BY id_cliente ASC";
                
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la lista de clientes: " + ex.Message);
            }

            return dt;
        }
        
        public static bool EditClient(int idClient, string name, string paternal, string maternal,
                      string phone, string email, string password, DateTime birthdate)
        {
            try
            {
                NpgsqlConnection connection = Connection.GetConnection();
                {
                    if (connection == null || connection.State != System.Data.ConnectionState.Open)
                    {
                        MessageBox.Show("No se pudo establecer conexión con la base de datos.");
                        return false;
                    }

                    string query = @"UPDATE cliente SET nombre = @name, ap_paterno = @paternal, ap_materno = @maternal, 
                          telefono = @phone, correo_electronico = @email, contrasena = @password, fecha_nacimiento = @birthdate
                      WHERE id_cliente = @idClient";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@idClient", idClient);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@paternal", paternal);
                        cmd.Parameters.AddWithValue("@maternal", maternal);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@birthdate", birthdate);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el cliente: " + ex.Message);
                return false;
            }
        }
    }
}
