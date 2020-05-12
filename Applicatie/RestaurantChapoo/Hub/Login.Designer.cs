namespace Hub
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt_Gebruikersnaam = new System.Windows.Forms.TextBox();
            this.txt_Wachtwoord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.pnl_Login = new System.Windows.Forms.Panel();
            this.pnl_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Gebruikersnaam
            // 
            this.txt_Gebruikersnaam.Location = new System.Drawing.Point(257, 97);
            this.txt_Gebruikersnaam.Name = "txt_Gebruikersnaam";
            this.txt_Gebruikersnaam.Size = new System.Drawing.Size(212, 22);
            this.txt_Gebruikersnaam.TabIndex = 0;
            // 
            // txt_Wachtwoord
            // 
            this.txt_Wachtwoord.Location = new System.Drawing.Point(257, 135);
            this.txt_Wachtwoord.Name = "txt_Wachtwoord";
            this.txt_Wachtwoord.Size = new System.Drawing.Size(212, 22);
            this.txt_Wachtwoord.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gebruikersnaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wachtwoord";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Location = new System.Drawing.Point(283, 178);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(164, 34);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            // 
            // btn_Home
            // 
            this.btn_Home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Home.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Location = new System.Drawing.Point(693, 12);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(97, 34);
            this.btn_Home.TabIndex = 6;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.Btn_Home_Click);
            // 
            // pnl_Login
            // 
            this.pnl_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_Login.Controls.Add(this.label1);
            this.pnl_Login.Controls.Add(this.label2);
            this.pnl_Login.Controls.Add(this.btn_Login);
            this.pnl_Login.Controls.Add(this.txt_Gebruikersnaam);
            this.pnl_Login.Controls.Add(this.txt_Wachtwoord);
            this.pnl_Login.Location = new System.Drawing.Point(78, 97);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(639, 224);
            this.pnl_Login.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(802, 473);
            this.Controls.Add(this.pnl_Login);
            this.Controls.Add(this.btn_Home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Restaurant Chapoo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_Login.ResumeLayout(false);
            this.pnl_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Gebruikersnaam;
        private System.Windows.Forms.TextBox txt_Wachtwoord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Panel pnl_Login;
    }
}