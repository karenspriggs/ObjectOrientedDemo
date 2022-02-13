using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class HelloController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public IActionResult Index(string Name)
        {
            ViewData["Message"] = Hello(Name, 14);
            return View();
        }

        public string Hello(string name, int ?age=0)
        {
            return $"Hello {name}, you are {age} years old.";
        }

        public string Goodbye(string name)
        {
            return $"Bye {name}.";
        }
    }
}
