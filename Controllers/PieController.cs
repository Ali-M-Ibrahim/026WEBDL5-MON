using Microsoft.AspNetCore.Mvc;

namespace TPUSJ.Controllers
{
    [Route("mycontroller")]
    public class PieController : Controller
    {
        [Route("")]
        public IActionResult Index() //pie || //pie/index
        {
            return Ok("i am index function in pie controller");
        }

        [Route("mydetails")]
        public IActionResult Details() 
        {
            return Ok("i am details function in pie controller");
        }

    }
}
