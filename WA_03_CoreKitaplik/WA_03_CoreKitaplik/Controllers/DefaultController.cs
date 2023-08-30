using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WA_03_CoreKitaplik.Models;

namespace WA_03_CoreKitaplik.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            var ktp = new List<Kitaplar>()
            {
                new Kitaplar(){ID=1, KitapAd="Satranç", Yazar="Stefan Zweig"},
                new Kitaplar(){ID=2, KitapAd="Doktor Ox'un Deneyi", Yazar="Jules Verne"},
                new Kitaplar(){ID=3, KitapAd="Delifişek", Yazar="Jose Mauro De Vasconcelos"},
                new Kitaplar(){ID=4, KitapAd="Kırmız Bisiklet", Yazar="Muzaffer İzgü"},
                new Kitaplar(){ID=5, KitapAd="Toros Canavarı", Yazar="Aziz Nesin"}
            };

            return View(ktp);
        }

        public IActionResult Deneme()
        {
            return View();
        }
    }
}
