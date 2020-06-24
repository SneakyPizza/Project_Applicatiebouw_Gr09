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
<<<<<<< HEAD
            this.ColumnNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnAantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_afreken = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.lbl_afrekenen = new System.Windows.Forms.Label();
            this.lvTafels = new System.Windows.Forms.ListView();
            this.ColumnTafelnummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAchternaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBedrag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
=======
            this.ColumnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnAantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_afreken = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.lbl_afrekenen = new System.Windows.Forms.Label();
>>>>>>> Lars-v2
            this.radioButtonPIN = new System.Windows.Forms.RadioButton();
            this.radioButtonContant = new System.Windows.Forms.RadioButton();
            this.textBoxFooi = new System.Windows.Forms.TextBox();
            this.lbl_Fooi = new System.Windows.Forms.Label();
<<<<<<< HEAD
=======
            this.lbl_bedrag = new System.Windows.Forms.Label();
            this.lbl_Totaalbedrag = new System.Windows.Forms.Label();
            this.lbl_BTW = new System.Windows.Forms.Label();
            this.lbl_tekst = new System.Windows.Forms.Label();
            this.lbl_currentTable = new System.Windows.Forms.Label();
>>>>>>> Lars-v2
            ((System.ComponentModel.ISupportInitialize)(this.ChapooIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // ChapooIMG
            // 
            this.ChapooIMG.Image = global::Hub.Properties.Resources.Chapoo;
<<<<<<< HEAD
            this.ChapooIMG.Location = new System.Drawing.Point(13, 13);
            this.ChapooIMG.Name = "ChapooIMG";
            this.ChapooIMG.Size = new System.Drawing.Size(100, 50);
=======
            this.ChapooIMG.Location = new System.Drawing.Point(20, 20);
            this.ChapooIMG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChapooIMG.Name = "ChapooIMG";
            this.ChapooIMG.Size = new System.Drawing.Size(150, 77);
>>>>>>> Lars-v2
            this.ChapooIMG.TabIndex = 0;
            this.ChapooIMG.TabStop = false;
            // 
            // lvBestellingen
            // 
<<<<<<< HEAD
            this.lvBestellingen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvBestellingen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnNaam,
            this.ColumnAantal});
            this.lvBestellingen.HideSelection = false;
            this.lvBestellingen.Location = new System.Drawing.Point(931, 120);
            this.lvBestellingen.Name = "lvBestellingen";
            this.lvBestellingen.Size = new System.Drawing.Size(321, 282);
=======
            this.lvBestellingen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvBestellingen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnName,
            this.ColumnAantal,
            this.columnPrice});
            this.lvBestellingen.HideSelection = false;
            this.lvBestellingen.Location = new System.Drawing.Point(18, 151);
            this.lvBestellingen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvBestellingen.Name = "lvBestellingen";
            this.lvBestellingen.Size = new System.Drawing.Size(1046, 432);
>>>>>>> Lars-v2
            this.lvBestellingen.TabIndex = 1;
            this.lvBestellingen.UseCompatibleStateImageBehavior = false;
            this.lvBestellingen.View = System.Windows.Forms.View.Details;
            // 
<<<<<<< HEAD
            // ColumnNaam
            // 
            this.ColumnNaam.Text = "Naam";
            this.ColumnNaam.Width = 219;
=======
            // ColumnName
            // 
            this.ColumnName.Text = "Naam";
            this.ColumnName.Width = 150;
>>>>>>> Lars-v2
            // 
            // ColumnAantal
            // 
            this.ColumnAantal.Text = "Aantal";
<<<<<<< HEAD
            this.ColumnAantal.Width = 98;
            // 
            // btn_afreken
            // 
            this.btn_afreken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_afreken.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_afreken.Location = new System.Drawing.Point(931, 508);
            this.btn_afreken.Name = "btn_afreken";
            this.btn_afreken.Size = new System.Drawing.Size(321, 53);
            this.btn_afreken.TabIndex = 2;
            this.btn_afreken.Text = "Afrekenen";
            this.btn_afreken.UseVisualStyleBackColor = false;
=======
            this.ColumnAantal.Width = 377;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Prijs";
            this.columnPrice.Width = 168;
            // 
            // btn_afreken
            // 
            this.btn_afreken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_afreken.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_afreken.Location = new System.Drawing.Point(20, 805);
            this.btn_afreken.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_afreken.Name = "btn_afreken";
            this.btn_afreken.Size = new System.Drawing.Size(482, 82);
            this.btn_afreken.TabIndex = 2;
            this.btn_afreken.Text = "Afrekenen";
            this.btn_afreken.UseVisualStyleBackColor = false;
            this.btn_afreken.Click += new System.EventHandler(this.btn_afreken_Click);
>>>>>>> Lars-v2
            // 
            // btn_Home
            // 
            this.btn_Home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
            this.btn_Home.Location = new System.Drawing.Point(1177, 13);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(75, 24);
            this.btn_Home.TabIndex = 4;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = true;
