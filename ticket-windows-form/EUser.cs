using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using System.Xml.Linq;
using ticket_windows_form.DB;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ticket_windows_form
{
    public partial class EUser : Form
    {
        public EUser()
        {
            InitializeComponent();
            dataGridView1.DataSource = Client.GetClient();
            box_name.KeyPress += new KeyPressEventHandler(Restriction.OnlyLetters);
            box_paternal.KeyPress += new KeyPressEventHandler(Restriction.OnlyLetters);
            box_maternal.KeyPress += new KeyPressEventHandler(Restriction.OnlyLetters);
            box_ci.KeyPress += new KeyPressEventHandler(Restriction.OnlyNumbers);
            box_phone.KeyPress += new KeyPressEventHandler(Restriction.OnlyNumbers);
            box_id.KeyPress += new KeyPressEventHandler(Restriction.OnlyNumbers);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EOption option = new EOption();
            option.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(box_id.Text, out int idClient))
                {
                    MessageBox.Show("ID inválido.");
                    return;
                }

                bool success = Client.EditClient(idClient, box_name.Text, box_paternal.Text, box_maternal.Text, box_phone.Text, box_email.Text, box_password.Text, DateTime.Parse(box_date.Text));
                if (success)
                {
                    MessageBox.Show("Empleado actualizado correctamente.");
                    dataGridView1.DataSource = Client.GetClient();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void box_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
