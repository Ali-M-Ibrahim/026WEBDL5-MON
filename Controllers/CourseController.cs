using Microsoft.AspNetCore.Mvc;
using TPUSJ.Models;

namespace TPUSJ.Controllers
{
    public class CourseController : Controller
    {
 
        //strongly typed data
        public IActionResult Index() //
        {
            Course c1 = new Course();
            c1.Id = 1;
            c1.Name = "Web Dynamique 2";
            c1.Details = "Dot net 9999";
            return View("Test",c1);
            //var courses = new List<Course>();
            //Course c1 = new Course();
            //c1.Id= 1;
            //c1.Name = "Web Dynamique";
            //c1.Details = "Dot net 9";


            //Course c2 = new Course();
            //c2.Id = 2;
            //c2.Name = "Projet Informatique";
            //c2.Details = "PFE";

            //courses.Add(c1);
            //courses.Add(c2);

            //return Ok(courses);
        }

        public IActionResult Details()
        {
            return View("Test");
            //Course c1 = new Course();
            //c1.Id = 1;
            //c1.Name = "Web Dynamique";
            //c1.Details = "Dot net 9";
            //return Ok(c1);
        }



        //weakly typed data

        public IActionResult info()
        {
            ViewData["greeting"] = "hello team";
            ViewData["myname"] = "Ali Ibrahim";
            ViewData["coursename"] = "Web dynamique";

            Course c1 = new Course();
            c1.Id = 1;
            c1.Name = "Web Dynamique 2";
            c1.Details = "Dot net 9999";

            ViewData["data"] = c1;
            return View();
        }


        public IActionResult list()
        {
            Course c1 = new Course();
            c1.Id = 1;
            c1.Name = "Web Dynamique 2";
            c1.Details = "Dot net 9999";

            ViewBag.data = c1;
            ViewBag.myname = "Ali Ibrahim";
            return View();

        }


        public IActionResult Array()
        {
            var courses = new List<Course>();
            Course c1 = new Course();
            c1.Id = 1;
            c1.Name = "Web Dynamique";
            c1.Details = "Dot net 9";


            Course c2 = new Course();
            c2.Id = 2;
            c2.Name = "Projet Informatique";
            c2.Details = "PFE";

            courses.Add(c1);
            courses.Add(c2);

            return View(courses);
        }

    }
}
