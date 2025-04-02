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
            Tickets tickets = new Tickets(3);
            tickets.Show();
            this.Hide();
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
            Tickets tickets = new Tickets(1);
            tickets.Show();
            this.Hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            //this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CreateConcert create_concert = new CreateConcert();
            create_concert.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            CreateEmployee create_employee = new CreateEmployee();
            create_employee.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Tickets tickets = new Tickets(2);
            tickets.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Tickets tickets = new Tickets(1);
            tickets.Show();
            this.Hide();
        }
    }
}
