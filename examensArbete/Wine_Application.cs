using examensArbete.BusinessLogic;
using examensArbete.Models;
using examensArbete.Models.PostModels.Wines;
using examensArbete.Models.ResponseModel.GeneralSectionResponse;
using examensArbete.Models.ResponseModel.UserSectionResponse;
using Firebase.Auth;
using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Apis.Auth.OAuth2;
using Newtonsoft.Json;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examensArbete
{
    public partial class Wine_Application : Form
    {
        private MetaDataResponse Metadata;
        private long SelectedCountryId = 0;
        private long SelectedRegionId = 0;
        private string WineNameFilterWIneList = null;

        private long SelectedCountryIdAllwinelist = 0;
        private long SelectedRegionIdAllwinelist = 0;
        private string WineNameFilterWIneListAllwinelist = null;

        private List<WineGrape> AddedGrapes = new List<WineGrape>();



        public Wine_Application(MetaDataResponse _metadata)
        {
            InitializeComponent();
            Metadata = _metadata;
        }


        private void Wine_Application_Load(object sender, EventArgs e)
        {
            ShowCountriesWinelist();
            ShowCountriesAllWinelist();
            ShowUsersWinelist();
            ShowUseInfo();
        }
        private void ShowUseInfo()
        {
            var userInfo = Infrastructure.GetUserInfo();
            lblUserEmail.Text = string.IsNullOrEmpty(userInfo.Email) ? "-" : userInfo.Email;
            lblUserName.Text = string.IsNullOrEmpty(userInfo.DisplayName) ? "-" : userInfo.DisplayName;
            lblUserPhoneNumber.Text = string.IsNullOrEmpty(userInfo.PhoneNumber) ? "-" : userInfo.PhoneNumber;
        }


        private void Wine_Application_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure want to exit?",
                               "My First Application",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
                    Environment.Exit(1);
                else
                    e.Cancel = true; // to don't close form is user change his mind
            }
        }



        ///////////////////
        ///////////////////
        ///////////////////
        ///////////////////
        ///////////////////
        /// users winelist tab


        public async void ShowUsersWinelist()
        {

            var usersWinelistErrorModel = await Infrastructure.GetUsersWinelist(WineNameFilterWIneList, SelectedCountryId, SelectedRegionId);

            if (usersWinelistErrorModel.ErrorCode)
            {

                flowLayoutPanel1.Controls.Clear();
                if (((List<WineTicket>)usersWinelistErrorModel.Object).Count == 0)
                {
                    var imagePath = Path.Combine(Environment.CurrentDirectory, @"noWInes.jpg");
                    pbNoWine.Visible = true;
                    pbNoWine.Image = new Bitmap(imagePath);

                }
                else
                {


                    pbNoWine.Visible = false;


                    List<WineTicket> wineTickets = (List<WineTicket>)usersWinelistErrorModel.Object;
                    foreach (Control wineticket in wineTickets)
                    {
                        flowLayoutPanel1.Controls.Add(wineticket);
                    }
                }
            }
            else if (!string.IsNullOrEmpty(usersWinelistErrorModel.Message))
                MessageBox.Show(usersWinelistErrorModel.Message, "Fel");

        }

        private void tbWineNameWineList_TextUpdate(Object sender, EventArgs e)
        {
            WineNameFilterWIneList = tbWineNameWineList.Text;
            ShowUsersWinelist();

        }
        private void cbCountryWineList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            CountryResponse selectedCountry = (CountryResponse)cbCountryWineList.SelectedItem;
            SelectedCountryId = selectedCountry.CountryId;
            ShowRegionsWinelist();
        }
        private void cbRegionWineList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            RegionResponse selectedRegion = (RegionResponse)cbRegionWineList.SelectedItem;
            SelectedRegionId = selectedRegion.RegionId;
            ShowUsersWinelist();

        }

        private void ShowCountriesWinelist()
        {
            cbCountryWineList.Items.Clear();


            CountryResponse firstObject = new CountryResponse { CountryId = -1, CountryName = "alla länder" };
            cbCountryWineList.Items.Add(firstObject);

            cbCountryWineList.Items.AddRange(Metadata.Countries.ToArray());


            cbCountryWineList.SelectedIndex = 0;
        }
        private void ShowRegionsWinelist()
        {
            CountryResponse selectedCountry = Metadata.Countries.FirstOrDefault(r => r.CountryId == SelectedCountryId);
            cbRegionWineList.Items.Clear();

            RegionResponse firstObject = new RegionResponse { RegionId = -1, CountryId = -1, RegionName = "alla regioner" };
            cbRegionWineList.Items.Add(firstObject);
            if (selectedCountry != null)
                cbRegionWineList.Items.AddRange(selectedCountry.Regions.ToArray());
            cbRegionWineList.SelectedIndex = 0;
        }

        ///////////////////
        ///////////////////
        ///////////////////
        ///////////////////
        ///////////////////
        /// add bottle tab


        private async void ShowAllWinelist()
        {

            var allWinelistErrorModel = await Infrastructure.GetAllWinelist(WineNameFilterWIneListAllwinelist, SelectedCountryIdAllwinelist, SelectedRegionIdAllwinelist);

            if (allWinelistErrorModel.ErrorCode)
            {
                flowLayoutPanel2.Controls.Clear();
                if (((List<WineTicket>)allWinelistErrorModel.Object).Count == 0)
                {
                    var imagePath = Path.Combine(Environment.CurrentDirectory, @"noWInes.jpg");
                    pbNoWine2.Visible = true;
                    pbNoWine2.Image = new Bitmap(imagePath);
                }
                else
                {
                    pbNoWine2.Visible = false;

                    List<WineTicket> wineTickets = (List<WineTicket>)allWinelistErrorModel.Object;
                    foreach (Control wineticket in wineTickets)
                    {
                        flowLayoutPanel2.Controls.Add(wineticket);
                    }
                }

            }
            else if (!string.IsNullOrEmpty(allWinelistErrorModel.Message))
                MessageBox.Show(allWinelistErrorModel.Message, "Fel");

        }
        private void tbWineNameAllWineList_TextUpdate(Object sender, EventArgs e)
        {
            WineNameFilterWIneListAllwinelist = tbWineNameAllWineList.Text;
            ShowAllWinelist();

        }
        private void cbCountryAllWineList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            CountryResponse selectedCountry = (CountryResponse)cbCountryAllWineList.SelectedItem;
            if (selectedCountry != null)
                SelectedCountryIdAllwinelist = selectedCountry.CountryId;
            ShowRegionsAllWinelist();
        }
        private void cbRegionAllWineList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            RegionResponse selectedRegion = (RegionResponse)cbRegionAllWineList.SelectedItem;
            if (selectedRegion != null)
                SelectedRegionIdAllwinelist = selectedRegion.RegionId;
            ShowAllWinelist();

        }

        private void ShowCountriesAllWinelist()
        {
            cbCountryAllWineList.Items.Clear();


            CountryResponse firstObject = new CountryResponse { CountryId = -1, CountryName = "alla länder" };
            cbCountryAllWineList.Items.Add(firstObject);

            cbCountryAllWineList.Items.AddRange(Metadata.Countries.ToArray());


            cbCountryAllWineList.SelectedIndex = 0;
        }
        private void ShowRegionsAllWinelist()
        {
            CountryResponse selectedCountry = Metadata.Countries.FirstOrDefault(r => r.CountryId == SelectedCountryIdAllwinelist);
            cbRegionAllWineList.Items.Clear();

            RegionResponse firstObject = new RegionResponse { RegionId = -1, CountryId = -1, RegionName = "alla regioner" };
            cbRegionAllWineList.Items.Add(firstObject);
            if (selectedCountry != null)
                cbRegionAllWineList.Items.AddRange(selectedCountry.Regions.ToArray());
            cbRegionAllWineList.SelectedIndex = 0;
        }



        ///////////////////
        ///////////////////
        ///////////////////
        ///////////////////
        ///////////////////
        /// someother tab

        // int charChanged = 0;
        //int currentCharLength = 0;


        //private async void ComboBox1_TextUpdate(Object sender, EventArgs e)
        //{
        /*
        Console.WriteLine(comboBox1.Text);
        //comboBox1.AutoCompleteMode = AutoCompleteMode.None;
        //comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
        if (comboBox1.Text.Length >= 3)
        {
            var token = "";
            var allWinelistUrl = Links.baseLink + Links.allwineList;
            if (comboBox1.Text != string.Empty)
                allWinelistUrl = allWinelistUrl.Replace("startswith=", "startswith=" + comboBox1.Text);
            var responseBody = await RestVerbs.Get(allWinelistUrl, token);
            var responseBodyJson = JsonConvert.DeserializeObject<ICollection<WineListResponse>>(responseBody);
            var dt = new DataTable();


            // comboBox1.DisplayMember = "WineName";
            // comboBox1.DataSource = responseBodyJson;
            foreach (var wine in responseBodyJson)
            {
                comboBox1.Items.Add(wine.WineName);
            }

        }
        currentCharLength = comboBox1.Text.Length;
        */
        //}











        ///////////////////
        ///////////////////
        ///////////////////
        ///////////////////
        ///////////////////
        /// mypages tab

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var isSuccess = Infrastructure.Logout();

            if (!string.IsNullOrEmpty(isSuccess.Message))
                MessageBox.Show(isSuccess.Message, "fel");

            LogIn login = new LogIn();
            login.Show();
            Hide();
        }


        #region add new wine 


        private void btnGetImage_Click(object sender, EventArgs e)
        {
            var getImage = Infrastructure.GetImageFromDisk();
            if (getImage.ErrorCode)
            {
                pbWineImage.ImageLocation = (string)getImage.Object;

            }
            else if (!string.IsNullOrEmpty(getImage.Message))
                MessageBox.Show(getImage.Message, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        private async void btnAddWine_Click(object sender, EventArgs e)
        {
            var winName = tbWineName.Text;
            var producer = tbProducer.Text;
            var selectedDistrict = (DistrictResponse)cbOriginDistrict.SelectedItem;
            var alcohol = tbAlcohol.Text;
            if (string.IsNullOrEmpty(winName) || selectedDistrict == null || selectedDistrict.DistrictId <= 0)
            {
                MessageBox.Show("vinnamnet och distrikt är oligatoriska!", "Fel");
                return;
            }

            var addWineResponse = await Infrastructure.AddWine(winName, producer, selectedDistrict.DistrictId, alcohol, AddedGrapes, pbWineImage.Image);

            if (!addWineResponse.ErrorCode && !string.IsNullOrEmpty(addWineResponse.Message))
                MessageBox.Show(addWineResponse.Message, "Fel");
        }

        //add new wine tab load 



        private void btnAddGrape_Click(object sender, EventArgs e)
        {
            var selectedGrape = (GrapeResponse)cbGrapes.SelectedItem;
            var isNumber = double.TryParse(tbGrapePercent.Text, out double percent);
            if (!isNumber)
            {
                MessageBox.Show("procent måste vara en siffra!", "Fel");
                return;
            }
            if (percent < 0 || percent > 100)
            {
                MessageBox.Show("procent är inte rimligt!", "Fel");
                return;
            }
            if (AddedGrapes.Any(g => g.GrapeId == selectedGrape.GrapeId))
            {
                MessageBox.Show("Druvan finns redan!", "Fel");
                return;
            }
            AddedGrapes.Add(new WineGrape { GrapeId = selectedGrape.GrapeId, Percent = percent, Grape = new Grape { GrapeId = selectedGrape.GrapeId, GrapeName = selectedGrape.GrapeName } });
            refreshGrapesListBox();
        }
        private void refreshGrapesListBox()
        {
            lbGrapes.Items.Clear();
            if (AddedGrapes != null)
                foreach (var grape in AddedGrapes)
                {
                    lbGrapes.Items.Add(grape.Grape.GrapeName + " => " + grape.Percent.ToString() + '%');
                }
        }
        private void btnRemoveGrape_Click(object sender, EventArgs e)
        {
            string[] separator = { " => " };
            if (lbGrapes.SelectedItem != null)
            {
                var selectedItem = lbGrapes.SelectedItem.ToString();
                string selectedGrape = selectedItem.Split(separator, StringSplitOptions.None)[0];
                for (int i = 0; i < AddedGrapes.Count(); i++)
                {
                    if (!string.Equals(selectedGrape, AddedGrapes[i].Grape.GrapeName, StringComparison.OrdinalIgnoreCase)) continue;
                    AddedGrapes.RemoveAt(i);
                    break;
                }

            }
            refreshGrapesListBox();
        }




        private async void btnAddCountry_Click(object sender, EventArgs e)
        {
            var addCountryResponse = await Infrastructure.AddCountry(tbNewCountry.Text);
            if (addCountryResponse.ErrorCode)
            {
                var metadetaErrorModel = await Infrastructure.GetMetadata();
                MetaDataResponse metadata = (MetaDataResponse)metadetaErrorModel.Object;
                Metadata = metadata;

                ShowCountriesAddNewWine();
                cbOriginCountry.SelectedIndex = cbOriginCountry.FindStringExact(tbNewCountry.Text);
            }
            else if (!string.IsNullOrEmpty(addCountryResponse.Message))
                MessageBox.Show(addCountryResponse.Message, "Fel");
        }


        private async void btnAddRegion_Click(object sender, EventArgs e)
        {
            var selectedCountry = (CountryResponse)cbOriginCountry.SelectedItem;
            var addRegionResponse = await Infrastructure.AddRegion(tbNewRegion.Text, selectedCountry.CountryId);
            if (addRegionResponse.ErrorCode)
            {
                var metadetaErrorModel = await Infrastructure.GetMetadata();
                MetaDataResponse metadata = (MetaDataResponse)metadetaErrorModel.Object;
                Metadata = metadata;

                ShowCountriesAddNewWine();
                cbOriginCountry.SelectedIndex = cbOriginCountry.FindStringExact(selectedCountry.CountryName);
                cbOriginRegion.SelectedIndex = cbOriginRegion.FindStringExact(tbNewRegion.Text);
            }
            else if (!string.IsNullOrEmpty(addRegionResponse.Message))
                MessageBox.Show(addRegionResponse.Message, "Fel");
        }

        private async void btnAddDistrict_Click(object sender, EventArgs e)
        {
            var selectedCountry = (CountryResponse)cbOriginCountry.SelectedItem;

            var selectedRegion = (RegionResponse)cbOriginRegion.SelectedItem;


            var addCountryResponse = await Infrastructure.AddDistrict(tbNewDistrict.Text, selectedRegion.RegionId);
            if (addCountryResponse.ErrorCode)
            {
                var metadetaErrorModel = await Infrastructure.GetMetadata();
                MetaDataResponse metadata = (MetaDataResponse)metadetaErrorModel.Object;
                Metadata = metadata;

                ShowCountriesAddNewWine();
                cbOriginCountry.SelectedIndex = cbOriginCountry.FindStringExact(selectedCountry.CountryName);
                cbOriginRegion.SelectedIndex = cbOriginRegion.FindStringExact(selectedRegion.RegionName);
                cbOriginDistrict.SelectedIndex = cbOriginDistrict.FindStringExact(tbNewDistrict.Text);
            }
            else if (!string.IsNullOrEmpty(addCountryResponse.Message))
                MessageBox.Show(addCountryResponse.Message, "Fel");
        }








        //all drop down for origin and getting its IDs
        private void ShowCountriesAddNewWine()
        {
            cbOriginCountry.Items.Clear();
            cbOriginCountry.Items.AddRange(Metadata.Countries.ToArray());
            cbOriginCountry.SelectedIndex = 0;
        }
        private void cbOriginCountry_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            CountryResponse selectedCountry = (CountryResponse)cbOriginCountry.SelectedItem;
            ShowRegionsAddNewWine(selectedCountry.CountryId);
        }
        private void ShowRegionsAddNewWine(long selectedCountryId)
        {
            cbOriginRegion.Items.Clear();

            CountryResponse selectedCountry = Metadata.Countries.FirstOrDefault(r => r.CountryId == selectedCountryId);
            if (selectedCountry != null && selectedCountry.Regions.Count() > 0)
            {
                cbOriginRegion.Items.AddRange(selectedCountry.Regions.ToArray());
                cbOriginRegion.SelectedIndex = 0;
            }
            else
            {
                ShowDistrictAddNewWine(0, 0);
            }
        }
        private void cbOriginRegion_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            RegionResponse selectedRegion = (RegionResponse)cbOriginRegion.SelectedItem;
            ShowDistrictAddNewWine(selectedRegion.CountryId, selectedRegion.RegionId);
        }
        private void ShowDistrictAddNewWine(long selectedCountryId, long selectedRegionId)
        {
            cbOriginDistrict.Items.Clear();

            CountryResponse selectedCountry = Metadata.Countries.FirstOrDefault(r => r.CountryId == selectedCountryId);
            if (selectedCountry == null)
                return;
            RegionResponse selectedRegion = selectedCountry.Regions.First(r => r.RegionId == selectedRegionId);
            if (selectedRegion == null)
                return;

            if (selectedRegion != null && selectedRegion.Districts.Count() > 0)
            {
                cbOriginDistrict.Items.AddRange(selectedRegion.Districts.ToArray());
                cbOriginDistrict.SelectedIndex = 0;
            }
        }
        private void ShowGrapes()
        {
            cbGrapes.Items.Clear();
            cbGrapes.Items.AddRange(Metadata.Grapes.ToArray());
            cbGrapes.SelectedIndex = 0;
        }







        #endregion

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button is not functional yet!!", "Info");
        }







        //common
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                ShowUsersWinelist();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                if (tabControl2.SelectedIndex == 0)
                {
                    ShowAllWinelist();
                }
                else if (tabControl2.SelectedIndex == 1)
                {
                    ShowCountriesAddNewWine();
                    ShowGrapes();
                }
            }
        }
        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedIndex == 0)
            {
                ShowAllWinelist();
            }
            else if (tabControl2.SelectedIndex == 1)
            {
                ShowCountriesAddNewWine();
                ShowGrapes();
            }
        }


    }
}



















