using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WA_06_CoreAndFood.Data.Models;
using WA_06_CoreAndFood.Repositories;

namespace WA_06_CoreAndFood.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult Index()
        {
            FoodRepository foodRepository = new FoodRepository();
            return View(foodRepository.TList("Category"));
        }

        [HttpGet]
        public IActionResult AddFood()
        {
            CategoryRepository categoryRepository = new CategoryRepository();

            List<SelectListItem> values = (from x in categoryRepository.TList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.ID.ToString()
                                           }).ToList();
            ViewBag.v1 = values;

            return View();
        }

        [HttpPost]
        public IActionResult AddFood(Food p)
        {
            return View();
        }
    }
}