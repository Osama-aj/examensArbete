using examensArbete.BusinessLogic;
using examensArbete.Models.ResponseModel.GeneralSectionResponse;
using examensArbete.Models.ResponseModel.UserSectionResponse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace examensArbete
{
    public partial class AddShelfVintageInventory : Form
    {
        private readonly long WineId;
        private List<ShelfResponse> Shelves;
        private List<VintageResponse> Vintages;


        public AddShelfVintageInventory(long _wineId)
        {
            WineId = _wineId;
            InitializeComponent();
        }
        private async void AddShelfVintageInventory_Load(object sender, EventArgs e)
        {
            Shelves = await Infrastructure.GetUsersShelves();
            Vintages = await Infrastructure.GetVintages(WineId);
            ShowShelves();
            ShowVintages();

        }

        private void btnAddInventory_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedSelf = (ShelfResponse)cbShelves.SelectedItem;
                var selectedvintage = (VintageResponse)cbYears.SelectedItem;
                var amount = int.Parse(tbAmount.Text);
                var addinventoryResponnse = Infrastructure.AddInventory(selectedvintage.VintageId, selectedSelf.ShelfId, amount);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Fel");
                return;
            }
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }








        private void ShowShelves()
        {
            cbShelves.Items.Clear();
            if (Shelves != null && Shelves.Count > 0)
            {
                cbShelves.Items.AddRange(Shelves.ToArray());
                cbShelves.SelectedIndex = 0;
            }

        }
        private void ShowVintages()
        {
            cbYears.Items.Clear();
            if (Vintages != null && Vintages.Count > 0)
            {
                cbYears.Items.AddRange(Vintages.ToArray());
                cbYears.SelectedIndex = 0;
            }
        }

        private async void btnAddShelf_Click(object sender, EventArgs e)
        {
            var addShelfResponse = await Infrastructure.AddShelf(tbShelfName.Text);
            if (addShelfResponse.ErrorCode)
            {
                Shelves.Add((ShelfResponse)addShelfResponse.Object);
                ShowShelves();
                cbShelves.SelectedIndex = cbShelves.Items.Count - 1;
            }
            else if (!string.IsNullOrEmpty(addShelfResponse.Message))
                MessageBox.Show(addShelfResponse.Message, "Fel");
        }

        private async void btnAddVintage_Click(object sender, EventArgs e)
        {
            var addVintageResponse = await Infrastructure.AddVintage(this.WineId, tbYear.Text);
            if (addVintageResponse.ErrorCode)
            {
                Vintages.Add((VintageResponse)addVintageResponse.Object);
                ShowVintages();
                cbYears.SelectedIndex = cbYears.Items.Count - 1;
            }
            else if (!string.IsNullOrEmpty(addVintageResponse.Message))
                MessageBox.Show(addVintageResponse.Message, "Fel");
        }
    }
}
