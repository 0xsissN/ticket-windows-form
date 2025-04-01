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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Information information = new Information();
            information.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp login = new SignUp();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tickets tickets = new Tickets();
            tickets.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
        }
    }
}
