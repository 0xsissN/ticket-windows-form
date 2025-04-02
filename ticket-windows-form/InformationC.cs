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
    public partial class InformationC : Form
    {
        public InformationC()
        {
            InitializeComponent();
        }

        private void InformationC_Load(object sender, EventArgs e)
        {

        }

        private void btn_ticket_Click(object sender, EventArgs e)
        {
            Tickets tickets = new Tickets(2);
            tickets.Show();
            this.Hide();
        }
    }
}
