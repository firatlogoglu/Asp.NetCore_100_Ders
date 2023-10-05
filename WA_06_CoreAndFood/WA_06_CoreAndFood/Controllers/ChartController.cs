using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WA_06_CoreAndFood.Data;
using WA_06_CoreAndFood.Repositories;

namespace WA_06_CoreAndFood.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult VisualizeProductResult()
        {
            return Json(ProList());
        }

        public List<Class1> ProList()
        {
            List<Class1> cs = new List<Class1>();
            cs.Add(new Class1()
            {
                ProName = "Computer",
                Stock = 150
            });
            cs.Add(new Class1()
            {
                ProName = "Lcd",
                Stock = 75
            });
            cs.Add(new Class1()
            {
                ProName = "Usb Disk",
                Stock = 220
            });
            return cs;
        }

        public IActionResult Index3()
        {
            return View();
        }

        public IActionResult VisualizeProductResult2()
        {
            return Json(FoodList());
        }

        public List<Class2> FoodList()
        {
            List<Class2> cs2 = new List<Class2>();
            FoodRepository f = new FoodRepository();

            cs2 = f.TList().Select(x => new Class2
            {
                FoodName = x.Name,
                Stock = x.Stock
            }).ToList();

            return cs2;
        }

        public IActionResult Statistics()
        {
            FoodRepository f = new FoodRepository();
            CategoryRepository c = new CategoryRepository();

            var deger1 = f.TList().Count;
            ViewBag.d1 = deger1;

            var deger2 = c.TList().Count;
            ViewBag.d2 = deger2;

            var foid = c.TList().Where(x => x.Name == "Fruit").Select(y => y.ID).FirstOrDefault();

            var deger3 = f.TList().Where(x => x.CategoryID == foid).Count();
            ViewBag.d3 = deger3;

            var deger4 = f.TList().Where(x => x.CategoryID == (c.TList().Where(z => z.Name == "Vegetables").Select(y => y.ID).FirstOrDefault())).Count();
            ViewBag.d4 = deger4;

            var deger5 = f.TList().Sum(x => x.Stock);
            ViewBag.d5 = deger5;

            var deger6 = f.TList().Where(x => x.CategoryID == c.TList().Where(y => y.Name == "Legumes").Select(z => z.ID).FirstOrDefault()).Count();
            ViewBag.d6 = deger6;

            var deger7 = f.TList().OrderByDescending(x => x.Stock).Select(y => y.Name).FirstOrDefault();
            ViewBag.d7 = deger7;

            var deger8 = f.TList().OrderBy(x => x.Stock).Select(y => y.Name).FirstOrDefault();
            ViewBag.d8 = deger8;

            var deger9 = f.TList().Average(x => x.Price).ToString("0.00");
            ViewBag.d9 = deger9;

            var deger10 = c.TList().Where(x => x.Name == "Fruit").Select(y => y.ID).FirstOrDefault();
            var deger10p = f.TList().Where(y => y.CategoryID == deger10).Sum(x => x.Stock);
            ViewBag.d10 = deger10p;

            var deger11 = c.TList().Where(x => x.Name == "Vegetables").Select(y => y.ID).FirstOrDefault();
            var deger11p = f.TList().Where(y => y.CategoryID == deger11).Sum(x => x.Stock);
            ViewBag.d11 = deger11p;

            return View();
        }
    }
}
