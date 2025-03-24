using Microsoft.AspNetCore.Mvc;
using TPUSJ.Data;
using TPUSJ.Models;

namespace TPUSJ.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext db)
        {
            _context = db;
   
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Store(Product obj)
        {
            if (obj!=null && obj.Name.Length < 3) {
                ModelState.AddModelError("Name", "Minimum 3 characters");
            }

            if (ModelState.IsValid)
            {
                // insert into products ("name","description") values (?,?);
                _context.Products.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }

            return View("Create");
         
        }

        public IActionResult Index()
        {
            // select * from products
            List<Product> all = _context.Products.ToList();
            return View(all);
        }


        public IActionResult Delete(int id)
        {
            // select * from products where id=?
            Product obj = _context.Products.Find(id);
            if (obj == null) {
                return NotFound();
            }
            _context.Products.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            if(id == null)
            {
                return NotFound();
            }
            // select * from products where id=?
            Product obj = _context.Products.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }

        [HttpPost]
        public IActionResult Update(Product obj)
        {
            _context.Products.Update(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
