using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examensArbete.Models.ResponseModel.GeneralSectionResponse
{
    public class WineResponse
    {
        public long WineId { get; set; }
        public string Name { get; set; }
        public string ImageOriginal { get; set; }
        public string ImageThumbnail { get; set; }
        public double Alcohol { get; set; }
        public DistrictResponse District { get; set; }
        public ICollection<WineGrapeResponse> WineGrapes { get; set; }
    }
}
