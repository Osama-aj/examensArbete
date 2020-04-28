using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examensArbete.Models.ResponseModel.GeneralSectionResponse
{
    public class RegionResponse
    {
        public long RegionId { get; set; }
        public string RegionName { get; set; }
        public long CountryId { get; set; }
        public virtual ICollection<DistrictResponse> Districts { get; set; }
    }
}
