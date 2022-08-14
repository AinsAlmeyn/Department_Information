using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Knowledge_Departman_Revize.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }

        [Column(TypeName ="Varchar(20)")]
        public string Kullanici { get; set; }

        [Column(TypeName ="Varhcar(10)")]
        public string Sifre { get; set; }
    }
}
