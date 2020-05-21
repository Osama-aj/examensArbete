namespace examensArbete
{
    partial class InventoryTicket
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
            this.lblYear = new System.Windows.Forms.Label();
            this.lblCurrentAmount = new System.Windows.Forms.Label();
            this.lblShelf = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.AddOneBottleButton = new System.Windows.Forms.Button();
            this.RemoveOneBottleButton = new System.Windows.Forms.Button();
            this.lblinventoryId = new System.Windows.Forms.Label();
            this.tbamount = new System.Windows.Forms.TextBox();
            this.cbShelves = new System.Windows.Forms.ComboBox();
            this.cbVintages = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(16, 3);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(45, 13);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "put year";
            // 
            // lblCurrentAmount
            // 
            this.lblCurrentAmount.AutoSize = true;
            this.lblCurrentAmount.Location = new System.Drawing.Point(77, 4);
            this.lblCurrentAmount.Name = "lblCurrentAmount";
            this.lblCurrentAmount.Size = new System.Drawing.Size(60, 13);
            this.lblCurrentAmount.TabIndex = 1;
            this.lblCurrentAmount.Text = "put amount";
            // 
            // lblShelf
            // 
            this.lblShelf.AutoSize = true;
            this.lblShelf.Location = new System.Drawing.Point(222, 3);
            this.lblShelf.Name = "lblShelf";
            this.lblShelf.Size = new System.Drawing.Size(29, 13);
            this.lblShelf.TabIndex = 2;
            this.lblShelf.Text = "shelf";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(154, 3);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(52, 13);
            this.lblGrade.TabIndex = 3;
            this.lblGrade.Text = "put grade";
            this.lblGrade.Click += new System.EventHandler(this.lblGrade_Click);
            // 
            // AddOneBottleButton
            // 
            this.AddOneBottleButton.Location = new System.Drawing.Point(420, -1);
            this.AddOneBottleButton.Name = "AddOneBottleButton";
            this.AddOneBottleButton.Size = new System.Drawing.Size(56, 23);
            this.AddOneBottleButton.TabIndex = 4;
            this.AddOneBottleButton.Text = "Lägg till";
            this.AddOneBottleButton.UseVisualStyleBackColor = true;
            this.AddOneBottleButton.Click += new System.EventHandler(this.AddOneBottleButton_Click);
            // 
            // RemoveOneBottleButton
            // 
            this.RemoveOneBottleButton.Location = new System.Drawing.Point(479, -1);
            this.RemoveOneBottleButton.Name = "RemoveOneBottleButton";
            this.RemoveOneBottleButton.Size = new System.Drawing.Size(56, 23);
            this.RemoveOneBottleButton.TabIndex = 5;
            this.RemoveOneBottleButton.Text = "Ta bort";
            this.RemoveOneBottleButton.UseVisualStyleBackColor = true;
            this.RemoveOneBottleButton.Click += new System.EventHandler(this.RemoveOneBottleButton_Click);
            // 
            // lblinventoryId
            // 
            this.lblinventoryId.AutoSize = true;
            this.lblinventoryId.Location = new System.Drawing.Point(432, 4);
            this.lblinventoryId.Name = "lblinventoryId";
            this.lblinventoryId.Size = new System.Drawing.Size(30, 13);
            this.lblinventoryId.TabIndex = 6;
            this.lblinventoryId.Text = "invId";
            // 
            // tbamount
            // 
            this.tbamount.Location = new System.Drawing.Point(375, 0);
            this.tbamount.Name = "tbamount";
            this.tbamount.Size = new System.Drawing.Size(40, 20);
            this.tbamount.TabIndex = 7;
            // 
            // cbShelves
            // 
            this.cbShelves.DisplayMember = "Name";
            this.cbShelves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShelves.FormattingEnabled = true;
            this.cbShelves.Location = new System.Drawing.Point(217, 0);
            this.cbShelves.Name = "cbShelves";
            this.cbShelves.Size = new System.Drawing.Size(112, 21);
            this.cbShelves.TabIndex = 7;
            this.cbShelves.ValueMember = "ShelfId";
            this.cbShelves.SelectedIndexChanged += new System.EventHandler(this.cbShelves_SelectedIndexChanged);
            // 
            // cbVintages
            // 
            this.cbVintages.DisplayMember = "Year";
            this.cbVintages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVintages.FormattingEnabled = true;
            this.cbVintages.Location = new System.Drawing.Point(10, 0);
            this.cbVintages.Name = "cbVintages";
            this.cbVintages.Size = new System.Drawing.Size(61, 21);
            this.cbVintages.TabIndex = 8;
            this.cbVintages.ValueMember = "VintageId";
            // 
            // InventoryTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbVintages);
            this.Controls.Add(this.cbShelves);
            this.Controls.Add(this.tbamount);
            this.Controls.Add(this.RemoveOneBottleButton);
            this.Controls.Add(this.AddOneBottleButton);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblShelf);
            this.Controls.Add(this.lblCurrentAmount);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblinventoryId);
            this.Name = "InventoryTicket";
            this.Size = new System.Drawing.Size(539, 20);
            this.Load += new System.EventHandler(this.InventoryTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblCurrentAmount;
        private System.Windows.Forms.Label lblShelf;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Button AddOneBottleButton;
        private System.Windows.Forms.Button RemoveOneBottleButton;
        private System.Windows.Forms.Label lblinventoryId;
        private System.Windows.Forms.TextBox tbamount;
        private System.Windows.Forms.ComboBox cbShelves;
        private System.Windows.Forms.ComboBox cbVintages;
    }
}
