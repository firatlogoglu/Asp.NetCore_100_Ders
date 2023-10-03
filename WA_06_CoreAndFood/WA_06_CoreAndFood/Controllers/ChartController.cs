using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WA_06_CoreAndFood.Data;
using WA_06_CoreAndFood.Data.Models;

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
            using (var c = new Context())
            {
                cs2 = c.Foods.Select(x => new Class2
                {
                    FoodName = x.Name,
                    Stock = x.Stock
                }).ToList();
            }
            return cs2;
        }
    }
}
