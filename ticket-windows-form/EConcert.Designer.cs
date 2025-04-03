namespace ticket_windows_form
{
    partial class EConcert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.box_end_date = new System.Windows.Forms.DateTimePicker();
            this.box_start_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.box_capacity = new System.Windows.Forms.TextBox();
            this.box_concert_name = new System.Windows.Forms.TextBox();
            this.box_organization = new System.Windows.Forms.TextBox();
            this.box_location = new System.Windows.Forms.TextBox();
            this.box = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.box_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1319, 89);
            this.panel1.TabIndex = 81;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(52, 22);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 49);
            this.button4.TabIndex = 19;
            this.button4.Text = "Volver";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(492, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(327, 48);
            this.label4.TabIndex = 34;
            this.label4.Text = "Editar Concierto";
            // 
            // box_end_date
            // 
            this.box_end_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_end_date.Location = new System.Drawing.Point(351, 503);
            this.box_end_date.Margin = new System.Windows.Forms.Padding(4);
            this.box_end_date.Name = "box_end_date";
            this.box_end_date.Size = new System.Drawing.Size(297, 30);
            this.box_end_date.TabIndex = 98;
            // 
            // box_start_date
            // 
            this.box_start_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_start_date.Location = new System.Drawing.Point(349, 434);
            this.box_start_date.Margin = new System.Windows.Forms.Padding(4);
            this.box_start_date.Name = "box_start_date";
            this.box_start_date.Size = new System.Drawing.Size(297, 30);
            this.box_start_date.TabIndex = 97;
            this.box_start_date.ValueChanged += new System.EventHandler(this.box_start_date_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(227, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 29);
            this.label3.TabIndex = 96;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(251, 622);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 76);
            this.button1.TabIndex = 93;
            this.button1.Text = "Guardar Concierto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // box_capacity
            // 
            this.box_capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_capacity.Location = new System.Drawing.Point(349, 222);
            this.box_capacity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_capacity.Multiline = true;
            this.box_capacity.Name = "box_capacity";
            this.box_capacity.Size = new System.Drawing.Size(299, 27);
            this.box_capacity.TabIndex = 92;
            this.box_capacity.TextChanged += new System.EventHandler(this.box_capacity_TextChanged);
            // 
            // box_concert_name
            // 
            this.box_concert_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_concert_name.Location = new System.Drawing.Point(349, 360);
            this.box_concert_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_concert_name.Multiline = true;
            this.box_concert_name.Name = "box_concert_name";
            this.box_concert_name.Size = new System.Drawing.Size(299, 27);
            this.box_concert_name.TabIndex = 91;
            // 
            // box_organization
            // 
            this.box_organization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_organization.Location = new System.Drawing.Point(349, 291);
            this.box_organization.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_organization.Name = "box_organization";
            this.box_organization.Size = new System.Drawing.Size(299, 30);
            this.box_organization.TabIndex = 90;
            // 
            // box_location
            // 
            this.box_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_location.Location = new System.Drawing.Point(349, 157);
            this.box_location.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_location.Multiline = true;
            this.box_location.Name = "box_location";
            this.box_location.Size = new System.Drawing.Size(299, 27);
            this.box_location.TabIndex = 89;
            this.box_location.TextChanged += new System.EventHandler(this.box_location_TextChanged);
            // 
            // box
            // 
            this.box.AutoSize = true;
            this.box.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box.Location = new System.Drawing.Point(59, 360);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(225, 28);
            this.box.TabIndex = 88;
            this.box.Text = "Nombre Concierto :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 28);
            this.label6.TabIndex = 87;
            this.label6.Text = "Organizacion :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 28);
            this.label7.TabIndex = 86;
            this.label7.Text = "Ubicacion Concierto :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(59, 499);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(260, 28);
            this.label8.TabIndex = 85;
            this.label8.Text = "Fecha de Finalizacion :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(59, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 28);
            this.label9.TabIndex = 84;
            this.label9.Text = "Fecha de Inicio :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 28);
            this.label10.TabIndex = 83;
            this.label10.Text = "Capacidad :";
            // 
            // box_id
            // 
            this.box_id.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_id.Location = new System.Drawing.Point(349, 563);
            this.box_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_id.Multiline = true;
            this.box_id.Name = "box_id";
            this.box_id.Size = new System.Drawing.Size(299, 30);
            this.box_id.TabIndex = 100;
            this.box_id.TextChanged += new System.EventHandler(this.box_id_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 28);
            this.label1.TabIndex = 99;
            this.label1.Text = "Elegir id Para Editar :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(745, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(499, 446);
            this.dataGridView1.TabIndex = 101;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EConcert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 727);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.box_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_end_date);
            this.Controls.Add(this.box_start_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.box_capacity);
            this.Controls.Add(this.box_concert_name);
            this.Controls.Add(this.box_organization);
            this.Controls.Add(this.box_location);
            this.Controls.Add(this.box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Name = "EConcert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EConcert";
            this.Load += new System.EventHandler(this.EConcert_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker box_end_date;
        private System.Windows.Forms.DateTimePicker box_start_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox box_capacity;
        private System.Windows.Forms.TextBox box_concert_name;
        private System.Windows.Forms.TextBox box_organization;
        private System.Windows.Forms.TextBox box_location;
        private System.Windows.Forms.Label box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox box_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}