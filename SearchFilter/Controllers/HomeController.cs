using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SearchFilter.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SearchFilter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext db;

        public HomeController(ILogger<HomeController> logger,
                              AppDbContext context)
        {
            _logger = logger;
            db = context;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var players = from p in db.Players select p;
            //if(!String.IsNullOrEmpty(searchString))
            if (searchString != null)
            {
                players = players.Where(n => n.Name.Contains(searchString) || n.Country.Contains(searchString));
            }
            return View(await players.ToListAsync());
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
