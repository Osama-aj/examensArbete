using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examensArbete.Models.ResponseModel.GeneralSectionResponse
{
    public class MetaDataResponse
    {
        public IList<GrapeResponse> Grapes { get; set; }
        public IList<CountryResponse> Countries { get; set; }
    }
}
