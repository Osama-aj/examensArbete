namespace examensArbete
{
    public partial class WineTicket
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
            this.picWinePic = new System.Windows.Forms.PictureBox();
            this.lblWineName = new System.Windows.Forms.Label();
            this.lblGrapes = new System.Windows.Forms.Label();
            this.lblWineId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BottlesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddThings = new System.Windows.Forms.Button();
            this.tbAlcohol = new System.Windows.Forms.TextBox();
            this.tbProducer = new System.Windows.Forms.TextBox();
            this.btnUpdateWine = new System.Windows.Forms.Button();
            this.cbCountries = new System.Windows.Forms.ComboBox();
            this.cbRegions = new System.Windows.Forms.ComboBox();
            this.cbDistricts = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWinePic)).BeginInit();
            this.SuspendLayout();
            // 
            // picWinePic
            // 
            this.picWinePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picWinePic.ImageLocation = "";
            this.picWinePic.Location = new System.Drawing.Point(12, 3);
            this.picWinePic.Name = "picWinePic";
            this.picWinePic.Size = new System.Drawing.Size(98, 82);
            this.picWinePic.TabIndex = 0;
            this.picWinePic.TabStop = false;
            this.picWinePic.Click += new System.EventHandler(this.picWinePic_Click);
            // 
            // lblWineName
            // 
            this.lblWineName.AutoEllipsis = true;
            this.lblWineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWineName.Location = new System.Drawing.Point(126, 12);
            this.lblWineName.Name = "lblWineName";
            this.lblWineName.Size = new System.Drawing.Size(670, 30);
            this.lblWineName.TabIndex = 1;
            this.lblWineName.Text = "Put here wine name";
            // 
            // lblGrapes
            // 
            this.lblGrapes.AutoSize = true;
            this.lblGrapes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrapes.Location = new System.Drawing.Point(21, 260);
            this.lblGrapes.Name = "lblGrapes";
            this.lblGrapes.Size = new System.Drawing.Size(70, 34);
            this.lblGrapes.TabIndex = 5;
            this.lblGrapes.Text = "Put here\r\nall grapes";
            // 
            // lblWineId
            // 
            this.lblWineId.AutoSize = true;
            this.lblWineId.Location = new System.Drawing.Point(37, 42);
            this.lblWineId.Name = "lblWineId";
            this.lblWineId.Size = new System.Drawing.Size(41, 13);
            this.lblWineId.TabIndex = 6;
            this.lblWineId.Text = "WineId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mina Flaskor";
            // 
            // BottlesPanel
            // 
            this.BottlesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BottlesPanel.Location = new System.Drawing.Point(218, 115);
            this.BottlesPanel.Name = "BottlesPanel";
            this.BottlesPanel.Size = new System.Drawing.Size(584, 167);
            this.BottlesPanel.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Antal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Årgång";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(438, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Hylla";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(361, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Betyg";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Producent";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Råvaror";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Alkoholhalt";
            // 
            // btnAddThings
            // 
            this.btnAddThings.Location = new System.Drawing.Point(710, 288);
            this.btnAddThings.Name = "btnAddThings";
            this.btnAddThings.Size = new System.Drawing.Size(75, 23);
            this.btnAddThings.TabIndex = 20;
            this.btnAddThings.Text = "Lägg till";
            this.btnAddThings.UseVisualStyleBackColor = true;
            this.btnAddThings.Click += new System.EventHandler(this.btnAddThings_Click);
            // 
            // tbAlcohol
            // 
            this.tbAlcohol.Location = new System.Drawing.Point(103, 177);
            this.tbAlcohol.Name = "tbAlcohol";
            this.tbAlcohol.Size = new System.Drawing.Size(67, 20);
            this.tbAlcohol.TabIndex = 21;
            // 
            // tbProducer
            // 
            this.tbProducer.Location = new System.Drawing.Point(24, 220);
            this.tbProducer.Name = "tbProducer";
            this.tbProducer.Size = new System.Drawing.Size(146, 20);
            this.tbProducer.TabIndex = 22;
            // 
            // btnUpdateWine
            // 
            this.btnUpdateWine.Location = new System.Drawing.Point(604, 288);
            this.btnUpdateWine.Name = "btnUpdateWine";
            this.btnUpdateWine.Size = new System.Drawing.Size(88, 23);
            this.btnUpdateWine.TabIndex = 23;
            this.btnUpdateWine.Text = "Redigera vinet";
            this.btnUpdateWine.UseVisualStyleBackColor = true;
            this.btnUpdateWine.Click += new System.EventHandler(this.btnUpdateWine_Click);
            // 
            // cbCountries
            // 
            this.cbCountries.DisplayMember = "CountryName";
            this.cbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountries.FormattingEnabled = true;
            this.cbCountries.Location = new System.Drawing.Point(12, 96);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(121, 21);
            this.cbCountries.TabIndex = 24;
            this.cbCountries.ValueMember = "CountryId";
            this.cbCountries.SelectedIndexChanged += new System.EventHandler(this.cbCountries_SelectedIndexChanged);
            // 
            // cbRegions
            // 
            this.cbRegions.DisplayMember = "RegionName";
            this.cbRegions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegions.FormattingEnabled = true;
            this.cbRegions.Location = new System.Drawing.Point(12, 123);
            this.cbRegions.Name = "cbRegions";
            this.cbRegions.Size = new System.Drawing.Size(121, 21);
            this.cbRegions.TabIndex = 25;
            this.cbRegions.ValueMember = "RegionId";
            this.cbRegions.SelectedIndexChanged += new System.EventHandler(this.cbRegions_SelectedIndexChanged);
            // 
            // cbDistricts
            // 
            this.cbDistricts.DisplayMember = "DistrictName";
            this.cbDistricts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDistricts.FormattingEnabled = true;
            this.cbDistricts.Location = new System.Drawing.Point(12, 150);
            this.cbDistricts.Name = "cbDistricts";
            this.cbDistricts.Size = new System.Drawing.Size(121, 21);
            this.cbDistricts.TabIndex = 26;
            this.cbDistricts.ValueMember = "DistrictId";
            // 
            // WineTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.cbRegions);
            this.Controls.Add(this.cbDistricts);
            this.Controls.Add(this.cbCountries);
            this.Controls.Add(this.btnUpdateWine);
            this.Controls.Add(this.tbProducer);
            this.Controls.Add(this.tbAlcohol);
            this.Controls.Add(this.btnAddThings);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BottlesPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGrapes);
            this.Controls.Add(this.lblWineName);
            this.Controls.Add(this.picWinePic);
            this.Controls.Add(this.lblWineId);
            this.Name = "WineTicket";
            this.Size = new System.Drawing.Size(800, 315);
            this.Load += new System.EventHandler(this.WineTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWinePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picWinePic;
        private System.Windows.Forms.Label lblWineName;
        private System.Windows.Forms.Label lblGrapes;
        private System.Windows.Forms.Label lblWineId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel BottlesPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddThings;
        private System.Windows.Forms.TextBox tbAlcohol;
        private System.Windows.Forms.TextBox tbProducer;
        private System.Windows.Forms.Button btnUpdateWine;
        private System.Windows.Forms.ComboBox cbCountries;
        private System.Windows.Forms.ComboBox cbRegions;
        private System.Windows.Forms.ComboBox cbDistricts;
    }
}
