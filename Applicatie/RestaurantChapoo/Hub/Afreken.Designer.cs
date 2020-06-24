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
            this.ColumnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnAantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_afreken = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.lbl_afrekenen = new System.Windows.Forms.Label();
            this.radioButtonPIN = new System.Windows.Forms.RadioButton();
            this.radioButtonContant = new System.Windows.Forms.RadioButton();
            this.textBoxFooi = new System.Windows.Forms.TextBox();
            this.lbl_Fooi = new System.Windows.Forms.Label();
            this.lbl_bedrag = new System.Windows.Forms.Label();
            this.lbl_Totaalbedrag = new System.Windows.Forms.Label();
            this.lbl_BTW = new System.Windows.Forms.Label();
            this.lbl_tekst = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChapooIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // ChapooIMG
            // 
            this.ChapooIMG.Image = global::Hub.Properties.Resources.Chapoo;
            this.ChapooIMG.Location = new System.Drawing.Point(20, 20);
            this.ChapooIMG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChapooIMG.Name = "ChapooIMG";
            this.ChapooIMG.Size = new System.Drawing.Size(150, 77);
            this.ChapooIMG.TabIndex = 0;
            this.ChapooIMG.TabStop = false;
            // 
            // lvBestellingen
            // 
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
            this.lvBestellingen.TabIndex = 1;
            this.lvBestellingen.UseCompatibleStateImageBehavior = false;
            this.lvBestellingen.View = System.Windows.Forms.View.Details;
            // 
            // ColumnName
            // 
            this.ColumnName.Text = "Naam";
            this.ColumnName.Width = 150;
            // 
            // ColumnAantal
            // 
            this.ColumnAantal.Text = "Aantal";
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
            // 
            // btn_Home
            // 
            this.btn_Home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Home.Location = new System.Drawing.Point(1766, 20);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(112, 37);
            this.btn_Home.TabIndex = 4;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // lbl_afrekenen
            // 
            this.lbl_afrekenen.AutoSize = true;
            this.lbl_afrekenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
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
            this.radioButtonPIN.TabIndex = 7;
            this.radioButtonPIN.TabStop = true;
            this.radioButtonPIN.Text = "PIN";
            this.radioButtonPIN.UseVisualStyleBackColor = true;
            // 
            // radioButtonContant
            // 
            this.radioButtonContant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonContant.AutoSize = true;
            this.radioButtonContant.Location = new System.Drawing.Point(18, 716);
            this.radioButtonContant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonContant.Name = "radioButtonContant";
            this.radioButtonContant.Size = new System.Drawing.Size(91, 24);
            this.radioButtonContant.TabIndex = 8;
            this.radioButtonContant.TabStop = true;
            this.radioButtonContant.Text = "Contant";
            this.radioButtonContant.UseVisualStyleBackColor = true;
            // 
            // textBoxFooi
            // 
            this.textBoxFooi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFooi.Location = new System.Drawing.Point(126, 754);
            this.textBoxFooi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFooi.Name = "textBoxFooi";
            this.textBoxFooi.Size = new System.Drawing.Size(164, 26);
            this.textBoxFooi.TabIndex = 9;
            // 
            // lbl_Fooi
            // 
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
            // Afreken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1896, 1048);
            this.Controls.Add(this.lbl_tekst);
            this.Controls.Add(this.lbl_BTW);
            this.Controls.Add(this.lbl_Totaalbedrag);
            this.Controls.Add(this.lbl_bedrag);
            this.Controls.Add(this.lbl_Fooi);
            this.Controls.Add(this.textBoxFooi);
            this.Controls.Add(this.radioButtonContant);
            this.Controls.Add(this.radioButtonPIN);
            this.Controls.Add(this.lbl_afrekenen);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.btn_afreken);
            this.Controls.Add(this.lvBestellingen);
            this.Controls.Add(this.ChapooIMG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.ColumnHeader ColumnAantal;
        private System.Windows.Forms.ColumnHeader ColumnName;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Label lbl_afrekenen;
        private System.Windows.Forms.RadioButton radioButtonPIN;
        private System.Windows.Forms.RadioButton radioButtonContant;
        private System.Windows.Forms.TextBox textBoxFooi;
        private System.Windows.Forms.Label lbl_Fooi;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.Label lbl_bedrag;
        private System.Windows.Forms.Label lbl_Totaalbedrag;
        private System.Windows.Forms.Label lbl_BTW;
        private System.Windows.Forms.Label lbl_tekst;
    }
}