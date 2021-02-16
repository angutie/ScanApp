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
        private readonly ScanDatabaseContext _context;

        public HomeController(ILogger<HomeController> logger, ScanDatabaseContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            var data = new MyModel
            {
                MyData = DateTime.Now,
                Names = new List<string>() { "Jon", "Andres", "Josiah" },
                Money = 5.50,
            };

            return View(data);
        }

        public IActionResult Scans()
        {
            var ClientInfo = new MyModel
            {
                Id = 1001,
                Location = "102",
                Address = "Client Address",
                ScannerId = "001"


            };
            return View();
        }
        [HttpPost]

        public async Task<ActionResult<PostingScans>> ScansAsync(PostingScans data)
        {
            
            await this._context.Scans.AddAsync(data);
            await this._context.SaveChangesAsync();
            // Pull data from client dataclein
            // Save Data to data
            // Pull list of Data from datalist
            // Return list of data in model to client in view
            var scans = this._context.Scans.ToList();

            var log = new PageData
            {
                Scans = scans
            };
            return View(new PageData
            {
                Scans = scans
            });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }


}
