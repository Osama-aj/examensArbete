using examensArbete.Models.ResponseModel.GeneralSectionResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examensArbete.Models.ResponseModel.UserSectionResponse
{
    public class InventoryResponse
    {
        public long InventoryId { get; set; }
        public int Amount { get; set; }
        public long ShelfId { get; set; }

        public long VintageId { get; set; }
        public VintageResponse Vintage { get; set; }
    }
}
