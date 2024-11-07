using Microsoft.AspNetCore.Mvc;
using online_ticari_otomasyon.Models.Class;
namespace online_ticari_otomasyon.Controllers
{
    public class CategoryController : Controller
    {
        private readonly Context _context;

        public CategoryController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Categoriess.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CategoryAdd(Categories categories)
        {
            _context.Categoriess.Add(categories);
            _context.SaveChanges();
            return RedirectToAction("Index");            
        }

        public IActionResult CategoryDelete(int id)
        {
            var category = _context.Categoriess.Find(id);
            if (category != null) 
            {
                _context.Categoriess.Remove(category);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult CategoryGet(int id)
        {
            var category = _context.Categoriess.Find(id);
            return View("CategoryGet", category);
        }

        public IActionResult CategoryUpdate(Categories categories)
        {
            var category = _context.Categoriess.Find(categories.CategoryID);
            category.CategoryName = categories.CategoryName;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
