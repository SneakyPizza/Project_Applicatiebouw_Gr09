namespace Hub
{
    partial class CustomOrderControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tableNumber = new System.Windows.Forms.Label();
            this.lv_menuItems = new System.Windows.Forms.ListView();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.lbl_DinerType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tafel:";
            // 
            // lbl_tableNumber
            // 
            this.lbl_tableNumber.AutoSize = true;
            this.lbl_tableNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tableNumber.Location = new System.Drawing.Point(60, 4);
            this.lbl_tableNumber.Name = "lbl_tableNumber";
            this.lbl_tableNumber.Size = new System.Drawing.Size(69, 20);
            this.lbl_tableNumber.TabIndex = 1;
            this.lbl_tableNumber.Text = "Nummer";
            // 
            // lv_menuItems
            // 
            this.lv_menuItems.HideSelection = false;
            this.lv_menuItems.Location = new System.Drawing.Point(3, 51);
            this.lv_menuItems.Name = "lv_menuItems";
            this.lv_menuItems.Size = new System.Drawing.Size(294, 172);
            this.lv_menuItems.TabIndex = 2;
            this.lv_menuItems.UseCompatibleStateImageBehavior = false;
            this.lv_menuItems.View = System.Windows.Forms.View.Details;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(-1, 253);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(150, 33);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Annuleren ";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.Location = new System.Drawing.Point(152, 253);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(150, 33);
            this.btn_Confirm.TabIndex = 4;
            this.btn_Confirm.Text = "Gereed";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // lbl_DinerType
            // 
            this.lbl_DinerType.AutoSize = true;
            this.lbl_DinerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DinerType.Location = new System.Drawing.Point(148, 28);
            this.lbl_DinerType.Name = "lbl_DinerType";
            this.lbl_DinerType.Size = new System.Drawing.Size(51, 20);
            this.lbl_DinerType.TabIndex = 5;
            this.lbl_DinerType.Text = "label2";
            // 
            // CustomOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_DinerType);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.lv_menuItems);
            this.Controls.Add(this.lbl_tableNumber);
            this.Controls.Add(this.label1);
            this.Name = "CustomOrderControl";
            this.Size = new System.Drawing.Size(300, 285);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tableNumber;
        private System.Windows.Forms.ListView lv_menuItems;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Label lbl_DinerType;
    }
}
