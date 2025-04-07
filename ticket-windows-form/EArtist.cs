using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using ticket_windows_form.DB;

namespace ticket_windows_form
{
    public partial class EArtist : Form
    {
        public EArtist()
        {
            InitializeComponent();
            dataGridView1.DataSource = Artist.SaveArtists();
            box_name.KeyPress += new KeyPressEventHandler(Restriction.OnlyLetters);
            box_paternal.KeyPress += new KeyPressEventHandler(Restriction.OnlyLetters);
            box_stage_name.KeyPress += new KeyPressEventHandler(Restriction.OnlyLetters);
            box_manager.KeyPress += new KeyPressEventHandler(Restriction.OnlyLetters);
            box_id.KeyPress += new KeyPressEventHandler(Restriction.OnlyNumbers);
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = Artist.SaveArtists();
        }

        private void save_editArtist_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EOption option = new EOption();
            option.Show();
            this.Close();
        }

        private void EArtist_Load(object sender, EventArgs e)
        {

        }

        private void txtCarnetIdentidad_Click(object sender, EventArgs e)
        {

        }

        private void box_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_paternal_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_maternal_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EOption option = new EOption();
            option.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idArtist;
            if (!int.TryParse(box_id.Text, out idArtist))
            {
                MessageBox.Show("Seleccione un artista válido para editar.");
                return;
            }

            string name = box_name.Text;
            string paternal = box_paternal.Text;
            string maternal = box_stage_name.Text;
            string stageName = box_stage_name.Text;
            string manager = box_manager.Text;
            DateTime birthdate = box_birthdate.Value;

            using (NpgsqlConnection connection = Connection.GetConnection())
            {
                Artist artist = new Artist();

                if (artist.EditArtist(idArtist, name, paternal, maternal, stageName, manager, birthdate))
                {
                    MessageBox.Show("Artista actualizado con éxito.");
                    dataGridView1.DataSource = Artist.SaveArtists(idArtist);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el artista.");
                }
            }
        }
    }
}
