using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace online_ticari_otomasyon.Models.Class
{
    public class Invoices
    {
        [Key]
        public int InvoiceID { get; set; }

        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string InvoiceSerialNo { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(6)]
        public string InvoiceSequenceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(60)]
        public string TaxOffice { get; set; }
        public DateTime InvoiceTime { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string InvoiceDeliverer { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string InvoiceReceiver { get; set; }
        public ICollection<InvoiceItem> InvoiceItems { get; set; }

    }
}
