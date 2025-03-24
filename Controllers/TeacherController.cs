using Microsoft.AspNetCore.Mvc;
using TPUSJ.Models;

namespace TPUSJ.Controllers
{
    public class TeacherController : Controller
    {
 
        public IActionResult Index() 
        {
            Teacher obj = new Teacher();
            obj.Id=1;
            obj.Name = "Ali Ibrahim";
            obj.Degree = "PhD";

            Teacher obj2 = new Teacher();
            obj2.Id = 2;
            obj2.Name = "Ralph Zaidan";
            obj2.Degree = "Student";

            ViewData["first_key"] = "This is my values";
            ViewData["second_key"] = obj2;

            Teacher obj3 = new Teacher();
            obj3.Id = 3;
            obj3.Name = "Elie Hassoun";
            obj3.Degree = "Student";

            ViewBag.message = "this is my message";
            ViewBag.teacher3 = obj3;


            return View(obj);  //views/teacher/index

        }

        public IActionResult Details()
        {
            Teacher obj = new Teacher();
            obj.Id = 1;
            obj.Name = "Ali Ibrahim";
            obj.Degree = "PhD";

            Teacher obj2 = new Teacher();
            obj2.Id = 2;
            obj2.Name = "Ralph Zeidan";
            obj2.Degree = "Student";

            Teacher obj3 = new Teacher();
            obj3.Id = 3;
            obj3.Name = "Elie Hassoun";
            obj3.Degree = "Student";


            List<Teacher> all = new List<Teacher>();
            all.Add(obj);
            all.Add(obj2);
            all.Add(obj3);

            return View(all); // views/teacher/details
        }
    }
}
