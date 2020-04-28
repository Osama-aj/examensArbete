using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examensArbete.Models.PostModels.Grades
{
    public class AddGradeModel
    {
        [Required(ErrorMessage = "vintage id is required")]
        public long? VintageId { get; set; }

        public int Grade { get; set; }
        public string Comment { get; set; }
    }
}
