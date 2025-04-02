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
    public partial class CreateEmployee : Form
    {
        private Restriction restriction = new Restriction();
        public CreateEmployee()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateArtist create_artist = new CreateArtist();
            create_artist.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = Employee.AddEmployee(
                    box_name.Text,
                    box_paternal.Text,
                    box_maternal.Text,
                    box_phone.Text,
                    box_email.Text,
                    box_password.Text,
                    DateTime.Parse(box_birthdate.Text),
                    int.Parse(box_salary.Text),
                    DateTime.Parse(box_hiring_date.Text),
                    box_charge.Text
                );
                if (res)
                {
                    MessageBox.Show("Empleado agregado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void box_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_hiring_date_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_charge_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateConcert create_concert = new CreateConcert();
            create_concert.Show();
        }

        private void CreateEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Close();
        }
    }
}
