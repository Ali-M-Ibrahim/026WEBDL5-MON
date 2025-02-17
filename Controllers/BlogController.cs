using Microsoft.AspNetCore.Mvc;

namespace TPUSJ.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return Ok("Hello Class");
        }

        public IActionResult Notf()
        {
            return NotFound();
        }

        public IActionResult BadF()
        {
            return BadRequest("I am the response");
        }

        public IActionResult status()
        {
            return StatusCode(202);
        }

        public IActionResult cont()
        {
            return Content("hello i am content message");
        }

        public IActionResult redirct()
        {
            return RedirectToAction("cont");
        }

        public IActionResult details(int id,string name)
        {
            if (id > 100)
            {
                return BadRequest("The id should be lower than 100");
            }

            return Ok("the id is " + id + " and the name is:" + name);
        }

    }
}
