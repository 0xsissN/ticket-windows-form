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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void SingIn_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(box_email.Text) || string.IsNullOrWhiteSpace(box_password.Text)) 
            {
                MessageBox.Show("Por favor, ingrese su correo y contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool res = Client.ValidateCredential(box_email.Text, box_password.Text);
                if (res) 
                {
                    MessageBox.Show("Inicio de sesión exitoso", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void box_password_TextChanged(object sender, EventArgs e)
        {
            box_password.UseSystemPasswordChar = true;
        }

        private void box_email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
