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
            this.pnl_Hub.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Datum
            // 
            this.lbl_Datum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Datum.AutoSize = true;
            this.lbl_Datum.Location = new System.Drawing.Point(894, 9);
            this.lbl_Datum.Name = "lbl_Datum";
            this.lbl_Datum.Size = new System.Drawing.Size(63, 17);
            this.lbl_Datum.TabIndex = 4;
            this.lbl_Datum.Text = "<datum>";
            // 
            // btn_Bar
            // 
            this.btn_Bar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Bar.FlatAppearance.BorderSize = 0;
            this.btn_Bar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bar.Location = new System.Drawing.Point(429, 46);
            this.btn_Bar.Name = "btn_Bar";
            this.btn_Bar.Size = new System.Drawing.Size(110, 100);
            this.btn_Bar.TabIndex = 2;
            this.btn_Bar.Text = "Bar";
            this.btn_Bar.UseVisualStyleBackColor = false;
            // 
            // btn_Management
            // 
            this.btn_Management.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Management.FlatAppearance.BorderSize = 0;
            this.btn_Management.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Management.Location = new System.Drawing.Point(262, 169);
            this.btn_Management.Name = "btn_Management";
            this.btn_Management.Size = new System.Drawing.Size(110, 100);
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
            this.btn_BestellingOpnemen.Location = new System.Drawing.Point(262, 46);
            this.btn_BestellingOpnemen.Name = "btn_BestellingOpnemen";
            this.btn_BestellingOpnemen.Size = new System.Drawing.Size(110, 100);
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
            this.btn_Keuken.Location = new System.Drawing.Point(101, 46);
            this.btn_Keuken.Name = "btn_Keuken";
            this.btn_Keuken.Size = new System.Drawing.Size(110, 100);
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
            this.pnl_Hub.Location = new System.Drawing.Point(159, 172);
            this.pnl_Hub.Name = "pnl_Hub";
            this.pnl_Hub.Size = new System.Drawing.Size(659, 290);
            this.pnl_Hub.TabIndex = 5;
            // 
            // lbl_WelkomstZin
            // 
            this.lbl_WelkomstZin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_WelkomstZin.AutoSize = true;
            this.lbl_WelkomstZin.Font = new System.Drawing.Font("Viner Hand ITC", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WelkomstZin.Location = new System.Drawing.Point(262, 98);
            this.lbl_WelkomstZin.Name = "lbl_WelkomstZin";
            this.lbl_WelkomstZin.Size = new System.Drawing.Size(426, 71);
            this.lbl_WelkomstZin.TabIndex = 6;
            this.lbl_WelkomstZin.Text = "Restaurant Chapoo";
            // 
            // Hub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.lbl_WelkomstZin);
            this.Controls.Add(this.pnl_Hub);
            this.Controls.Add(this.lbl_Datum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}

