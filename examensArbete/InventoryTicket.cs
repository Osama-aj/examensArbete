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

namespace examensArbete
{
    public partial class InventoryTicket : UserControl
    {
        public InventoryTicket()
        {
            InitializeComponent();
        }

        private long _inventoryId;
        private long _shelfId;
        private long _vintageId;
        private int _year;
        private int _amount;
        private int _grade;
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
        public int Year
        {
            get { return _year; }
            set { _year = value; lblYear.Text = value.ToString(); }
        }


        [Category("Custom Props")]
        public int Amount
        {
            get { return _amount; }
            set { _amount = value; lblAmount.Text = value.ToString(); }
        }

        [Category("Custom Props")]
        public int Grade
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
            var sendSuccessfully = await Infrastructure.EditBottlesAmount(this.InventoryId, this.Amount + 1, this.ShelfId);

            if (sendSuccessfully.ErrorCode)
            {
                var responseObject = (InventoryResponse)sendSuccessfully.Object;
                this.Amount = responseObject.Amount;
            }
            else if (!string.IsNullOrEmpty(sendSuccessfully.Message))
                MessageBox.Show(sendSuccessfully.Message, "Fel");

        }

        private async void RemoveOneBottleButton_Click(object sender, EventArgs e)
        {
            var sendSuccessfully = await Infrastructure.EditBottlesAmount(this.InventoryId, this.Amount - 1, this.ShelfId);

            if (sendSuccessfully.ErrorCode)
            {
                var responseObject = (InventoryResponse)sendSuccessfully.Object;
                this.Amount = responseObject.Amount;
            }
            else if (!string.IsNullOrEmpty(sendSuccessfully.Message))
                MessageBox.Show(sendSuccessfully.Message, "Fel");
        }


        private void lblGrade_Click(object sender, EventArgs e)
        {
            var url = Links.baseLink + Links.grades;
            var payload = new AddGradeModel
            {
                VintageId = this.VintageId,

            };

        }
    }
}
