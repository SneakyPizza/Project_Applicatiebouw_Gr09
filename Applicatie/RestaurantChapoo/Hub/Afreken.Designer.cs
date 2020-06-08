namespace Hub
{
    partial class Afreken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Afreken));
            this.ChapooIMG = new System.Windows.Forms.PictureBox();
            this.lvBestellingen = new System.Windows.Forms.ListView();
            this.btn_afreken = new System.Windows.Forms.Button();
            this.ColumnNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnAantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Home = new System.Windows.Forms.Button();
            this.lbl_afrekenen = new System.Windows.Forms.Label();
            this.lvTafels = new System.Windows.Forms.ListView();
            this.ColumnTafelnummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBedrag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAchternaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.ChapooIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // ChapooIMG
            // 
            this.ChapooIMG.Image = global::Hub.Properties.Resources.Chapoo;
            this.ChapooIMG.Location = new System.Drawing.Point(13, 13);
            this.ChapooIMG.Name = "ChapooIMG";
            this.ChapooIMG.Size = new System.Drawing.Size(100, 50);
            this.ChapooIMG.TabIndex = 0;
            this.ChapooIMG.TabStop = false;
            // 
            // lvBestellingen
            // 
            this.lvBestellingen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnNaam,
            this.ColumnAantal});
            this.lvBestellingen.HideSelection = false;
            this.lvBestellingen.Location = new System.Drawing.Point(728, 82);
            this.lvBestellingen.Name = "lvBestellingen";
            this.lvBestellingen.Size = new System.Drawing.Size(282, 382);
            this.lvBestellingen.TabIndex = 1;
            this.lvBestellingen.UseCompatibleStateImageBehavior = false;
            this.lvBestellingen.View = System.Windows.Forms.View.Details;
            // 
            // btn_afreken
            // 
            this.btn_afreken.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_afreken.Location = new System.Drawing.Point(728, 470);
            this.btn_afreken.Name = "btn_afreken";
            this.btn_afreken.Size = new System.Drawing.Size(282, 53);
            this.btn_afreken.TabIndex = 2;
            this.btn_afreken.Text = "Afrekenen";
            this.btn_afreken.UseVisualStyleBackColor = false;
            // 
            // ColumnNaam
            // 
            this.ColumnNaam.Text = "Naam";
            this.ColumnNaam.Width = 219;
            // 
            // ColumnAantal
            // 
            this.ColumnAantal.Text = "Aantal";
            // 
            // btn_Home
            // 
            this.btn_Home.Location = new System.Drawing.Point(935, 12);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(75, 24);
            this.btn_Home.TabIndex = 4;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            // 
            // lbl_afrekenen
            // 
            this.lbl_afrekenen.AutoSize = true;
            this.lbl_afrekenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lbl_afrekenen.Location = new System.Drawing.Point(119, 39);
            this.lbl_afrekenen.Name = "lbl_afrekenen";
            this.lbl_afrekenen.Size = new System.Drawing.Size(97, 24);
            this.lbl_afrekenen.TabIndex = 5;
            this.lbl_afrekenen.Text = "Afrekenen";
            // 
            // lvTafels
            // 
            this.lvTafels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnTafelnummer,
            this.columnAchternaam,
            this.columnBedrag});
            this.lvTafels.HideSelection = false;
            this.lvTafels.Location = new System.Drawing.Point(13, 82);
            this.lvTafels.Name = "lvTafels";
            this.lvTafels.Size = new System.Drawing.Size(709, 441);
            this.lvTafels.TabIndex = 6;
            this.lvTafels.UseCompatibleStateImageBehavior = false;
            this.lvTafels.View = System.Windows.Forms.View.Details;
            // 
            // ColumnTafelnummer
            // 
            this.ColumnTafelnummer.Text = "Tafelnummer";
            this.ColumnTafelnummer.Width = 110;
            // 
            // columnBedrag
            // 
            this.columnBedrag.Text = "Te betalen bedrag:";
            this.columnBedrag.Width = 108;
            // 
            // columnAchternaam
            // 
            this.columnAchternaam.Text = "Achternaam";
            this.columnAchternaam.Width = 108;
            // 
            // Afreken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1022, 535);
            this.Controls.Add(this.lvTafels);
            this.Controls.Add(this.lbl_afrekenen);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.btn_afreken);
            this.Controls.Add(this.lvBestellingen);
            this.Controls.Add(this.ChapooIMG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Afreken";
            this.Text = "Restaurant Chapoo";
            ((System.ComponentModel.ISupportInitialize)(this.ChapooIMG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ChapooIMG;
        private System.Windows.Forms.ListView lvBestellingen;
        private System.Windows.Forms.Button btn_afreken;
        private System.Windows.Forms.ColumnHeader ColumnNaam;
        private System.Windows.Forms.ColumnHeader ColumnAantal;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Label lbl_afrekenen;
        private System.Windows.Forms.ListView lvTafels;
        private System.Windows.Forms.ColumnHeader ColumnTafelnummer;
        private System.Windows.Forms.ColumnHeader columnBedrag;
        private System.Windows.Forms.ColumnHeader columnAchternaam;
    }
}