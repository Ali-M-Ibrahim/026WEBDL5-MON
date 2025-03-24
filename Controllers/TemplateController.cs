using Microsoft.AspNetCore.Mvc;

namespace TPUSJ.Controllers
{
    public class TemplateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();

        }
    }
}
