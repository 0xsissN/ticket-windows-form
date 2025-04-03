using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ticket_windows_form.DB;

namespace ticket_windows_form
{
    public partial class Information : Form
    {
        private int inf_id;
        public Information(int id)
        {
            InitializeComponent();
            inf_id = id;

            Concert concert = new Concert();
            string concert_name = concert.GetConcertName(id);

            if (!string.IsNullOrEmpty(concert_name))
            {
                box_concert.Text = concert_name.Trim();
            }
            else
            {
                box_concert.Text = "Concierto no encontrado";
            }

            string concert_location = concert.GetLocationConcert(id);

            if (!string.IsNullOrEmpty(concert_location))
            {
                box_location.Text = concert_location.Trim();
            }
            else
            {
                box_location.Text = "Ubicacion no encontrada";
            }

            string concert_start_date = concert.GetStartDateConcert(id);

            if (!string.IsNullOrEmpty(concert_start_date))
            {
                box_start_date.Text = concert_start_date.Trim();
            }
            else
            {
                box_start_date.Text = "Fecha de inicio no encontrada";
            }

            string concert_end_date = concert.GetEndDateConcert(id);

            if (!string.IsNullOrEmpty(concert_end_date))
            {
                box_end_date.Text = concert_end_date.Trim();
            }
            else
            {
                box_end_date.Text = "Fecha de fin no encontrada";
            }

            string concert_artist = concert.GetArtistConcert(id);

            if (!string.IsNullOrEmpty(concert_artist))
            {
                box_artist.Text = concert_artist.Trim();
            }
            else
            {
                box_artist.Text = "Artista no encontrada";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
            this.Hide();
        }

        private void btn_ticket_Click(object sender, EventArgs e)
        {
            Tickets ticket = new Tickets(inf_id);
            ticket.Show();
            this.Hide();
        }

        private void Information_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_location_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_artist_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_end_date_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
