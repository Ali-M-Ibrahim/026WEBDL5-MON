using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using TPUSJ.Data;

namespace TPUSJ.Controllers
{
    public class LinqController : Controller
    {

        private readonly ApplicationDbContext _context;

        public LinqController(ApplicationDbContext db)
        {
            _context = db; 
        }

        public IActionResult Index()
        {
            // select * from items where price > 50;
            var data = from p in _context.Items
                       where p.Price > 50
                       select p;
            var data2 = _context.Items.Where(p => p.Price > 80);

            // select * from items where price > 10 and type = 'Drink'
            var data3 = from p in _context.Items
                       where p.Price > 10
                       where p.Type=="Drink"
                        select p;

            var data4 = _context.Items.Where(p => p.Price > 10)
                .Where(p => p.Type == "Drink");


            // select name from items;
            var data5 = _context.Items.Select(p => p.Name);

            // select * from items orderBy price asc
            var data6 = _context.Items.OrderBy(p => p.Price);

            // select * from items orderBy price desc
            var data7 = _context.Items.OrderByDescending(p => p.Price);

            //select * from items where Type="Drink" order by price desc;

            var data8 = _context.Items.Where(p => p.Type == "Drink")
                .OrderByDescending(p => p.Price);


            //select * from items where type = "Drink" limit 1;
            var data9 = _context.Items.Where(p => p.Type == "Drink")
                 .OrderByDescending(p => p.Price).First();

            //select * from items where type = "Drink" 
            var data10 = _context.Items.Where(p => p.Id == 2)
                 .Single();


            //select * from items where id > 0 limit 3
            var data11 = _context.Items.Where(p => p.Id > 0)
                .Take(3);


            //select * from items where id > 0 skip 3
            var data12= _context.Items.Where(p => p.Id > 0)
                .Skip(3);


            var data13 = _context.Items.GroupBy(p => p.Type);


            var data14 = _context.Items.Where(p => p.Price > 300).Any();
            var data15 = _context.Items.All(p => p.Price > 1);



            // select distinct type from items

            var data16 = _context.Items.Select(p => p.Type).Distinct();


            //select count(1) from items
            var data17 = _context.Items.Count();

            // select max(price) from items;
            var data18 = _context.Items.Max(p => p.Price);

            // select min(price) from items;
            var data19 = _context.Items.Min(p => p.Price);


            // select min(price) from items;
            var data20 = _context.Items.Sum(p => p.Price);

            return Ok(data20);
           
        }
    }
}
