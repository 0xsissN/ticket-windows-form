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
    public partial class EEmployee : Form
    {
        public EEmployee()
        {
            InitializeComponent();
            dataGridView1.DataSource = Employee.GetEmployees();
            box_name.KeyPress += new KeyPressEventHandler(Restriction.OnlyLetters);
            box_paternal.KeyPress += new KeyPressEventHandler(Restriction.OnlyLetters);
            box_maternal.KeyPress += new KeyPressEventHandler(Restriction.OnlyLetters);
            box_charge.KeyPress += new KeyPressEventHandler(Restriction.OnlyLetters);
            box_phone.KeyPress += new KeyPressEventHandler(Restriction.OnlyNumbers);
            box_salary.KeyPress += new KeyPressEventHandler(Restriction.OnlyNumbers);
            box_id.KeyPress += new KeyPressEventHandler(Restriction.OnlyNumbers);
        }

        private void SaveEmployee_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EEmployee_Load(object sender, EventArgs e)
        {

        }

        private void box_paternal_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_maternal_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EOption option = new EOption();
            option.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(box_id.Text, out int idEmployee))
                {
                    MessageBox.Show("ID inválido.");
                    return;
                }

                string name = box_name.Text;
                string paternal = box_paternal.Text;
                string maternal = box_maternal.Text;
                string phone = box_phone.Text;
                string email = box_email.Text;
                string password = box_password.Text;
                DateTime birthdate = box_birthdate.Value;
                int salary = int.Parse(box_salary.Text);
                DateTime hiring_date = box_hiring_date.Value;
                string charge = box_charge.Text;

                bool success = Employee.EditEmployeess(idEmployee, name, paternal, maternal, phone, email, password, birthdate, salary, hiring_date, charge);

                if (success)
                {
                    MessageBox.Show("Empleado actualizado correctamente.");
                    dataGridView1.DataSource = Employee.GetEmployees();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el empleado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void box_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
