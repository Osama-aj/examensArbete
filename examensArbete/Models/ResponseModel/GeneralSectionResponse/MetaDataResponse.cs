using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examensArbete.Models.ResponseModel.GeneralSectionResponse
{
    public class MetaDataResponse
    {
        public IEnumerable<GrapeResponse> Grapes { get; set; }
        public IEnumerable<CountryResponse> Countries { get; set; }
    }
}
