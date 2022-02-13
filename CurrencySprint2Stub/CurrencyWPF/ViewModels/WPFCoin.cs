using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using Currency;

namespace CurrencyWPF.ViewModels
{
    [Serializable]
    public class WPFCoin : INotifyPropertyChanged
    {
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        public ICoin coin;

        public WPFCoin(ICoin coin)
        {
            this.coin = coin;
        }

        public string Name
        {
            get
            {
                return this.coin.Name;
            }
            set
            {
                if (value != Name)
                {
                    this.coin.Name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }

        public decimal MonetaryValue
        {
            get
            {
                return this.coin.MonetaryValue;
            }
            set
            {
                if (value != MonetaryValue)
                {
                    this.coin.MonetaryValue = value;
                    RaisePropertyChanged("MonetaryValue");
                }
            }
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
