using examensArbete.BusinessLogic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examensArbete.Models.PostModels.Wines
{
    public class AddWine
    {
        [Required] public string Name { get; set; }
        [JsonConverter(typeof(Base64FileJsonConverter))]
        public byte[] Image { get; set; }
        [Required] public long? DistrictId { get; set; }
        public string Producer { get; set; }

        public double Alcohol { get; set; }
        public ICollection<WineGrape> WineGrapes { get; set; }
    }

    public class WineGrape
    {
        public double Percent { get; set; }
        public long GrapeId { get; set; }
        public Grape Grape { get; set; }

    }

    public class Grape
    {
        public long GrapeId { get; set; }

         public string GrapeName { get; set; }

    }
}
