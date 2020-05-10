using examensArbete.Models;
using Firebase.Auth;
using FirebaseAdmin.Auth;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examensArbete.BusinessLogic
{


    public class Infrastructure
    {

        private UserRecord _user;
        private FirebaseAuthLink _auth;


        private static string apiKey = "AIzaSyA5jFE8V7DgpWWP7HdP_JoR9lmnEveoSus";
        private static char separator = Path.DirectorySeparatorChar;
        private static string userDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + separator + "vinAppData";
        private static string userDataFile = userDataDirectory + separator + "data.txt";


        public static async Task<ErrorModel> CheckIfLoggedIn()
        {
            System.IO.Directory.CreateDirectory(userDataDirectory);

            FirebaseAuthProvider fbAuthProvider = new FirebaseAuthProvider(new FirebaseConfig(apiKey));

            var uId = "";
            try
            {
                uId = System.IO.File.ReadAllText(userDataFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine("=====>\nCheckSavedUserId func, ex : " + ex.Message + "\n<=======");
                uId = null;
            }

            if (string.IsNullOrEmpty(uId))
            {

                return new ErrorModel { ErrorCode = false, Message = null };
            }





            var user = await GetUser(uId);
            if (user == null)
            {
                System.IO.File.WriteAllText(userDataFile, string.Empty);
                return new ErrorModel { ErrorCode = false, Message = "You need to log In." };

            }
            var customTokent = await FirebaseAdmin.Auth.FirebaseAuth.DefaultInstance.CreateCustomTokenAsync(user.Uid);

            FirebaseAuthLink auth = await fbAuthProvider.SignInWithCustomTokenAsync(customTokent);
            return new ErrorModel { ErrorCode = true, Message = null };

        }

        public static async Task<ErrorModel> LogInWithEmailAndPassword(string email, string password)
        {

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                // MessageBox.Show("E-postadress och lösenord är obligatoriska.", "Fel");
                return new ErrorModel { ErrorCode = false, Message = "E-postadress och lösenord är obligatoriska." };
            }


            UserRecord user = null;
            FirebaseAuthLink auth = null;
            FirebaseAuthProvider fbAuthProvider = new FirebaseAuthProvider(new FirebaseConfig(apiKey));
            try
            {
                //TODO: try internet 
                auth = await fbAuthProvider.SignInWithEmailAndPasswordAsync(email, password);


                user = await GetUser(auth.User.LocalId);
                if (user == null)
                    return new ErrorModel { ErrorCode = false, Message = null };



            }
            catch (Exception ex)
            {
                Console.WriteLine("=====>\nbtnLogin_Click func, ex : " + ex.Message + "\n<=======");

                //MessageBox.Show("E-postadress eller lösenord är felaktiga.", "Fel");
                return new ErrorModel { ErrorCode = false, Message = "E-postadress eller lösenord är felaktiga." };

            }
            try
            {
                System.IO.File.WriteAllText(userDataFile, auth.User.LocalId);

            }
            catch (Exception ex)
            {
                Console.WriteLine("=====>\nbtnLogin_Click func, ex : " + ex.Message + "\n<=======");


                //MessageBox.Show("Kunde inte skriva till fil.", "Fel");
                return new ErrorModel { ErrorCode = false, Message = "Skrivning till filen misslyckades." };

            }


            var ct = await FirebaseAdmin.Auth.FirebaseAuth.DefaultInstance.CreateCustomTokenAsync(auth.User.LocalId);

            auth = await fbAuthProvider.SignInWithCustomTokenAsync(ct);
            var tt = await FirebaseAdmin.Auth.FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(auth.FirebaseToken);

            return new ErrorModel { ErrorCode = true, Message = null };


        }
        public static async Task<ErrorModel> SignUp(string email, string password, string repeatPassword)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                //MessageBox.Show("E-postadress och lösenord är obligatoriska.", "Fel");
                return new ErrorModel { ErrorCode = false, Message = "E-postadress och lösenord är obligatoriska." };
            }
            if (!string.Equals(password, repeatPassword))
            {
                // MessageBox.Show("Båda lösenorden matchar inte.", "Fel");
                return new ErrorModel { ErrorCode = false, Message = "Båda lösenorden matchar inte." };

            }


            FirebaseAuthProvider fbAuthProvider = new FirebaseAuthProvider(new FirebaseConfig(apiKey));

            try
            {
                await fbAuthProvider.CreateUserWithEmailAndPasswordAsync(email, password);
                await LogInWithEmailAndPassword(email, password);
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
                //MessageBox.Show(exceptionMessage.Response.Error.Message, "Fel");

                return new ErrorModel { ErrorCode = false, Message = "exceptionMessage.Response.Error.Message" };
            }
            return new ErrorModel { ErrorCode = true, Message = null };

        }

        public static ErrorModel Logout()
        {
            try
            {
                System.IO.File.WriteAllText(userDataFile, string.Empty);
                return new ErrorModel { ErrorCode = true, Message = null };
            }
            catch (Exception)
            {
                return new ErrorModel { ErrorCode = false, Message = "Nnting gick fel medan loggning ut!" };

            }
        }




        ///////////////////
        ///////////////////
        ///////////////////
        ///////////////////
        ///////////////////
        /// Helper Functions 
        /// 

        private async Task<string> GetToken()
        {
            _auth = await _auth.GetFreshAuthAsync();
            Console.WriteLine("Token : {0}", _auth.FirebaseToken);
            return _auth.FirebaseToken;

        }


        private static async Task<UserRecord> GetUser(string uId)
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
