using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace online_ticari_otomasyon.Models.Class
{
    public class Sales
    {
        [Key]
        public int SalesID { get; set; }

        public DateTime Date { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string SalesProduct { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string SalesClient { get; set; }

        public int Amount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }

        // Foreign Key tanımları
        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        public int CurrentID { get; set; }
        [ForeignKey("CurrentID")]
        public virtual Current Current { get; set; }

        public int EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public virtual Employee Employee { get; set; }




    }
}
