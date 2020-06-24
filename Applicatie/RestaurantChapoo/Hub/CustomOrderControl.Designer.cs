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
            this.col_Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.lbl_OrderTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tafel:";
            // 
            // lbl_tableNumber
            // 
            this.lbl_tableNumber.AutoSize = true;
            this.lbl_tableNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tableNumber.Location = new System.Drawing.Point(164, 6);
            this.lbl_tableNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tableNumber.Name = "lbl_tableNumber";
            this.lbl_tableNumber.Size = new System.Drawing.Size(140, 29);
            this.lbl_tableNumber.TabIndex = 1;
            this.lbl_tableNumber.Text = "< Number >";
            // 
            // lv_menuItems
            // 
            this.lv_menuItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Item,
            this.col_Amount});
            this.lv_menuItems.Enabled = false;
            this.lv_menuItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_menuItems.HideSelection = false;
            this.lv_menuItems.Location = new System.Drawing.Point(4, 78);
            this.lv_menuItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lv_menuItems.MultiSelect = false;
            this.lv_menuItems.Name = "lv_menuItems";
            this.lv_menuItems.Size = new System.Drawing.Size(514, 262);
            this.lv_menuItems.TabIndex = 2;
            this.lv_menuItems.UseCompatibleStateImageBehavior = false;
            this.lv_menuItems.View = System.Windows.Forms.View.Details;
            // 
            // col_Item
            // 
            this.col_Item.Text = "Product";
            this.col_Item.Width = 280;
            // 
            // col_Amount
            // 
            this.col_Amount.Text = "Aantal";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.Location = new System.Drawing.Point(-1, 389);
            this.btn_Confirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(527, 51);
            this.btn_Confirm.TabIndex = 4;
            this.btn_Confirm.Text = "Gereed";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // lbl_OrderTime
            // 
            this.lbl_OrderTime.AutoSize = true;
            this.lbl_OrderTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderTime.Location = new System.Drawing.Point(164, 43);
            this.lbl_OrderTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OrderTime.Name = "lbl_OrderTime";
            this.lbl_OrderTime.Size = new System.Drawing.Size(109, 29);
            this.lbl_OrderTime.TabIndex = 5;
            this.lbl_OrderTime.Text = "< Time >";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Besteld om:";
            // 
            // CustomOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_OrderTime);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.lv_menuItems);
            this.Controls.Add(this.lbl_tableNumber);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomOrderControl";
            this.Size = new System.Drawing.Size(525, 438);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tableNumber;
        private System.Windows.Forms.ListView lv_menuItems;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Label lbl_OrderTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader col_Item;
        private System.Windows.Forms.ColumnHeader col_Amount;
    }
}