=======
            this.btn_Home.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.Location = new System.Drawing.Point(1766, 20);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(112, 37);
            this.btn_Home.TabIndex = 4;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = false;
>>>>>>> Lars-v2
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // lbl_afrekenen
            // 
            this.lbl_afrekenen.AutoSize = true;
            this.lbl_afrekenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
<<<<<<< HEAD
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
            this.lvTafels.Location = new System.Drawing.Point(12, 120);
            this.lvTafels.Name = "lvTafels";
            this.lvTafels.Size = new System.Drawing.Size(876, 441);
            this.lvTafels.TabIndex = 6;
            this.lvTafels.UseCompatibleStateImageBehavior = false;
            this.lvTafels.View = System.Windows.Forms.View.Details;
            // 
            // ColumnTafelnummer
            // 
            this.ColumnTafelnummer.Text = "Tafelnummer";
            this.ColumnTafelnummer.Width = 110;
            // 
            // columnAchternaam
            // 
            this.columnAchternaam.Text = "Achternaam";
            this.columnAchternaam.Width = 148;
            // 
            // columnBedrag
            // 
            this.columnBedrag.Text = "Te betalen bedrag:";
            this.columnBedrag.Width = 120;
            // 
            // radioButtonPIN
            // 
            this.radioButtonPIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonPIN.AutoSize = true;
            this.radioButtonPIN.Location = new System.Drawing.Point(931, 417);
            this.radioButtonPIN.Name = "radioButtonPIN";
            this.radioButtonPIN.Size = new System.Drawing.Size(43, 17);
=======
            this.lbl_afrekenen.Location = new System.Drawing.Point(178, 60);
            this.lbl_afrekenen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_afrekenen.Name = "lbl_afrekenen";
            this.lbl_afrekenen.Size = new System.Drawing.Size(145, 32);
            this.lbl_afrekenen.TabIndex = 5;
            this.lbl_afrekenen.Text = "Afrekenen";
            // 
            // radioButtonPIN
            // 
            this.radioButtonPIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonPIN.AutoSize = true;
            this.radioButtonPIN.Location = new System.Drawing.Point(20, 680);
            this.radioButtonPIN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonPIN.Name = "radioButtonPIN";
            this.radioButtonPIN.Size = new System.Drawing.Size(60, 24);
>>>>>>> Lars-v2
            this.radioButtonPIN.TabIndex = 7;
            this.radioButtonPIN.TabStop = true;
            this.radioButtonPIN.Text = "PIN";
            this.radioButtonPIN.UseVisualStyleBackColor = true;
            // 
            // radioButtonContant
            // 
<<<<<<< HEAD
            this.radioButtonContant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonContant.AutoSize = true;
            this.radioButtonContant.Location = new System.Drawing.Point(931, 440);
            this.radioButtonContant.Name = "radioButtonContant";
            this.radioButtonContant.Size = new System.Drawing.Size(62, 17);
=======
            this.radioButtonContant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonContant.AutoSize = true;
            this.radioButtonContant.Location = new System.Drawing.Point(18, 716);
            this.radioButtonContant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonContant.Name = "radioButtonContant";
            this.radioButtonContant.Size = new System.Drawing.Size(91, 24);
>>>>>>> Lars-v2
            this.radioButtonContant.TabIndex = 8;
            this.radioButtonContant.TabStop = true;
            this.radioButtonContant.Text = "Contant";
            this.radioButtonContant.UseVisualStyleBackColor = true;
            // 
            // textBoxFooi
            // 
<<<<<<< HEAD
            this.textBoxFooi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFooi.Location = new System.Drawing.Point(1001, 482);
            this.textBoxFooi.Name = "textBoxFooi";
            this.textBoxFooi.Size = new System.Drawing.Size(111, 20);
=======
            this.textBoxFooi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFooi.Location = new System.Drawing.Point(126, 754);
            this.textBoxFooi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFooi.Name = "textBoxFooi";
            this.textBoxFooi.Size = new System.Drawing.Size(164, 26);
>>>>>>> Lars-v2
            this.textBoxFooi.TabIndex = 9;
            // 
            // lbl_Fooi
            // 
<<<<<<< HEAD
            this.lbl_Fooi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Fooi.AutoSize = true;
            this.lbl_Fooi.Location = new System.Drawing.Point(928, 485);
            this.lbl_Fooi.Name = "lbl_Fooi";
            this.lbl_Fooi.Size = new System.Drawing.Size(66, 13);
            this.lbl_Fooi.TabIndex = 10;
            this.lbl_Fooi.Text = "Voer Fooi in:";
            // 
            // Afreken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1264, 681);
