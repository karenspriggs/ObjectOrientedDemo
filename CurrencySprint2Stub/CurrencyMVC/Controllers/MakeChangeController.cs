using CurrencyMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Currency;
using Currency.US;

public class MakeChangeController : Controller
{
    ICurrencyRepo repo { get; set; }
    RepoViewModel vm;

    public MakeChangeController()
    {
        repo = new USCurrencyRepo();
        vm = new RepoViewModel(repo);
    }
    
    // GET: CurrencyRepo
    public ActionResult Index(decimal Amount)
    {
        vm.MakeChange(Amount);
        return View(vm);
    }

    
    [HttpPost]
    public ActionResult MakeChange(decimal Amount)
    {
        var change = repo.MakeChange(Amount);

        RepoViewModel vm1 = new RepoViewModel(change);
        return View(vm1);
    }
}