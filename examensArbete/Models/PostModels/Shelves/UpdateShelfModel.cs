using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace examensArbete.Models.PostModels.Shelves
{
    public class UpdateShelfModel
    {
        [Required] public long ShelfId { get; set; }
        [Required] public string ShelfName { get; set; }
    }
}
