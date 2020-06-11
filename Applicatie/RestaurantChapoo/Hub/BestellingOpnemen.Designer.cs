namespace Hub
{
    partial class BestellingOpnemen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestellingOpnemen));
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_BestellingPlaatsen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_DrankenAlcoholisch = new System.Windows.Forms.Button();
            this.btn_Diner = new System.Windows.Forms.Button();
            this.btn_Lunch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Dranken = new System.Windows.Forms.Button();
            this.listViewMenuItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewWinkelwagen = new System.Windows.Forms.ListView();
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Plus = new System.Windows.Forms.Button();
            this.btn_Min = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Tafelnr = new System.Windows.Forms.ComboBox();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Datum = new System.Windows.Forms.Label();
            this.lbl_CurrentEmployee = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Home
            // 
            this.btn_Home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Home.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Location = new System.Drawing.Point(1155, 7);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(97, 34);
            this.btn_Home.TabIndex = 7;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // btn_BestellingPlaatsen
            // 
            this.btn_BestellingPlaatsen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BestellingPlaatsen.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_BestellingPlaatsen.FlatAppearance.BorderSize = 0;
            this.btn_BestellingPlaatsen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BestellingPlaatsen.Location = new System.Drawing.Point(1032, 619);
            this.btn_BestellingPlaatsen.Name = "btn_BestellingPlaatsen";
            this.btn_BestellingPlaatsen.Size = new System.Drawing.Size(230, 42);
            this.btn_BestellingPlaatsen.TabIndex = 8;
            this.btn_BestellingPlaatsen.Text = "Bestelling plaatsen";
            this.btn_BestellingPlaatsen.UseVisualStyleBackColor = false;
            this.btn_BestellingPlaatsen.Click += new System.EventHandler(this.Btn_BestellingPlaatsen_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btn_DrankenAlcoholisch);
            this.panel1.Controls.Add(this.btn_Diner);
            this.panel1.Controls.Add(this.btn_Lunch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Dranken);
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 620);
            this.panel1.TabIndex = 9;
            // 
            // btn_DrankenAlcoholisch
            // 
            this.btn_DrankenAlcoholisch.BackColor = System.Drawing.Color.LightBlue;
            this.btn_DrankenAlcoholisch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_DrankenAlcoholisch.FlatAppearance.BorderSize = 0;
            this.btn_DrankenAlcoholisch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DrankenAlcoholisch.Location = new System.Drawing.Point(29, 195);
            this.btn_DrankenAlcoholisch.Name = "btn_DrankenAlcoholisch";
            this.btn_DrankenAlcoholisch.Size = new System.Drawing.Size(100, 50);
            this.btn_DrankenAlcoholisch.TabIndex = 4;
            this.btn_DrankenAlcoholisch.Text = "Alcoholische dranken";
            this.btn_DrankenAlcoholisch.UseVisualStyleBackColor = false;
            this.btn_DrankenAlcoholisch.Click += new System.EventHandler(this.Btn_DrankenAlcoholisch_Click);
            // 
            // btn_Diner
            // 
            this.btn_Diner.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Diner.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Diner.FlatAppearance.BorderSize = 0;
            this.btn_Diner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Diner.Location = new System.Drawing.Point(29, 467);
            this.btn_Diner.Name = "btn_Diner";
            this.btn_Diner.Size = new System.Drawing.Size(100, 50);
            this.btn_Diner.TabIndex = 3;
            this.btn_Diner.Text = "Diner";
            this.btn_Diner.UseVisualStyleBackColor = false;
            this.btn_Diner.Click += new System.EventHandler(this.Btn_Diner_Click);
            // 
            // btn_Lunch
            // 
            this.btn_Lunch.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Lunch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Lunch.FlatAppearance.BorderSize = 0;
            this.btn_Lunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Lunch.Location = new System.Drawing.Point(29, 331);
            this.btn_Lunch.Name = "btn_Lunch";
            this.btn_Lunch.Size = new System.Drawing.Size(100, 50);
            this.btn_Lunch.TabIndex = 2;
            this.btn_Lunch.Text = "Lunch";
            this.btn_Lunch.UseVisualStyleBackColor = false;
            this.btn_Lunch.Click += new System.EventHandler(this.Btn_Lunch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // btn_Dranken
            // 
            this.btn_Dranken.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Dranken.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Dranken.FlatAppearance.BorderSize = 0;
            this.btn_Dranken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dranken.Location = new System.Drawing.Point(29, 69);
            this.btn_Dranken.Name = "btn_Dranken";
            this.btn_Dranken.Size = new System.Drawing.Size(100, 50);
            this.btn_Dranken.TabIndex = 0;
            this.btn_Dranken.Text = "Dranken";
            this.btn_Dranken.UseVisualStyleBackColor = false;
            this.btn_Dranken.Click += new System.EventHandler(this.Btn_Dranken_Click);
            // 
            // listViewMenuItems
            // 
            this.listViewMenuItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewMenuItems.BackColor = System.Drawing.Color.Beige;
            this.listViewMenuItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewMenuItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewMenuItems.HideSelection = false;
            this.listViewMenuItems.Location = new System.Drawing.Point(154, 68);
            this.listViewMenuItems.Name = "listViewMenuItems";
            this.listViewMenuItems.Size = new System.Drawing.Size(704, 545);
            this.listViewMenuItems.TabIndex = 10;
            this.listViewMenuItems.UseCompatibleStateImageBehavior = false;
            this.listViewMenuItems.View = System.Windows.Forms.View.Tile;
            this.listViewMenuItems.Click += new System.EventHandler(this.listViewMenuItems_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            // 
            // listViewWinkelwagen
            // 
            this.listViewWinkelwagen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewWinkelwagen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewWinkelwagen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Product,
            this.Aantal});
            this.listViewWinkelwagen.HideSelection = false;
            this.listViewWinkelwagen.Location = new System.Drawing.Point(766, 58);
            this.listViewWinkelwagen.Name = "listViewWinkelwagen";
            this.listViewWinkelwagen.Size = new System.Drawing.Size(496, 555);
            this.listViewWinkelwagen.TabIndex = 14;
            this.listViewWinkelwagen.UseCompatibleStateImageBehavior = false;
            this.listViewWinkelwagen.View = System.Windows.Forms.View.Details;
            // 
            // Product
            // 
            this.Product.Text = "Naam";
            this.Product.Width = 310;
            // 
            // Aantal
            // 
            this.Aantal.Text = "Aantal";
            // 
            // btn_Plus
            // 
            this.btn_Plus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Plus.FlatAppearance.BorderSize = 0;
            this.btn_Plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Plus.Location = new System.Drawing.Point(977, 619);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(49, 42);
            this.btn_Plus.TabIndex = 15;
            this.btn_Plus.Text = "+";
            this.btn_Plus.UseVisualStyleBackColor = false;
            this.btn_Plus.Click += new System.EventHandler(this.Btn_Plus_Click);
            // 
            // btn_Min
            // 
            this.btn_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Min.FlatAppearance.BorderSize = 0;
            this.btn_Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Min.Location = new System.Drawing.Point(922, 619);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(49, 42);
            this.btn_Min.TabIndex = 16;
            this.btn_Min.Text = "-";
            this.btn_Min.UseVisualStyleBackColor = false;
            this.btn_Min.Click += new System.EventHandler(this.Btn_Min_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(744, 644);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tafelnr:";
            // 
            // cmb_Tafelnr
            // 
            this.cmb_Tafelnr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Tafelnr.FormattingEnabled = true;
            this.cmb_Tafelnr.Location = new System.Drawing.Point(807, 635);
            this.cmb_Tafelnr.Name = "cmb_Tafelnr";
            this.cmb_Tafelnr.Size = new System.Drawing.Size(53, 24);
            this.cmb_Tafelnr.TabIndex = 19;
            // 
            // pic_Logo
            // 
            this.pic_Logo.Image = global::Hub.Properties.Resources.Knipsel;
            this.pic_Logo.Location = new System.Drawing.Point(0, 0);
            this.pic_Logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(146, 51);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Logo.TabIndex = 20;
            this.pic_Logo.TabStop = false;
            // 
            // pnl_Header
            // 
            this.pnl_Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Header.BackColor = System.Drawing.Color.White;
            this.pnl_Header.Controls.Add(this.lbl_CurrentEmployee);
            this.pnl_Header.Controls.Add(this.lbl_Datum);
            this.pnl_Header.Controls.Add(this.pic_Logo);
            this.pnl_Header.Controls.Add(this.btn_Home);
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1262, 62);
            this.pnl_Header.TabIndex = 21;
            // 
            // lbl_Datum
            // 
            this.lbl_Datum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Datum.AutoSize = true;
            this.lbl_Datum.Location = new System.Drawing.Point(1055, 7);
            this.lbl_Datum.Name = "lbl_Datum";
            this.lbl_Datum.Size = new System.Drawing.Size(63, 17);
            this.lbl_Datum.TabIndex = 21;
            this.lbl_Datum.Text = "<datum>";
            // 
            // lbl_CurrentEmployee
            // 
            this.lbl_CurrentEmployee.AutoSize = true;
            this.lbl_CurrentEmployee.Location = new System.Drawing.Point(154, 33);
            this.lbl_CurrentEmployee.Name = "lbl_CurrentEmployee";
            this.lbl_CurrentEmployee.Size = new System.Drawing.Size(52, 17);
            this.lbl_CurrentEmployee.TabIndex = 22;
            this.lbl_CurrentEmployee.Text = "<user>";
            // 
            // BestellingOpnemen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.listViewWinkelwagen);
            this.Controls.Add(this.cmb_Tafelnr);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Min);
            this.Controls.Add(this.btn_Plus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_BestellingPlaatsen);
            this.Controls.Add(this.listViewMenuItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BestellingOpnemen";
            this.Text = "Restaurant Chapoo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_BestellingPlaatsen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_DrankenAlcoholisch;
        private System.Windows.Forms.Button btn_Diner;
        private System.Windows.Forms.Button btn_Lunch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Dranken;
        private System.Windows.Forms.ListView listViewMenuItems;
        private System.Windows.Forms.ListView listViewWinkelwagen;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Aantal;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btn_Plus;
        private System.Windows.Forms.Button btn_Min;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Tafelnr;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Datum;
        private System.Windows.Forms.Label lbl_CurrentEmployee;
    }
}