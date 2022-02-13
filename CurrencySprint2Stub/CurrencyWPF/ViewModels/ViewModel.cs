using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using Currency;
using Currency.US;
using CurrencyWPF.Serializing;

namespace CurrencyWPF.ViewModels
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand saveRepo { get; set; }
        public ICommand loadRepo { get; set; }
        public ICommand newRepo { get; set; }

        private WPFCurrencyRepo currencyRepo;
        private WPFRepoSaver repoSaver;

        public ViewModel()
        {
            repoSaver = new WPFRepoSaver();
            FillRepo();
            CurrencyRepo.MakeListCoins();
            this.saveRepo = new CoinCommand(ExecuteSaveRepo, CanSaveRepo);
            this.loadRepo = new CoinCommand(ExecuteLoadRepo, CanLoadRepo);
            this.newRepo = new CoinCommand(ExecuteNewRepo, CanNewRepo);
        }

        public WPFCurrencyRepo CurrencyRepo
        {
            get
            {
                return currencyRepo;
            }
        }

        public WPFRepoSaver RepoSaver
        {
            get
            {
                return repoSaver;
            }
        }

        private bool CanSaveRepo(object parameter)
        {
            return true;
        }

        private void ExecuteSaveRepo(object parameter)
        {
            //repoSaver.currencyRepo = currencyRepo;
            repoSaver.currencyRepo.Coins.Clear();
            repoSaver.currencyRepo.Coins = currencyRepo.Coins;
            repoSaver.SaveTo();
        }

        private bool CanLoadRepo(object parameter)
        {
            return true;
        }

        private void ExecuteLoadRepo(object parameter)
        {
            WPFCurrencyRepo loadRepo = repoSaver.Load();

            if (currencyRepo.Coins != repoSaver.currencyRepo.Coins)
            {
                currencyRepo.Coins = loadRepo.currencyrepo.Coins;
                currencyRepo.TotalValue = currencyRepo.currencyrepo.TotalValue();
                currencyRepo.ListCoins = currencyRepo.MakeListCoins();
            }

            RaisePropertyChanged("CurrencyRepo");
        }

        private bool CanNewRepo(object parameter)
        {
            return true;
        }

        private void ExecuteNewRepo(object parameter)
        {
            currencyRepo.TotalValue = 0;
            currencyRepo.ListCoins = "";
            currencyRepo.Coins.Clear();
            RaisePropertyChanged("CurrencyRepo");
        }

        public void FillRepo()
        {
            CurrencyRepo newrepo = new CurrencyRepo();
            newrepo.Coins.Add(new Penny());
            newrepo.Coins.Add(new Nickel());
            newrepo.Coins.Add(new Dime());
            currencyRepo = new WPFCurrencyRepo(newrepo);
            currencyRepo.TotalValue = currencyRepo.currencyrepo.TotalValue();
            currencyRepo.ListCoins = currencyRepo.MakeListCoins();
        }

        public void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
