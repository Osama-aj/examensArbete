using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examensArbete.Models.PostModels.Metadata
{
    public class AddDistrictModel
    {
        [StringLength(40)]
        [Required]
        public string DistrictName { get; set; }
        // [ForeignKey("Region")]
        [Required] public long RegionId { get; set; }
    }
}
