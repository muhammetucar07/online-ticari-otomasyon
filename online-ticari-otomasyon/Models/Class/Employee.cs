using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace online_ticari_otomasyon.Models.Class
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string EmployeeName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string EmployeeSurname { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string EmployeeCity { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string EmployeeEmail { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string EmployeeJob { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string EmployeeImage { get; set; }
        public ICollection<Sales> Saless { get; set; }
        public Department Department { get; set; }
    }
}
