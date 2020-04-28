using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace examensArbete.Models.PostModels.Vintages
{
    public class AddVintageModel
    {
        [Required] public int Year { get; set; }
        public string EAN { get; set; }
        [Required] public long? WineId { get; set; }
    }
}
