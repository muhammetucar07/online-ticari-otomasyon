using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace online_ticari_otomasyon.Models.Class
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string AdminUserName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string AdminPassword { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(1)]
        public string Authorize { get; set; }


    }
}
