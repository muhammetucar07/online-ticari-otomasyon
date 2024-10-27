using System.ComponentModel.DataAnnotations;
namespace online_ticari_otomasyon.Models.Class
{
    public class Sales
    {
        [Key]
        public int SalesID { get; set; }
        public DateTime date { get; set; }  
        public string SalesProduct { get; set; }
        public string SalesClient { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        
        public Product Product { get; set; } 
        public  Current Current { get; set; }
        public  Employee Employee { get; set; }




    }
}
