namespace examensArbete
{
    partial class AddShelfVintageInventory
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
            this.btnAddShelf = new System.Windows.Forms.Button();
            this.btnAddInventory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbShelfName = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.cbShelves = new System.Windows.Forms.ComboBox();
            this.cbYears = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddVintage = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddShelf
            // 
            this.btnAddShelf.Location = new System.Drawing.Point(148, 45);
            this.btnAddShelf.Name = "btnAddShelf";
            this.btnAddShelf.Size = new System.Drawing.Size(75, 23);
            this.btnAddShelf.TabIndex = 0;
            this.btnAddShelf.Text = "Lägg till";
            this.btnAddShelf.UseVisualStyleBackColor = true;
            this.btnAddShelf.Click += new System.EventHandler(this.btnAddShelf_Click);
            // 
            // btnAddInventory
            // 
            this.btnAddInventory.Location = new System.Drawing.Point(194, 126);
            this.btnAddInventory.Name = "btnAddInventory";
            this.btnAddInventory.Size = new System.Drawing.Size(121, 23);
            this.btnAddInventory.TabIndex = 1;
            this.btnAddInventory.Text = "Lägg till och klar";
            this.btnAddInventory.UseVisualStyleBackColor = true;
            this.btnAddInventory.Click += new System.EventHandler(this.btnAddInventory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hylla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Årgång";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Antal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hylla namn";
            // 
            // tbShelfName
            // 
            this.tbShelfName.Location = new System.Drawing.Point(25, 47);
            this.tbShelfName.Name = "tbShelfName";
            this.tbShelfName.Size = new System.Drawing.Size(100, 20);
            this.tbShelfName.TabIndex = 12;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(41, 128);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(100, 20);
            this.tbAmount.TabIndex = 13;
            // 
            // cbShelves
            // 
            this.cbShelves.DisplayMember = "Name";
            this.cbShelves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShelves.FormattingEnabled = true;
            this.cbShelves.Location = new System.Drawing.Point(41, 56);
            this.cbShelves.Name = "cbShelves";
            this.cbShelves.Size = new System.Drawing.Size(121, 21);
            this.cbShelves.TabIndex = 14;
            this.cbShelves.ValueMember = "ShelfId";
            // 
            // cbYears
            // 
            this.cbYears.DisplayMember = "Year";
            this.cbYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYears.FormattingEnabled = true;
            this.cbYears.Location = new System.Drawing.Point(194, 56);
            this.cbYears.Name = "cbYears";
            this.cbYears.Size = new System.Drawing.Size(121, 21);
            this.cbYears.TabIndex = 16;
            this.cbYears.ValueMember = "VintageId";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbYears);
            this.groupBox1.Controls.Add(this.cbShelves);
            this.groupBox1.Controls.Add(this.tbAmount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddInventory);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 175);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "lägg till inventering";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbShelfName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnAddShelf);
            this.groupBox2.Location = new System.Drawing.Point(12, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 93);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lägg till hylla";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbYear);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnAddVintage);
            this.groupBox3.Location = new System.Drawing.Point(12, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 93);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lägg till årgång";
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(25, 47);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(100, 20);
            this.tbYear.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Årgång";
            // 
            // btnAddVintage
            // 
            this.btnAddVintage.Location = new System.Drawing.Point(148, 45);
            this.btnAddVintage.Name = "btnAddVintage";
            this.btnAddVintage.Size = new System.Drawing.Size(75, 23);
            this.btnAddVintage.TabIndex = 0;
            this.btnAddVintage.Text = "Lägg till";
            this.btnAddVintage.UseVisualStyleBackColor = true;
            this.btnAddVintage.Click += new System.EventHandler(this.btnAddVintage_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(252, 391);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "Klar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // AddShelfVintageInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(383, 427);
            this.ControlBox = false;
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddShelfVintageInventory";
            this.Text = "AddShelfVintageInventory";
            this.Load += new System.EventHandler(this.AddShelfVintageInventory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddShelf;
        private System.Windows.Forms.Button btnAddInventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbShelfName;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.ComboBox cbShelves;
        private System.Windows.Forms.ComboBox cbYears;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddVintage;
        private System.Windows.Forms.Button btnOk;
    }
}