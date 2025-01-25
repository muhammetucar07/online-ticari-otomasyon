using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace online_ticari_otomasyon.Models.Class
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string ProductName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Brand { get; set; }
        public short Stock { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public bool Status { get; set; } = true;

        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string Image { get; set; }

        // Kategori ilişkisi
        public int CategoryID { get; set; } // Foreign Key
        [ForeignKey("CategoryID")]
        public virtual Categories Categories { get; set; }
        //public virtual Categories Categories { get; set; }
        public ICollection<Sales> Saless { get; set; }


    }
}
