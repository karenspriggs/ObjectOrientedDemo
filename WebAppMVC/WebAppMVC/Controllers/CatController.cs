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
    public class CatController : Controller
    {
        private readonly ILogger<CatController> _logger;
        ICat cat;

        // If need to expand on this for a later assignment, add some cat breeds as classes
        List<ICat> cats = new List<ICat>()
        {
            new Cat("bob", 11, "bob the siamese cat"),
            new Cat("chris", 5, "chris the tabby cat"),
            new Cat("joe", 6, "joe the munchkin cat")
        };

        public CatController()
        {
            cat = new Cat();
        }

        public IActionResult Index()
        {
            return View(cats);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Details(string Name)
        {
            return View(cats.Where(n => n.Name == Name).FirstOrDefault());
        }

        public IActionResult Edit(string Name)
        {
            return View(cats.Where(n => n.Name == Name).FirstOrDefault());
        }
        public IActionResult Delete(string Name)
        {
            return View(cats.Where(n => n.Name == Name).FirstOrDefault());
        }

    }
}
