using examensArbete.BusinessLogic;
using examensArbete.Models;
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


        public Wine_Application()
        {
            InitializeComponent();
        }


        private async void Wine_Application_Load(object sender, EventArgs e)
        {
            var metadetaErrorModel = await Infrastructure.GetMetadata();
            MetaDataResponse metadata = (MetaDataResponse)metadetaErrorModel.Object;
            Metadata = metadata;

            ShowCountriesWinelist();
            ShowCountriesAllWinelist();
            ShowUsersWinelist();
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


        private async void ShowUsersWinelist()
        {

            var usersWinelistErrorModel = await Infrastructure.GetUsersWinelist(WineNameFilterWIneList, SelectedCountryId, SelectedRegionId);

            if (usersWinelistErrorModel.ErrorCode)
            {
                flowLayoutPanel1.Controls.Clear();
                List<WineTicket> wineTickets = (List<WineTicket>)usersWinelistErrorModel.Object;
                foreach (Control wineticket in wineTickets)
                {
                    flowLayoutPanel1.Controls.Add(wineticket);
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
                List<WineTicket> wineTickets = (List<WineTicket>)allWinelistErrorModel.Object;
                foreach (Control wineticket in wineTickets)
                {
                    flowLayoutPanel2.Controls.Add(wineticket);
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
    }
}



















