﻿using System;
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
    public partial class EOption : Form
    {
        public EOption()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void EOption_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CreateConcert concert = new CreateConcert();
            concert.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateArtist artist = new CreateArtist();
            artist.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CreateEmployee employee = new CreateEmployee();
            employee.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            EUser user = new EUser();
            user.Show();
            this.Hide();
        }
    }
}
