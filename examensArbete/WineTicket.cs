using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using examensArbete.BusinessLogic;
using examensArbete.Models.ResponseModel.GeneralSectionResponse;

namespace examensArbete
{
    public partial class WineTicket : UserControl
    {
        public WineTicket()
        {
            InitializeComponent();
        }
        private async void WineTicket_Load(object sender, EventArgs e)
        {
            var metadetaErrorModel = await Infrastructure.GetMetadata();
            MetaDataResponse metadata = (MetaDataResponse)metadetaErrorModel.Object;
            Metadata = metadata;

            ShowAndSelectOrigin();

        }
        #region variabels
        private MetaDataResponse Metadata;

        private long _wineId;
        private string _wineName;
        private string _country;
        private string _region;
        private string _district;
        private string _producer;
        private string _grapes;
        private string _alcohol;
        private List<InventoryTicket> _bottlePanel;

        [Category("Custom Props")]
        public string WinePic
        {

            set
            {
                picWinePic.ImageLocation = value;
                picWinePic.SizeMode = PictureBoxSizeMode.CenterImage;
                picWinePic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }




        [Category("Custom Props")]
        public List<InventoryTicket> Bottles
        {
            get { return _bottlePanel; }
            set { _bottlePanel = value; BottlesPanel.Controls.AddRange(value.ToArray()); }
        }


        [Category("Custom Props")]
        public long WineId
        {
            get { return _wineId; }
            set { _wineId = value; lblWineId.Text = value.ToString(); }
        }

        [Category("Custom Props")]
        public string WineName
        {
            get { return _wineName; }
            set { _wineName = value; lblWineName.Text = value; }
        }

        [Category("Custom Props")]
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        [Category("Custom Props")]
        public string Region
        {
            get { return _region; }
            set { _region = value; }
        }
        [Category("Custom Props")]
        public string District
        {
            get { return _district; }
            set { _district = value; }
        }




        [Category("Custom Props")]
        public string Producer
        {
            get { return _producer; }
            set { _producer = value; tbProducer.Text = value; }
        }


        [Category("Custom Props")]
        public string Grapes
        {
            get { return _grapes; }
            set { _grapes = value; lblGrapes.Text = value; }
        }



        [Category("Custom Props")]
        public string Alcohol
        {
            get { return _alcohol; }
            set { _alcohol = value; tbAlcohol.Text = value; }
        }

        #endregion

        private async void btnAddThings_Click(object sender, EventArgs e)
        {
            AddShelfVintageInventory addDialog = new AddShelfVintageInventory(this.WineId);
            addDialog.ShowDialog();

            var oneWineResponse = await Infrastructure.GetOneWine(_wineId);
            if (oneWineResponse.ErrorCode)
            {
                BottlesPanel.Controls.Clear();
                var newWineInfo = (List<WineTicket>)oneWineResponse.Object;

                this.WineName = newWineInfo[0].WineName;
                this.Country = newWineInfo[0].Country;
                this.Region = newWineInfo[0].Region;
                this.District = newWineInfo[0].District;
                Producer = newWineInfo[0].Producer;
                Grapes = newWineInfo[0].Grapes;
                Alcohol = newWineInfo[0].Alcohol;
                this.Bottles = newWineInfo[0].Bottles;
            }
            else if (!string.IsNullOrEmpty(oneWineResponse.Message))
                MessageBox.Show(oneWineResponse.Message, "Fel");
        }

        private async void btnUpdateWine_Click(object sender, EventArgs e)
        {
            var selectedDistrict = (DistrictResponse)cbDistricts.SelectedItem;
            var producer = tbProducer.Text;
            if (tbAlcohol.Text.EndsWith("%"))
                tbAlcohol.Text = tbAlcohol.Text.Remove(tbAlcohol.Text.Count() - 1);
            double.TryParse(tbAlcohol.Text, out double alcohol);
            if (selectedDistrict == null)
            {
                MessageBox.Show("Inget distrikt har valts", "Fel");
                return;
            }

            var updateWineResponse = await Infrastructure.UpdateWine(this.WineId, producer, alcohol, selectedDistrict.DistrictId);
            if (updateWineResponse.ErrorCode)
            {
                var updatedWine = (WineResponse)updateWineResponse.Object;
                tbProducer.Text = updatedWine.Producer;
                tbAlcohol.Text = updatedWine.Alcohol.ToString();


            }
            else if (!string.IsNullOrEmpty(updateWineResponse.Message))
                MessageBox.Show(updateWineResponse.Message, "Fel");
        }







        private void ShowCountries()
        {
            cbCountries.Items.Clear();
            cbCountries.Items.AddRange(Metadata.Countries.ToArray());
            cbCountries.SelectedIndex = 0;
        }
        private void cbCountries_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            CountryResponse selectedCountry = (CountryResponse)cbCountries.SelectedItem;
            ShowRegions(selectedCountry.CountryId);
        }
        private void ShowRegions(long selectedCountryId)
        {
            cbRegions.Items.Clear();

            CountryResponse selectedCountry = Metadata.Countries.FirstOrDefault(r => r.CountryId == selectedCountryId);
            if (selectedCountry != null && selectedCountry.Regions.Count() > 0)
            {
                cbRegions.Items.AddRange(selectedCountry.Regions.ToArray());
                cbRegions.SelectedIndex = 0;
            }
            else
            {
                ShowDistrict(0, 0);
            }
        }
        private void cbRegions_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            RegionResponse selectedRegion = (RegionResponse)cbRegions.SelectedItem;
            ShowDistrict(selectedRegion.CountryId, selectedRegion.RegionId);
        }
        private void ShowDistrict(long selectedCountryId, long selectedRegionId)
        {
            cbDistricts.Items.Clear();

            CountryResponse selectedCountry = Metadata.Countries.FirstOrDefault(r => r.CountryId == selectedCountryId);
            if (selectedCountry == null)
                return;
            RegionResponse selectedRegion = selectedCountry.Regions.First(r => r.RegionId == selectedRegionId);
            if (selectedRegion == null)
                return;

            if (selectedRegion != null && selectedRegion.Districts.Count() > 0)
            {
                cbDistricts.Items.AddRange(selectedRegion.Districts.ToArray());
                cbDistricts.SelectedIndex = 0;
            }
        }
















        //private

        private void ShowAndSelectOrigin()
        {
            ShowCountries();
            cbCountries.SelectedIndex = cbCountries.FindStringExact(Country);
            cbRegions.SelectedIndex = cbRegions.FindStringExact(Region);
            cbDistricts.SelectedIndex = cbDistricts.FindStringExact(District);
        }
    }
}
