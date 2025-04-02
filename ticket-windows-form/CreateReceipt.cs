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
    public partial class CreateReceipt : Form
    {
        private int last_receipt_id;
        public CreateReceipt(int super_vip, int vip, int general, string method, int client_id, int last_receipt_id)
        {
            InitializeComponent();
            this.last_receipt_id = last_receipt_id;

            box_amount_super_vip.Text = super_vip.ToString(); 
            box_amount_vip.Text = vip.ToString();      
            box_amount_general.Text = general.ToString();  

            box_method.Text = method;

            box_cod_client.Text = client_id.ToString();

            UpdateTextBoxes();
        }

        private void UpdateTextBoxes()
        {
            int amount_super_vip = int.TryParse(box_amount_super_vip.Text, out int superVip) ? superVip : 0;
            int amount_vip = int.TryParse(box_amount_vip.Text, out int vip) ? vip : 0;
            int amount_general = int.TryParse(box_amount_general.Text, out int general) ? general : 0;

            box_total_super_vip.Text = (amount_super_vip * 300).ToString() + " Bs";
            box_total_vip.Text = (amount_vip * 200).ToString() + " Bs";     
            box_total_general.Text = (amount_general * 70).ToString() + " Bs"; 

            int total = (amount_super_vip * 300) + (amount_vip * 200) + (amount_general * 70);
            box_total.Text = total.ToString() + " Bs"; 

            box_nro_receipt.Text = last_receipt_id.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tickets tickets = new Tickets(1);
            tickets.Show();
            this.Hide();
        }

        private void box_amount_super_vip_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_method_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_cod_client_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_total_super_vip_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_nro_receipt_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_date_TextChanged(object sender, EventArgs e)
        {
            string fechaActual = DateTime.Now.ToString("dd/MM/yyyy");
            box_date.Text = fechaActual;
        }

        private void box_total_vip_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_total_general_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_amount_vip_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_amount_general_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtFechaNacimiento_Click(object sender, EventArgs e)
        {

        }

        private void CreateReceipt_Load(object sender, EventArgs e)
        {
            string fechaActual = DateTime.Now.ToString("dd/MM/yyyy");
            box_date.Text = fechaActual;
        }

        private void box_details_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
