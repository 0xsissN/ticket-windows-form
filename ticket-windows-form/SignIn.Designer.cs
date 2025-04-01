namespace ticket_windows_form
{
    partial class SignIn
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
            this.box_email = new System.Windows.Forms.TextBox();
            this.box_password = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // box_email
            // 
            this.box_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.box_email.Location = new System.Drawing.Point(593, 244);
            this.box_email.Name = "box_email";
            this.box_email.Size = new System.Drawing.Size(298, 26);
            this.box_email.TabIndex = 17;
            this.box_email.TextChanged += new System.EventHandler(this.box_email_TextChanged);
            // 
            // box_password
            // 
            this.box_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.box_password.Location = new System.Drawing.Point(593, 356);
            this.box_password.Name = "box_password";
            this.box_password.Size = new System.Drawing.Size(298, 26);
            this.box_password.TabIndex = 18;
            this.box_password.TextChanged += new System.EventHandler(this.box_password_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNombre.Location = new System.Drawing.Point(309, 239);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(222, 29);
            this.txtNombre.TabIndex = 19;
            this.txtNombre.Text = "Correo Electrónico";
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(309, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Contraseña";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(547, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 49);
            this.button1.TabIndex = 21;
            this.button1.Text = "Iniciar Sesión";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1312, 727);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.box_password);
            this.Controls.Add(this.box_email);
            this.Name = "SignIn";
            this.Text = "SingIn";
            this.Load += new System.EventHandler(this.SingIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox box_email;
        private System.Windows.Forms.TextBox box_password;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}