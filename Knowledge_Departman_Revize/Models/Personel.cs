using System.ComponentModel.DataAnnotations;

namespace Knowledge_Departman_Revize.Models
{
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sehir { get; set; }

        public int BirimID { get; set; }
        public Birim Birim { get; set; }
    }
}
