using Microsoft.AspNetCore.Mvc;
using online_ticari_otomasyon.Models.Class;
using System.Data.Entity;

namespace online_ticari_otomasyon.Controllers
{
    public class DepartmentController : Controller
    {
        //Get
        private readonly Context _context;

        public DepartmentController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // var values = _context.Products.ToList();
            var values = _context.Departments.Where(x => x.Status == true).ToList();
            return View(values);

        }

        [HttpGet]
        public IActionResult DepartmentAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DepartmentAdd(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DepartmentDelete(int id)
        {
            var department = _context.Departments.Find(id);
            department.Status = false;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DepartmentGet(int id)
        {
            var department = _context.Departments.Find(id);
            return View("DepartmentGet", department);
        }

        public IActionResult DepartmentUpdate(Department department)
        {
            var dep = _context.Departments.Find(department.DepartmentID);
            dep.DepartmentName = department.DepartmentName;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DepartmentDetail(int id)
        {
            var values = _context.Employees.Where(x => x.DepartmentID == id).ToList();
            var departmentName = _context.Departments.Where(x => x.DepartmentID == id).Select(y => y.DepartmentName).FirstOrDefault();
            ViewBag.d = departmentName;
            return View(values);

        }

        public IActionResult DepartmentEmployeeSaless(int id)
        {
            //var values = _context.Saless.Where(x => x.Employee.EmployeeID == id).ToList();
            //var employeName = _context.Employees.Where(x => x.EmployeeID == id).Select(y => y.EmployeeName + " " + y.EmployeeSurname).FirstOrDefault();
            //ViewBag.d = employeName;
            //return View(values); 
            var values = _context.Saless
                                .Include(x => x.Product)  // Product tablosunu dahil ediyoruz
                                .Include(x => x.Current)  // Current tablosunu dahil ediyoruz
                                .Where(x => x.Employee.EmployeeID == id)
                                .ToList();


            var employeName = _context.Employees
                .Where(x => x.EmployeeID == id)
                .Select(y => y.EmployeeName + " " + y.EmployeeSurname)
                .FirstOrDefault();

            ViewBag.d = employeName;
            return View(values);
        }
    }
}
