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
    public partial class CreateArtist : Form
    {
        public CreateArtist()
        {
            InitializeComponent();
            box_manager.KeyPress += new KeyPressEventHandler(Restriction.OnlyLetters);
            box_maternal.KeyPress += new KeyPressEventHandler(Restriction.OnlyLetters);
            box_paternal.KeyPress += new KeyPressEventHandler(Restriction.OnlyLetters);
            box_name.KeyPress += new KeyPressEventHandler(Restriction.OnlyLetters);
            box_maternal.KeyPress += new KeyPressEventHandler(Restriction.OnlyLetters);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection connection = Connection.GetConnection();
                int id_artist = Artist.CreateArtist(
                    box_name.Text,
                    box_paternal.Text,
                    box_maternal.Text,
                    box_stage_name.Text,
                    box_manager.Text,
                    DateTime.Parse(box_birthdate.Text),
                    connection
                );

                if (id_artist > 0)
                {
                    MessageBox.Show("Artista agregado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar el artista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar artista: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void box_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateEmployee retar = new CreateEmployee();
            retar.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
