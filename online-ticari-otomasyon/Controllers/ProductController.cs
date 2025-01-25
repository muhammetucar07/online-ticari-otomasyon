using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using online_ticari_otomasyon.Models.Class;

namespace online_ticari_otomasyon.Controllers
{
    public class ProductController : Controller
    {
        //Get
        private readonly Context _context;

        public ProductController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // var values = _context.Products.ToList();
            var values = _context.Products.Where(x => x.Status == true).ToList();
            return View(values);

        }

        [HttpGet]
        public IActionResult ProductAdd()
        {
            /* 
             
             Veritabanı Sorgusu (LINQ):

            from x in _context.Categoriess.ToList() kısmı, Entity Framework üzerinden veritabanındaki Categoriess tablosundaki tüm verileri çeker.

            SelectListItem, dropdown listesi için kullanılan bir model sınıfıdır. Bu sınıfın iki ana özelliği vardır:

              Text: Dropdown menüsünde görünen metin. Burada, her kategorinin ismi (CategoryName) bu alanda yer alır.
              Value: Her bir dropdown öğesinin değeri. Bu değeri, kullanıcının seçtiği kategoriyi daha sonra işlemek için kullanabilirsiniz. 
                     Burada, CategoryID'yi string formatında veriyoruz.select new SelectListItem kısmı, 
                     bu verileri SelectListItem tipine dönüştürür.

             */


            List<SelectListItem> value = (from x in _context.Categoriess.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.CategoryName, // Dropdown menüsünde görünen metin (Kategori adı)
                                              Value = x.CategoryID.ToString() // Her bir kategorinin değeri, ID'si (CategoryID) ile eşleşir
                                          }).ToList();
            ViewBag.v1 = value;  // ViewBag, Controller'dan View'e veri taşımak için kullanılır.
            return View();
        }

        [HttpPost]
        public IActionResult ProductAdd(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult ProductDelete(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                product.Status = false;
                // _context.Products.Remove(product);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ProductGet(int id)
        {
            var product = _context.Products.Find(id);
            List<SelectListItem> value = (from x in _context.Categoriess.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.CategoryName,
                                              Value = x.CategoryID.ToString()
                                          }).ToList();
            ViewBag.v1 = value;
            return View("ProductGet", product);
        }

        [HttpPost]
        public IActionResult ProductUpdate(Product product)
        {
            var p = _context.Products.Find(product.ProductID);
            p.ProductName = product.ProductName;
            p.Brand = product.Brand;
            p.Stock = product.Stock;
            p.PurchasePrice = product.PurchasePrice;
            p.SalePrice = product.SalePrice;
            p.Status = product.Status;
            p.Image = product.Image;
            p.CategoryID = product.CategoryID;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
