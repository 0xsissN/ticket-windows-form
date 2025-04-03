namespace ticket_windows_form
{
    partial class Information
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            this.panel1 = new System.Windows.Forms.Panel();
            this.box_concert = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ticket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.box_location = new System.Windows.Forms.TextBox();
            this.box_start_date = new System.Windows.Forms.TextBox();
            this.box_end_date = new System.Windows.Forms.TextBox();
            this.box_artist = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.box_concert);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-5, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1319, 124);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // box_concert
            // 
            this.box_concert.BackColor = System.Drawing.Color.Black;
            this.box_concert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_concert.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_concert.ForeColor = System.Drawing.SystemColors.Window;
            this.box_concert.Location = new System.Drawing.Point(491, 37);
            this.box_concert.Margin = new System.Windows.Forms.Padding(4);
            this.box_concert.Name = "box_concert";
            this.box_concert.ReadOnly = true;
            this.box_concert.Size = new System.Drawing.Size(575, 39);
            this.box_concert.TabIndex = 35;
            this.box_concert.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(55, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 49);
            this.button1.TabIndex = 19;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(777, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 26);
            this.label3.TabIndex = 2;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(762, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 26);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(715, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 26);
            this.label5.TabIndex = 4;
            // 
            // btn_ticket
            // 
            this.btn_ticket.AccessibleName = "";
            this.btn_ticket.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ticket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ticket.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ticket.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ticket.Location = new System.Drawing.Point(562, 580);
            this.btn_ticket.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ticket.Name = "btn_ticket";
            this.btn_ticket.Size = new System.Drawing.Size(153, 49);
            this.btn_ticket.TabIndex = 6;
            this.btn_ticket.Text = "COMPRAR";
            this.btn_ticket.UseVisualStyleBackColor = false;
            this.btn_ticket.Click += new System.EventHandler(this.btn_ticket_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(653, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Artista:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(653, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fecha de Inicio: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(653, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 26);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ubicación: ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(653, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Fecha de fin: ";
            // 
            // box_location
            // 
            this.box_location.BackColor = System.Drawing.SystemColors.Control;
            this.box_location.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_location.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_location.Location = new System.Drawing.Point(855, 296);
            this.box_location.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_location.Name = "box_location";
            this.box_location.ReadOnly = true;
            this.box_location.Size = new System.Drawing.Size(221, 27);
            this.box_location.TabIndex = 41;
            this.box_location.TextChanged += new System.EventHandler(this.box_location_TextChanged);
            // 
            // box_start_date
            // 
            this.box_start_date.BackColor = System.Drawing.SystemColors.Control;
            this.box_start_date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_start_date.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_start_date.Location = new System.Drawing.Point(855, 357);
            this.box_start_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_start_date.Name = "box_start_date";
            this.box_start_date.ReadOnly = true;
            this.box_start_date.Size = new System.Drawing.Size(221, 27);
            this.box_start_date.TabIndex = 42;
            // 
            // box_end_date
            // 
            this.box_end_date.BackColor = System.Drawing.SystemColors.Control;
            this.box_end_date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_end_date.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_end_date.Location = new System.Drawing.Point(855, 422);
            this.box_end_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_end_date.Name = "box_end_date";
            this.box_end_date.ReadOnly = true;
            this.box_end_date.Size = new System.Drawing.Size(221, 27);
            this.box_end_date.TabIndex = 43;
            this.box_end_date.TextChanged += new System.EventHandler(this.box_end_date_TextChanged);
            // 
            // box_artist
            // 
            this.box_artist.BackColor = System.Drawing.SystemColors.Control;
            this.box_artist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_artist.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_artist.Location = new System.Drawing.Point(855, 232);
            this.box_artist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_artist.Name = "box_artist";
            this.box_artist.ReadOnly = true;
            this.box_artist.Size = new System.Drawing.Size(221, 27);
            this.box_artist.TabIndex = 44;
            this.box_artist.TextChanged += new System.EventHandler(this.box_artist_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(176, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 278);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1312, 727);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.box_artist);
            this.Controls.Add(this.box_end_date);
            this.Controls.Add(this.box_start_date);
            this.Controls.Add(this.box_location);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_ticket);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Information_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_ticket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox box_concert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox box_location;
        private System.Windows.Forms.TextBox box_start_date;
        private System.Windows.Forms.TextBox box_end_date;
        private System.Windows.Forms.TextBox box_artist;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}