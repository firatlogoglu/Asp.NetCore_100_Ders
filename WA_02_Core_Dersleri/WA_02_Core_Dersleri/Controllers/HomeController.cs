﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WA_02_Core_Dersleri.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }

        public int Index3()
        {
            return 24;
        }

        public string Index4()
        {
            return "Merhaba Bugün Hava Çok Soğuk";
        }
    }
}
