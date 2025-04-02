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
    public partial class InformacionB : Form
    {
        public InformacionB()
        {
            InitializeComponent();
        }

        private void btn_ticket_Click(object sender, EventArgs e)
        {
            Tickets tickets = new Tickets(1);
            tickets.Show();
            this.Hide();
        }
    }
}
