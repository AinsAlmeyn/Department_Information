using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Knowledge_Departman_Revize.Models
{
    public class Birim
    {
        [Key]
        public int BirimID { get; set; }
        public string BirimAd { get; set; }

        public IList<Personel> Personels { get; set; }
    }
}
