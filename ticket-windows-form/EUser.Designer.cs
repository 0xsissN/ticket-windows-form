namespace ticket_windows_form
{
    partial class EUser
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
            this.box_phone = new System.Windows.Forms.TextBox();
            this.box_maternal = new System.Windows.Forms.TextBox();
            this.box_paternal = new System.Windows.Forms.TextBox();
            this.box_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.Label();
            this.box_email = new System.Windows.Forms.TextBox();
            this.box_password = new System.Windows.Forms.TextBox();
            this.box_ci = new System.Windows.Forms.TextBox();
            this.box_date = new System.Windows.Forms.DateTimePicker();
            this.txtCorreo = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.Label();
            this.txtCarnetIdentidad = new System.Windows.Forms.Label();
            this.txtFechaNacimiento = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.box_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1319, 89);
            this.panel1.TabIndex = 108;
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
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // box_phone
            // 
            this.box_phone.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_phone.Location = new System.Drawing.Point(330, 626);
            this.box_phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_phone.Name = "box_phone";
            this.box_phone.Size = new System.Drawing.Size(297, 35);
            this.box_phone.TabIndex = 124;
            // 
            // box_maternal
            // 
            this.box_maternal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_maternal.Location = new System.Drawing.Point(330, 278);
            this.box_maternal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_maternal.Name = "box_maternal";
            this.box_maternal.Size = new System.Drawing.Size(297, 35);
            this.box_maternal.TabIndex = 123;
            // 
            // box_paternal
            // 
            this.box_paternal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_paternal.Location = new System.Drawing.Point(330, 208);
            this.box_paternal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_paternal.Name = "box_paternal";
            this.box_paternal.Size = new System.Drawing.Size(297, 35);
            this.box_paternal.TabIndex = 122;
            // 
            // box_name
            // 
            this.box_name.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_name.Location = new System.Drawing.Point(330, 135);
            this.box_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_name.Name = "box_name";
            this.box_name.Size = new System.Drawing.Size(297, 35);
            this.box_name.TabIndex = 121;
            this.box_name.TextChanged += new System.EventHandler(this.box_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 30);
            this.label1.TabIndex = 120;
            this.label1.Text = "Apellido Materno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 30);
            this.label2.TabIndex = 119;
            this.label2.Text = "Apellido Paterno";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(54, 135);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(106, 30);
            this.txtNombre.TabIndex = 118;
            this.txtNombre.Text = "Nombre";
            // 
            // txtCelular
            // 
            this.txtCelular.AutoSize = true;
            this.txtCelular.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(54, 628);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(98, 30);
            this.txtCelular.TabIndex = 117;
            this.txtCelular.Text = "Celular";
            // 
            // box_email
            // 
            this.box_email.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_email.Location = new System.Drawing.Point(330, 345);
            this.box_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_email.Name = "box_email";
            this.box_email.Size = new System.Drawing.Size(297, 35);
            this.box_email.TabIndex = 116;
            // 
            // box_password
            // 
            this.box_password.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_password.Location = new System.Drawing.Point(330, 413);
            this.box_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_password.Name = "box_password";
            this.box_password.Size = new System.Drawing.Size(297, 35);
            this.box_password.TabIndex = 115;
            // 
            // box_ci
            // 
            this.box_ci.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_ci.Location = new System.Drawing.Point(330, 483);
            this.box_ci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_ci.Name = "box_ci";
            this.box_ci.Size = new System.Drawing.Size(297, 35);
            this.box_ci.TabIndex = 114;
            // 
            // box_date
            // 
            this.box_date.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_date.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_date.Location = new System.Drawing.Point(330, 555);
            this.box_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_date.Name = "box_date";
            this.box_date.Size = new System.Drawing.Size(297, 30);
            this.box_date.TabIndex = 113;
            // 
            // txtCorreo
            // 
            this.txtCorreo.AutoSize = true;
            this.txtCorreo.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(54, 345);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(235, 30);
            this.txtCorreo.TabIndex = 112;
            this.txtCorreo.Text = "Correo electrónico";
            // 
            // txtContrasena
            // 
            this.txtContrasena.AutoSize = true;
            this.txtContrasena.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(54, 413);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(150, 30);
            this.txtContrasena.TabIndex = 111;
            this.txtContrasena.Text = "Contraseña";
            // 
            // txtCarnetIdentidad
            // 
            this.txtCarnetIdentidad.AutoSize = true;
            this.txtCarnetIdentidad.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarnetIdentidad.Location = new System.Drawing.Point(54, 485);
            this.txtCarnetIdentidad.Name = "txtCarnetIdentidad";
            this.txtCarnetIdentidad.Size = new System.Drawing.Size(245, 30);
            this.txtCarnetIdentidad.TabIndex = 110;
            this.txtCarnetIdentidad.Text = "Carnet de identidad";
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.AutoSize = true;
            this.txtFechaNacimiento.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNacimiento.Location = new System.Drawing.Point(54, 555);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(258, 30);
            this.txtFechaNacimiento.TabIndex = 109;
            this.txtFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(737, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(505, 383);
            this.dataGridView1.TabIndex = 125;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(844, 626);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 76);
            this.button1.TabIndex = 126;
            this.button1.Text = "Guardar Usuario";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // box_id
            // 
            this.box_id.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_id.Location = new System.Drawing.Point(962, 557);
            this.box_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_id.Multiline = true;
            this.box_id.Name = "box_id";
            this.box_id.Size = new System.Drawing.Size(299, 30);
            this.box_id.TabIndex = 128;
            this.box_id.TextChanged += new System.EventHandler(this.box_id_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(685, 559);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 28);
            this.label3.TabIndex = 127;
            this.label3.Text = "Elegir id Para Editar :";
            // 
            // EUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 727);
            this.Controls.Add(this.box_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.box_phone);
            this.Controls.Add(this.box_maternal);
            this.Controls.Add(this.box_paternal);
            this.Controls.Add(this.box_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.box_email);
            this.Controls.Add(this.box_password);
            this.Controls.Add(this.box_ci);
            this.Controls.Add(this.box_date);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtCarnetIdentidad);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.panel1);
            this.Name = "EUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox box_phone;
        private System.Windows.Forms.TextBox box_maternal;
        private System.Windows.Forms.TextBox box_paternal;
        private System.Windows.Forms.TextBox box_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtCelular;
        private System.Windows.Forms.TextBox box_email;
        private System.Windows.Forms.TextBox box_password;
        private System.Windows.Forms.TextBox box_ci;
        private System.Windows.Forms.DateTimePicker box_date;
        private System.Windows.Forms.Label txtCorreo;
        private System.Windows.Forms.Label txtContrasena;
        private System.Windows.Forms.Label txtCarnetIdentidad;
        private System.Windows.Forms.Label txtFechaNacimiento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox box_id;
        private System.Windows.Forms.Label label3;
    }
}