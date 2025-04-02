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
            this.box_birthdate = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // box_birthdate
            // 
            this.box_birthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.box_birthdate.Location = new System.Drawing.Point(470, 254);
            this.box_birthdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_birthdate.Multiline = true;
            this.box_birthdate.Name = "box_birthdate";
            this.box_birthdate.Size = new System.Drawing.Size(335, 33);
            this.box_birthdate.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(392, 56);
            this.label3.TabIndex = 47;
            this.label3.Text = "Registrar Artista";
            // 
            // box_maternal
            // 
            this.box_maternal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.box_maternal.Location = new System.Drawing.Point(470, 425);
            this.box_maternal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_maternal.Multiline = true;
            this.box_maternal.Name = "box_maternal";
            this.box_maternal.Size = new System.Drawing.Size(335, 33);
            this.box_maternal.TabIndex = 46;
            // 
            // box_paternal
            // 
            this.box_paternal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.box_paternal.Location = new System.Drawing.Point(470, 338);
            this.box_paternal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_paternal.Name = "box_paternal";
            this.box_paternal.Size = new System.Drawing.Size(335, 30);
            this.box_paternal.TabIndex = 45;
            // 
            // box_name
            // 
            this.box_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.box_name.Location = new System.Drawing.Point(470, 171);
            this.box_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_name.Multiline = true;
            this.box_name.Name = "box_name";
            this.box_name.Size = new System.Drawing.Size(335, 33);
            this.box_name.TabIndex = 44;
            this.box_name.TextChanged += new System.EventHandler(this.box_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 33);
            this.label1.TabIndex = 43;
            this.label1.Text = "Apellido Materno :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 33);
            this.label2.TabIndex = 42;
            this.label2.Text = "Apellido Paterno :";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(142, 171);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(134, 33);
            this.txtNombre.TabIndex = 41;
            this.txtNombre.Text = "Nombre :";
            // 
            // box_manager
            // 
            this.box_manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.box_manager.Location = new System.Drawing.Point(470, 598);
            this.box_manager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_manager.Multiline = true;
            this.box_manager.Name = "box_manager";
            this.box_manager.Size = new System.Drawing.Size(335, 33);
            this.box_manager.TabIndex = 40;
            // 
            // box_stage_name
            // 
            this.box_stage_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.box_stage_name.Location = new System.Drawing.Point(470, 512);
            this.box_stage_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_stage_name.Multiline = true;
            this.box_stage_name.Name = "box_stage_name";
            this.box_stage_name.Size = new System.Drawing.Size(335, 33);
            this.box_stage_name.TabIndex = 39;
            // 
            // txtContrasena
            // 
            this.txtContrasena.AutoSize = true;
            this.txtContrasena.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(142, 598);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(145, 33);
            this.txtContrasena.TabIndex = 38;
            this.txtContrasena.Text = "Manager :";
            // 
            // txtCarnetIdentidad
            // 
            this.txtCarnetIdentidad.AutoSize = true;
            this.txtCarnetIdentidad.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarnetIdentidad.Location = new System.Drawing.Point(142, 512);
            this.txtCarnetIdentidad.Name = "txtCarnetIdentidad";
            this.txtCarnetIdentidad.Size = new System.Drawing.Size(258, 33);
            this.txtCarnetIdentidad.TabIndex = 37;
            this.txtCarnetIdentidad.Text = "Nombre Artistico :";
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.AutoSize = true;
            this.txtFechaNacimiento.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNacimiento.Location = new System.Drawing.Point(142, 254);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(305, 33);
            this.txtFechaNacimiento.TabIndex = 36;
            this.txtFechaNacimiento.Text = "Fecha de nacimiento :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 697);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 74);
            this.button1.TabIndex = 49;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 783);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.box_birthdate);
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
            this.Name = "CreateArtist";
            this.Text = "CreateArtist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox box_birthdate;
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
    }
}