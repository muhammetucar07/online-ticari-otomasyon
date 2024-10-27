using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace online_ticari_otomasyon.Models.Class
{
    public class Current
    {
        [Key]
        public int CurrentID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CurrentName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CurrentSurname { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(13)]
        public string CurrentCity { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string CurrentEmail { get; set; }
        public ICollection<Sales> Saless { get; set; }
    }
}
