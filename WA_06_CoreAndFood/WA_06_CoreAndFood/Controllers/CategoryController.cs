using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WA_06_CoreAndFood.Data.Models;
using WA_06_CoreAndFood.Repositories;

namespace WA_06_CoreAndFood.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository categoryRepository = new CategoryRepository();

        public IActionResult Index()
        {
            return View(categoryRepository.TList());
        }

        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CategoryAdd(Category p)
        {
            if (!ModelState.IsValid)
            {
                return View("CategoryAdd");
            }
            categoryRepository.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult CategoryGet(int id)
        {
            var x = categoryRepository.TGet(id);
            Category ct = new Category()
            {
                ID = x.ID,
                Name = x.Name,
                Description = x.Description,
            };

            return View(ct);
        }

        [HttpPost]
        public IActionResult CategoryUpdate(Category p)
        {
            var x = categoryRepository.TGet(p.ID);
            x.Name = p.Name;
            x.Description = p.Description;
            x.Status = true;
            categoryRepository.TUpdate(x);

            return RedirectToAction("Index");
        }
    }
}
