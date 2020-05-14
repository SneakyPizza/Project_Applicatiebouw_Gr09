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
            this.btn_Uitloggen = new System.Windows.Forms.Button();
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
            this.lbl_BestellingPlaatsen = new System.Windows.Forms.Label();
            this.listViewWinkelwagen = new System.Windows.Forms.ListView();
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Uitloggen
            // 
            this.btn_Uitloggen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Uitloggen.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Uitloggen.FlatAppearance.BorderSize = 0;
            this.btn_Uitloggen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Uitloggen.Location = new System.Drawing.Point(1373, 12);
            this.btn_Uitloggen.Name = "btn_Uitloggen";
            this.btn_Uitloggen.Size = new System.Drawing.Size(97, 34);
            this.btn_Uitloggen.TabIndex = 7;
            this.btn_Uitloggen.Text = "Uitloggen";
            this.btn_Uitloggen.UseVisualStyleBackColor = false;
            // 
            // btn_BestellingPlaatsen
            // 
            this.btn_BestellingPlaatsen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_BestellingPlaatsen.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_BestellingPlaatsen.FlatAppearance.BorderSize = 0;
            this.btn_BestellingPlaatsen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BestellingPlaatsen.Location = new System.Drawing.Point(1128, 559);
            this.btn_BestellingPlaatsen.Name = "btn_BestellingPlaatsen";
            this.btn_BestellingPlaatsen.Size = new System.Drawing.Size(342, 52);
            this.btn_BestellingPlaatsen.TabIndex = 8;
            this.btn_BestellingPlaatsen.Text = "Bestelling plaatsen";
            this.btn_BestellingPlaatsen.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btn_DrankenAlcoholisch);
            this.panel1.Controls.Add(this.btn_Diner);
            this.panel1.Controls.Add(this.btn_Lunch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Dranken);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 559);
            this.panel1.TabIndex = 9;
            // 
            // btn_DrankenAlcoholisch
            // 
            this.btn_DrankenAlcoholisch.BackColor = System.Drawing.Color.LightBlue;
            this.btn_DrankenAlcoholisch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_DrankenAlcoholisch.FlatAppearance.BorderSize = 0;
            this.btn_DrankenAlcoholisch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DrankenAlcoholisch.Location = new System.Drawing.Point(29, 177);
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
            this.btn_Diner.Location = new System.Drawing.Point(29, 405);
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
            this.btn_Lunch.Location = new System.Drawing.Point(29, 289);
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
            this.listViewMenuItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewMenuItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewMenuItems.HideSelection = false;
            this.listViewMenuItems.Location = new System.Drawing.Point(168, 52);
            this.listViewMenuItems.Name = "listViewMenuItems";
            this.listViewMenuItems.Size = new System.Drawing.Size(954, 559);
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
            // lbl_BestellingPlaatsen
            // 
            this.lbl_BestellingPlaatsen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_BestellingPlaatsen.AutoSize = true;
            this.lbl_BestellingPlaatsen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BestellingPlaatsen.Location = new System.Drawing.Point(12, 17);
            this.lbl_BestellingPlaatsen.Name = "lbl_BestellingPlaatsen";
            this.lbl_BestellingPlaatsen.Size = new System.Drawing.Size(228, 29);
            this.lbl_BestellingPlaatsen.TabIndex = 11;
            this.lbl_BestellingPlaatsen.Text = "Bestelling opnemen";
            // 
            // listViewWinkelwagen
            // 
            this.listViewWinkelwagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewWinkelwagen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Product,
            this.Aantal});
            this.listViewWinkelwagen.HideSelection = false;
            this.listViewWinkelwagen.Location = new System.Drawing.Point(1128, 52);
            this.listViewWinkelwagen.Name = "listViewWinkelwagen";
            this.listViewWinkelwagen.Size = new System.Drawing.Size(342, 501);
            this.listViewWinkelwagen.TabIndex = 14;
            this.listViewWinkelwagen.UseCompatibleStateImageBehavior = false;
            this.listViewWinkelwagen.View = System.Windows.Forms.View.Details;
            // 
            // Product
            // 
            this.Product.Text = "Product nr";
            this.Product.Width = 201;
            // 
            // Aantal
            // 
            this.Aantal.Text = "Aantal";
            // 
            // BestellingOpnemen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1482, 653);
            this.Controls.Add(this.listViewWinkelwagen);
            this.Controls.Add(this.lbl_BestellingPlaatsen);
            this.Controls.Add(this.listViewMenuItems);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_BestellingPlaatsen);
            this.Controls.Add(this.btn_Uitloggen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BestellingOpnemen";
            this.Text = "Restaurant Chapoo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Uitloggen;
        private System.Windows.Forms.Button btn_BestellingPlaatsen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_DrankenAlcoholisch;
        private System.Windows.Forms.Button btn_Diner;
        private System.Windows.Forms.Button btn_Lunch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Dranken;
        private System.Windows.Forms.ListView listViewMenuItems;
        private System.Windows.Forms.Label lbl_BestellingPlaatsen;
        private System.Windows.Forms.ListView listViewWinkelwagen;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Aantal;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}