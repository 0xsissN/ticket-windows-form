using System;
using System.Collections.Generic;
using System.Data;
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
            string location, int capacity, string organization,
            string concert_name, DateTime start_date, DateTime end_date, int id_artist)
        {
            bool res = false;
            try
            {
                NpgsqlConnection connection = Connection.GetConnection();
                id_employee = Employee.GetEmployee(connection);
                id_zona = Zona.GetZona(connection);

                if (id_employee == 0 || id_zona == 0)
                {
                    MessageBox.Show("No se pudo obtener un ID válido de empleado o zona.");
                    return false;
                }

                string query = "INSERT INTO concierto (artista_id, empleado_id, zona_id, ubicacion_concierto, capacidad_total, organizacion, nombre_concierto, fecha_inicio, fecha_fin) VALUES (@id_artist, @id_employee, @id_zona, @location, @capacity, @organization, @concert_name, @start_date, @end_date)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
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
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el concierto: " + ex.Message);
            }

            return res;
        }

        public string GetConcertName(int conciertoId)
        {
            string concert_name = string.Empty;

            try
            {
                NpgsqlConnection connection = Connection.GetConnection();
                {
                    string query = "SELECT nombre_concierto FROM CONCIERTO WHERE id_concierto = @conciertoId";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@conciertoId", conciertoId);
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            concert_name = result.ToString();
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

            return concert_name;
        }

        public string GetLocationConcert(int conciertoId)
        {
            string concert_location = string.Empty;

            try
            {
                NpgsqlConnection connection = Connection.GetConnection();
                {
                    string query = "SELECT ubicacion_concierto FROM CONCIERTO WHERE id_concierto = @conciertoId";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@conciertoId", conciertoId);
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            concert_location = result.ToString();
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

            return concert_location;
        }

        public string GetStartDateConcert(int conciertoId)
        {
            string concert_start_date = string.Empty;

            try
            {
                NpgsqlConnection connection = Connection.GetConnection();
                {
                    string query = "SELECT fecha_inicio FROM CONCIERTO WHERE id_concierto = @conciertoId";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@conciertoId", conciertoId);
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            concert_start_date = result.ToString();
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

            return concert_start_date;
        }
        public string GetEndDateConcert(int conciertoId)
        {
            string concert_end_date = string.Empty;

            try
            {
                NpgsqlConnection connection = Connection.GetConnection();
                {
                    string query = "SELECT fecha_fin FROM CONCIERTO WHERE id_concierto = @conciertoId";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@conciertoId", conciertoId);
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            concert_end_date = result.ToString();
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

            return concert_end_date;
        }

        public string GetArtistConcert(int conciertoId)
        {
            string concert_artist = string.Empty;

            try
            {
                NpgsqlConnection connection = Connection.GetConnection();
                {
                    string query = "SELECT a.nom_artistico FROM CONCIERTO c JOIN ARTISTA a ON c.artista_id = a.id_artista WHERE c.id_concierto = @conciertoId";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@conciertoId", conciertoId);
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            concert_artist = result.ToString();
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

            return concert_artist;
        }

        public static bool Edit_Concert(
    int idConcert, string location, int capacity, string organization,
    string concertName, DateTime startDate, DateTime endDate)
        {
            try
            {

                NpgsqlConnection connection = Connection.GetConnection();
                if (connection == null || connection.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("No se pudo establecer conexión con la base de datos.");
                    return false;
                }

                string query = @"UPDATE concierto 
                         SET ubicacion_concierto = @location, 
                             capacidad_total = @capacity, organizacion = @organization, 
                             nombre_concierto = @concertName, fecha_inicio = @startDate, fecha_fin = @endDate 
                         WHERE id_concierto = @idConcert";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@idConcert", idConcert);
                    cmd.Parameters.AddWithValue("@location", location);
                    cmd.Parameters.AddWithValue("@capacity", capacity);
                    cmd.Parameters.AddWithValue("@organization", organization);
                    cmd.Parameters.AddWithValue("@concertName", concertName);
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el concierto: " + ex.Message);
                return false;
            }
        }

        public static DataTable GetConcerts()
        {
            DataTable dt = new DataTable();
            try
            {
                NpgsqlConnection connection = Connection.GetConnection();
                string query = @"SELECT id_concierto, artista_id, empleado_id, zona_id, 
                                ubicacion_concierto, capacidad_total, organizacion, 
                                nombre_concierto, fecha_inicio, fecha_fin 
                         FROM concierto
                         ORDER BY id_concierto ASC";

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
                MessageBox.Show("Error al obtener la lista de conciertos: " + ex.Message);
            }
            return dt;
        }

    }
}

