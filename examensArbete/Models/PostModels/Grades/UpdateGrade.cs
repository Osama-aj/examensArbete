using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examensArbete.Models.PostModels.Grades
{
    public class UpdateGrade
    {
        [Required] public long GradeId { get; set; }
        [Range(1, 5)] public int Grade { get; set; }
        public string Comment { get; set; }
    }
}
