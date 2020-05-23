using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examensArbete.Models.PostModels.Metadata
{
    public class AddCountryModel
    {
        [StringLength(40)]
        [Required] public string CountryName { get; set; }
    }
}
