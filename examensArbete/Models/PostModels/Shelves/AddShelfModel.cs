using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examensArbete.Models.PostModels.Shelves
{
    public class AddShelfModel
    {
        [Required] public string ShelfName { get; set; }

    }
}
