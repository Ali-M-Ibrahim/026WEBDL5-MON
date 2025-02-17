using Microsoft.AspNetCore.Mvc;
using TPUSJ.Models;

namespace TPUSJ.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
          
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
