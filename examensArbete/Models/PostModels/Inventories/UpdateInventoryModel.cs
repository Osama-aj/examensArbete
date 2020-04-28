using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examensArbete.Models.PostModels.Inventories
{
    public class UpdateInventoryModel
    {
        [Required] public long InventoryId { get; set; }

        public int? Amount { get; set; }

        public long? ShelfId { get; set; }
    }
}
