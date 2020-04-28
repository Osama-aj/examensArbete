using examensArbete.Models.ResponseModel.GeneralSectionResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examensArbete.Models.ResponseModel.UserSectionResponse
{
    public class WineListResponse
    {
        public long WineId { get; set; }
        public string WineName { get; set; }
        public string ImageOriginal { get; set; }
        public string ImageThumbnail { get; set; }
        public double Alcohol { get; set; }
        public DistrictResponse District { get; set; }
        public ICollection<WineGrapeResponse> WineGrapes { get; set; }



        public ICollection<WineListVintagesResponse> Vintages { get; set; }
    }

    public class WineListVintagesResponse
    {
        public long WineId { get; set; }


        public long VintageId { get; set; }
        public int Year { get; set; }
        public string EAN { get; set; }



        public long InventoryId { get; set; }
        public int Amount { get; set; }
        public long ShelfId { get; set; }
        public string ShelfName { get; set; }


        public GradeResponse Grade { get; set; }
        //public WineListInventoryDto Inventory { get; set; }



    }
}
