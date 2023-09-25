using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WA_05_CoreDepartman_Revize.Models;

namespace WA_05_CoreDepartman_Revize.Controllers
{
    public class PersonelController : Controller
    {
        Context c = new Context();

        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.Personels.Include(x => x.Birim).ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult YeniPersonel()
        {
            List<SelectListItem> degerler = (from x in c.Birims.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.Ad,
                                                 Value = x.ID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;

            return View();
        }

        public IActionResult YeniPersonel(Personel p)
        {
            var per = c.Birims.Where(x => x.ID == p.Birim.ID).FirstOrDefault();
            p.Birim = per;
            c.Personels.Add(p);
            c.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
