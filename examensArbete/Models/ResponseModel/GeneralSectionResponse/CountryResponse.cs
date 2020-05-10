using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examensArbete.Models.ResponseModel.GeneralSectionResponse
{
    public class CountryResponse
    {
        public long CountryId { get; set; }
        public string CountryName { get; set; }
        public virtual IList<RegionResponse> Regions { get; set; }
    }
}
