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
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblShelf = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.AddOneBottleButton = new System.Windows.Forms.Button();
            this.RemoveOneBottleButton = new System.Windows.Forms.Button();
            this.lblinventoryId = new System.Windows.Forms.Label();
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
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(77, 4);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(60, 13);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "put amount";
            // 
            // lblShelf
            // 
            this.lblShelf.AutoSize = true;
            this.lblShelf.Location = new System.Drawing.Point(222, 3);
            this.lblShelf.Name = "lblShelf";
            this.lblShelf.Size = new System.Drawing.Size(47, 13);
            this.lblShelf.TabIndex = 2;
            this.lblShelf.Text = "put shelf";
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
            this.AddOneBottleButton.Location = new System.Drawing.Point(331, -1);
            this.AddOneBottleButton.Name = "AddOneBottleButton";
            this.AddOneBottleButton.Size = new System.Drawing.Size(62, 23);
            this.AddOneBottleButton.TabIndex = 4;
            this.AddOneBottleButton.Text = "Lägg till";
            this.AddOneBottleButton.UseVisualStyleBackColor = true;
            this.AddOneBottleButton.Click += new System.EventHandler(this.AddOneBottleButton_Click);
            // 
            // RemoveOneBottleButton
            // 
            this.RemoveOneBottleButton.Location = new System.Drawing.Point(397, -1);
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
            this.lblinventoryId.Location = new System.Drawing.Point(297, 4);
            this.lblinventoryId.Name = "lblinventoryId";
            this.lblinventoryId.Size = new System.Drawing.Size(30, 13);
            this.lblinventoryId.TabIndex = 6;
            this.lblinventoryId.Text = "invId";
            // 
            // InventoryTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoveOneBottleButton);
            this.Controls.Add(this.AddOneBottleButton);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblShelf);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblinventoryId);
            this.Name = "InventoryTicket";
            this.Size = new System.Drawing.Size(457, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblShelf;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Button AddOneBottleButton;
        private System.Windows.Forms.Button RemoveOneBottleButton;
        private System.Windows.Forms.Label lblinventoryId;
    }
}
