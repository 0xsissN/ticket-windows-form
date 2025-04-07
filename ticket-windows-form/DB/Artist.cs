using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows;
using System.Data;

namespace ticket_windows_form.DB
{
    internal class Artist
    {
        public static int CreateArtist(
            string name, 
            string paternal, 
            string maternal, 
            string stage_name,
            string manager, 
            DateTime birthdate, 
            NpgsqlConnection connection)
        {
            try
            {
                string query = "INSERT INTO artista (nombre, ap_paterno, ap_materno, nom_artistico, manager, fecha_nacimiento) VALUES (@name, @paternal, @maternal, @stage_name, @manager, @birthdate) RETURNING id_artista";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@paternal", paternal);
                    cmd.Parameters.AddWithValue("@maternal", maternal);
                    cmd.Parameters.AddWithValue("@stage_name", stage_name);
                    cmd.Parameters.AddWithValue("@manager", manager);
                    cmd.Parameters.AddWithValue("@birthdate", birthdate);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el artista: " + ex.Message);
                return 1;
            }

        }
        public static bool ExistsArtistId(int id_artist)
        {
            bool exists = false;
            try
            {
                NpgsqlConnection connection = Connection.GetConnection();
                string query = "SELECT COUNT(*) FROM artista WHERE id_artista = @id_artist";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id_artist", id_artist);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    exists = (count > 0);  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el ID del artista: " + ex.Message);
            }

            return exists;
        }
        public static DataTable GetArtists()
        {
            DataTable dt = new DataTable();
            try
            {
                NpgsqlConnection connection = Connection.GetConnection();
                string query = "SELECT id_artista, nombre, ap_paterno, ap_materno, nom_artistico, manager, fecha_nacimiento FROM artista";

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
                MessageBox.Show("Error al obtener la lista de artistas: " + ex.Message);
            }

            return dt;
        }
        public bool EditArtist(
            int idArtist, 
            string name, 
            string paternal,
            string maternal,
            string stageName, 
            string manager, 
            DateTime birthdate)
        {
            try
            {
                NpgsqlConnection connection = Connection.GetConnection();

                string query = @"
            UPDATE artista 
            SET nombre = @name, ap_paterno = @paternal, ap_materno = @maternal, 
                nom_artistico = @stageName, manager = @manager, fecha_nacimiento = @birthdate 
            WHERE id_artista = @idArtist";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@idArtist", idArtist);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@paternal", paternal);
                    cmd.Parameters.AddWithValue("@maternal", maternal);
                    cmd.Parameters.AddWithValue("@stageName", stageName);
                    cmd.Parameters.AddWithValue("@manager", manager);
                    cmd.Parameters.AddWithValue("@birthdate", birthdate);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el artista: " + ex.Message);
                return false;
            }
        }
        public static DataTable SaveArtists(int? editedArtistId = null)
        {
            DataTable dt = new DataTable();
            try
            {
                NpgsqlConnection connection = Connection.GetConnection();
                {
                    string query = @"
                SELECT id_artista, nombre, ap_paterno, ap_materno, nom_artistico, manager, fecha_nacimiento 
                FROM artista
                ORDER BY id_artista ASC";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@editedArtistId", (object)editedArtistId ?? DBNull.Value);

                        using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la lista de artistas: " + ex.Message);
            }

            return dt;
        }
    }

}
