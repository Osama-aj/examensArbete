using examensArbete.BusinessLogic;
using examensArbete.Models;
using examensArbete.Models.ResponseModel.GeneralSectionResponse;
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

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);

        }
        private void btnSignUpInLogin_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            Hide();
        }




        private async void LogIn_Load(object sender, EventArgs e)
        {
            var isLoggedIn = await Infrastructure.CheckIfLoggedIn();

            if (isLoggedIn.ErrorCode)
            {
                var metadetaErrorModel = await Infrastructure.GetMetadata();
                MetaDataResponse metadata = (MetaDataResponse)metadetaErrorModel.Object;
                

                Wine_Application wineApp = new Wine_Application(metadata);
                wineApp.Show();
                this.Hide();
            }
            else if (!string.IsNullOrEmpty(isLoggedIn.Message))
            {
                MessageBox.Show(isLoggedIn.Message, "Fel");
                btnLogin.Enabled = true;
                btnSignUpInLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = true;
                btnSignUpInLogin.Enabled = true;
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            //tbEmailLogin.Text = "mycoolemailname@blabla.com";
            //tbPasswordLogin.Text = "123456";

            ErrorModel loggedInSuccessfully = await Infrastructure.LogInWithEmailAndPassword(tbEmailLogin.Text, tbPasswordLogin.Text);

            if (loggedInSuccessfully.ErrorCode)
            {
                var metadetaErrorModel = await Infrastructure.GetMetadata();
                MetaDataResponse metadata = (MetaDataResponse)metadetaErrorModel.Object;
                Wine_Application wineApp = new Wine_Application(metadata);
                wineApp.Show();
                this.Hide();

            }
            else if (!string.IsNullOrEmpty(loggedInSuccessfully.Message))
                MessageBox.Show(loggedInSuccessfully.Message, "Fel");

        }



    }
}
