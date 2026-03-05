using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using Lab_rab_3_KutlubaevAD_БПИ_23_02.Models;

namespace Lab_rab_3_KutlubaevAD_БПИ_23_02.Controllers
{
    public class VegetablesController : Controller
    {
        public ActionResult FirstViewMethod()
        {
            List<Vegetable> veggies = new List<Vegetable>
            {
                new Vegetable { Id = 1, Name = "Картофель" },
                new Vegetable { Id = 2, Name = "Морковь" },
                new Vegetable { Id = 3, Name = "Лук" },
                new Vegetable { Id = 4, Name = "Капуста" },
                new Vegetable { Id = 5, Name = "Свекла" }
            };
            return View(veggies);
        }
        public ActionResult SecondViewMethod()
        {
            List<Vegetable> veggies = new List<Vegetable>
            {
                new Vegetable { Id = 1, Name = "Картофель" },
                new Vegetable { Id = 2, Name = "Морковь" },
                new Vegetable { Id = 3, Name = "Лук" },
                new Vegetable { Id = 4, Name = "Капуста" },
                new Vegetable { Id = 5, Name = "Свекла" }
            };
            var sorted = veggies.OrderBy(v => v.Name).ToList();
            return View(sorted);
        }
        public ActionResult ThirdViewMethod()
        {
            List<Vegetable> veggies = new List<Vegetable>
            {
                new Vegetable { Id = 1, Name = "Картофель" },
                new Vegetable { Id = 2, Name = "Морковь" },
                new Vegetable { Id = 3, Name = "Лук" },
                new Vegetable { Id = 4, Name = "Капуста" },
                new Vegetable { Id = 5, Name = "Свекла" }
            };

            var grouped = veggies.GroupBy(v => v.Name[0]);

            return View(grouped);
        }
    }
}