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
    }
}
