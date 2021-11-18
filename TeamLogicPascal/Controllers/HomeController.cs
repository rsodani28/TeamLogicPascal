using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TeamLogicPascal.Models;

namespace TeamLogicPascal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<SelectListItem> effectingFactors = new List<SelectListItem>()
            {
                new SelectListItem{ Text="Weather Patterns", Value = "5" },
                    new SelectListItem{ Text="Small Ship", Value = "10" },
                    new SelectListItem{ Text="Crew Count", Value = "6" },
                    new SelectListItem{ Text="Stoppage", Value = "4" },
                    new SelectListItem{ Text="Custom’s Check", Value = "5" },
                    new SelectListItem{ Text="Wind Speed", Value = "6" },
                    new SelectListItem{ Text="Port Availability", Value = "8" },
                    new SelectListItem{ Text="Dock Availability", Value = "7" },
                    new SelectListItem{ Text="Labor Availability", Value = "6" }                   

            };
            ViewData["factors"] = effectingFactors;
            return View();
        }

        public IActionResult Privacy()
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
