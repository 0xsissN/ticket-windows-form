using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticket_windows_form
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUp sign_up = new SignUp();
            sign_up.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignIn sign_in = new SignIn();
            sign_in.Show();
        }
    }
}
