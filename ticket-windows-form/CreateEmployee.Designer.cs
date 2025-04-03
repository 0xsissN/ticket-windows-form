namespace ticket_windows_form
{
    partial class CreateEmployee
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
            this.button1 = new System.Windows.Forms.Button();
            this.box_charge = new System.Windows.Forms.TextBox();
            this.box_salary = new System.Windows.Forms.TextBox();
            this.box = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.box_password = new System.Windows.Forms.TextBox();
            this.box_email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.box_maternal = new System.Windows.Forms.TextBox();
            this.box_paternal = new System.Windows.Forms.TextBox();
            this.box_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.box_phone = new System.Windows.Forms.TextBox();
            this.txtCarnetIdentidad = new System.Windows.Forms.Label();
            this.txtFechaNacimiento = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.box_hiring_date = new System.Windows.Forms.DateTimePicker();
            this.box_birthdate = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(408, 499);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 65);
            this.button1.TabIndex = 75;
            this.button1.Text = "Guardar Datos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // box_charge
            // 
            this.box_charge.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_charge.Location = new System.Drawing.Point(969, 266);
            this.box_charge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_charge.Multiline = true;
            this.box_charge.Name = "box_charge";
            this.box_charge.Size = new System.Drawing.Size(299, 30);
            this.box_charge.TabIndex = 73;
            this.box_charge.TextChanged += new System.EventHandler(this.box_charge_TextChanged);
            // 
            // box_salary
            // 
            this.box_salary.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_salary.Location = new System.Drawing.Point(969, 199);
            this.box_salary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_salary.Multiline = true;
            this.box_salary.Name = "box_salary";
            this.box_salary.Size = new System.Drawing.Size(299, 30);
            this.box_salary.TabIndex = 72;
            // 
            // box
            // 
            this.box.AutoSize = true;
            this.box.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box.Location = new System.Drawing.Point(671, 268);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(90, 28);
            this.box.TabIndex = 70;
            this.box.Text = "Cargo :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(671, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 28);
            this.label6.TabIndex = 69;
            this.label6.Text = "Email :";
            // 
            // box_password
            // 
            this.box_password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_password.Location = new System.Drawing.Point(969, 406);
            this.box_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_password.Multiline = true;
            this.box_password.Name = "box_password";
            this.box_password.Size = new System.Drawing.Size(299, 30);
            this.box_password.TabIndex = 67;
            this.box_password.TextChanged += new System.EventHandler(this.box_password_TextChanged);
            // 
            // box_email
            // 
            this.box_email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_email.Location = new System.Drawing.Point(969, 341);
            this.box_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_email.Multiline = true;
            this.box_email.Name = "box_email";
            this.box_email.Size = new System.Drawing.Size(299, 30);
            this.box_email.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(671, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(271, 28);
            this.label8.TabIndex = 65;
            this.label8.Text = "Fecha de Contratacion :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(671, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 28);
            this.label9.TabIndex = 64;
            this.label9.Text = "Sueldo :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(671, 409);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 28);
            this.label10.TabIndex = 63;
            this.label10.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(448, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(389, 48);
            this.label4.TabIndex = 61;
            this.label4.Text = "Registrar Empleado";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(227, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 29);
            this.label3.TabIndex = 60;
            // 
            // box_maternal
            // 
            this.box_maternal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_maternal.Location = new System.Drawing.Point(325, 343);
            this.box_maternal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_maternal.Multiline = true;
            this.box_maternal.Name = "box_maternal";
            this.box_maternal.Size = new System.Drawing.Size(299, 30);
            this.box_maternal.TabIndex = 59;
            // 
            // box_paternal
            // 
            this.box_paternal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_paternal.Location = new System.Drawing.Point(325, 272);
            this.box_paternal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_paternal.Multiline = true;
            this.box_paternal.Name = "box_paternal";
            this.box_paternal.Size = new System.Drawing.Size(299, 30);
            this.box_paternal.TabIndex = 58;
            this.box_paternal.TextChanged += new System.EventHandler(this.box_paternal_TextChanged);
            // 
            // box_name
            // 
            this.box_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_name.Location = new System.Drawing.Point(325, 139);
            this.box_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_name.Multiline = true;
            this.box_name.Name = "box_name";
            this.box_name.Size = new System.Drawing.Size(299, 30);
            this.box_name.TabIndex = 57;
            this.box_name.TextChanged += new System.EventHandler(this.box_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 28);
            this.label1.TabIndex = 56;
            this.label1.Text = "Apellido Materno :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 28);
            this.label2.TabIndex = 55;
            this.label2.Text = "Apellido Paterno :";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(48, 139);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(111, 28);
            this.txtNombre.TabIndex = 54;
            this.txtNombre.Text = "Nombre :";
            // 
            // box_phone
            // 
            this.box_phone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_phone.Location = new System.Drawing.Point(325, 410);
            this.box_phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_phone.Multiline = true;
            this.box_phone.Name = "box_phone";
            this.box_phone.Size = new System.Drawing.Size(299, 30);
            this.box_phone.TabIndex = 52;
            // 
            // txtCarnetIdentidad
            // 
            this.txtCarnetIdentidad.AutoSize = true;
            this.txtCarnetIdentidad.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarnetIdentidad.Location = new System.Drawing.Point(48, 412);
            this.txtCarnetIdentidad.Name = "txtCarnetIdentidad";
            this.txtCarnetIdentidad.Size = new System.Drawing.Size(104, 28);
            this.txtCarnetIdentidad.TabIndex = 50;
            this.txtCarnetIdentidad.Text = "Celular :";
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.AutoSize = true;
            this.txtFechaNacimiento.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNacimiento.Location = new System.Drawing.Point(48, 208);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(251, 28);
            this.txtFechaNacimiento.TabIndex = 49;
            this.txtFechaNacimiento.Text = "Fecha de nacimiento :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(1, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1319, 89);
            this.panel1.TabIndex = 78;
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
            // box_hiring_date
            // 
            this.box_hiring_date.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_hiring_date.Location = new System.Drawing.Point(971, 132);
            this.box_hiring_date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.box_hiring_date.Name = "box_hiring_date";
            this.box_hiring_date.Size = new System.Drawing.Size(297, 30);
            this.box_hiring_date.TabIndex = 79;
            this.box_hiring_date.ValueChanged += new System.EventHandler(this.box_hiring_date_ValueChanged);
            // 
            // box_birthdate
            // 
            this.box_birthdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_birthdate.Location = new System.Drawing.Point(328, 213);
            this.box_birthdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.box_birthdate.Name = "box_birthdate";
            this.box_birthdate.Size = new System.Drawing.Size(300, 30);
            this.box_birthdate.TabIndex = 80;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(710, 499);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(220, 68);
            this.button5.TabIndex = 81;
            this.button5.Text = "Editar Empleado";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CreateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1316, 599);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.box_birthdate);
            this.Controls.Add(this.box_hiring_date);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.box_charge);
            this.Controls.Add(this.box_salary);
            this.Controls.Add(this.box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.box_password);
            this.Controls.Add(this.box_email);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.box_maternal);
            this.Controls.Add(this.box_paternal);
            this.Controls.Add(this.box_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.box_phone);
            this.Controls.Add(this.txtCarnetIdentidad);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeCreate";
            this.Load += new System.EventHandler(this.CreateEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox box_charge;
        private System.Windows.Forms.TextBox box_salary;
        private System.Windows.Forms.Label box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox box_password;
        private System.Windows.Forms.TextBox box_email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox box_maternal;
        private System.Windows.Forms.TextBox box_paternal;
        private System.Windows.Forms.TextBox box_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.TextBox box_phone;
        private System.Windows.Forms.Label txtCarnetIdentidad;
        private System.Windows.Forms.Label txtFechaNacimiento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker box_hiring_date;
        private System.Windows.Forms.DateTimePicker box_birthdate;
        private System.Windows.Forms.Button button5;
    }
}