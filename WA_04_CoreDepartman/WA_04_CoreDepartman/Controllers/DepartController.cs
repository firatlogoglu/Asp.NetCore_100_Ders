using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WA_04_CoreDepartman.Models;

namespace WA_04_CoreDepartman.Controllers
{
    public class DepartController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Departmen.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult YeniDepartman()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniDepartman(Departman d)
        {
            c.Departmen.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DepartmanSil(int id)
        {
            var dep = c.Departmen.Find(id);
            c.Departmen.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DepartmanGetir(int id)
        {
            var depart = c.Departmen.Find(id);
            return View("DepartmanGetir");
        }
    }
}
