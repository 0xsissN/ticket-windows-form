﻿namespace ticket_windows_form
{
    partial class CreateReceipt
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.box_nro_receipt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.box_date = new System.Windows.Forms.TextBox();
            this.box_method = new System.Windows.Forms.TextBox();
            this.box_cod_client = new System.Windows.Forms.TextBox();
            this.box_details = new System.Windows.Forms.TextBox();
            this.box_amount_super_vip = new System.Windows.Forms.TextBox();
            this.box_amount_vip = new System.Windows.Forms.TextBox();
            this.box_amount_general = new System.Windows.Forms.TextBox();
            this.box_total_super_vip = new System.Windows.Forms.TextBox();
            this.box_total_vip = new System.Windows.Forms.TextBox();
            this.box_total_general = new System.Windows.Forms.TextBox();
            this.box_total = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(819, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 30);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nro Recibo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 30);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 30);
            this.label3.TabIndex = 23;
            this.label3.Text = "Detalle Facturacion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 30);
            this.label4.TabIndex = 24;
            this.label4.Text = "Metodo de Pago:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 36);
            this.label5.TabIndex = 25;
            this.label5.Text = "Boleto";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(353, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 36);
            this.label6.TabIndex = 26;
            this.label6.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(629, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 36);
            this.label7.TabIndex = 27;
            this.label7.Text = "Precio Unitario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(981, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 36);
            this.label8.TabIndex = 28;
            this.label8.Text = "Sup Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(68, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 30);
            this.label9.TabIndex = 29;
            this.label9.Text = "Super Vip";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(68, 516);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 30);
            this.label10.TabIndex = 30;
            this.label10.Text = "Vip";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(63, 574);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 30);
            this.label11.TabIndex = 31;
            this.label11.Text = "General";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(647, 455);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 30);
            this.label12.TabIndex = 32;
            this.label12.Text = "300 Bs";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(647, 516);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 30);
            this.label13.TabIndex = 33;
            this.label13.Text = "200 Bs";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(647, 574);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 30);
            this.label14.TabIndex = 34;
            this.label14.Text = "70 Bs";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(629, 638);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(163, 30);
            this.label15.TabIndex = 35;
            this.label15.Text = "Sup Total Bs";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(819, 218);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(158, 30);
            this.label17.TabIndex = 37;
            this.label17.Text = "Cod Cliente:";
            // 
            // box_nro_receipt
            // 
            this.box_nro_receipt.BackColor = System.Drawing.SystemColors.Control;
            this.box_nro_receipt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_nro_receipt.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_nro_receipt.Location = new System.Drawing.Point(1016, 149);
            this.box_nro_receipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_nro_receipt.Name = "box_nro_receipt";
            this.box_nro_receipt.ReadOnly = true;
            this.box_nro_receipt.Size = new System.Drawing.Size(151, 27);
            this.box_nro_receipt.TabIndex = 38;
            this.box_nro_receipt.TextChanged += new System.EventHandler(this.box_nro_receipt_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // box_date
            // 
            this.box_date.BackColor = System.Drawing.SystemColors.Control;
            this.box_date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_date.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_date.Location = new System.Drawing.Point(508, 146);
            this.box_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_date.Name = "box_date";
            this.box_date.ReadOnly = true;
            this.box_date.Size = new System.Drawing.Size(221, 27);
            this.box_date.TabIndex = 40;
            this.box_date.TextChanged += new System.EventHandler(this.box_date_TextChanged);
            // 
            // box_method
            // 
            this.box_method.BackColor = System.Drawing.SystemColors.Control;
            this.box_method.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_method.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_method.Location = new System.Drawing.Point(508, 293);
            this.box_method.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_method.Name = "box_method";
            this.box_method.ReadOnly = true;
            this.box_method.Size = new System.Drawing.Size(151, 27);
            this.box_method.TabIndex = 41;
            this.box_method.TextChanged += new System.EventHandler(this.box_method_TextChanged);
            // 
            // box_cod_client
            // 
            this.box_cod_client.BackColor = System.Drawing.SystemColors.Control;
            this.box_cod_client.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_cod_client.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_cod_client.Location = new System.Drawing.Point(1016, 218);
            this.box_cod_client.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_cod_client.Name = "box_cod_client";
            this.box_cod_client.ReadOnly = true;
            this.box_cod_client.Size = new System.Drawing.Size(151, 27);
            this.box_cod_client.TabIndex = 42;
            this.box_cod_client.TextChanged += new System.EventHandler(this.box_cod_client_TextChanged);
            // 
            // box_details
            // 
            this.box_details.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_details.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_details.Location = new System.Drawing.Point(508, 219);
            this.box_details.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_details.Name = "box_details";
            this.box_details.ReadOnly = true;
            this.box_details.Size = new System.Drawing.Size(245, 27);
            this.box_details.TabIndex = 43;
            this.box_details.Text = "Compra de Boletos";
            this.box_details.TextChanged += new System.EventHandler(this.box_details_TextChanged);
            // 
            // box_amount_super_vip
            // 
            this.box_amount_super_vip.BackColor = System.Drawing.SystemColors.Control;
            this.box_amount_super_vip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_amount_super_vip.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_amount_super_vip.Location = new System.Drawing.Point(360, 455);
            this.box_amount_super_vip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_amount_super_vip.Name = "box_amount_super_vip";
            this.box_amount_super_vip.ReadOnly = true;
            this.box_amount_super_vip.Size = new System.Drawing.Size(104, 27);
            this.box_amount_super_vip.TabIndex = 44;
            this.box_amount_super_vip.TextChanged += new System.EventHandler(this.box_amount_super_vip_TextChanged);
            // 
            // box_amount_vip
            // 
            this.box_amount_vip.BackColor = System.Drawing.SystemColors.Control;
            this.box_amount_vip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_amount_vip.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_amount_vip.Location = new System.Drawing.Point(360, 516);
            this.box_amount_vip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_amount_vip.Name = "box_amount_vip";
            this.box_amount_vip.ReadOnly = true;
            this.box_amount_vip.Size = new System.Drawing.Size(104, 27);
            this.box_amount_vip.TabIndex = 45;
            this.box_amount_vip.TextChanged += new System.EventHandler(this.box_amount_vip_TextChanged);
            // 
            // box_amount_general
            // 
            this.box_amount_general.BackColor = System.Drawing.SystemColors.Control;
            this.box_amount_general.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_amount_general.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_amount_general.Location = new System.Drawing.Point(360, 574);
            this.box_amount_general.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_amount_general.Name = "box_amount_general";
            this.box_amount_general.ReadOnly = true;
            this.box_amount_general.Size = new System.Drawing.Size(104, 27);
            this.box_amount_general.TabIndex = 46;
            this.box_amount_general.TextChanged += new System.EventHandler(this.box_amount_general_TextChanged);
            // 
            // box_total_super_vip
            // 
            this.box_total_super_vip.BackColor = System.Drawing.SystemColors.Control;
            this.box_total_super_vip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_total_super_vip.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_total_super_vip.Location = new System.Drawing.Point(988, 455);
            this.box_total_super_vip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_total_super_vip.Name = "box_total_super_vip";
            this.box_total_super_vip.ReadOnly = true;
            this.box_total_super_vip.Size = new System.Drawing.Size(104, 27);
            this.box_total_super_vip.TabIndex = 47;
            this.box_total_super_vip.TextChanged += new System.EventHandler(this.box_total_super_vip_TextChanged);
            // 
            // box_total_vip
            // 
            this.box_total_vip.BackColor = System.Drawing.SystemColors.Control;
            this.box_total_vip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_total_vip.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_total_vip.Location = new System.Drawing.Point(987, 511);
            this.box_total_vip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_total_vip.Name = "box_total_vip";
            this.box_total_vip.ReadOnly = true;
            this.box_total_vip.Size = new System.Drawing.Size(104, 27);
            this.box_total_vip.TabIndex = 48;
            this.box_total_vip.TextChanged += new System.EventHandler(this.box_total_vip_TextChanged);
            // 
            // box_total_general
            // 
            this.box_total_general.BackColor = System.Drawing.SystemColors.Control;
            this.box_total_general.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_total_general.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_total_general.Location = new System.Drawing.Point(987, 569);
            this.box_total_general.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_total_general.Name = "box_total_general";
            this.box_total_general.ReadOnly = true;
            this.box_total_general.Size = new System.Drawing.Size(104, 27);
            this.box_total_general.TabIndex = 49;
            this.box_total_general.TextChanged += new System.EventHandler(this.box_total_general_TextChanged);
            // 
            // box_total
            // 
            this.box_total.BackColor = System.Drawing.SystemColors.Control;
            this.box_total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_total.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_total.Location = new System.Drawing.Point(987, 635);
            this.box_total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_total.Name = "box_total";
            this.box_total.ReadOnly = true;
            this.box_total.Size = new System.Drawing.Size(104, 27);
            this.box_total.TabIndex = 50;
            this.box_total.TextChanged += new System.EventHandler(this.box_total_TextChanged);
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.AutoSize = true;
            this.txtFechaNacimiento.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.txtFechaNacimiento.Location = new System.Drawing.Point(555, 27);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(144, 46);
            this.txtFechaNacimiento.TabIndex = 20;
            this.txtFechaNacimiento.Text = "Recibo";
            this.txtFechaNacimiento.Click += new System.EventHandler(this.txtFechaNacimiento_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.txtFechaNacimiento);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1313, 110);
            this.panel1.TabIndex = 51;
            // 
            // CreateReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1312, 727);
            this.Controls.Add(this.box_total);
            this.Controls.Add(this.box_total_general);
            this.Controls.Add(this.box_total_vip);
            this.Controls.Add(this.box_total_super_vip);
            this.Controls.Add(this.box_amount_general);
            this.Controls.Add(this.box_amount_vip);
            this.Controls.Add(this.box_amount_super_vip);
            this.Controls.Add(this.box_details);
            this.Controls.Add(this.box_cod_client);
            this.Controls.Add(this.box_method);
            this.Controls.Add(this.box_date);
            this.Controls.Add(this.box_nro_receipt);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateReceipt";
            this.Load += new System.EventHandler(this.CreateReceipt_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox box_nro_receipt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox box_date;
        private System.Windows.Forms.TextBox box_method;
        private System.Windows.Forms.TextBox box_cod_client;
        private System.Windows.Forms.TextBox box_details;
        private System.Windows.Forms.TextBox box_amount_super_vip;
        private System.Windows.Forms.TextBox box_amount_vip;
        private System.Windows.Forms.TextBox box_amount_general;
        private System.Windows.Forms.TextBox box_total_super_vip;
        private System.Windows.Forms.TextBox box_total_vip;
        private System.Windows.Forms.TextBox box_total_general;
        private System.Windows.Forms.TextBox box_total;
        private System.Windows.Forms.Label txtFechaNacimiento;
        private System.Windows.Forms.Panel panel1;
    }
}