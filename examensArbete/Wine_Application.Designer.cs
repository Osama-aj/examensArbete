namespace examensArbete
{
    partial class Wine_Application
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.UsersWineList = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRegionWineList = new System.Windows.Forms.ComboBox();
            this.cbCountryWineList = new System.Windows.Forms.ComboBox();
            this.tbWineNameWineList = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Add = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.AddBottleTab = new System.Windows.Forms.TabPage();
            this.AddShelfTab = new System.Windows.Forms.TabPage();
            this.AddVintageTab = new System.Windows.Forms.TabPage();
            this.myPages = new System.Windows.Forms.TabPage();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.wineListResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.UsersWineList.SuspendLayout();
            this.Add.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.myPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wineListResponseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(247, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.UsersWineList);
            this.tabControl1.Controls.Add(this.Add);
            this.tabControl1.Controls.Add(this.myPages);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(842, 485);
            this.tabControl1.TabIndex = 1;
            // 
            // UsersWineList
            // 
            this.UsersWineList.Controls.Add(this.label3);
            this.UsersWineList.Controls.Add(this.cbRegionWineList);
            this.UsersWineList.Controls.Add(this.cbCountryWineList);
            this.UsersWineList.Controls.Add(this.tbWineNameWineList);
            this.UsersWineList.Controls.Add(this.label2);
            this.UsersWineList.Controls.Add(this.flowLayoutPanel1);
            this.UsersWineList.Location = new System.Drawing.Point(4, 22);
            this.UsersWineList.Name = "UsersWineList";
            this.UsersWineList.Padding = new System.Windows.Forms.Padding(3);
            this.UsersWineList.Size = new System.Drawing.Size(834, 459);
            this.UsersWineList.TabIndex = 0;
            this.UsersWineList.Text = "vin lista";
            this.UsersWineList.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "extra filter";
            // 
            // cbRegionWineList
            // 
            this.cbRegionWineList.DisplayMember = "RegionName";
            this.cbRegionWineList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegionWineList.FormattingEnabled = true;
            this.cbRegionWineList.Location = new System.Drawing.Point(450, 8);
            this.cbRegionWineList.Name = "cbRegionWineList";
            this.cbRegionWineList.Size = new System.Drawing.Size(121, 21);
            this.cbRegionWineList.TabIndex = 8;
            this.cbRegionWineList.ValueMember = "RegionId";
            this.cbRegionWineList.SelectedIndexChanged += new System.EventHandler(this.cbRegionWineList_SelectedIndexChanged);
            // 
            // cbCountryWineList
            // 
            this.cbCountryWineList.DisplayMember = "CountryName";
            this.cbCountryWineList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountryWineList.FormattingEnabled = true;
            this.cbCountryWineList.Location = new System.Drawing.Point(323, 8);
            this.cbCountryWineList.Name = "cbCountryWineList";
            this.cbCountryWineList.Size = new System.Drawing.Size(121, 21);
            this.cbCountryWineList.TabIndex = 7;
            this.cbCountryWineList.ValueMember = "CountryId";
            this.cbCountryWineList.SelectedIndexChanged += new System.EventHandler(this.cbCountryWineList_SelectedIndexChanged);
            // 
            // tbWineNameWineList
            // 
            this.tbWineNameWineList.Location = new System.Drawing.Point(82, 9);
            this.tbWineNameWineList.Name = "tbWineNameWineList";
            this.tbWineNameWineList.Size = new System.Drawing.Size(142, 20);
            this.tbWineNameWineList.TabIndex = 6;
            this.tbWineNameWineList.TextChanged += new System.EventHandler(this.tbWineNameWineList_TextUpdate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "vin namn";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(828, 421);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // Add
            // 
            this.Add.Controls.Add(this.tabControl2);
            this.Add.Location = new System.Drawing.Point(4, 22);
            this.Add.Name = "Add";
            this.Add.Padding = new System.Windows.Forms.Padding(3);
            this.Add.Size = new System.Drawing.Size(834, 459);
            this.Add.TabIndex = 1;
            this.Add.Text = "lägg till";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.AddBottleTab);
            this.tabControl2.Controls.Add(this.AddShelfTab);
            this.tabControl2.Controls.Add(this.AddVintageTab);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(828, 453);
            this.tabControl2.TabIndex = 0;
            // 
            // AddBottleTab
            // 
            this.AddBottleTab.Location = new System.Drawing.Point(4, 22);
            this.AddBottleTab.Name = "AddBottleTab";
            this.AddBottleTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddBottleTab.Size = new System.Drawing.Size(820, 427);
            this.AddBottleTab.TabIndex = 0;
            this.AddBottleTab.Text = "Flaska";
            this.AddBottleTab.UseVisualStyleBackColor = true;
            // 
            // AddShelfTab
            // 
            this.AddShelfTab.Location = new System.Drawing.Point(4, 22);
            this.AddShelfTab.Name = "AddShelfTab";
            this.AddShelfTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddShelfTab.Size = new System.Drawing.Size(820, 427);
            this.AddShelfTab.TabIndex = 1;
            this.AddShelfTab.Text = "Hylla";
            this.AddShelfTab.UseVisualStyleBackColor = true;
            // 
            // AddVintageTab
            // 
            this.AddVintageTab.Location = new System.Drawing.Point(4, 22);
            this.AddVintageTab.Name = "AddVintageTab";
            this.AddVintageTab.Size = new System.Drawing.Size(820, 427);
            this.AddVintageTab.TabIndex = 2;
            this.AddVintageTab.Text = "Årgång";
            this.AddVintageTab.UseVisualStyleBackColor = true;
            // 
            // myPages
            // 
            this.myPages.Controls.Add(this.btnLogOut);
            this.myPages.Controls.Add(this.lblUserInfo);
            this.myPages.Location = new System.Drawing.Point(4, 22);
            this.myPages.Name = "myPages";
            this.myPages.Padding = new System.Windows.Forms.Padding(3);
            this.myPages.Size = new System.Drawing.Size(834, 459);
            this.myPages.TabIndex = 2;
            this.myPages.Text = "mina sidor";
            this.myPages.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(109, 244);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(83, 38);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Logga ut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Location = new System.Drawing.Point(119, 47);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(35, 13);
            this.lblUserInfo.TabIndex = 0;
            this.lblUserInfo.Text = "label2";
            // 
            // wineListResponseBindingSource
            // 
            this.wineListResponseBindingSource.DataSource = typeof(examensArbete.Models.ResponseModel.UserSectionResponse.WineListResponse);
            // 
            // Wine_Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 485);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Wine_Application";
            this.Text = "Vinn App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Wine_Application_FormClosing);
            this.Load += new System.EventHandler(this.Wine_Application_Load);
            this.tabControl1.ResumeLayout(false);
            this.UsersWineList.ResumeLayout(false);
            this.UsersWineList.PerformLayout();
            this.Add.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.myPages.ResumeLayout(false);
            this.myPages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wineListResponseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion






























































        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Add;
        private System.Windows.Forms.BindingSource wineListResponseBindingSource;
        private System.Windows.Forms.TabPage UsersWineList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage AddBottleTab;
        private System.Windows.Forms.TabPage AddShelfTab;
        private System.Windows.Forms.TabPage AddVintageTab;
        private System.Windows.Forms.TabPage myPages;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.ComboBox cbRegionWineList;
        private System.Windows.Forms.ComboBox cbCountryWineList;
        private System.Windows.Forms.TextBox tbWineNameWineList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}