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

        //public static UserRecord _user;
        //FirebaseAuthLink _auth;

        public Wine_Application()
        {
            // _auth = auth;
            // _user = user;
            InitializeComponent();



        }
        private static readonly char separator = Path.DirectorySeparatorChar;
        private static readonly string userDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + separator + "vinAppData";
        private static readonly string userDataFile = userDataDirectory + separator + "data.txt";


        private void Wine_Application_Load(object sender, EventArgs e)
        {
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













        ////////////////////
        ////////////////////
        ////////////////////
        ////////////////////
        ////////////////////
        /// after copy


        //winelist tab

        private async void ShowUsersWinelist()
        {

            var usersWinelistErrorModel = await Infrastructure.GetUsersWineList();

            if (usersWinelistErrorModel.ErrorCode)
            {
                flowLayoutPanel1.Controls.Clear();
                List<WineTicket> wineTickets = (List<WineTicket>)usersWinelistErrorModel.Object;
                foreach (Control wineticket in wineTickets)
                {
                    flowLayoutPanel1.Controls.Add(wineticket);
                }

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
                var token = /*await GetToken()*/"";
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

        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            var isSuccess = Infrastructure.Logout();

            if (!string.IsNullOrEmpty(isSuccess.Message))
                MessageBox.Show(isSuccess.Message, "fel");

            LogIn login = new LogIn();
            login.Show();
            Hide();
        }






        //MessageBox.Show("You are in the ComboBox.TextUpdate event.");

    }
}



















