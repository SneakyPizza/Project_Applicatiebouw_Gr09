namespace Hub
{
    partial class KeukenBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeukenBar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_User = new System.Windows.Forms.Label();
            this.btn_Home = new System.Windows.Forms.Button();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.tlp_OrderGrid = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hub.Properties.Resources.Knipsel;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_User);
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 117);
            this.panel1.TabIndex = 1;
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.Location = new System.Drawing.Point(207, 7);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(69, 20);
            this.lbl_User.TabIndex = 2;
            this.lbl_User.Text = "< User >";
            // 
            // btn_Home
            // 
            this.btn_Home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Home.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.Location = new System.Drawing.Point(1183, 3);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(78, 29);
            this.btn_Home.TabIndex = 1;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // tlp_OrderGrid
            // 
            this.tlp_OrderGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_OrderGrid.AutoScroll = true;
            this.tlp_OrderGrid.ColumnCount = 5;
            this.tlp_OrderGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_OrderGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_OrderGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_OrderGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_OrderGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_OrderGrid.Location = new System.Drawing.Point(28, 123);
            this.tlp_OrderGrid.Margin = new System.Windows.Forms.Padding(2);
            this.tlp_OrderGrid.Name = "tlp_OrderGrid";
            this.tlp_OrderGrid.RowCount = 1;
            this.tlp_OrderGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 557F));
            this.tlp_OrderGrid.Size = new System.Drawing.Size(1202, 557);
            this.tlp_OrderGrid.TabIndex = 3;
            // 
            // KeukenBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tlp_OrderGrid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KeukenBar";
            this.Text = "Restaurant Chapoo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Home;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.TableLayoutPanel tlp_OrderGrid;
        private System.Windows.Forms.Label lbl_User;
    }
}