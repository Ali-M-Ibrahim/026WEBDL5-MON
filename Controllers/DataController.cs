using Microsoft.AspNetCore.Mvc;
using TPUSJ.Models;

namespace TPUSJ.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index()
        {
            Address obj = new Address()
            {
                Id = 1,
                city = "Beiurt",
                street = "Mar roukoz",
                country = "Lebanon"
            };
            return Ok(obj);
        }
    }
}
