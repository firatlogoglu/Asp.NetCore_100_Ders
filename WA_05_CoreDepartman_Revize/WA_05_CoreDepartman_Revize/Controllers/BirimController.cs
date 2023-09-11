using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WA_05_CoreDepartman_Revize.Models;

namespace WA_05_CoreDepartman_Revize.Controllers
{
    public class BirimController : Controller
    {
        Context c = new Context();

        public IActionResult Index()
        {
            var degerler = c.Birims.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult YeniBirim()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniBirim(Birim b)
        {
            c.Birims.Add(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
