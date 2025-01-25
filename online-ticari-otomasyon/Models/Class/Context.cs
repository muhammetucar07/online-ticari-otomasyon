using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;
namespace online_ticari_otomasyon.Models.Class
{
    public class Context : DbContext
    {


        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        // DbSet --> Tablo Bazlı çalışıyoruz.
        // property(değişken) yada sütun adı bazlı çalışmıyoryoruz
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Categories> Categoriess { get; set; }
        public DbSet<Current> Currents { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Expenses> Expensess { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<Invoices> Invoicess { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sales> Saless { get; set; }

    }
}
