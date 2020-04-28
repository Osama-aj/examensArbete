using examensArbete.BusinessLogic;
using examensArbete.Models;
using examensArbete.Models.ResponseModel.UserSectionResponse;
using Firebase.Auth;
using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Apis.Auth.OAuth2;
using Newtonsoft.Json;
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

        public static UserRecord _user;

        public Wine_Application(UserRecord user)
        {
            _user = user;
            InitializeComponent();



        }
        private static readonly char separator = Path.DirectorySeparatorChar;
        private static readonly string userDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + separator + "vinAppData";
        private static readonly string userDataFile = userDataDirectory + separator + "data.txt";


        private void Wine_Application_Load(object sender, EventArgs e)
        {


        }



























        ////////////////////
        ////////////////////
        ////////////////////
        ////////////////////
        /// before copy
        private async Task<string> GetToken()
        {
           
            return await FirebaseAdmin.Auth.FirebaseAuth.DefaultInstance.CreateCustomTokenAsync(_user.Uid);

        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(userDataFile, string.Empty);

            LogIn login = new LogIn();
            login.Show();
            Hide();
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













        ////////////////////
        ////////////////////
        ////////////////////
        ////////////////////
        ////////////////////
        /// after copy
        

        //winelist tab

        private void GetUsersWineListButton_Click(object sender, EventArgs e)
        {

            GetUsersWineList();
        }
        private async void GetUsersWineList()
        {
            var getUsersWineListLink = Links.baseLink + Links.usersWineList + Links.userId;
            var responseBody = await RestVerbs.Get(getUsersWineListLink);
            var responseBodyJson = JsonConvert.DeserializeObject<ICollection<WineListResponse>>(responseBody);
            //dataGridView1.DataSource = responseBodyJson;
            var wineTickets = new List<WineTicket>();
            flowLayoutPanel1.Controls.Clear();
            foreach (var wine in responseBodyJson)
            {

                var inves = new List<InventoryTicket>();
                foreach (var inv in wine.Vintages)
                {
                    inves.Add(new InventoryTicket
                    {
                        Year = inv.Year,
                        Amount = inv.Amount,
                        Shelf = inv.ShelfName,
                        Grade = inv.Grade != null ? inv.Grade.Grade : 0,
                        InventoryId = inv.InventoryId,
                        ShelfId = inv.ShelfId,

                    });

                    //wineTickets[wineTickets.Count() - 1].Bottles.Controls.Add(new InventoryTicket
                    //{
                    //    Year = inv.Year,
                    //    Amount = inv.Amount,
                    //    Shelf = inv.ShelfName,
                    //    Grade = inv.Grade != null ? inv.Grade.Grade : 0,
                    //    InventoryId = inv.InventoryId
                    //});
                }




                wineTickets.Add(new WineTicket
                {
                    WineId = wine.WineId,
                    WineName = wine.WineName,
                    District = wine.District.DistrictName,
                    Alcohol = wine.Alcohol,
                    Bottles = inves,
                    WinePic = wine.ImageThumbnail,


                });

                // flowLayoutPanel1.Controls.Add(wineTickets.Last());
            }


            for (int i = 0; i < wineTickets.Count() - 1 && i < 5; i++)
            {
                //flowLayoutPanel1.Controls.AddRange(wineTickets.ToArray());

                wineTickets[i].Region = i.ToString();
                flowLayoutPanel1.Controls.Add(wineTickets[i]);

            }

        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

            //if (flowLayoutPanel1.CanSelect)
            //    flowLayoutPanel1.Select();
            //foreach (Control c in flowLayoutPanel1.Controls)
            //{
            //    if (c.CanSelect)
            //    {
            //        c.Select();

            //    }
            //}
        }
        int charChanged = 0;
        int currentCharLength = 0;
        private async void ComboBox1_TextUpdate(Object sender, EventArgs e)
        {
            Console.WriteLine(comboBox1.Text);
            //comboBox1.AutoCompleteMode = AutoCompleteMode.None;
            //comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            if (comboBox1.Text.Length >= 3)
            {
                var getAllWinelist = Links.baseLink + Links.allwineList + Links.userId + "&startswith=" + comboBox1.Text;
                var responseBody = await RestVerbs.Get(getAllWinelist);
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

        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }






        //MessageBox.Show("You are in the ComboBox.TextUpdate event.");

    }
}



















