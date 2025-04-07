namespace ticket_windows_form
{
    partial class EArtist
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
            this.txtFechaNacimiento = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.box_birthdate = new System.Windows.Forms.DateTimePicker();
            this.box_stage_name = new System.Windows.Forms.TextBox();
            this.box_paternal = new System.Windows.Forms.TextBox();
            this.box_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.box_manager = new System.Windows.Forms.TextBox();
            this.txtCarnetIdentidad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.box_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.save_editArtist = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.txtFechaNacimiento);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1313, 110);
            this.panel1.TabIndex = 52;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.AutoSize = true;
            this.txtFechaNacimiento.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.txtFechaNacimiento.Location = new System.Drawing.Point(495, 33);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(266, 46);
            this.txtFechaNacimiento.TabIndex = 20;
            this.txtFechaNacimiento.Text = "Editar Artista";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(68, 33);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 49);
            this.button1.TabIndex = 19;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // box_birthdate
            // 
            this.box_birthdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_birthdate.Location = new System.Drawing.Point(362, 270);
            this.box_birthdate.Margin = new System.Windows.Forms.Padding(4);
            this.box_birthdate.Name = "box_birthdate";
            this.box_birthdate.Size = new System.Drawing.Size(300, 30);
            this.box_birthdate.TabIndex = 90;
            // 
            // box_stage_name
            // 
            this.box_stage_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_stage_name.Location = new System.Drawing.Point(359, 400);
            this.box_stage_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_stage_name.Multiline = true;
            this.box_stage_name.Name = "box_stage_name";
            this.box_stage_name.Size = new System.Drawing.Size(299, 30);
            this.box_stage_name.TabIndex = 89;
            this.box_stage_name.TextChanged += new System.EventHandler(this.box_maternal_TextChanged);
            // 
            // box_paternal
            // 
            this.box_paternal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_paternal.Location = new System.Drawing.Point(359, 329);
            this.box_paternal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_paternal.Multiline = true;
            this.box_paternal.Name = "box_paternal";
            this.box_paternal.Size = new System.Drawing.Size(299, 30);
            this.box_paternal.TabIndex = 88;
            this.box_paternal.TextChanged += new System.EventHandler(this.box_paternal_TextChanged);
            // 
            // box_name
            // 
            this.box_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_name.Location = new System.Drawing.Point(359, 196);
            this.box_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_name.Multiline = true;
            this.box_name.Name = "box_name";
            this.box_name.Size = new System.Drawing.Size(299, 30);
            this.box_name.TabIndex = 87;
            this.box_name.TextChanged += new System.EventHandler(this.box_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 28);
            this.label1.TabIndex = 86;
            this.label1.Text = "Nombre Artistico :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 28);
            this.label2.TabIndex = 85;
            this.label2.Text = "Apellido Paterno :";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(82, 196);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(111, 28);
            this.txtNombre.TabIndex = 84;
            this.txtNombre.Text = "Nombre :";
            // 
            // box_manager
            // 
            this.box_manager.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_manager.Location = new System.Drawing.Point(359, 467);
            this.box_manager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_manager.Multiline = true;
            this.box_manager.Name = "box_manager";
            this.box_manager.Size = new System.Drawing.Size(299, 30);
            this.box_manager.TabIndex = 83;
            this.box_manager.TextChanged += new System.EventHandler(this.box_phone_TextChanged);
            // 
            // txtCarnetIdentidad
            // 
            this.txtCarnetIdentidad.AutoSize = true;
            this.txtCarnetIdentidad.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarnetIdentidad.Location = new System.Drawing.Point(82, 469);
            this.txtCarnetIdentidad.Name = "txtCarnetIdentidad";
            this.txtCarnetIdentidad.Size = new System.Drawing.Size(119, 28);
            this.txtCarnetIdentidad.TabIndex = 82;
            this.txtCarnetIdentidad.Text = "Manager :";
            this.txtCarnetIdentidad.Click += new System.EventHandler(this.txtCarnetIdentidad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 28);
            this.label3.TabIndex = 81;
            this.label3.Text = "Fecha de nacimiento :";
            // 
            // box_id
            // 
            this.box_id.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_id.Location = new System.Drawing.Point(363, 535);
            this.box_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_id.Multiline = true;
            this.box_id.Name = "box_id";
            this.box_id.Size = new System.Drawing.Size(299, 30);
            this.box_id.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 28);
            this.label4.TabIndex = 91;
            this.label4.Text = "Elegir id Para Editar :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(757, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(457, 376);
            this.dataGridView1.TabIndex = 93;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // save_editArtist
            // 
            this.save_editArtist.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.save_editArtist.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_editArtist.ForeColor = System.Drawing.SystemColors.Control;
            this.save_editArtist.Location = new System.Drawing.Point(588, 629);
            this.save_editArtist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_editArtist.Name = "save_editArtist";
            this.save_editArtist.Size = new System.Drawing.Size(135, 60);
            this.save_editArtist.TabIndex = 21;
            this.save_editArtist.Text = "Guardar";
            this.save_editArtist.UseVisualStyleBackColor = false;
            this.save_editArtist.Click += new System.EventHandler(this.button2_Click);
            // 
            // EArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 727);
            this.Controls.Add(this.save_editArtist);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.box_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.box_birthdate);
            this.Controls.Add(this.box_stage_name);
            this.Controls.Add(this.box_paternal);
            this.Controls.Add(this.box_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.box_manager);
            this.Controls.Add(this.txtCarnetIdentidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "EArtist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EArtist";
            this.Load += new System.EventHandler(this.EArtist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtFechaNacimiento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker box_birthdate;
        private System.Windows.Forms.TextBox box_stage_name;
        private System.Windows.Forms.TextBox box_paternal;
        private System.Windows.Forms.TextBox box_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.TextBox box_manager;
        private System.Windows.Forms.Label txtCarnetIdentidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox box_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button save_editArtist;
    }
}