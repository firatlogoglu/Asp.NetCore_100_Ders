using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index()
        {
            var degerler = c.Personels.Include(x => x.Birim).ToList();
            return View(degerler);
        }
    }
}
