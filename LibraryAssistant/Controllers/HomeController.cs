using LibraryAssistant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAssistant.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {                       
            try
                {
                    int s = int.Parse("error"); //Test excemption
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Exception found in Privacy page");
                }
                return View();
                        
        }

    }
}
