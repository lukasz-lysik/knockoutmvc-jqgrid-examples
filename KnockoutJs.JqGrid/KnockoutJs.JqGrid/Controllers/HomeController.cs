using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PerpetuumSoft.Knockout;

namespace KnockoutJs.JqGrid.Controllers
{
    public class HomeController : KnockoutController
    {
        public ActionResult Index()
        {
            var data = new[]
                           {
                               new MyListItem {id = 1, name = "Well-Travelled Kitten", sales = 352, price = 75.95},
                               new MyListItem {id = 2, name = "Speedy Coyote", sales = 89, price = 190.00},
                               new MyListItem {id = 3, name = "Furious Lizard", sales = 152, price = 25.00},
                               new MyListItem {id = 4, name = "Indifferent Monkey", sales = 1, price = 99.95},
                               new MyListItem {id = 5, name = "Brooding Dragon", sales = 0, price = 6350},
                               new MyListItem {id = 6, name = "Ingenious Tadpole", sales = 39450, price = 0.35},
                               new MyListItem {id = 7, name = "Optimistic Snail", sales = 420, price = 1.50}
                           }.ToList();

            return View(new MyViewModel { Items = data});
        }

        public ActionResult Add(MyViewModel model)
        {
            model.Items.Add(new MyListItem { id = 8, name = "Optimistic", sales = 42, price = 1.34 });
            return Json(model);
        }

    }

    public class MyViewModel
    {
        public IList<MyListItem> Items { get; set; }
    }

    public class MyListItem
    {
        public int id { get; set; }
        public string name { get; set; }
        public int sales { get; set; }
        public double price { get; set; }
    }
}
