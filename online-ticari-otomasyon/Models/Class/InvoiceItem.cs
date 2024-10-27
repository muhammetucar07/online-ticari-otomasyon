using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace online_ticari_otomasyon.Models.Class
{
    public class InvoiceItem
    {
        [Key]
        public int InvoiceItemID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string InvoiceItemDescription { get; set; }
        public string InvoiceItemName { get; set; }
        public int InvoiceItemAmount { get; set; }
        public decimal InvoiceItemPrice { get; set; }
        public decimal InvoiceItemTotal { get; set; }

        public Invoices Invoices { get; set; }

    }
}
