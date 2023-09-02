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
    }
}
