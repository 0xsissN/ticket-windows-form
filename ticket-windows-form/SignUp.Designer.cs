namespace ticket_windows_form
{
    partial class SignUp
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
            this.txtFechaNacimiento = new System.Windows.Forms.Label();
            this.txtCarnetIdentidad = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.Label();
            this.box_date = new System.Windows.Forms.DateTimePicker();
            this.box_ci = new System.Windows.Forms.TextBox();
            this.box_password = new System.Windows.Forms.TextBox();
            this.box_email = new System.Windows.Forms.TextBox();
            this.box_maternal = new System.Windows.Forms.TextBox();
            this.box_paternal = new System.Windows.Forms.TextBox();
            this.box_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.Label();
            this.box_phone = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.AutoSize = true;
            this.txtFechaNacimiento.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNacimiento.Location = new System.Drawing.Point(32, 123);
            this.txtFechaNacimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(205, 24);
            this.txtFechaNacimiento.TabIndex = 0;
            this.txtFechaNacimiento.Text = "Fecha de nacimiento";
            this.txtFechaNacimiento.Click += new System.EventHandler(this.txtFechaNacimiento_Click);
            // 
            // txtCarnetIdentidad
            // 
            this.txtCarnetIdentidad.AutoSize = true;
            this.txtCarnetIdentidad.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarnetIdentidad.Location = new System.Drawing.Point(31, 199);
            this.txtCarnetIdentidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCarnetIdentidad.Name = "txtCarnetIdentidad";
            this.txtCarnetIdentidad.Size = new System.Drawing.Size(195, 24);
            this.txtCarnetIdentidad.TabIndex = 1;
            this.txtCarnetIdentidad.Text = "Carnet de identidad";
            this.txtCarnetIdentidad.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.AutoSize = true;
            this.txtContrasena.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(32, 288);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(119, 24);
            this.txtContrasena.TabIndex = 2;
            this.txtContrasena.Text = "Contraseña";
            this.txtContrasena.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtCorreo
            // 
            this.txtCorreo.AutoSize = true;
            this.txtCorreo.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(32, 373);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(186, 24);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.Text = "Correo electrónico";
            // 
            // box_date
            // 
            this.box_date.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_date.Location = new System.Drawing.Point(238, 119);
            this.box_date.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.box_date.Name = "box_date";
            this.box_date.Size = new System.Drawing.Size(260, 29);
            this.box_date.TabIndex = 4;
            this.box_date.ValueChanged += new System.EventHandler(this.box_date_ValueChanged);
            // 
            // box_ci
            // 
            this.box_ci.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_ci.Location = new System.Drawing.Point(238, 197);
            this.box_ci.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.box_ci.Name = "box_ci";
            this.box_ci.Size = new System.Drawing.Size(228, 29);
            this.box_ci.TabIndex = 5;
            this.box_ci.TextChanged += new System.EventHandler(this.box_ci_TextChanged);
            // 
            // box_password
            // 
            this.box_password.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_password.Location = new System.Drawing.Point(238, 288);
            this.box_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.box_password.Name = "box_password";
            this.box_password.Size = new System.Drawing.Size(228, 29);
            this.box_password.TabIndex = 6;
            this.box_password.TextChanged += new System.EventHandler(this.box_password_TextChanged);
            // 
            // box_email
            // 
            this.box_email.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_email.Location = new System.Drawing.Point(238, 373);
            this.box_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.box_email.Name = "box_email";
            this.box_email.Size = new System.Drawing.Size(228, 29);
            this.box_email.TabIndex = 7;
            this.box_email.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // box_maternal
            // 
            this.box_maternal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_maternal.Location = new System.Drawing.Point(709, 373);
            this.box_maternal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.box_maternal.Name = "box_maternal";
            this.box_maternal.Size = new System.Drawing.Size(224, 29);
            this.box_maternal.TabIndex = 15;
            this.box_maternal.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // box_paternal
            // 
            this.box_paternal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_paternal.Location = new System.Drawing.Point(709, 291);
            this.box_paternal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.box_paternal.Name = "box_paternal";
            this.box_paternal.Size = new System.Drawing.Size(224, 29);
            this.box_paternal.TabIndex = 14;
            this.box_paternal.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // box_name
            // 
            this.box_name.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_name.Location = new System.Drawing.Point(709, 197);
            this.box_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.box_name.Name = "box_name";
            this.box_name.Size = new System.Drawing.Size(224, 29);
            this.box_name.TabIndex = 13;
            this.box_name.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 378);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Apellido Materno";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(502, 293);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Apellido Paterno";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(502, 204);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(84, 24);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCelular
            // 
            this.txtCelular.AutoSize = true;
            this.txtCelular.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(502, 123);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(76, 24);
            this.txtCelular.TabIndex = 8;
            this.txtCelular.Text = "Celular";
            this.txtCelular.Click += new System.EventHandler(this.label4_Click);
            // 
            // box_phone
            // 
            this.box_phone.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_phone.Location = new System.Drawing.Point(709, 123);
            this.box_phone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.box_phone.Name = "box_phone";
            this.box_phone.Size = new System.Drawing.Size(224, 29);
            this.box_phone.TabIndex = 16;
            this.box_phone.TextChanged += new System.EventHandler(this.box_phone_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(417, 444);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 52);
            this.button1.TabIndex = 17;
            this.button1.Text = "Registrarse";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(-4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 72);
            this.panel1.TabIndex = 53;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(39, 18);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 40);
            this.button3.TabIndex = 19;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(362, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 32);
            this.label4.TabIndex = 54;
            this.label4.Text = "Registro de Usuario";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 504);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SignUp";
            this.Text = "login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtFechaNacimiento;
        private System.Windows.Forms.Label txtCarnetIdentidad;
        private System.Windows.Forms.Label txtContrasena;
        private System.Windows.Forms.Label txtCorreo;
        private System.Windows.Forms.DateTimePicker box_date;
        private System.Windows.Forms.TextBox box_ci;
        private System.Windows.Forms.TextBox box_password;
        private System.Windows.Forms.TextBox box_email;
        private System.Windows.Forms.TextBox box_maternal;
        private System.Windows.Forms.TextBox box_paternal;
        private System.Windows.Forms.TextBox box_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtCelular;
        private System.Windows.Forms.TextBox box_phone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}