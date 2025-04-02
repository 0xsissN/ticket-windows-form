using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ticket_windows_form.DB
{
    internal class Employee
    {
        public static bool AddEmployee(string name, string paternal, string maternal, string phone, string email, string password, DateTime birthdate, int salary, DateTime hiring_date, string charge) 
        {
            bool res = false;
            try
            {
                NpgsqlConnection connection = Connection.GetConnection();
                {
                    if (hiring_date == DateTime.MinValue || hiring_date == DateTime.MaxValue)
                    {
                        hiring_date = DateTime.Now;
                    }

                    string query = "INSERT INTO empleado (nombre, ap_paterno, ap_materno, telefono, correo_electronico, contrasena, fecha_nacimiento, sueldo, fecha_contratacion, cargo) VALUES (@name, @paternal, @maternal, @phone, @email, @password, @birthdate, @salary, @hiring_date, @charge)";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection)) 
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@paternal", paternal);
                        cmd.Parameters.AddWithValue("@maternal", maternal);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@birthdate", birthdate);
                        cmd.Parameters.AddWithValue("@salary", salary);
                        cmd.Parameters.AddWithValue("@hiring_date", hiring_date);
                        cmd.Parameters.AddWithValue("@charge", charge);
                        cmd.ExecuteNonQuery();
                        res = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar los datos: " + ex.Message);
            }

            return res;
        }
        public static int GetEmployee(NpgsqlConnection connection)
        {
            int id_employee = 0;
            try
            {
                string query_employee = "SELECT id_empleado FROM empleado ORDER BY RANDOM() LIMIT 1";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query_employee, connection))
                {
                    object result = cmd.ExecuteScalar();
                    id_employee = result != null ? Convert.ToInt32(result) : 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener ID de empleado o zona: " + ex.Message);
            }
            return id_employee;
        }
        public static bool ValidateEmployeeCredential(string email, string password)
        {
            bool res = false;
            try
            {
                using (NpgsqlConnection connection = Connection.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM empleado WHERE correo_electronico = @email AND contrasena = @password";
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
    }
}
