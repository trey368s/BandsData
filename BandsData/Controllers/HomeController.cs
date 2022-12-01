using BandsData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BandsData.Controllers
{
    public class HomeController : Controller
    {
        private BandContext context { get; set; }

        public HomeController(BandContext ctx)
        {
            context = ctx;  
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.bands = context.Bands.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id > 0)
            {
                var band = context.Bands.Find(id);
                ViewBag.button = "Save";
                return View(band);
            }
            ViewBag.button = "Add";
            return View(new Band());
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var band = context.Bands.Find(id);
            context.Bands.Remove(band); 
            context.SaveChanges();
            ViewBag.bands = context.Bands.ToList();
            return View("Index");
        }

        [HttpPost]
        public IActionResult Index(Band model)
        {
            if (model.BandId > 0)
            {
                context.Bands.Update(model);
                context.SaveChanges();
            }
            else
            {
                context.Bands.Add(model);
                context.SaveChanges();
            }

            ViewBag.bands = context.Bands.ToList();
            return View();
        }

        public IActionResult PinkFloyd()
        {
            return View();
        }

        public IActionResult LedZeppelin()
        {
            return View();
        }
        public IActionResult AliceInChains()
        {
            return View();
        }
        public IActionResult Yes()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Details(int id) 
        {
            var band = context.Bands.Find(id);
            return View(band);
        }
    }
}
