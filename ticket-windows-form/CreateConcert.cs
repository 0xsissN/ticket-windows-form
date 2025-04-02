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
    public partial class CreateConcert : Form
    {
        private int capacity;
        private Restriction restriction = new Restriction();
        public CreateConcert()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si el ID del artista es un número válido
                if (!int.TryParse(textBox1.Text, out int id_artist))
                {
                    MessageBox.Show("Ingrese un ID de artista válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llamar a la función CreateConcert con el ID del artista
                bool res = Concert.CreateConcert(
                    box_location.Text,
                    int.Parse(box_capacity.Text),
                    box_organization.Text,
                    box_concert_name.Text,
                    DateTime.Parse(box_start_date.Text),
                    DateTime.Parse(box_end_date.Text),
                    id_artist  // Pasamos el ID del artista ingresado
                );

                if (res)
                {
                    MessageBox.Show("Concierto agregado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar el concierto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar concierto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void box_capacity_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(box_capacity.Text.Trim(), out capacity))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico en Capacidad Total.");
                box_capacity.Clear();
            }
        }

        private void box_concert_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_organization_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_location_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void box_end_date_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_start_date_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void box_birthdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void box_maternal_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_paternal_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_Click(object sender, EventArgs e)
        {

        }

        private void box_manager_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_stage_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContrasena_Click(object sender, EventArgs e)
        {

        }

        private void txtCarnetIdentidad_Click(object sender, EventArgs e)
        {

        }

        private void txtFechaNacimiento_Click(object sender, EventArgs e)
        {

        }

        private void CreateConcert_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Artist.GetArtists();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int id_artist))
            {
                if (!Artist.ExistsArtistId(id_artist))
                {
                    MessageBox.Show("El ID del artista no existe. Ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear(); 
                }
            }
        }
    }
}
