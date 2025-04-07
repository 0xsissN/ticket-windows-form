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
    public partial class EConcert : Form
    {
        public EConcert()
        {
            InitializeComponent();
            dataGridView1.DataSource = Concert.GetConcerts();
            box_location.KeyPress += new KeyPressEventHandler(Restriction.OnlyLetters);
            box_organization.KeyPress += new KeyPressEventHandler(Restriction.OnlyLetters);
            box_concert_name.KeyPress += new KeyPressEventHandler(Restriction.OnlyLetters);
            box_capacity.KeyPress += new KeyPressEventHandler(Restriction.OnlyNumbers);
            box_id.KeyPress += new KeyPressEventHandler(Restriction.OnlyNumbers);
        }
        private void SaveConcert_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }


        private void EConcert_Load(object sender, EventArgs e)
        {

        }

        private void box_location_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_start_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void box_capacity_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            EOption option = new EOption();
            option.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idConcert;
                if (!int.TryParse(box_id.Text, out idConcert))
                {
                    MessageBox.Show("Seleccione un concierto válido para editar.");
                    return;
                }

                string location = box_location.Text;
                int capacity;
                if (!int.TryParse(box_capacity.Text, out capacity))
                {
                    MessageBox.Show("Capacidad debe ser un número válido.");
                    return;
                }

                string organization = box_organization.Text;
                string concert_name = box_concert_name.Text;
                DateTime start_date = box_start_date.Value;
                DateTime end_date = box_end_date.Value;

                NpgsqlConnection connection = Connection.GetConnection();
                if (connection == null)
                {
                    MessageBox.Show("Error al conectar con la base de datos.");
                    return;
                }

                if (Concert.EditConcert(idConcert, location, capacity, organization, concert_name, start_date, end_date))
                {
                    MessageBox.Show("Concierto actualizado con éxito.");
                    dataGridView1.DataSource = Concert.GetConcerts();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el concierto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el concierto: " + ex.Message);
            }
        }
    }
}
