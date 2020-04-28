using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace examensArbete.Models.PostModels.Users
{
    public class UpdateUserModel
    {
        [Required] public string Username { get; set; }

    }
}
