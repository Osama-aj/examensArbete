using examensArbete.Models;
using examensArbete.Models.PostModels.Inventories;
using examensArbete.Models.PostModels.Shelves;
using examensArbete.Models.PostModels.Vintages;
using examensArbete.Models.ResponseModel.GeneralSectionResponse;
using examensArbete.Models.ResponseModel.UserSectionResponse;
using Firebase.Auth;
using FirebaseAdmin.Auth;
using Google.Apis.Upload;
using Newtonsoft.Json;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Crypto.Engines;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examensArbete.BusinessLogic
{
    //TODO: add alwayes new line to inventories there I can choose vintage, shelf and amount 
    // vintage can be disabled list in all inventories but enabled in the last one
    //add "lägg till vintage" in the corner 
    // four  tabs "min vin lista;; alla viner ;;lägg till;; mina sidor"
    // in "lägg till" tab will be add shelf, country, region, district

    //add addCountry, region and district to the backend


    public class Infrastructure
    {
        #region global variables 
        private static UserRecord _user;
        private static FirebaseAuthLink _auth;


        private static string apiKey = "AIzaSyA5jFE8V7DgpWWP7HdP_JoR9lmnEveoSus";
        private static char separator = Path.DirectorySeparatorChar;
        private static string userDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + separator + "vinAppData";
        private static string userDataFile = userDataDirectory + separator + "data.txt";
        #endregion

        #region login,out and signup
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
            _auth = auth;
            _user = user;
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
            _auth = auth;
            _user = user;
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
        #endregion

        #region winelist 
        public static async Task<ErrorModel> GetMetadata()
        {
            MetaDataResponse responseBodyJson = new MetaDataResponse();

            var url = Links.baseLink + Links.metadata;
            var token = await GetToken();
            var responseErrorModel = await RestVerbs.Get(url, token);

            if (responseErrorModel.ErrorCode)
            {
                responseBodyJson = JsonConvert.DeserializeObject<MetaDataResponse>((string)responseErrorModel.Object);

            }
            else
            {
                return responseErrorModel;

            }

            return new ErrorModel { ErrorCode = true, Message = null, Object = responseBodyJson };




        }
        public static async Task<ErrorModel> GetOneWine(long wineid)
        {
            var url = Links.baseLink + Links.allwineList;
            url = url.Replace("wineId=-1", "wineId=" + wineid.ToString());
            var res = await GetWineList(url, "", -1, -1);
            return res;
        }
        public static async Task<ErrorModel> GetUsersWinelist(string startsWith, long countryId, long regionId)
        {
            var url = Links.baseLink + Links.usersWineList;
            return await GetWineList(url, startsWith, countryId, regionId);
        }
        public static async Task<ErrorModel> GetAllWinelist(string startsWith, long countryId, long regionId)
        {
            var url = Links.baseLink + Links.allwineList;
            return await GetWineList(url, startsWith, countryId, regionId);
        }

        #endregion


        #region inventoryTicket




        public static async Task<ErrorModel> AddBottles(long inventoryId, string currentAmount, int amount, long shelfId)
        {
            if (char.IsDigit(currentAmount[0]))
            {
                return await Infrastructure.UpdateInventory(inventoryId, shelfId, int.Parse(currentAmount) + amount);

            }
            else if (!char.IsDigit(currentAmount[0]))
            {
                // return await Infrastructure.AddNewInventory(int.Parse(amount) + 1, shelfId);

            }
            return new ErrorModel { ErrorCode = false, Message = "Någonting gick fel!", Object = null };
        }
        public static async Task<ErrorModel> RemoveBottles(long inventoryId, string currentAmount, int amount, long shelfId)
        {
            if (inventoryId == 0 || string.Equals(currentAmount, "-") || shelfId == 0)
                return new ErrorModel { ErrorCode = false, Message = "Inga flaskor att ta bort!", Object = null };
            var newAmount = int.Parse(currentAmount) - amount;
            if (newAmount < 0)
                return new ErrorModel { ErrorCode = false, Message = "summan blir mindre än noll!", Object = null };

            return await Infrastructure.UpdateInventory(inventoryId, shelfId, newAmount);
        }
        public static async Task<ErrorModel> UpdateInventory(long inventoryId, long shelfId, int newAmount = -1)
        {

            var url = Links.baseLink + Links.inventories;
            var payload = new UpdateInventoryModel
            {
                InventoryId = inventoryId,
                ShelfId = shelfId
            };

            if (newAmount != -1)
                payload.Amount = newAmount;

            var token = await GetToken();
            var responseBody = await RestVerbs.Put(url, payload, token);
            if (string.IsNullOrEmpty(responseBody) && newAmount == 0)
            {
                return new ErrorModel { ErrorCode = false, Message = "Information har inte updateras", Object = new InventoryResponse { InventoryId = 0, ShelfId = 0, Amount = 0 } };

            }
            try
            {
                var responseBodyJson = JsonConvert.DeserializeObject<InventoryResponse>(responseBody);
                return new ErrorModel { ErrorCode = true, Message = null, Object = responseBodyJson };
                //this.Amount = responseBodyJson.Amount;
            }
            catch (Exception error)
            {
                return new ErrorModel { ErrorCode = false, Message = error.Message, Object = null };
            }

        }
        public static async Task<ErrorModel> AddInventory(long vintageId, long shelfId, int amount)
        {
            var url = Links.baseLink + Links.inventories;
            var payload = new AddInventoryModel
            {
                VintageId = vintageId,
                ShelfId = shelfId,
                Amount = amount
            };
            var token = await GetToken();
            var responseBody = await RestVerbs.Post(url, payload, token);
            if (string.IsNullOrEmpty(responseBody))
                return new ErrorModel { ErrorCode = false, Message = "Inventeringen har inte lagts till", Object = new InventoryResponse { InventoryId = 0, ShelfId = 0, Amount = 0 } };

            try
            {
                var responseBodyJson = JsonConvert.DeserializeObject<InventoryResponse>(responseBody);
                return new ErrorModel { ErrorCode = true, Message = null, Object = responseBodyJson };
            }
            catch (Exception error)
            {
                return new ErrorModel { ErrorCode = false, Message = error.Message, Object = null };
            }
        }

        #endregion

        #region addVintageShelfInventory
        public static async Task<ErrorModel> AddShelf(string shelfName)
        {
            var url = Links.baseLink + Links.shelves;
            var payload = new AddShelfModel
            {
                ShelfName = shelfName
            };
            var token = await GetToken();
            var responseBody = await RestVerbs.Post(url, payload, token);
            if (string.IsNullOrEmpty(responseBody))
                return new ErrorModel { ErrorCode = false, Message = "Hyllan har inte lagts till", Object = new ShelfResponse { ShelfId = 0, Name = null } };

            try
            {
                var responseBodyJson = JsonConvert.DeserializeObject<ShelfResponse>(responseBody);
                return new ErrorModel { ErrorCode = true, Message = null, Object = responseBodyJson };
            }
            catch (Exception error)
            {
                return new ErrorModel { ErrorCode = false, Message = error.Message, Object = null };
            }

        }
        public static async Task<ErrorModel> AddVintage(long wineId, string year)
        {

            var isNumber = int.TryParse(year, out int yearInt);
            if (!isNumber)
                return new ErrorModel { ErrorCode = false, Message = "Du får skriva bara siffror", Object = null };

            var url = Links.baseLink + Links.vintages;
            var payload = new AddVintageModel
            {
                WineId = wineId,
                Year = yearInt
            };
            var token = await GetToken();
            var responseBody = await RestVerbs.Post(url, payload, token);
            if (string.IsNullOrEmpty(responseBody))
                return new ErrorModel { ErrorCode = false, Message = "Årgangen har inte lagts till", Object = new VintageResponse { VintageId = 0, WineId = 0, Year = "0" } };

            try
            {
                var responseBodyJson = JsonConvert.DeserializeObject<VintageResponse>(responseBody);
                if ( responseBodyJson.WineId == 0 || responseBodyJson.VintageId == 0)
                    return new ErrorModel { ErrorCode = false, Message = "Årgangen har inte lagts till", Object = new VintageResponse { VintageId = 0, WineId = 0, Year = "0" } };

                return new ErrorModel { ErrorCode = true, Message = null, Object = responseBodyJson };
            }
            catch (Exception error)
            {
                return new ErrorModel { ErrorCode = false, Message = error.Message, Object = null };
            }


        }

        #endregion








        public static async Task<List<ShelfResponse>> GetUsersShelves()
        {
            var url = Links.baseLink + Links.shelves;
            var token = await GetToken();
            var responseErrorModel = await RestVerbs.Get(url, token);
            if (responseErrorModel.ErrorCode)
            {
                var responseBodyJson = JsonConvert.DeserializeObject<List<ShelfResponse>>((string)responseErrorModel.Object);
                return responseBodyJson;
            }
            else if (!string.IsNullOrEmpty(responseErrorModel.Message))
                MessageBox.Show(responseErrorModel.Message, "Fel");

            return null;

        }

        public static async Task<List<VintageResponse>> GetVintages(long wineId)
        {
            var url = Links.baseLink + Links.vintages + "?wineid=" + wineId;
            var token = await GetToken();
            var responseErrorModel = await RestVerbs.Get(url, token);
            if (responseErrorModel.ErrorCode)
            {
                var responseBodyJson = JsonConvert.DeserializeObject<List<VintageResponse>>((string)responseErrorModel.Object);
                return responseBodyJson;
            }
            else if (!string.IsNullOrEmpty(responseErrorModel.Message))
                MessageBox.Show(responseErrorModel.Message, "Fel");

            return null;

        }




        private static async Task<ErrorModel> GetWineList(string url, string startsWith, long countryId, long regionId)
        {
            var shelves = await GetUsersShelves();


            if (!string.IsNullOrEmpty(startsWith))
                url = url.Replace("startswith=", "startswith=" + startsWith);
            if (countryId > 0)
                url = url.Replace("countryid=-1", "countryid=" + countryId);
            if (regionId > 0)
                url = url.Replace("regionid=-1", "regionid=" + regionId);

            ICollection<WineListResponse> responseBodyJson = new List<WineListResponse>();
            var token = await GetToken();
            var responseErrorModel = await RestVerbs.Get(url, token);
            if (responseErrorModel.ErrorCode)
            {
                responseBodyJson = JsonConvert.DeserializeObject<ICollection<WineListResponse>>((string)responseErrorModel.Object);

            }
            else
            {
                return responseErrorModel;

            }




            var wineTickets = new List<WineTicket>();
            responseBodyJson = responseBodyJson.Take(10).ToList();
            foreach (var wine in responseBodyJson)
            {

                List<VintageResponse> vintages = await GetVintages(wine.WineId);

                List<InventoryTicket> inves = new List<InventoryTicket>();
                if (wine.Vintages != null)
                {
                    foreach (var inv in wine.Vintages)
                    {
                        inves.Add(new InventoryTicket(shelves, vintages)
                        {
                            Year = inv != null ? inv.Year : "",
                            CurrentAmount = inv != null ? inv.Amount.ToString() : "",
                            Shelf = inv.ShelfName,
                            //Grade = (inv.Grade != null && inv.Grade.Grade >= 1 && inv.Grade.Grade <= 5) ? inv.Grade.Grade.ToString() : "-",
                            Grade = "--",
                            InventoryId = inv.InventoryId,
                            ShelfId = inv.ShelfId,

                        });
                    }
                }
                else
                    inves.Add(new InventoryTicket(shelves, vintages) { CurrentAmount = "-", Year = "-", Grade = "--", Shelf = "-" });

                string origin = wine.Country.CountryName;
                if (wine.Region.RegionName != "Okänt region")
                    origin += " >> \r\n" + wine.Region.RegionName;
                if (wine.District.DistrictName != "Okänt distrikt")
                    origin += " >> \r\n" + wine.District.DistrictName;

                string grapes = "";
                foreach (var grape in wine.WineGrapes)
                {
                    grapes += grape.GrapeName + ((grape.Percent > 0) ? " " + grape.Percent + "%" + "\r\n" : "\r\n");
                }
                wineTickets.Add(new WineTicket
                {
                    WineId = wine.WineId,
                    WineName = wine.WineName,
                    Alcohol = wine.Alcohol.ToString() + "%",
                    Bottles = inves,
                    Origin = origin,
                    Producer = wine.Producer,
                    Grapes = grapes,
                    WinePic = wine.ImageThumbnail
                });
            }
            return new ErrorModel { ErrorCode = true, Message = null, Object = wineTickets };
        }


        private static async Task<string> GetToken()
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
