using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AzureWebApp.Models;
using Microsoft.Extensions.Configuration;

namespace AzureWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IConfiguration congigurattion { get; private set; }

        public HomeController(IConfiguration configuration )
        {
            this.congigurattion = configuration;
        }
        public IActionResult Index()
        {
            var model = this.congigurattion["Greetings"];

            return View("index",model);
        }

        public IActionResult Test()
        {
            throw new InvalidOperationException("Not yet supported feature");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
