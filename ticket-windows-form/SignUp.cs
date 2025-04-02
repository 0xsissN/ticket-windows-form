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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void txtFechaNacimiento_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(box_paternal.Text, @"^[A-Za-zÁÉÍÓÚáéíóúÑñ]+( [A-Za-zÁÉÍÓÚáéíóúÑñ]+)*$"))
            {
                MessageBox.Show("Solo se permiten letras en el campo Apellido Paterno.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                box_paternal.Text = System.Text.RegularExpressions.Regex.Replace(box_paternal.Text, @"[^A-Za-zÁÉÍÓÚáéíóúÑñ\s]", "");
                box_paternal.Text = box_paternal.Text.Trim();
                box_paternal.Text = System.Text.RegularExpressions.Regex.Replace(box_paternal.Text, @"\s+", " ");
                box_paternal.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(box_paternal.Text.ToLower());
            }

            box_paternal.SelectionStart = box_paternal.Text.Length;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(box_name.Text, @"^[A-Za-zÁÉÍÓÚáéíóúÑñ]+( [A-Za-zÁÉÍÓÚáéíóúÑñ]+)*$"))
            {
                MessageBox.Show("Solo se permiten letras en el campo Nombre. No uses números ni caracteres especiales.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                box_name.Text = System.Text.RegularExpressions.Regex.Replace(box_name.Text, @"[^A-Za-zÁÉÍÓÚáéíóúÑñ\s]", "");
                box_name.Text = box_name.Text.Trim();
                box_name.Text = System.Text.RegularExpressions.Regex.Replace(box_name.Text, @"\s+", " ");
                box_name.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(box_name.Text.ToLower());
            }

            box_name.SelectionStart = box_name.Text.Length;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(box_maternal.Text, @"^[A-Za-zÁÉÍÓÚáéíóúÑñ]+( [A-Za-zÁÉÍÓÚáéíóúÑñ]+)*$"))
            {
                MessageBox.Show("Solo se permiten letras en el campo Apellido Materno.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                box_maternal.Text = System.Text.RegularExpressions.Regex.Replace(box_maternal.Text, @"[^A-Za-zÁÉÍÓÚáéíóúÑñ\s]", "");
                box_maternal.Text = box_maternal.Text.Trim();
                box_maternal.Text = System.Text.RegularExpressions.Regex.Replace(box_maternal.Text, @"\s+", " ");
                box_maternal.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(box_maternal.Text.ToLower());
            }

            box_maternal.SelectionStart = box_maternal.Text.Length;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_ci_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(box_ci.Text, @"^\d*$"))
            {
                MessageBox.Show("Solo se permiten números en el campo Carnet de Identidad.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                box_ci.Text = new string(box_ci.Text.Where(char.IsDigit).ToArray());
                box_ci.SelectionStart = box_ci.Text.Length;
            }
        }

        private void box_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(box_name.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                box_name.Focus();
            }
            if (string.IsNullOrWhiteSpace(box_paternal.Text))
            {
                MessageBox.Show("El campo Apellido Paterno es obligatorio.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                box_paternal.Focus();
            }
            if (string.IsNullOrWhiteSpace(box_maternal.Text))
            {
                MessageBox.Show("El campo Apellido Materno es obligatorio.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                box_maternal.Focus();
            }
            if (string.IsNullOrWhiteSpace(box_date.Text))
            {
                MessageBox.Show("El campo Fecha de Nacimiento es obligatorio.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                box_date.Focus();
            }
            if (string.IsNullOrWhiteSpace(box_email.Text))
            {
                MessageBox.Show("El campo Correo Electrónico es obligatorio.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                box_email.Focus();
 
            }
            if (string.IsNullOrWhiteSpace(box_phone.Text))
            {
                MessageBox.Show("El campo Teléfono es obligatorio.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                box_phone.Focus();
            }
            if (string.IsNullOrWhiteSpace(box_password.Text))
            {
                MessageBox.Show("El campo Contraseña es obligatorio.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                box_password.Focus();
            }

            try
            {
                bool res = Client.InsertClient(box_name.Text, box_paternal.Text, box_maternal.Text, DateTime.Parse(box_date.Text), box_email.Text, box_phone.Text, box_password.Text);
                if (res) 
                {

                    MessageBox.Show("Cliente agregado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    User user = new User();
                    user.Show();
                    this.Close();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al agregar al cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void box_password_TextChanged(object sender, EventArgs e)
        {
            box_password.UseSystemPasswordChar = true;
        }
        
        private void box_phone_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(box_phone.Text, @"^\d*$"))
            {
                MessageBox.Show("Solo se permiten números en el campo Celular.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                box_phone.Text = new string(box_phone.Text.Where(char.IsDigit).ToArray());
                box_phone.SelectionStart = box_phone.Text.Length;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Hide();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
