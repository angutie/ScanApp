using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mentor_3.Models;
using Microsoft.AspNetCore.Http;

namespace mentor_3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Scanner()
        {   
            var ClientInfo = new MyModel{
                Id = 1001,
                Location = "102",
                Address = "Client Address",
                ScannerId = "001"


            }
            return View();    
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            var data = new MyModel {
                MyData = DateTime.Now,
                Names = new List<string>() {"Jon","Andres","Josiah"},
                Money = 5.50,
            };

            return View(data);
        }

        [HttpPost]
    
        public ActionResult Scans(MyModel dataclein) {
            
            // Pull data from client dataclein
            // Save Data to data
            // Pull list of Data from datalist
            // Return list of data in model to client in view


            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    
}
