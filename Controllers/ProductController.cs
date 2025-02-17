using Microsoft.AspNetCore.Mvc;

namespace TPUSJ.Controllers
{
    public class ProductController : Controller
    {
        [Route("test",Name ="myroute")]
        public IActionResult Index()
        {
            return Ok("i am index function");
        }
        [Route("mydetails")]
        public IActionResult Details()
        {
            return Ok("details");
        }
    }
}
