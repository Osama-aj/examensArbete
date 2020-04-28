using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examensArbete.Models.PostModels.Inventories
{
    public class AddInventoryModel
    {
        [Required] public int Amount { get; set; }
        [Required] public long VintageId { get; set; }
        [Required] public long ShelfId { get; set; }
    }
}
