using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WA_03_CoreKitaplik.Models;

namespace WA_03_CoreKitaplik.ViewComponents
{
    public class YeniKitaplar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var kitaplistesi = new List<Kitaplar>
            {
                new Kitaplar
                {
                    ID=6,
                    KitapAd="Korku",
                    Yazar="Zweig"
                },
                new Kitaplar
                {
                    ID=7,
                    KitapAd="Anna Karenina",
                    Yazar="Tolstoy"
                }
            };
            return View(kitaplistesi);
        }
    }
}
