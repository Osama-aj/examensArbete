using Firebase.Auth;
using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Apis.Auth.OAuth2;
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
        private static char separator = Path.DirectorySeparatorChar;
        private static string userDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + separator + "vinAppData";
        private static string userDataFile = userDataDirectory + separator + "data.txt";




























        private async Task<string> GetToken()
        {
           
            return await FirebaseAdmin.Auth.FirebaseAuth.DefaultInstance.CreateCustomTokenAsync(_user.Uid);

        }

        private void btnLogout_Click(object sender, EventArgs e)
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
    }
}
