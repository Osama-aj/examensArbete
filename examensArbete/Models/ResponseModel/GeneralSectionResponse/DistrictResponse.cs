using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examensArbete.Models.ResponseModel.GeneralSectionResponse
{
    public class DistrictResponse
    {
        public long DistrictId { get; set; }
        public string DistrictName { get; set; }
        public long RegionId { get; set; }
    }
}
