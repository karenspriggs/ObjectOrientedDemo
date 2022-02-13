using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using Currency;
using Currency.US;

namespace CurrencyWPF.ViewModels
{
    [Serializable]
    public class WPFCurrencyRepo : INotifyPropertyChanged
    {
        // Commands and stuff
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        [field: NonSerialized]
        public ICommand MakeChange { get; set; }
        [field: NonSerialized]
        public ICommand AddCoin { get; set; }
        [field: NonSerialized]
        public ICommand AddPenny { get; set; }
        [field: NonSerialized]
        public ICommand AddNickel { get; set; }
        [field: NonSerialized]
        public ICommand AddDime { get; set; }
        [field: NonSerialized]
        public ICommand AddQuarter { get; set; }
        [field: NonSerialized]
        public ICommand AddHalfDollar { get; set; }
        [field: NonSerialized]
        public ICommand AddDollar { get; set; }

        // Properties
        public ICurrencyRepo currencyrepo;
        private string listcoins { get; set; }
        private decimal totalvalue { get; set; }
        private decimal changeamount { get; set; }

        // Constructor
        public WPFCurrencyRepo(ICurrencyRepo repo)
        {
            this.currencyrepo = repo;
            //Commands
            this.MakeChange = new CoinCommand(ExecuteMakeChange, CanMakeChange);
            this.AddCoin = new CoinCommand(ExecuteAddCoin, CanAddCoin);
            this.AddPenny = new CoinCommand(ExecuteAddPenny, CanAddPenny);
            this.AddNickel = new CoinCommand(ExecuteAddNickel, CanAddNickel);
            this.AddDime = new CoinCommand(ExecuteAddDime, CanAddDime);
            this.AddQuarter = new CoinCommand(ExecuteAddQuarter, CanAddQuarter);
            this.AddHalfDollar = new CoinCommand(ExecuteAddHalfDollar, CanAddHalfDollar);
            this.AddDollar = new CoinCommand(ExecuteAddDollarCoin, CanAddDollarCoin);
        }
        private bool CanMakeChange(object parameter)
        {
            return true;
        }
        private void ExecuteMakeChange(object parameter)
        {
            RaisePropertyChanged("changeamount");

            CurrencyRepo changerepo = new CurrencyRepo();
            ICurrencyRepo newrepo = changerepo.CreateChange(changeamount);
            currencyrepo.Coins = newrepo.Coins;
            listcoins = MakeListCoins();
            totalvalue = currencyrepo.TotalValue();
            RaisePropertyChanged("Coins");
            RaisePropertyChanged("TotalValue");
            RaisePropertyChanged("ListCoins");
        }

        private bool CanAddCoin(object parameter)
        {
            return true;
        }

        private void ExecuteAddCoin(object parameter)
        {
            RaisePropertyChanged("Coins");
        }

        private bool CanAddPenny(object parameter)
        {
            return true;
        }

        private void ExecuteAddPenny(object parameter)
        {
            Penny p = new Penny();
            currencyrepo.AddCoin(p);
            listcoins = MakeListCoins();
            totalvalue += 0.01M;
            RaisePropertyChanged("TotalValue");
            RaisePropertyChanged("ListCoins");
            RaisePropertyChanged("Coins");
        }

        private bool CanAddNickel(object parameter)
        {
            return true;
        }

        private void ExecuteAddNickel(object parameter)
        {
            listcoins = MakeListCoins();
            totalvalue += 0.05M;
            RaisePropertyChanged("TotalValue");
            RaisePropertyChanged("ListCoins");
            currencyrepo.AddCoin(new Nickel());
            RaisePropertyChanged("Coins");
        }

        private bool CanAddDime(object parameter)
        {
            return true;
        }

        private void ExecuteAddDime(object parameter)
        {
            listcoins = MakeListCoins();
            totalvalue += 0.10M;
            RaisePropertyChanged("TotalValue");
            RaisePropertyChanged("ListCoins");
            currencyrepo.AddCoin(new Dime());
            RaisePropertyChanged("Coins");
        }

        private bool CanAddQuarter(object parameter)
        {
            return true;
        }
        private void ExecuteAddQuarter(object parameter)
        {
            listcoins = MakeListCoins();
            totalvalue += 0.25M;
            RaisePropertyChanged("TotalValue");
            RaisePropertyChanged("ListCoins");
            currencyrepo.AddCoin(new Quarter());
            RaisePropertyChanged("Coins");
        }

        private bool CanAddHalfDollar(object parameter)
        {
            return true;
        }
        private void ExecuteAddHalfDollar(object parameter)
        {
            listcoins = MakeListCoins();
            totalvalue += 0.5M;
            RaisePropertyChanged("TotalValue");
            RaisePropertyChanged("ListCoins");
            currencyrepo.AddCoin(new HalfDollar());
            RaisePropertyChanged("Coins");
        }

        private bool CanAddDollarCoin(object parameter)
        {
            return true;
        }
        private void ExecuteAddDollarCoin(object parameter)
        {
            listcoins = MakeListCoins();
            totalvalue += 1M;
            RaisePropertyChanged("TotalValue");
            RaisePropertyChanged("ListCoins");
            currencyrepo.AddCoin(new DollarCoin());
            RaisePropertyChanged("Coins");
        }

        public string ListCoins
        {
            get
            {
                return listcoins;
            }
            set
            {
                if (value != ListCoins)
                {
                    this.listcoins = value;
                    RaisePropertyChanged("ListCoins");
                }
            }
        }

        public decimal TotalValue
        {
            get
            {
                return totalvalue;
            }
            set
            {
                if (value != TotalValue)
                {
                    this.totalvalue = value;
                    RaisePropertyChanged("TotalValue");
                }
            }
        }

        public decimal ChangeAmount
        {
            get
            {
                return changeamount;
            }
            set
            {
                if (value != ChangeAmount)
                {
                    this.changeamount = value;
                    RaisePropertyChanged("ChangeAmount");
                }
            }
        }

        public List<ICoin> Coins
        {
            get
            {
                return this.currencyrepo.Coins;
            }
            set
            {
                if (value != Coins)
                {
                    this.currencyrepo.Coins = value;
                    RaisePropertyChanged("Coins");
                }
            }
        }

        public string MakeListCoins()
        {
            string message = "";

            if (currencyrepo.Coins.Count == 0)
            {
                return message;
            }

            foreach (ICoin i in currencyrepo.Coins)
            {
                message += i.Name;
                message += " ";
            }

            return message;
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
