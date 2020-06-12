namespace Hub
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
            this.btn_BestellingOpnemen = new System.Windows.Forms.Button();
            this.btn_Keuken = new System.Windows.Forms.Button();
            this.pnl_Hub = new System.Windows.Forms.Panel();
            this.lbl_WelkomstZin = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_Ingelogd = new System.Windows.Forms.Label();
            this.pnl_Hub.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Datum
            // 
            this.lbl_Datum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Datum.AutoSize = true;
            this.lbl_Datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Datum.Location = new System.Drawing.Point(1007, 2);
            this.lbl_Datum.Name = "lbl_Datum";
            this.lbl_Datum.Size = new System.Drawing.Size(90, 25);
            this.lbl_Datum.TabIndex = 4;
            this.lbl_Datum.Text = "<datum>";
            // 
            // btn_Bar
            // 
            this.btn_Bar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Bar.FlatAppearance.BorderSize = 0;
            this.btn_Bar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bar.Location = new System.Drawing.Point(429, 46);
            this.btn_Bar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Bar.Name = "btn_Bar";
            this.btn_Bar.Size = new System.Drawing.Size(109, 100);
            this.btn_Bar.TabIndex = 2;
            this.btn_Bar.Text = "Bar";
            this.btn_Bar.UseVisualStyleBackColor = false;
            this.btn_Bar.Click += new System.EventHandler(this.btn_Bar_Click);
            // 
            // btn_BestellingOpnemen
            // 
            this.btn_BestellingOpnemen.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_BestellingOpnemen.FlatAppearance.BorderSize = 0;
            this.btn_BestellingOpnemen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BestellingOpnemen.Location = new System.Drawing.Point(261, 46);
            this.btn_BestellingOpnemen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_BestellingOpnemen.Name = "btn_BestellingOpnemen";
            this.btn_BestellingOpnemen.Size = new System.Drawing.Size(109, 100);
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
            this.btn_Keuken.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Keuken.Name = "btn_Keuken";
            this.btn_Keuken.Size = new System.Drawing.Size(109, 100);
            this.btn_Keuken.TabIndex = 0;
            this.btn_Keuken.Text = "Keuken";
            this.btn_Keuken.UseVisualStyleBackColor = false;
            this.btn_Keuken.Click += new System.EventHandler(this.btn_Keuken_Click);
            // 
            // pnl_Hub
            // 
            this.pnl_Hub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_Hub.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Hub.Controls.Add(this.btn_Keuken);
            this.pnl_Hub.Controls.Add(this.btn_BestellingOpnemen);
            this.pnl_Hub.Controls.Add(this.btn_Bar);
            this.pnl_Hub.Location = new System.Drawing.Point(228, 111);
            this.pnl_Hub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Hub.Name = "pnl_Hub";
            this.pnl_Hub.Size = new System.Drawing.Size(659, 290);
            this.pnl_Hub.TabIndex = 5;
            // 
            // lbl_WelkomstZin
            // 
            this.lbl_WelkomstZin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_WelkomstZin.AutoSize = true;
            this.lbl_WelkomstZin.Font = new System.Drawing.Font("Viner Hand ITC", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WelkomstZin.Location = new System.Drawing.Point(331, 37);
            this.lbl_WelkomstZin.Name = "lbl_WelkomstZin";
            this.lbl_WelkomstZin.Size = new System.Drawing.Size(413, 69);
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
            this.btn_Login.Text = "Logout";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logout.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(956, 31);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(145, 41);
            this.btn_logout.TabIndex = 7;
            this.btn_logout.Text = "Uitloggen";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lbl_Ingelogd
            // 
            this.lbl_Ingelogd.AutoSize = true;
            this.lbl_Ingelogd.Location = new System.Drawing.Point(13, 13);
            this.lbl_Ingelogd.Name = "lbl_Ingelogd";
            this.lbl_Ingelogd.Size = new System.Drawing.Size(46, 17);
            this.lbl_Ingelogd.TabIndex = 8;
            this.lbl_Ingelogd.Text = "label1";
            // 
            // Hub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1117, 530);
            this.Controls.Add(this.lbl_Ingelogd);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lbl_WelkomstZin);
            this.Controls.Add(this.pnl_Hub);
            this.Controls.Add(this.lbl_Datum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button btn_BestellingOpnemen;
        private System.Windows.Forms.Button btn_Keuken;
        private System.Windows.Forms.Panel pnl_Hub;
        private System.Windows.Forms.Label lbl_WelkomstZin;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_Ingelogd;
    }
}

