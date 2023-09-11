﻿using Microsoft.AspNetCore.Mvc;
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

        public IActionResult BirimSil(int id)
        {
            var dep = c.Birims.Find(id);
            c.Birims.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        //public IActionResult DepartmanGetir(int id)
        //{
        //    var depart = c.Departmen.Find(id);
        //    return View("DepartmanGetir", depart);
        //}

        //public IActionResult DepartmanGuncelle(Departman d)
        //{
        //    var dep = c.Departmen.Find(d.ID);
        //    dep.Ad = d.Ad;
        //    c.SaveChanges();
        //    return RedirectToAction("Index");
        //}
    }
}