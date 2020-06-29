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
            this.lbl_exBedrag = new System.Windows.Forms.Label();
            this.lbl_BTW = new System.Windows.Forms.Label();
            this.lbl_tekst = new System.Windows.Forms.Label();
            this.lbl_currentTable = new System.Windows.Forms.Label();
            this.columnBTW = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_bedragincl = new System.Windows.Forms.Label();
            this.lbl_inclBedrag = new System.Windows.Forms.Label();
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
            this.lvBestellingen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvBestellingen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnName,
            this.ColumnAantal,
            this.columnPrice,
            this.columnBTW});
            this.lvBestellingen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lvBestellingen.HideSelection = false;
            this.lvBestellingen.Location = new System.Drawing.Point(12, 98);
            this.lvBestellingen.Name = "lvBestellingen";
            this.lvBestellingen.Size = new System.Drawing.Size(739, 322);
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
            this.ColumnAantal.Width = 315;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Prijs";
            this.columnPrice.Width = 119;
            // 
            // btn_afreken
            // 
            this.btn_afreken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_afreken.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_afreken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_afreken.Location = new System.Drawing.Point(13, 560);
            this.btn_afreken.Name = "btn_afreken";
            this.btn_afreken.Size = new System.Drawing.Size(321, 53);
            this.btn_afreken.TabIndex = 2;
            this.btn_afreken.Text = "Afrekenen";
            this.btn_afreken.UseVisualStyleBackColor = false;
            this.btn_afreken.Click += new System.EventHandler(this.btn_afreken_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Home.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.Location = new System.Drawing.Point(1177, 13);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(75, 24);
            this.btn_Home.TabIndex = 4;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
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
            // radioButtonPIN
            // 
            this.radioButtonPIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonPIN.AutoSize = true;
            this.radioButtonPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtonPIN.Location = new System.Drawing.Point(13, 471);
            this.radioButtonPIN.Name = "radioButtonPIN";
            this.radioButtonPIN.Size = new System.Drawing.Size(53, 24);
            this.radioButtonPIN.TabIndex = 7;
            this.radioButtonPIN.TabStop = true;
            this.radioButtonPIN.Text = "PIN";
            this.radioButtonPIN.UseVisualStyleBackColor = true;
            // 
            // radioButtonContant
            // 
            this.radioButtonContant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonContant.AutoSize = true;
            this.radioButtonContant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtonContant.Location = new System.Drawing.Point(12, 494);
            this.radioButtonContant.Name = "radioButtonContant";
            this.radioButtonContant.Size = new System.Drawing.Size(84, 24);
            this.radioButtonContant.TabIndex = 8;
            this.radioButtonContant.TabStop = true;
            this.radioButtonContant.Text = "Contant";
            this.radioButtonContant.UseVisualStyleBackColor = true;
            // 
            // textBoxFooi
            // 
            this.textBoxFooi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFooi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFooi.Location = new System.Drawing.Point(123, 528);
            this.textBoxFooi.Name = "textBoxFooi";
            this.textBoxFooi.Size = new System.Drawing.Size(111, 26);
            this.textBoxFooi.TabIndex = 9;
            // 
            // lbl_Fooi
            // 
            this.lbl_Fooi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Fooi.AutoSize = true;
            this.lbl_Fooi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Fooi.Location = new System.Drawing.Point(12, 530);
            this.lbl_Fooi.Name = "lbl_Fooi";
            this.lbl_Fooi.Size = new System.Drawing.Size(98, 20);
            this.lbl_Fooi.TabIndex = 10;
            this.lbl_Fooi.Text = "Voer Fooi in:";
            // 
            // lbl_bedrag
            // 
            this.lbl_bedrag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_bedrag.AutoSize = true;
            this.lbl_bedrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_bedrag.Location = new System.Drawing.Point(546, 449);
            this.lbl_bedrag.Name = "lbl_bedrag";
            this.lbl_bedrag.Size = new System.Drawing.Size(124, 20);
            this.lbl_bedrag.TabIndex = 12;
            this.lbl_bedrag.Text = "Bedrag ex BTW:";
            // 
            // lbl_exBedrag
            // 
            this.lbl_exBedrag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_exBedrag.AutoSize = true;
            this.lbl_exBedrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_exBedrag.Location = new System.Drawing.Point(683, 449);
            this.lbl_exBedrag.Name = "lbl_exBedrag";
            this.lbl_exBedrag.Size = new System.Drawing.Size(0, 20);
            this.lbl_exBedrag.TabIndex = 13;
            // 
            // lbl_BTW
            // 
            this.lbl_BTW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_BTW.AutoSize = true;
            this.lbl_BTW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_BTW.Location = new System.Drawing.Point(683, 475);
            this.lbl_BTW.Name = "lbl_BTW";
            this.lbl_BTW.Size = new System.Drawing.Size(0, 20);
            this.lbl_BTW.TabIndex = 14;
            // 
            // lbl_tekst
            // 
            this.lbl_tekst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_tekst.AutoSize = true;
            this.lbl_tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_tekst.Location = new System.Drawing.Point(546, 478);
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
            this.lbl_currentTable.Location = new System.Drawing.Point(11, 436);
            this.lbl_currentTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_currentTable.Name = "lbl_currentTable";
            this.lbl_currentTable.Size = new System.Drawing.Size(113, 20);
            this.lbl_currentTable.TabIndex = 24;
            this.lbl_currentTable.Text = "<huidige tafel>";
            // 
            // columnBTW
            // 
            this.columnBTW.Text = "BTW (21% / 9%)";
            this.columnBTW.Width = 149;
            // 
            // lbl_bedragincl
            // 
            this.lbl_bedragincl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_bedragincl.AutoSize = true;
            this.lbl_bedragincl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_bedragincl.Location = new System.Drawing.Point(546, 503);
            this.lbl_bedragincl.Name = "lbl_bedragincl";
            this.lbl_bedragincl.Size = new System.Drawing.Size(131, 20);
            this.lbl_bedragincl.TabIndex = 25;
            this.lbl_bedragincl.Text = "Bedrag incl BTW:";
            // 
            // lbl_inclBedrag
            // 
            this.lbl_inclBedrag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_inclBedrag.AutoSize = true;
            this.lbl_inclBedrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_inclBedrag.Location = new System.Drawing.Point(683, 503);
            this.lbl_inclBedrag.Name = "lbl_inclBedrag";
            this.lbl_inclBedrag.Size = new System.Drawing.Size(0, 20);
            this.lbl_inclBedrag.TabIndex = 26;
            // 
            // Afreken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lbl_bedragincl);
            this.Controls.Add(this.lbl_currentTable);
            this.Controls.Add(this.lbl_tekst);
            this.Controls.Add(this.lbl_BTW);
            this.Controls.Add(this.lbl_inclBedrag);
            this.Controls.Add(this.lbl_exBedrag);
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
        private System.Windows.Forms.Label lbl_exBedrag;
        private System.Windows.Forms.Label lbl_BTW;
        private System.Windows.Forms.Label lbl_tekst;
        private System.Windows.Forms.Label lbl_currentTable;
        private System.Windows.Forms.ColumnHeader columnBTW;
        private System.Windows.Forms.Label lbl_bedragincl;
        private System.Windows.Forms.Label lbl_inclBedrag;
    }
}