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

public class CurrencyRepoController : Controller
{
    ICurrencyRepo repo { get; set; }
    RepoViewModel vm;

    public CurrencyRepoController()
    {
        repo = new USCurrencyRepo();
        repo.AddCoin(new Penny());
        vm = new RepoViewModel(repo);
    }

    // GET: CurrencyRepo
    public ActionResult Index()
    {
        return View(vm);
    }
}