=======
            this.lbl_Fooi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Fooi.AutoSize = true;
            this.lbl_Fooi.Location = new System.Drawing.Point(18, 758);
            this.lbl_Fooi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Fooi.Name = "lbl_Fooi";
            this.lbl_Fooi.Size = new System.Drawing.Size(98, 20);
            this.lbl_Fooi.TabIndex = 10;
            this.lbl_Fooi.Text = "Voer Fooi in:";
            // 
            // lbl_bedrag
            // 
            this.lbl_bedrag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_bedrag.AutoSize = true;
            this.lbl_bedrag.Location = new System.Drawing.Point(819, 634);
            this.lbl_bedrag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bedrag.Name = "lbl_bedrag";
            this.lbl_bedrag.Size = new System.Drawing.Size(107, 20);
            this.lbl_bedrag.TabIndex = 12;
            this.lbl_bedrag.Text = "Totaalbedrag:";
            // 
            // lbl_Totaalbedrag
            // 
            this.lbl_Totaalbedrag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Totaalbedrag.AutoSize = true;
            this.lbl_Totaalbedrag.Location = new System.Drawing.Point(952, 634);
            this.lbl_Totaalbedrag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Totaalbedrag.Name = "lbl_Totaalbedrag";
            this.lbl_Totaalbedrag.Size = new System.Drawing.Size(0, 20);
            this.lbl_Totaalbedrag.TabIndex = 13;
            // 
            // lbl_BTW
            // 
            this.lbl_BTW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_BTW.AutoSize = true;
            this.lbl_BTW.Location = new System.Drawing.Point(952, 685);
            this.lbl_BTW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BTW.Name = "lbl_BTW";
            this.lbl_BTW.Size = new System.Drawing.Size(0, 20);
            this.lbl_BTW.TabIndex = 14;
            // 
            // lbl_tekst
            // 
            this.lbl_tekst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_tekst.AutoSize = true;
            this.lbl_tekst.Location = new System.Drawing.Point(819, 678);
            this.lbl_tekst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tekst.Name = "lbl_tekst";
            this.lbl_tekst.Size = new System.Drawing.Size(52, 20);
            this.lbl_tekst.TabIndex = 15;
            this.lbl_tekst.Text = "BTW: ";
            // 
            // lbl_currentTable
            // 
            this.lbl_currentTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_currentTable.AutoSize = true;
            this.lbl_currentTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentTable.Location = new System.Drawing.Point(17, 614);
            this.lbl_currentTable.Name = "lbl_currentTable";
            this.lbl_currentTable.Size = new System.Drawing.Size(172, 29);
            this.lbl_currentTable.TabIndex = 24;
            this.lbl_currentTable.Text = "<huidige tafel>";
            // 
            // Afreken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1896, 1048);
            this.Controls.Add(this.lbl_currentTable);
            this.Controls.Add(this.lbl_tekst);
            this.Controls.Add(this.lbl_BTW);
            this.Controls.Add(this.lbl_Totaalbedrag);
            this.Controls.Add(this.lbl_bedrag);
>>>>>>> Lars-v2
            this.Controls.Add(this.lbl_Fooi);
            this.Controls.Add(this.textBoxFooi);
            this.Controls.Add(this.radioButtonContant);
            this.Controls.Add(this.radioButtonPIN);
<<<<<<< HEAD
            this.Controls.Add(this.lvTafels);
=======
>>>>>>> Lars-v2
            this.Controls.Add(this.lbl_afrekenen);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.btn_afreken);
            this.Controls.Add(this.lvBestellingen);
            this.Controls.Add(this.ChapooIMG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
<<<<<<< HEAD
=======
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
>>>>>>> Lars-v2
            this.Name = "Afreken";
            this.Text = "Restaurant Chapoo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ChapooIMG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ChapooIMG;
        private System.Windows.Forms.ListView lvBestellingen;
        private System.Windows.Forms.Button btn_afreken;
<<<<<<< HEAD
        private System.Windows.Forms.ColumnHeader ColumnNaam;
        private System.Windows.Forms.ColumnHeader ColumnAantal;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Label lbl_afrekenen;
        private System.Windows.Forms.ListView lvTafels;
        private System.Windows.Forms.ColumnHeader ColumnTafelnummer;
        private System.Windows.Forms.ColumnHeader columnBedrag;
        private System.Windows.Forms.ColumnHeader columnAchternaam;
=======
        private System.Windows.Forms.ColumnHeader ColumnAantal;
        private System.Windows.Forms.ColumnHeader ColumnName;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Label lbl_afrekenen;
>>>>>>> Lars-v2
        private System.Windows.Forms.RadioButton radioButtonPIN;
        private System.Windows.Forms.RadioButton radioButtonContant;
        private System.Windows.Forms.TextBox textBoxFooi;
        private System.Windows.Forms.Label lbl_Fooi;
<<<<<<< HEAD
=======
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.Label lbl_bedrag;
        private System.Windows.Forms.Label lbl_Totaalbedrag;
        private System.Windows.Forms.Label lbl_BTW;
        private System.Windows.Forms.Label lbl_tekst;
        private System.Windows.Forms.Label lbl_currentTable;
>>>>>>> Lars-v2
    }
}