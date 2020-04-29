using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examensArbete.Models
{
    public class Links
    {
        public static string baseLink = @"http://54.72.51.80:5000/api/";
        //public static string baseLink = @"http://localhost:5000/api/";
       // public static string userId = @"";
        //public static string userId = @"?userId=Av4ivM6LMlRVz7W5YbgilBXUK5d2";


        public static string usersWineList = "userswinelist?startswith=&countryid=-1&regionid=-1&districtid=-1&grapeid=-1";
        public static string allwineList = "allwinelist?startswith=&countryid=-1&regionid=-1&districtid=-1&grapeid=-1";

        public static string shelves = @"shelves";
        public static string vintages = @"vintages";
        public static string countries = @"countries";
        public static string grapes = @"grapes";
        public static string inventories = @"inventories";
        public static string grades = @"grades";


    }
}
