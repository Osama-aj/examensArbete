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
            this.pbNoWine = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRegionWineList = new System.Windows.Forms.ComboBox();
            this.cbCountryWineList = new System.Windows.Forms.ComboBox();
            this.tbWineNameWineList = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Add = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.AddExistWine = new System.Windows.Forms.TabPage();
            this.pbNoWine2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRegionAllWineList = new System.Windows.Forms.ComboBox();
            this.cbCountryAllWineList = new System.Windows.Forms.ComboBox();
            this.tbWineNameAllWineList = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddNewWine = new System.Windows.Forms.TabPage();
            this.btnRemoveGrape = new System.Windows.Forms.Button();
            this.btnAddGrape = new System.Windows.Forms.Button();
            this.tbGrapePercent = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAddWine = new System.Windows.Forms.Button();
            this.lbGrapes = new System.Windows.Forms.ListBox();
            this.cbGrapes = new System.Windows.Forms.ComboBox();
            this.pbWineImage = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbAlcohol = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAddCountry = new System.Windows.Forms.Button();
            this.btnAddRegion = new System.Windows.Forms.Button();
            this.btnAddDistrict = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbNewDistrict = new System.Windows.Forms.TextBox();
            this.tbNewRegion = new System.Windows.Forms.TextBox();
            this.tbNewCountry = new System.Windows.Forms.TextBox();
            this.cbOriginDistrict = new System.Windows.Forms.ComboBox();
            this.cbOriginRegion = new System.Windows.Forms.ComboBox();
            this.tbProducer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbWineName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbOriginCountry = new System.Windows.Forms.ComboBox();
            this.btnGetImage = new System.Windows.Forms.Button();
            this.myPages = new System.Windows.Forms.TabPage();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.lblUserPhoneNumber = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.wineListResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.UsersWineList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNoWine)).BeginInit();
            this.Add.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.AddExistWine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNoWine2)).BeginInit();
            this.AddNewWine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWineImage)).BeginInit();
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
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // UsersWineList
            // 
            this.UsersWineList.Controls.Add(this.pbNoWine);
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
            // pbNoWine
            // 
            this.pbNoWine.Location = new System.Drawing.Point(82, 91);
            this.pbNoWine.Name = "pbNoWine";
            this.pbNoWine.Size = new System.Drawing.Size(648, 279);
            this.pbNoWine.TabIndex = 11;
            this.pbNoWine.TabStop = false;
            this.pbNoWine.Visible = false;
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
            this.Add.Text = "lägg till vin";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.AddExistWine);
            this.tabControl2.Controls.Add(this.AddNewWine);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(828, 453);
            this.tabControl2.TabIndex = 0;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // AddExistWine
            // 
            this.AddExistWine.Controls.Add(this.pbNoWine2);
            this.AddExistWine.Controls.Add(this.label1);
            this.AddExistWine.Controls.Add(this.cbRegionAllWineList);
            this.AddExistWine.Controls.Add(this.cbCountryAllWineList);
            this.AddExistWine.Controls.Add(this.tbWineNameAllWineList);
            this.AddExistWine.Controls.Add(this.label4);
            this.AddExistWine.Controls.Add(this.flowLayoutPanel2);
            this.AddExistWine.Location = new System.Drawing.Point(4, 22);
            this.AddExistWine.Name = "AddExistWine";
            this.AddExistWine.Padding = new System.Windows.Forms.Padding(3);
            this.AddExistWine.Size = new System.Drawing.Size(820, 427);
            this.AddExistWine.TabIndex = 0;
            this.AddExistWine.Text = "Befintligt";
            this.AddExistWine.UseVisualStyleBackColor = true;
            // 
            // pbNoWine2
            // 
            this.pbNoWine2.Location = new System.Drawing.Point(86, 74);
            this.pbNoWine2.Name = "pbNoWine2";
            this.pbNoWine2.Size = new System.Drawing.Size(648, 279);
            this.pbNoWine2.TabIndex = 17;
            this.pbNoWine2.TabStop = false;
            this.pbNoWine2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "extra filter";
            // 
            // cbRegionAllWineList
            // 
            this.cbRegionAllWineList.DisplayMember = "RegionName";
            this.cbRegionAllWineList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegionAllWineList.FormattingEnabled = true;
            this.cbRegionAllWineList.Location = new System.Drawing.Point(450, 8);
            this.cbRegionAllWineList.Name = "cbRegionAllWineList";
            this.cbRegionAllWineList.Size = new System.Drawing.Size(121, 21);
            this.cbRegionAllWineList.TabIndex = 15;
            this.cbRegionAllWineList.ValueMember = "RegionId";
            this.cbRegionAllWineList.SelectedIndexChanged += new System.EventHandler(this.cbRegionAllWineList_SelectedIndexChanged);
            // 
            // cbCountryAllWineList
            // 
            this.cbCountryAllWineList.DisplayMember = "CountryName";
            this.cbCountryAllWineList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountryAllWineList.FormattingEnabled = true;
            this.cbCountryAllWineList.Location = new System.Drawing.Point(323, 8);
            this.cbCountryAllWineList.Name = "cbCountryAllWineList";
            this.cbCountryAllWineList.Size = new System.Drawing.Size(121, 21);
            this.cbCountryAllWineList.TabIndex = 14;
            this.cbCountryAllWineList.ValueMember = "CountryId";
            this.cbCountryAllWineList.SelectedIndexChanged += new System.EventHandler(this.cbCountryAllWineList_SelectedIndexChanged);
            // 
            // tbWineNameAllWineList
            // 
            this.tbWineNameAllWineList.Location = new System.Drawing.Point(82, 9);
            this.tbWineNameAllWineList.Name = "tbWineNameAllWineList";
            this.tbWineNameAllWineList.Size = new System.Drawing.Size(142, 20);
            this.tbWineNameAllWineList.TabIndex = 13;
            this.tbWineNameAllWineList.TextChanged += new System.EventHandler(this.tbWineNameAllWineList_TextUpdate);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "vin namn";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 35);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(814, 389);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // AddNewWine
            // 
            this.AddNewWine.Controls.Add(this.btnRemoveGrape);
            this.AddNewWine.Controls.Add(this.btnAddGrape);
            this.AddNewWine.Controls.Add(this.tbGrapePercent);
            this.AddNewWine.Controls.Add(this.label14);
            this.AddNewWine.Controls.Add(this.btnAddWine);
            this.AddNewWine.Controls.Add(this.lbGrapes);
            this.AddNewWine.Controls.Add(this.cbGrapes);
            this.AddNewWine.Controls.Add(this.pbWineImage);
            this.AddNewWine.Controls.Add(this.label13);
            this.AddNewWine.Controls.Add(this.tbAlcohol);
            this.AddNewWine.Controls.Add(this.label12);
            this.AddNewWine.Controls.Add(this.btnAddCountry);
            this.AddNewWine.Controls.Add(this.btnAddRegion);
            this.AddNewWine.Controls.Add(this.btnAddDistrict);
            this.AddNewWine.Controls.Add(this.label11);
            this.AddNewWine.Controls.Add(this.tbNewDistrict);
            this.AddNewWine.Controls.Add(this.tbNewRegion);
            this.AddNewWine.Controls.Add(this.tbNewCountry);
            this.AddNewWine.Controls.Add(this.cbOriginDistrict);
            this.AddNewWine.Controls.Add(this.cbOriginRegion);
            this.AddNewWine.Controls.Add(this.tbProducer);
            this.AddNewWine.Controls.Add(this.label10);
            this.AddNewWine.Controls.Add(this.tbWineName);
            this.AddNewWine.Controls.Add(this.label9);
            this.AddNewWine.Controls.Add(this.label8);
            this.AddNewWine.Controls.Add(this.label7);
            this.AddNewWine.Controls.Add(this.label6);
            this.AddNewWine.Controls.Add(this.label5);
            this.AddNewWine.Controls.Add(this.cbOriginCountry);
            this.AddNewWine.Controls.Add(this.btnGetImage);
            this.AddNewWine.Location = new System.Drawing.Point(4, 22);
            this.AddNewWine.Name = "AddNewWine";
            this.AddNewWine.Padding = new System.Windows.Forms.Padding(3);
            this.AddNewWine.Size = new System.Drawing.Size(820, 427);
            this.AddNewWine.TabIndex = 1;
            this.AddNewWine.Text = "Nytt vin";
            this.AddNewWine.UseVisualStyleBackColor = true;
            // 
            // btnRemoveGrape
            // 
            this.btnRemoveGrape.Location = new System.Drawing.Point(482, 291);
            this.btnRemoveGrape.Name = "btnRemoveGrape";
            this.btnRemoveGrape.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveGrape.TabIndex = 30;
            this.btnRemoveGrape.Text = "ta bort";
            this.btnRemoveGrape.UseVisualStyleBackColor = true;
            this.btnRemoveGrape.Click += new System.EventHandler(this.btnRemoveGrape_Click);
            // 
            // btnAddGrape
            // 
            this.btnAddGrape.Location = new System.Drawing.Point(482, 257);
            this.btnAddGrape.Name = "btnAddGrape";
            this.btnAddGrape.Size = new System.Drawing.Size(75, 23);
            this.btnAddGrape.TabIndex = 29;
            this.btnAddGrape.Text = "lägg till";
            this.btnAddGrape.UseVisualStyleBackColor = true;
            this.btnAddGrape.Click += new System.EventHandler(this.btnAddGrape_Click);
            // 
            // tbGrapePercent
            // 
            this.tbGrapePercent.Location = new System.Drawing.Point(376, 259);
            this.tbGrapePercent.Name = "tbGrapePercent";
            this.tbGrapePercent.Size = new System.Drawing.Size(100, 20);
            this.tbGrapePercent.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(314, 262);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "procent";
            // 
            // btnAddWine
            // 
            this.btnAddWine.Location = new System.Drawing.Point(712, 389);
            this.btnAddWine.Name = "btnAddWine";
            this.btnAddWine.Size = new System.Drawing.Size(75, 23);
            this.btnAddWine.TabIndex = 26;
            this.btnAddWine.Text = "lägg till vin";
            this.btnAddWine.UseVisualStyleBackColor = true;
            this.btnAddWine.Click += new System.EventHandler(this.btnAddWine_Click);
            // 
            // lbGrapes
            // 
            this.lbGrapes.FormattingEnabled = true;
            this.lbGrapes.Location = new System.Drawing.Point(125, 291);
            this.lbGrapes.Name = "lbGrapes";
            this.lbGrapes.Size = new System.Drawing.Size(351, 121);
            this.lbGrapes.TabIndex = 25;
            // 
            // cbGrapes
            // 
            this.cbGrapes.DisplayMember = "GrapeName";
            this.cbGrapes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrapes.FormattingEnabled = true;
            this.cbGrapes.Location = new System.Drawing.Point(127, 264);
            this.cbGrapes.Name = "cbGrapes";
            this.cbGrapes.Size = new System.Drawing.Size(121, 21);
            this.cbGrapes.TabIndex = 24;
            this.cbGrapes.ValueMember = "GrapeId";
            // 
            // pbWineImage
            // 
            this.pbWineImage.Location = new System.Drawing.Point(614, 22);
            this.pbWineImage.Name = "pbWineImage";
            this.pbWineImage.Size = new System.Drawing.Size(200, 181);
            this.pbWineImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWineImage.TabIndex = 23;
            this.pbWineImage.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(45, 267);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Druvor";
            // 
            // tbAlcohol
            // 
            this.tbAlcohol.Location = new System.Drawing.Point(127, 226);
            this.tbAlcohol.Name = "tbAlcohol";
            this.tbAlcohol.Size = new System.Drawing.Size(100, 20);
            this.tbAlcohol.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "alkoholhallt";
            // 
            // btnAddCountry
            // 
            this.btnAddCountry.Location = new System.Drawing.Point(469, 130);
            this.btnAddCountry.Name = "btnAddCountry";
            this.btnAddCountry.Size = new System.Drawing.Size(88, 23);
            this.btnAddCountry.TabIndex = 18;
            this.btnAddCountry.Text = "lägg till land";
            this.btnAddCountry.UseVisualStyleBackColor = true;
            this.btnAddCountry.Click += new System.EventHandler(this.btnAddCountry_Click);
            // 
            // btnAddRegion
            // 
            this.btnAddRegion.Location = new System.Drawing.Point(469, 157);
            this.btnAddRegion.Name = "btnAddRegion";
            this.btnAddRegion.Size = new System.Drawing.Size(88, 23);
            this.btnAddRegion.TabIndex = 17;
            this.btnAddRegion.Text = "lägg till region";
            this.btnAddRegion.UseVisualStyleBackColor = true;
            this.btnAddRegion.Click += new System.EventHandler(this.btnAddRegion_Click);
            // 
            // btnAddDistrict
            // 
            this.btnAddDistrict.Location = new System.Drawing.Point(469, 184);
            this.btnAddDistrict.Name = "btnAddDistrict";
            this.btnAddDistrict.Size = new System.Drawing.Size(88, 23);
            this.btnAddDistrict.TabIndex = 16;
            this.btnAddDistrict.Text = "lägg till distrikt";
            this.btnAddDistrict.UseVisualStyleBackColor = true;
            this.btnAddDistrict.Click += new System.EventHandler(this.btnAddDistrict_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(287, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "nytt distrikt";
            // 
            // tbNewDistrict
            // 
            this.tbNewDistrict.Location = new System.Drawing.Point(351, 187);
            this.tbNewDistrict.Name = "tbNewDistrict";
            this.tbNewDistrict.Size = new System.Drawing.Size(100, 20);
            this.tbNewDistrict.TabIndex = 14;
            // 
            // tbNewRegion
            // 
            this.tbNewRegion.Location = new System.Drawing.Point(351, 159);
            this.tbNewRegion.Name = "tbNewRegion";
            this.tbNewRegion.Size = new System.Drawing.Size(100, 20);
            this.tbNewRegion.TabIndex = 13;
            // 
            // tbNewCountry
            // 
            this.tbNewCountry.Location = new System.Drawing.Point(351, 133);
            this.tbNewCountry.Name = "tbNewCountry";
            this.tbNewCountry.Size = new System.Drawing.Size(100, 20);
            this.tbNewCountry.TabIndex = 12;
            // 
            // cbOriginDistrict
            // 
            this.cbOriginDistrict.DisplayMember = "DistrictName";
            this.cbOriginDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOriginDistrict.FormattingEnabled = true;
            this.cbOriginDistrict.Location = new System.Drawing.Point(125, 186);
            this.cbOriginDistrict.Name = "cbOriginDistrict";
            this.cbOriginDistrict.Size = new System.Drawing.Size(121, 21);
            this.cbOriginDistrict.TabIndex = 11;
            this.cbOriginDistrict.ValueMember = "DistrictId";
            // 
            // cbOriginRegion
            // 
            this.cbOriginRegion.DisplayMember = "RegionName";
            this.cbOriginRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOriginRegion.FormattingEnabled = true;
            this.cbOriginRegion.Location = new System.Drawing.Point(125, 159);
            this.cbOriginRegion.Name = "cbOriginRegion";
            this.cbOriginRegion.Size = new System.Drawing.Size(121, 21);
            this.cbOriginRegion.TabIndex = 10;
            this.cbOriginRegion.ValueMember = "RegionId";
            this.cbOriginRegion.SelectedIndexChanged += new System.EventHandler(this.cbOriginRegion_SelectedIndexChanged);
            // 
            // tbProducer
            // 
            this.tbProducer.Location = new System.Drawing.Point(125, 96);
            this.tbProducer.Name = "tbProducer";
            this.tbProducer.Size = new System.Drawing.Size(100, 20);
            this.tbProducer.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(287, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "nytt land";
            // 
            // tbWineName
            // 
            this.tbWineName.Location = new System.Drawing.Point(125, 33);
            this.tbWineName.Name = "tbWineName";
            this.tbWineName.Size = new System.Drawing.Size(213, 20);
            this.tbWineName.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "producent";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "vin ursprung";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "ny region";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "vin bild";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "vin namnet";
            // 
            // cbOriginCountry
            // 
            this.cbOriginCountry.DisplayMember = "CountryName";
            this.cbOriginCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOriginCountry.FormattingEnabled = true;
            this.cbOriginCountry.Location = new System.Drawing.Point(125, 132);
            this.cbOriginCountry.Name = "cbOriginCountry";
            this.cbOriginCountry.Size = new System.Drawing.Size(121, 21);
            this.cbOriginCountry.TabIndex = 1;
            this.cbOriginCountry.ValueMember = "CountryId";
            this.cbOriginCountry.SelectedIndexChanged += new System.EventHandler(this.cbOriginCountry_SelectedIndexChanged);
            // 
            // btnGetImage
            // 
            this.btnGetImage.Location = new System.Drawing.Point(125, 61);
            this.btnGetImage.Name = "btnGetImage";
            this.btnGetImage.Size = new System.Drawing.Size(75, 23);
            this.btnGetImage.TabIndex = 0;
            this.btnGetImage.Text = "Hämta";
            this.btnGetImage.UseVisualStyleBackColor = true;
            this.btnGetImage.Click += new System.EventHandler(this.btnGetImage_Click);
            // 
            // myPages
            // 
            this.myPages.Controls.Add(this.btnChangePassword);
            this.myPages.Controls.Add(this.label17);
            this.myPages.Controls.Add(this.label16);
            this.myPages.Controls.Add(this.label15);
            this.myPages.Controls.Add(this.lblUserEmail);
            this.myPages.Controls.Add(this.lblUserPhoneNumber);
            this.myPages.Controls.Add(this.btnLogOut);
            this.myPages.Controls.Add(this.lblUserName);
            this.myPages.Location = new System.Drawing.Point(4, 22);
            this.myPages.Name = "myPages";
            this.myPages.Padding = new System.Windows.Forms.Padding(3);
            this.myPages.Size = new System.Drawing.Size(834, 459);
            this.myPages.TabIndex = 2;
            this.myPages.Text = "mina sidor";
            this.myPages.UseVisualStyleBackColor = true;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(50, 177);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(140, 23);
            this.btnChangePassword.TabIndex = 7;
            this.btnChangePassword.Text = "byta lösenordet";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(47, 126);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Mobil nummer";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(47, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "E-postadress";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(47, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Namn";
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Location = new System.Drawing.Point(155, 86);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(68, 13);
            this.lblUserEmail.TabIndex = 3;
            this.lblUserEmail.Text = "E-postadress";
            // 
            // lblUserPhoneNumber
            // 
            this.lblUserPhoneNumber.AutoSize = true;
            this.lblUserPhoneNumber.Location = new System.Drawing.Point(155, 126);
            this.lblUserPhoneNumber.Name = "lblUserPhoneNumber";
            this.lblUserPhoneNumber.Size = new System.Drawing.Size(72, 13);
            this.lblUserPhoneNumber.TabIndex = 2;
            this.lblUserPhoneNumber.Text = "Mobil nummer";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(50, 305);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(83, 38);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Logga ut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(155, 48);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(35, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Namn";
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
            ((System.ComponentModel.ISupportInitialize)(this.pbNoWine)).EndInit();
            this.Add.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.AddExistWine.ResumeLayout(false);
            this.AddExistWine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNoWine2)).EndInit();
            this.AddNewWine.ResumeLayout(false);
            this.AddNewWine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWineImage)).EndInit();
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
        private System.Windows.Forms.TabPage AddExistWine;
        private System.Windows.Forms.TabPage AddNewWine;
        private System.Windows.Forms.TabPage myPages;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ComboBox cbRegionWineList;
        private System.Windows.Forms.ComboBox cbCountryWineList;
        private System.Windows.Forms.TextBox tbWineNameWineList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRegionAllWineList;
        private System.Windows.Forms.ComboBox cbCountryAllWineList;
        private System.Windows.Forms.TextBox tbWineNameAllWineList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pbNoWine;
        private System.Windows.Forms.PictureBox pbNoWine2;
        private System.Windows.Forms.TextBox tbNewDistrict;
        private System.Windows.Forms.TextBox tbNewRegion;
        private System.Windows.Forms.TextBox tbNewCountry;
        private System.Windows.Forms.ComboBox cbOriginDistrict;
        private System.Windows.Forms.ComboBox cbOriginRegion;
        private System.Windows.Forms.TextBox tbProducer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbWineName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbOriginCountry;
        private System.Windows.Forms.Button btnGetImage;
        private System.Windows.Forms.PictureBox pbWineImage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbAlcohol;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAddCountry;
        private System.Windows.Forms.Button btnAddRegion;
        private System.Windows.Forms.Button btnAddDistrict;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbGrapes;
        private System.Windows.Forms.ListBox lbGrapes;
        private System.Windows.Forms.Button btnAddWine;
        private System.Windows.Forms.TextBox tbGrapePercent;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnRemoveGrape;
        private System.Windows.Forms.Button btnAddGrape;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Label lblUserPhoneNumber;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnChangePassword;
    }
}