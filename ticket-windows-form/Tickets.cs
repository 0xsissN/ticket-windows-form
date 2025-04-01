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
    public partial class Tickets : Form
    {
        public Tickets()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(combo_method.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un método de pago antes de realizar la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string method = combo_method.SelectedItem.ToString();
            int concert_id = 1;
            int client_id = 1;
            bool buy_ready = false;

            int amount_super_vip = int.TryParse(combo_super_vip.Text, out int sv) ? sv : 0;
            int amount_vip = int.TryParse(combo_vip.Text, out int v) ? v : 0;
            int amount_general = int.TryParse(combo_general.Text, out int g) ? g : 0;

            decimal total_super_vip = amount_super_vip * 300;
            decimal total_vip = amount_vip * 200;
            decimal total_general = amount_general * 70;
            decimal total = total_super_vip + total_vip + total_general;

            if (amount_super_vip > 0 || amount_vip > 0 || amount_general > 0)
            {
                SellTickets.AddTicket(concert_id, client_id, total);
            }

            if (amount_super_vip > 0)
            {
                int last_ticket_id = SellTickets.GetLastTicketId();
                SellDetails.AddDetailSale(last_ticket_id, "SuperVip", 300);
                buy_ready = true;
            }
            if (amount_vip > 0)
            {
                int last_ticket_id = SellTickets.GetLastTicketId();
                SellDetails.AddDetailSale(last_ticket_id, "Vip", 200);
                buy_ready = true;
            }
            if (amount_general > 0)
            {

                int last_ticket_id = SellTickets.GetLastTicketId();
                SellDetails.AddDetailSale(last_ticket_id, "General", 70);
                buy_ready = true;
            }

            if (buy_ready)
            {
                MessageBox.Show($"Compra realizada con éxito por un total de ${total} usando {method}.",
                    "Compra Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int last_ticket_id = SellTickets.GetLastTicketId();
                int last_receipt_id = Receipt.GetLastReceiptID();
                Receipt.GenerateReceipt(last_ticket_id, method);
                CreateReceipt create_receipt = new CreateReceipt(amount_super_vip, amount_vip, amount_general, method, client_id, last_receipt_id);
                create_receipt.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un boleto para comprar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tickets tickets = new Tickets();
            tickets.Show();
            this.Hide();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            int conciertoId = 1;
            Ticket ticket = new Ticket();
            string nombreConcierto = ticket.ObtenerNombreConcierto(conciertoId);

            if (!string.IsNullOrEmpty(nombreConcierto))
            {
                textBox1.Text = nombreConcierto.Trim();
            }
            else
            {
                textBox1.Text = "Concierto no encontrado";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
