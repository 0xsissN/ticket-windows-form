using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Npgsql;

namespace ticket_windows_form.DB
{
    internal class Concert
    {
        private static int id_employee;
        private static int id_zona;
        public static bool CreateConcert(
            string name, 
            string paternal, 
            string maternal, 
            string stage_name, 
            string manager, 
            DateTime birhtdate, 
            string location, 
            int capacity, 
            string organization, 
            string concert_name, 
            DateTime start_date, 
            DateTime end_date)
        {
            bool res = false;
            try
            {
                NpgsqlConnection connection = Connection.GetConnection();
                {
                    id_employee = Employee.GetEmployee(connection);
                    id_zona = Zona.GetZona(connection);
                    
                    if (id_employee == 0 || id_zona == 0)
                    {
                        MessageBox.Show("No se pudo obtener un ID válido de empleado o zona.");
                        return false;
                    }

                    string query_artist = "INSERT INTO artista (nombre, ap_paterno, ap_materno, nom_artistico, manager, fecha_nacimiento) VALUES (@name, @paternal, @maternal, @stage_name, @manager, @birthdate) RETURNING id_artista";
                    int id_artist;

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query_artist, connection))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@paternal", paternal);
                        cmd.Parameters.AddWithValue("@maternal", maternal);
                        cmd.Parameters.AddWithValue("@stage_name", stage_name);
                        cmd.Parameters.AddWithValue("@manager", manager);
                        cmd.Parameters.AddWithValue("@birthdate", birhtdate);
                        id_artist = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    if(id_artist <= 0)
                    {
                        MessageBox.Show("Error al obtener el ID del artista.");
                        return false;
                    }

                    string query_concert = "INSERT INTO concierto (artista_id, empleado_id, zona_id, ubicacion_concierto, capacidad_total, organizacion, nombre_concierto, fecha_inicio, fecha_fin) VALUES (@id_artist, @id_employee, @id_zona, @location, @capacity, @organization, @concert_name, @start_date, @end_date)";
                    using(NpgsqlCommand cmd = new NpgsqlCommand(query_concert, connection))
                    {
                        cmd.Parameters.AddWithValue("@id_artist", id_artist);
                        cmd.Parameters.AddWithValue("@id_employee", id_employee);
                        cmd.Parameters.AddWithValue("@id_zona", id_zona);
                        cmd.Parameters.AddWithValue("@location", location);
                        cmd.Parameters.AddWithValue("@capacity", capacity);
                        cmd.Parameters.AddWithValue("@organization", organization);
                        cmd.Parameters.AddWithValue("@concert_name", concert_name);
                        cmd.Parameters.AddWithValue("@start_date", start_date);
                        cmd.Parameters.AddWithValue("@end_date", end_date);
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
    }
}
