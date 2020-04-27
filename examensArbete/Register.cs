using Firebase.Auth;
using FirebaseAdmin.Auth;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private static string apiKey = "AIzaSyA5jFE8V7DgpWWP7HdP_JoR9lmnEveoSus";
        private static char separator = Path.DirectorySeparatorChar;
        private static string userDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + separator + "vinAppData";
        private static string userDataFile = userDataDirectory + separator + "data.txt";
        private void btnLoginInRegister_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            Hide();
        }
        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);

        }

        private async void btnSignup_Click(object sender, EventArgs e)
        {
            string apiKey = "AIzaSyA5jFE8V7DgpWWP7HdP_JoR9lmnEveoSus";

            FirebaseAuthProvider fbAuthProvider = new FirebaseAuthProvider(new FirebaseConfig(apiKey));

            try
            {
                await fbAuthProvider.CreateUserWithEmailAndPasswordAsync(tbEmailSignup.Text, tbPasswordSignUp.Text);
                await login(tbEmailSignup.Text, tbPasswordSignUp.Text);
            }
            catch (Exception ex)
            {
             
                System.IO.File.WriteAllText(userDataFile, ex.ToString());

                Console.WriteLine(ex.Data);
                MessageBox.Show( ex.ToString(), "Fel");

                return;
            }
        }


        private async Task login(string email, string password)
        {

            UserRecord user = null;
            FirebaseAuthLink auth = null;
            FirebaseAuthProvider fbAuthProvider = new FirebaseAuthProvider(new FirebaseConfig(apiKey));
            try
            {
                //TODO: try internet 
                auth = await fbAuthProvider.SignInWithEmailAndPasswordAsync(email, password);


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
