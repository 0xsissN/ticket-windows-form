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
            box_salary.KeyPress += restriction.OnlyNumbers;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validar campos
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
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
