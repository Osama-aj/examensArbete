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
            this.btnLogout = new System.Windows.Forms.Button();
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.UsersWineList = new System.Windows.Forms.TabPage();
            this.GetUsersWineListButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Add = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.AddBottleTab = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddShelfTab = new System.Windows.Forms.TabPage();
            this.AddVintageTab = new System.Windows.Forms.TabPage();
            this.wineListResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.UsersWineList.SuspendLayout();
            this.Add.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.AddBottleTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wineListResponseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(713, 415);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logga ut";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
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
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(842, 485);
            this.tabControl1.TabIndex = 1;
            // 
            // UsersWineList
            // 
            this.UsersWineList.Controls.Add(this.GetUsersWineListButton);
            this.UsersWineList.Controls.Add(this.flowLayoutPanel1);
            this.UsersWineList.Location = new System.Drawing.Point(4, 22);
            this.UsersWineList.Name = "UsersWineList";
            this.UsersWineList.Padding = new System.Windows.Forms.Padding(3);
            this.UsersWineList.Size = new System.Drawing.Size(834, 459);
            this.UsersWineList.TabIndex = 0;
            this.UsersWineList.Text = "vin lista";
            this.UsersWineList.UseVisualStyleBackColor = true;
            // 
            // GetUsersWineListButton
            // 
            this.GetUsersWineListButton.Location = new System.Drawing.Point(8, 0);
            this.GetUsersWineListButton.Name = "GetUsersWineListButton";
            this.GetUsersWineListButton.Size = new System.Drawing.Size(99, 28);
            this.GetUsersWineListButton.TabIndex = 1;
            this.GetUsersWineListButton.Text = "Hämta";
            this.GetUsersWineListButton.UseVisualStyleBackColor = true;
            this.GetUsersWineListButton.Click += new System.EventHandler(this.GetUsersWineListButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(828, 431);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
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
            this.AddBottleTab.Controls.Add(this.comboBox1);
            this.AddBottleTab.Controls.Add(this.label1);
            this.AddBottleTab.Location = new System.Drawing.Point(4, 22);
            this.AddBottleTab.Name = "AddBottleTab";
            this.AddBottleTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddBottleTab.Size = new System.Drawing.Size(820, 427);
            this.AddBottleTab.TabIndex = 0;
            this.AddBottleTab.Text = "Flaska";
            this.AddBottleTab.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(263, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.TextChanged += new System.EventHandler(this.ComboBox1_TextUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "wine name";
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
            // wineListResponseBindingSource
            // 
            this.wineListResponseBindingSource.DataSource = typeof(examensArbete.Models.ResponseModel.UserSectionResponse.WineListResponse);
            // 
            // Wine_Application
            // 
            this.Controls.Add(this.btnLogout);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Wine_Application_FormClosing);
            this.AcceptButton = this.GetUsersWineListButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 485);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Wine_Application";
            this.Text = "Vinn App";
            this.Load += new System.EventHandler(this.Wine_Application_Load);
            this.tabControl1.ResumeLayout(false);
            this.UsersWineList.ResumeLayout(false);
            this.Add.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.AddBottleTab.ResumeLayout(false);
            this.AddBottleTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wineListResponseBindingSource)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion































































        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Add;
        private System.Windows.Forms.BindingSource wineListResponseBindingSource;
        private System.Windows.Forms.TabPage UsersWineList;
        private System.Windows.Forms.Button GetUsersWineListButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage AddBottleTab;
        private System.Windows.Forms.TabPage AddShelfTab;
        private System.Windows.Forms.TabPage AddVintageTab;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}