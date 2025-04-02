namespace ticket_windows_form
{
    partial class CreateArtist
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
            this.label3 = new System.Windows.Forms.Label();
            this.box_maternal = new System.Windows.Forms.TextBox();
            this.box_paternal = new System.Windows.Forms.TextBox();
            this.box_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.box_manager = new System.Windows.Forms.TextBox();
            this.box_stage_name = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.Label();
            this.txtCarnetIdentidad = new System.Windows.Forms.Label();
            this.txtFechaNacimiento = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.box_birthdate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(196, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 38);
            this.label3.TabIndex = 47;
            this.label3.Text = "Registrar Artista";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // box_maternal
            // 
            this.box_maternal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_maternal.Location = new System.Drawing.Point(335, 268);
            this.box_maternal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.box_maternal.Multiline = true;
            this.box_maternal.Name = "box_maternal";
            this.box_maternal.Size = new System.Drawing.Size(225, 23);
            this.box_maternal.TabIndex = 46;
            // 
            // box_paternal
            // 
            this.box_paternal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_paternal.Location = new System.Drawing.Point(335, 212);
            this.box_paternal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.box_paternal.Name = "box_paternal";
            this.box_paternal.Size = new System.Drawing.Size(225, 26);
            this.box_paternal.TabIndex = 45;
            // 
            // box_name
            // 
            this.box_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_name.Location = new System.Drawing.Point(335, 103);
            this.box_name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.box_name.Multiline = true;
            this.box_name.Name = "box_name";
            this.box_name.Size = new System.Drawing.Size(225, 23);
            this.box_name.TabIndex = 44;
            this.box_name.TextChanged += new System.EventHandler(this.box_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 268);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 43;
            this.label1.Text = "Apellido Materno :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "Apellido Paterno :";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(117, 103);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(89, 23);
            this.txtNombre.TabIndex = 41;
            this.txtNombre.Text = "Nombre :";
            // 
            // box_manager
            // 
            this.box_manager.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_manager.Location = new System.Drawing.Point(335, 381);
            this.box_manager.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.box_manager.Multiline = true;
            this.box_manager.Name = "box_manager";
            this.box_manager.Size = new System.Drawing.Size(225, 23);
            this.box_manager.TabIndex = 40;
            // 
            // box_stage_name
            // 
            this.box_stage_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_stage_name.Location = new System.Drawing.Point(335, 325);
            this.box_stage_name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.box_stage_name.Multiline = true;
            this.box_stage_name.Name = "box_stage_name";
            this.box_stage_name.Size = new System.Drawing.Size(225, 23);
            this.box_stage_name.TabIndex = 39;
            // 
            // txtContrasena
            // 
            this.txtContrasena.AutoSize = true;
            this.txtContrasena.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(117, 381);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(97, 23);
            this.txtContrasena.TabIndex = 38;
            this.txtContrasena.Text = "Manager :";
            // 
            // txtCarnetIdentidad
            // 
            this.txtCarnetIdentidad.AutoSize = true;
            this.txtCarnetIdentidad.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarnetIdentidad.Location = new System.Drawing.Point(117, 325);
            this.txtCarnetIdentidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCarnetIdentidad.Name = "txtCarnetIdentidad";
            this.txtCarnetIdentidad.Size = new System.Drawing.Size(170, 23);
            this.txtCarnetIdentidad.TabIndex = 37;
            this.txtCarnetIdentidad.Text = "Nombre Artistico :";
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.AutoSize = true;
            this.txtFechaNacimiento.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNacimiento.Location = new System.Drawing.Point(117, 157);
            this.txtFechaNacimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(205, 23);
            this.txtFechaNacimiento.TabIndex = 36;
            this.txtFechaNacimiento.Text = "Fecha de nacimiento :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(258, 431);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 48);
            this.button1.TabIndex = 49;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 72);
            this.panel1.TabIndex = 80;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(39, 18);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 40);
            this.button4.TabIndex = 19;
            this.button4.Text = "Volver";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(175, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 79;
            // 
            // box_birthdate
            // 
            this.box_birthdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_birthdate.Location = new System.Drawing.Point(335, 160);
            this.box_birthdate.Name = "box_birthdate";
            this.box_birthdate.Size = new System.Drawing.Size(227, 26);
            this.box_birthdate.TabIndex = 81;
            // 
            // CreateArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 487);
            this.Controls.Add(this.box_birthdate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.box_maternal);
            this.Controls.Add(this.box_paternal);
            this.Controls.Add(this.box_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.box_manager);
            this.Controls.Add(this.box_stage_name);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtCarnetIdentidad);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "CreateArtist";
            this.Text = "CreateArtist";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox box_maternal;
        private System.Windows.Forms.TextBox box_paternal;
        private System.Windows.Forms.TextBox box_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.TextBox box_manager;
        private System.Windows.Forms.TextBox box_stage_name;
        private System.Windows.Forms.Label txtContrasena;
        private System.Windows.Forms.Label txtCarnetIdentidad;
        private System.Windows.Forms.Label txtFechaNacimiento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker box_birthdate;
    }
}