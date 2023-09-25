using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WA_05_CoreDepartman_Revize.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult GirisYap()
        {
            return View();
        }
    }
}