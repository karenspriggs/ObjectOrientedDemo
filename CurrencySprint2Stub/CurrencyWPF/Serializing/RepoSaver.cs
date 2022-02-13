using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Currency;
using Currency.US;
using CurrencyWPF.ViewModels;

namespace CurrencyWPF.Serializing
{
    [Serializable]
    public class RepoSaver
    {
        public WPFCurrencyRepo currencyRepo;
        public Coin coin { get; set; }

        public RepoSaver()
        {
            LoadRepo();
        }

        public void LoadRepo()
        {
            CurrencyRepo newrepo = new CurrencyRepo();
            newrepo.Coins.Add(new Penny());
            newrepo.Coins.Add(new Penny());
            newrepo.Coins.Add(new Penny());
            newrepo.Coins.Add(new Nickel());
            newrepo.Coins.Add(new Dime());
            currencyRepo = new WPFCurrencyRepo(newrepo);
            currencyRepo.TotalValue = currencyRepo.currencyrepo.TotalValue();
            currencyRepo.ListCoins = currencyRepo.currencyrepo.About();
        }
    }
}
