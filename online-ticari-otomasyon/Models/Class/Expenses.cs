using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace online_ticari_otomasyon.Models.Class
{
    public class Expenses
    {
        [Key]
        public int ExpensesID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string ExpensesName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string ExpensesInfo { get; set; }
        public decimal ExpensesAmount { get; set; }
        public DateTime ExpensesDate { get; set; }
    }
}
