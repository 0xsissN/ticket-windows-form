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
    public partial class Sell : Form
    {
        public Sell()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tickets tickets = new Tickets();
            tickets.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable sell_ticket = Ticket.GetSellTicket();
            if (sell_ticket.Rows.Count > 0)
            {
                dataGridView1.DataSource = sell_ticket;
            }
            else
            {
                MessageBox.Show("No se encontraron registros en la tabla persona.");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable detail_ticket = Ticket.GetDetailTicket();

            if (detail_ticket.Rows.Count > 0)
            {
                dataGridView2.DataSource = detail_ticket;
            }
            else
            {
                MessageBox.Show("No se encontraron registros en la tabla persona.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sell_Load(object sender, EventArgs e)
        {

        }
    }
}
