using examensArbete.BusinessLogic;
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
using System.Windows;
using System.Windows.Forms;

namespace examensArbete
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);

        }

        private void btnLoginInRegister_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            Hide();
        }






        private async void btnSignup_Click(object sender, EventArgs e)
        {
            var isSignedUp = await Infrastructure.SignUp(tbEmailSignup.Text, tbPasswordSignUp.Text, tbRepeatPasswordSignUp.Text);

            if (isSignedUp.ErrorCode)
            {
                Wine_Application wineApp = new Wine_Application();
                wineApp.Show();
                this.Hide();
            }
            else if (!string.IsNullOrEmpty(isSignedUp.Message))
                MessageBox.Show(isSignedUp.Message, "Fel");

        }
    }
}
