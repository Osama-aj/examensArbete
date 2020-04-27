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
    public partial class LogIn : Form
    {

        public LogIn()
        {
            InitializeComponent();

        }

        private static string apiKey = "AIzaSyA5jFE8V7DgpWWP7HdP_JoR9lmnEveoSus";
        private static char separator = Path.DirectorySeparatorChar;
        private static string userDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + separator + "vinAppData";
        private static string userDataFile = userDataDirectory + separator + "data.txt";
        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);

        }


        private async void LogIn_Load(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(userDataDirectory);

            FirebaseAuthProvider fbAuthProvider = new FirebaseAuthProvider(new FirebaseConfig(apiKey));

            var uId = CheckSavedUserId();
            if (string.IsNullOrEmpty(uId))
                return;





            var user = await GetUser(uId);
            if (user == null)
            {
                System.IO.File.WriteAllText(userDataFile, string.Empty);
                return;
            }

            Wine_Application wineApp = new Wine_Application(user);
            wineApp.Show();
            this.Hide();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            //tbEmailLogin.Text = "mycoolemailname@blabla.com";
            //tbPasswordLogin.Text = "123456";

            if (string.IsNullOrWhiteSpace(tbEmailLogin.Text) || string.IsNullOrWhiteSpace(tbPasswordLogin.Text))
            {
                MessageBox.Show("E-postadress och lösenord är obligatoriska.", "Fel");
                return;
            }

            UserRecord user = null;
            FirebaseAuthLink auth = null;
            FirebaseAuthProvider fbAuthProvider = new FirebaseAuthProvider(new FirebaseConfig(apiKey));
            try
            {
                //TODO: try internet 
                auth = await fbAuthProvider.SignInWithEmailAndPasswordAsync(tbEmailLogin.Text, tbPasswordLogin.Text);


                user = await GetUser(auth.User.LocalId);
                if (user == null)
                    return;



            }
            catch (Exception)
            {

                MessageBox.Show("E-postadress eller lösenord är felaktiga.", "Fel");
                return;
            }
            try
            {
                System.IO.File.WriteAllText(userDataFile, auth.User.LocalId);

            }
            catch (Exception)
            {

                MessageBox.Show("Kunde inte skriva till fil.", "Fel");
                return;
            }

            Wine_Application wineApp = new Wine_Application(user);
            wineApp.Show();
            this.Hide();

        }

        private void btnSignUpInLogin_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            Hide();
        }



        private string CheckSavedUserId()
        {


            string uId = null;
            try
            {
                uId = System.IO.File.ReadAllText(userDataFile);

            }
            catch (Exception)
            {

                return uId;
            }

            return uId;
        }

        private async Task<UserRecord> GetUser(string uId)
        {
            try
            {
                var user = await FirebaseAdmin.Auth.FirebaseAuth.DefaultInstance.GetUserAsync(uId);
                return user;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
