using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examensArbete.Models
{
    public class ErrorModel
    {
        public bool ErrorCode { get; set; }
        public string Message { get; set; }
        public Object Object { get; set; }
    }
}
