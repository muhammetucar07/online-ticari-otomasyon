using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace online_ticari_otomasyon.Models.Class
{
    public class Categories
    {
        [Key]
        public int CategoryID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
