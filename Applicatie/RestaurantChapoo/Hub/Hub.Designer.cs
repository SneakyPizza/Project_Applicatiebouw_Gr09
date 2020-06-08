﻿namespace Hub
{
    partial class Hub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hub));
            this.lbl_Datum = new System.Windows.Forms.Label();
            this.btn_Bar = new System.Windows.Forms.Button();
            this.btn_Management = new System.Windows.Forms.Button();
            this.btn_BestellingOpnemen = new System.Windows.Forms.Button();
            this.btn_Keuken = new System.Windows.Forms.Button();
            this.pnl_Hub = new System.Windows.Forms.Panel();
            this.lbl_WelkomstZin = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.pnl_Hub.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Datum
            // 
            this.lbl_Datum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Datum.AutoSize = true;
            this.lbl_Datum.Location = new System.Drawing.Point(11, 9);
            this.lbl_Datum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Datum.Name = "lbl_Datum";
            this.lbl_Datum.Size = new System.Drawing.Size(48, 13);
            this.lbl_Datum.TabIndex = 4;
            this.lbl_Datum.Text = "<datum>";
            // 
            // btn_Bar
            // 
            this.btn_Bar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Bar.FlatAppearance.BorderSize = 0;
            this.btn_Bar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bar.Location = new System.Drawing.Point(322, 37);
            this.btn_Bar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Bar.Name = "btn_Bar";
            this.btn_Bar.Size = new System.Drawing.Size(82, 81);
            this.btn_Bar.TabIndex = 2;
            this.btn_Bar.Text = "Bar";
            this.btn_Bar.UseVisualStyleBackColor = false;
            // 
            // btn_Management
            // 
            this.btn_Management.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Management.FlatAppearance.BorderSize = 0;
            this.btn_Management.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Management.Location = new System.Drawing.Point(196, 137);
            this.btn_Management.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Management.Name = "btn_Management";
            this.btn_Management.Size = new System.Drawing.Size(82, 81);
            this.btn_Management.TabIndex = 3;
            this.btn_Management.Text = "Management";
            this.btn_Management.UseVisualStyleBackColor = false;
            this.btn_Management.Click += new System.EventHandler(this.Btn_Management_Click);
            // 
            // btn_BestellingOpnemen
            // 
            this.btn_BestellingOpnemen.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_BestellingOpnemen.FlatAppearance.BorderSize = 0;
            this.btn_BestellingOpnemen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BestellingOpnemen.Location = new System.Drawing.Point(196, 37);
            this.btn_BestellingOpnemen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_BestellingOpnemen.Name = "btn_BestellingOpnemen";
            this.btn_BestellingOpnemen.Size = new System.Drawing.Size(82, 81);
            this.btn_BestellingOpnemen.TabIndex = 1;
            this.btn_BestellingOpnemen.Text = "Bestelling opnemen";
            this.btn_BestellingOpnemen.UseVisualStyleBackColor = false;
            this.btn_BestellingOpnemen.Click += new System.EventHandler(this.Btn_BestellingOpnemen_Click);
            // 
            // btn_Keuken
            // 
            this.btn_Keuken.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Keuken.FlatAppearance.BorderSize = 0;
            this.btn_Keuken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Keuken.Location = new System.Drawing.Point(76, 37);
            this.btn_Keuken.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Keuken.Name = "btn_Keuken";
            this.btn_Keuken.Size = new System.Drawing.Size(82, 81);
            this.btn_Keuken.TabIndex = 0;
            this.btn_Keuken.Text = "Keuken";
            this.btn_Keuken.UseVisualStyleBackColor = false;
            // 
            // pnl_Hub
            // 
            this.pnl_Hub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_Hub.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Hub.Controls.Add(this.btn_Keuken);
            this.pnl_Hub.Controls.Add(this.btn_BestellingOpnemen);
            this.pnl_Hub.Controls.Add(this.btn_Management);
            this.pnl_Hub.Controls.Add(this.btn_Bar);
            this.pnl_Hub.Location = new System.Drawing.Point(307, 140);
            this.pnl_Hub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_Hub.Name = "pnl_Hub";
            this.pnl_Hub.Size = new System.Drawing.Size(494, 236);
            this.pnl_Hub.TabIndex = 5;
            // 
            // lbl_WelkomstZin
            // 
            this.lbl_WelkomstZin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_WelkomstZin.AutoSize = true;
            this.lbl_WelkomstZin.Font = new System.Drawing.Font("Viner Hand ITC", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WelkomstZin.Location = new System.Drawing.Point(384, 80);
            this.lbl_WelkomstZin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_WelkomstZin.Name = "lbl_WelkomstZin";
            this.lbl_WelkomstZin.Size = new System.Drawing.Size(338, 57);
            this.lbl_WelkomstZin.TabIndex = 6;
            this.lbl_WelkomstZin.Text = "Restaurant Chapoo";
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(852, 13);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(64, 13);
            this.lbl_User.TabIndex = 7;
            this.lbl_User.Text = "< Userinfo >";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Location = new System.Drawing.Point(1035, 9);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(66, 56);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // Hub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1112, 531);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.lbl_WelkomstZin);
            this.Controls.Add(this.pnl_Hub);
            this.Controls.Add(this.lbl_Datum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Hub";
            this.Text = "Restaurant Chapoo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_Hub.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Datum;
        private System.Windows.Forms.Button btn_Bar;
        private System.Windows.Forms.Button btn_Management;
        private System.Windows.Forms.Button btn_BestellingOpnemen;
        private System.Windows.Forms.Button btn_Keuken;
        private System.Windows.Forms.Panel pnl_Hub;
        private System.Windows.Forms.Label lbl_WelkomstZin;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Button btn_Login;
    }
}

