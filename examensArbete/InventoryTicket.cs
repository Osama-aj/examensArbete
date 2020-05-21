using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using examensArbete.Models;
using examensArbete.Models.PostModels.Inventories;
using examensArbete.BusinessLogic;
using Newtonsoft.Json;
using examensArbete.Models.ResponseModel.UserSectionResponse;
using examensArbete.Models.PostModels.Grades;
using examensArbete.Models.ResponseModel.GeneralSectionResponse;

namespace examensArbete
{
    public partial class InventoryTicket : UserControl
    {
        private readonly List<ShelfResponse> Shelves = new List<ShelfResponse>();
        private readonly List<VintageResponse> Vintages = new List<VintageResponse>();
        bool firstShelfIndexChange = true;

        public InventoryTicket(List<ShelfResponse> _shelves, List<VintageResponse> _vintages)
        {
            Shelves = _shelves;
            Vintages = _vintages;
            InitializeComponent();
        }
        private void InventoryTicket_Load(object sender, EventArgs e)
        {

            cbShelves.Items.AddRange(Shelves.ToArray());
            cbShelves.SelectedIndex = cbShelves.FindStringExact(_shelf);

            cbVintages.Items.AddRange(Vintages.ToArray());


            if (_inventoryId > 0 && !string.Equals(_currentAmount, "-"))
            {
                cbVintages.Visible = false;
                lblYear.Visible = true;
            }
            else
            {
                cbVintages.Visible = true;
                lblYear.Visible = false;
                if (cbShelves.Items.Count >0)
                    cbShelves.SelectedIndex = 0;
                if (cbVintages.Items.Count > 0)
                    cbVintages.SelectedIndex = 0;

            }





            this.tbamount.Text = "1";
            if (string.Equals(_currentAmount, "-"))
                RemoveOneBottleButton.Enabled = false;
        }
        private long _inventoryId;
        private long _shelfId;
        private long _vintageId;
        private string _year;
        private string _currentAmount;
        private string _grade;
        private string _shelf;


        [Category("Custom Props")]
        public long InventoryId
        {
            get { return _inventoryId; }
            set { _inventoryId = value; lblinventoryId.Text = value.ToString(); }
        }


        [Category("Custom Props")]
        public long ShelfId
        {
            get { return _shelfId; }
            set { _shelfId = value; }

        }

        [Category("Custom Props")]
        public long VintageId
        {
            get { return _vintageId; }
            set { _vintageId = value; }


        }

        [Category("Custom Props")]
        public string Year
        {
            get { return _year; }
            set { _year = value; lblYear.Text = value.ToString(); }
        }


        [Category("Custom Props")]
        public string CurrentAmount
        {
            get { return _currentAmount; }
            set { _currentAmount = value; lblCurrentAmount.Text = value.ToString(); }
        }

        [Category("Custom Props")]
        public string Grade
        {
            get { return _grade; }
            set { _grade = value; lblGrade.Text = value.ToString(); }
        }

        [Category("Custom Props")]
        public string Shelf
        {
            get { return _shelf; }
            set { _shelf = value; lblShelf.Text = value; }
        }

        private async void AddOneBottleButton_Click(object sender, EventArgs e)
        {
            if (InventoryId <= 0 || _shelfId <= 0 || _currentAmount == "-")
            {
                var selectedVintage = (VintageResponse)cbVintages.SelectedItem;
                var selectedShelf = (ShelfResponse)cbShelves.SelectedItem;
                var sendSuccessfully = await Infrastructure.AddInventory(selectedVintage.VintageId, selectedShelf.ShelfId, int.Parse(this.tbamount.Text));
                if (sendSuccessfully.ErrorCode)
                {
                    var responseObject = (InventoryResponse)sendSuccessfully.Object;
                    if (responseObject.Amount.ToString() != this.tbamount.Text)
                        MessageBox.Show("Flaskorna har lagts till i en befintlig inventering\r\nDu kan behöva uppdatera listan", "Information");
                    else
                    {
                        this.CurrentAmount = responseObject.Amount.ToString();
                        this.VintageId = responseObject.VintageId;
                        this.InventoryId = responseObject.InventoryId;
                        this.Year = responseObject.Vintage.Year.ToString();
                        lblYear.Visible = true;
                        cbVintages.Visible = false;
                    }
                }
                else if (!string.IsNullOrEmpty(sendSuccessfully.Message))
                    MessageBox.Show(sendSuccessfully.Message, "Fel");
            }
            else
            {
                var sendSuccessfully = await Infrastructure.AddBottles(this._inventoryId, this._currentAmount, int.Parse(this.tbamount.Text), this._shelfId);

                if (sendSuccessfully.ErrorCode)
                {
                    var responseObject = (InventoryResponse)sendSuccessfully.Object;
                    this.CurrentAmount = responseObject.Amount.ToString();
                }
                else if (!string.IsNullOrEmpty(sendSuccessfully.Message))
                    MessageBox.Show(sendSuccessfully.Message, "Fel");
            }
        }

        private async void RemoveOneBottleButton_Click(object sender, EventArgs e)
        {
            ErrorModel sendSuccessfully;


            sendSuccessfully = await Infrastructure.RemoveBottles(this._inventoryId, this._currentAmount, int.Parse(this.tbamount.Text), this._shelfId);
            if (sendSuccessfully.ErrorCode && sendSuccessfully.Object != null)
            {
                var responseObject = (InventoryResponse)sendSuccessfully.Object;
                this.CurrentAmount = responseObject.Amount.ToString();
                if (responseObject.Amount <= 0)
                {
                    this.AddOneBottleButton.Enabled = false;
                    this.RemoveOneBottleButton.Enabled = false;
                }

            }
            else if (!string.IsNullOrEmpty(sendSuccessfully.Message))
                MessageBox.Show(sendSuccessfully.Message, "Fel");
        }


        private void lblGrade_Click(object sender, EventArgs e)
        {
            // var sendSuccessfully = await Infrastructure.EditGradeForVintage(this.VintageId,);

            //var url = Links.baseLink + Links.grades;
            //var payload = new AddGradeModel
            //{
            //    VintageId = this.VintageId,

            //};

        }


        private async void cbShelves_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (!firstShelfIndexChange && _inventoryId > 0)
            {
                ShelfResponse selectedShelf = (ShelfResponse)cbShelves.SelectedItem;
                if (selectedShelf.ShelfId != _shelfId)
                {
                    var updateShelfResponse = await Infrastructure.UpdateInventory(this._inventoryId, selectedShelf.ShelfId);

                    if (updateShelfResponse.ErrorCode)
                    {
                        var updatedInventory = (InventoryResponse)updateShelfResponse.Object;
                        var shelf = Shelves.First(s => s.ShelfId == updatedInventory.ShelfId);
                        var index = cbShelves.FindStringExact(shelf.Name);
                        cbShelves.SelectedIndex = index;

                    }
                    else if (!string.IsNullOrEmpty(updateShelfResponse.Message))
                    {
                        var previosShelf = Shelves.First(s=>s.ShelfId ==_shelfId);
                        cbShelves.SelectedIndex = cbShelves.FindStringExact(previosShelf.Name);
                        MessageBox.Show(updateShelfResponse.Message, "Fel");
                    }
                }
            }
            firstShelfIndexChange = false;
        }





    }
}
