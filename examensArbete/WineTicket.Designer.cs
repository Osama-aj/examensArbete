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
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblAlcohol = new System.Windows.Forms.Label();
            this.lblGrapes = new System.Windows.Forms.Label();
            this.lblWineId = new System.Windows.Forms.Label();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BottlesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picWinePic)).BeginInit();
            this.SuspendLayout();
            // 
            // picWinePic
            // 
            this.picWinePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picWinePic.ImageLocation = "";
            this.picWinePic.Location = new System.Drawing.Point(12, 25);
            this.picWinePic.Name = "picWinePic";
            this.picWinePic.Size = new System.Drawing.Size(98, 82);
            this.picWinePic.TabIndex = 0;
            this.picWinePic.TabStop = false;
            // 
            // lblWineName
            // 
            this.lblWineName.AutoEllipsis = true;
            this.lblWineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWineName.Location = new System.Drawing.Point(126, 25);
            this.lblWineName.Name = "lblWineName";
            this.lblWineName.Size = new System.Drawing.Size(480, 20);
            this.lblWineName.TabIndex = 1;
            this.lblWineName.Text = "Put here wine name";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(22, 70);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(86, 13);
            this.lblCountry.TabIndex = 2;
            this.lblCountry.Text = "Put here Country";
            // 
            // lblAlcohol
            // 
            this.lblAlcohol.AutoSize = true;
            this.lblAlcohol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlcohol.Location = new System.Drawing.Point(9, 149);
            this.lblAlcohol.Name = "lblAlcohol";
            this.lblAlcohol.Size = new System.Drawing.Size(138, 17);
            this.lblAlcohol.TabIndex = 4;
            this.lblAlcohol.Text = "Put here alcohol halt";
            // 
            // lblGrapes
            // 
            this.lblGrapes.AutoSize = true;
            this.lblGrapes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrapes.Location = new System.Drawing.Point(9, 179);
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
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrict.Location = new System.Drawing.Point(9, 116);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(107, 17);
            this.lblDistrict.TabIndex = 7;
            this.lblDistrict.Text = "Put here district";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(26, 83);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(84, 13);
            this.lblRegion.TabIndex = 8;
            this.lblRegion.Text = "Put here Region";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mina Flaskor";
            // 
            // BottlesPanel
            // 
            this.BottlesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BottlesPanel.Location = new System.Drawing.Point(172, 116);
            this.BottlesPanel.Name = "BottlesPanel";
            this.BottlesPanel.Size = new System.Drawing.Size(629, 200);
            this.BottlesPanel.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Antal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Årgång";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Hylla";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(316, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Betyg";
            // 
            // WineTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BottlesPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDistrict);
            this.Controls.Add(this.lblGrapes);
            this.Controls.Add(this.lblAlcohol);
            this.Controls.Add(this.lblWineName);
            this.Controls.Add(this.picWinePic);
            this.Controls.Add(this.lblWineId);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblRegion);
            this.Name = "WineTicket";
            this.Size = new System.Drawing.Size(799, 316);
            ((System.ComponentModel.ISupportInitialize)(this.picWinePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picWinePic;
        private System.Windows.Forms.Label lblWineName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblAlcohol;
        private System.Windows.Forms.Label lblGrapes;
        private System.Windows.Forms.Label lblWineId;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel BottlesPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
