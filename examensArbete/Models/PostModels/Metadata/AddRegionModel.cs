using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examensArbete.Models.PostModels.Metadata
{
    public class AddRegionModel
    {
        [StringLength(40)]
        [Required]
        public string RegionName { get; set; }


        [Required] public long CountryId { get; set; }
    }
}
