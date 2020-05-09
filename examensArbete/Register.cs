using examensArbete.Models;
using Firebase.Auth;
using FirebaseAdmin.Auth;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


        private async void btnSignup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbEmailSignup.Text) || string.IsNullOrEmpty(tbPasswordSignUp.Text))
            {
                MessageBox.Show("E-postadress och lösenord är obligatoriska.", "Fel");
                return;
            }
            if (!string.Equals(tbPasswordSignUp.Text, tbRepeatPasswordSignUp.Text))
            {
                MessageBox.Show("Båda lösenorden matchar inte.", "Fel");
                return;
            }

            string apiKey = "AIzaSyA5jFE8V7DgpWWP7HdP_JoR9lmnEveoSus";

            FirebaseAuthProvider fbAuthProvider = new FirebaseAuthProvider(new FirebaseConfig(apiKey));

            try
            {
                await fbAuthProvider.CreateUserWithEmailAndPasswordAsync(tbEmailSignup.Text, tbPasswordSignUp.Text);
                await login(tbEmailSignup.Text, tbPasswordSignUp.Text);
            }
            catch (Exception ex)
            {
                var offset = ex.Message.IndexOf('\n');
                offset = ex.Message.IndexOf('\n', offset + 1);
                var from = ex.Message.IndexOf('\n', offset + 1);
                var to = ex.Message.LastIndexOf('}');

                var message = "{" + ex.Message.Substring(from, to - from + 1).Replace("Response", "\"Response\"") + "}";
                var exceptionMessage = JsonConvert.DeserializeObject<ExceptionFirebase>(message);

                System.IO.File.WriteAllText(userDataFile, ex.ToString());
                MessageBox.Show(exceptionMessage.Response.Error.Message, "Fel");

                return;
            }
        }




        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);

        }







        ////////////////////////
        ////////////////////////
        ////////////////////////
        ////////////////////////
        ///helper methods
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
            catch (Exception ex)
            {
                Console.WriteLine("=====>\nlogin func, ex : " + ex.Message + "\n<=======");


                MessageBox.Show("E-postadress eller lösenord är felaktiga.", "Fel");
                return;
            }
            try
            {
                System.IO.File.WriteAllText(userDataFile, auth.User.LocalId);

            }
            catch (Exception ex)
            {
                Console.WriteLine("=====>\nlogin func, ex : " + ex.Message + "\n<=======");


                MessageBox.Show("Kunde inte skriva till fil.", "Fel");
                return;
            }

            Wine_Application wineApp = new Wine_Application(user, auth);
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
            catch (Exception ex)
            {
                Console.WriteLine("=====>\nGetUser func, ex : " + ex.Message + "\n<=======");

                return null;
            }
        }
    }
}
