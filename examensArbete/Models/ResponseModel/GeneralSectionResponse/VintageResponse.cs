using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examensArbete.Models.ResponseModel.GeneralSectionResponse
{
    public class VintageResponse
    {
        public long VintageId { get; set; }
        public string Year { get; set; }
        public string EAN { get; set; }

        public long WineId { get; set; }
        public WineResponse Wine { get; set; }
    }
}
