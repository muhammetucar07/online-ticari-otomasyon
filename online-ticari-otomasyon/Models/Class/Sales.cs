using System.ComponentModel.DataAnnotations;
namespace online_ticari_otomasyon.Models.Class
{
    public class Sales
    {
        [Key]
        public int SalesID { get; set; }
        public string SalesProduct { get; set; }
        public string SalesClient { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public DateTime SalesDate { get; set; }
        public ICollection<Product> Products { get; set; } 
        public ICollection<Current> Currents { get; set; }
        public ICollection<Employee> Employees { get; set; }




    }
}
