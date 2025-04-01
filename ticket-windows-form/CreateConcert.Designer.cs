namespace ticket_windows_form
{
    partial class CreateConcert
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.box_birthdate = new System.Windows.Forms.TextBox();
            this.box_capacity = new System.Windows.Forms.TextBox();
            this.box_concert_name = new System.Windows.Forms.TextBox();
            this.box_organization = new System.Windows.Forms.TextBox();
            this.box_location = new System.Windows.Forms.TextBox();
            this.box = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.box_end_date = new System.Windows.Forms.TextBox();
            this.box_start_date = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // box_maternal
            // 
            this.box_maternal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.box_maternal.Location = new System.Drawing.Point(330, 394);
            this.box_maternal.Name = "box_maternal";
            this.box_maternal.Size = new System.Drawing.Size(298, 26);
            this.box_maternal.TabIndex = 31;
            this.box_maternal.TextChanged += new System.EventHandler(this.box_maternal_TextChanged);
            // 
            // box_paternal
            // 
            this.box_paternal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.box_paternal.Location = new System.Drawing.Point(330, 324);
            this.box_paternal.Name = "box_paternal";
            this.box_paternal.Size = new System.Drawing.Size(298, 26);
            this.box_paternal.TabIndex = 30;
            this.box_paternal.TextChanged += new System.EventHandler(this.box_paternal_TextChanged);
            // 
            // box_name
            // 
            this.box_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.box_name.Location = new System.Drawing.Point(330, 190);
            this.box_name.Name = "box_name";
            this.box_name.Size = new System.Drawing.Size(298, 26);
            this.box_name.TabIndex = 29;
            this.box_name.TextChanged += new System.EventHandler(this.box_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(54, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Apellido Materno";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(54, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Apellido Paterno";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNombre.Location = new System.Drawing.Point(54, 190);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(103, 29);
            this.txtNombre.TabIndex = 26;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            // 
            // box_manager
            // 
            this.box_manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.box_manager.Location = new System.Drawing.Point(330, 532);
            this.box_manager.Name = "box_manager";
            this.box_manager.Size = new System.Drawing.Size(298, 26);
            this.box_manager.TabIndex = 23;
            this.box_manager.TextChanged += new System.EventHandler(this.box_manager_TextChanged);
            // 
            // box_stage_name
            // 
            this.box_stage_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.box_stage_name.Location = new System.Drawing.Point(330, 463);
            this.box_stage_name.Name = "box_stage_name";
            this.box_stage_name.Size = new System.Drawing.Size(298, 26);
            this.box_stage_name.TabIndex = 22;
            this.box_stage_name.TextChanged += new System.EventHandler(this.box_stage_name_TextChanged);
            // 
            // txtContrasena
            // 
            this.txtContrasena.AutoSize = true;
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtContrasena.Location = new System.Drawing.Point(54, 532);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(112, 29);
            this.txtContrasena.TabIndex = 19;
            this.txtContrasena.Text = "Manager";
            this.txtContrasena.Click += new System.EventHandler(this.txtContrasena_Click);
            // 
            // txtCarnetIdentidad
            // 
            this.txtCarnetIdentidad.AutoSize = true;
            this.txtCarnetIdentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCarnetIdentidad.Location = new System.Drawing.Point(54, 463);
            this.txtCarnetIdentidad.Name = "txtCarnetIdentidad";
            this.txtCarnetIdentidad.Size = new System.Drawing.Size(201, 29);
            this.txtCarnetIdentidad.TabIndex = 18;
            this.txtCarnetIdentidad.Text = "Nombre Artistico";
            this.txtCarnetIdentidad.Click += new System.EventHandler(this.txtCarnetIdentidad_Click);
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.AutoSize = true;
            this.txtFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtFechaNacimiento.Location = new System.Drawing.Point(54, 257);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(249, 29);
            this.txtFechaNacimiento.TabIndex = 17;
            this.txtFechaNacimiento.Text = "Fecha de nacimiento";
            this.txtFechaNacimiento.Click += new System.EventHandler(this.txtFechaNacimiento_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(229, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 29);
            this.label3.TabIndex = 33;
            this.label3.Text = "Registrar Artista";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(840, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 29);
            this.label4.TabIndex = 34;
            this.label4.Text = "Registrar Concierto";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // box_birthdate
            // 
            this.box_birthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.box_birthdate.Location = new System.Drawing.Point(330, 257);
            this.box_birthdate.Name = "box_birthdate";
            this.box_birthdate.Size = new System.Drawing.Size(298, 26);
            this.box_birthdate.TabIndex = 35;
            this.box_birthdate.TextChanged += new System.EventHandler(this.box_birthdate_TextChanged);
            // 
            // box_capacity
            // 
            this.box_capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.box_capacity.Location = new System.Drawing.Point(965, 257);
            this.box_capacity.Name = "box_capacity";
            this.box_capacity.Size = new System.Drawing.Size(298, 26);
            this.box_capacity.TabIndex = 47;
            this.box_capacity.TextChanged += new System.EventHandler(this.box_capacity_TextChanged);
            // 
            // box_concert_name
            // 
            this.box_concert_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.box_concert_name.Location = new System.Drawing.Point(965, 394);
            this.box_concert_name.Name = "box_concert_name";
            this.box_concert_name.Size = new System.Drawing.Size(298, 26);
            this.box_concert_name.TabIndex = 46;
            this.box_concert_name.TextChanged += new System.EventHandler(this.box_concert_name_TextChanged);
            // 
            // box_organization
            // 
            this.box_organization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.box_organization.Location = new System.Drawing.Point(965, 324);
            this.box_organization.Name = "box_organization";
            this.box_organization.Size = new System.Drawing.Size(298, 26);
            this.box_organization.TabIndex = 45;
            this.box_organization.TextChanged += new System.EventHandler(this.box_organization_TextChanged);
            // 
            // box_location
            // 
            this.box_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.box_location.Location = new System.Drawing.Point(965, 190);
            this.box_location.Name = "box_location";
            this.box_location.Size = new System.Drawing.Size(298, 26);
            this.box_location.TabIndex = 44;
            this.box_location.TextChanged += new System.EventHandler(this.box_location_TextChanged);
            // 
            // box
            // 
            this.box.AutoSize = true;
            this.box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.box.Location = new System.Drawing.Point(689, 394);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(218, 29);
            this.box.TabIndex = 43;
            this.box.Text = "Nombre Concierto";
            this.box.Click += new System.EventHandler(this.box_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(689, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 29);
            this.label6.TabIndex = 42;
            this.label6.Text = "Organizacion";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(689, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 29);
            this.label7.TabIndex = 41;
            this.label7.Text = "Ubicacion Concierto";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // box_end_date
            // 
            this.box_end_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.box_end_date.Location = new System.Drawing.Point(965, 532);
            this.box_end_date.Name = "box_end_date";
            this.box_end_date.Size = new System.Drawing.Size(298, 26);
            this.box_end_date.TabIndex = 40;
            this.box_end_date.TextChanged += new System.EventHandler(this.box_end_date_TextChanged);
            // 
            // box_start_date
            // 
            this.box_start_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.box_start_date.Location = new System.Drawing.Point(965, 463);
            this.box_start_date.Name = "box_start_date";
            this.box_start_date.Size = new System.Drawing.Size(298, 26);
            this.box_start_date.TabIndex = 39;
            this.box_start_date.TextChanged += new System.EventHandler(this.box_start_date_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(689, 532);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(260, 29);
            this.label8.TabIndex = 38;
            this.label8.Text = "Fecha de Finalizacion";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(689, 463);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 29);
            this.label9.TabIndex = 37;
            this.label9.Text = "Fecha de Inicio";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.Location = new System.Drawing.Point(689, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 29);
            this.label10.TabIndex = 36;
            this.label10.Text = "Capacidad";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(550, 624);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 65);
            this.button1.TabIndex = 48;
            this.button1.Text = "Guardar Concierto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateConcert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1312, 727);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.box_capacity);
            this.Controls.Add(this.box_concert_name);
            this.Controls.Add(this.box_organization);
            this.Controls.Add(this.box_location);
            this.Controls.Add(this.box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.box_end_date);
            this.Controls.Add(this.box_start_date);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.box_birthdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
            this.Name = "CreateConcert";
            this.Text = "Concert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox box_birthdate;
        private System.Windows.Forms.TextBox box_capacity;
        private System.Windows.Forms.TextBox box_concert_name;
        private System.Windows.Forms.TextBox box_organization;
        private System.Windows.Forms.TextBox box_location;
        private System.Windows.Forms.Label box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox box_end_date;
        private System.Windows.Forms.TextBox box_start_date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}