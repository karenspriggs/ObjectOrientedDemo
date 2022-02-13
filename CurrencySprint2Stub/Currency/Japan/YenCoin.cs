using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Japan
{
    public abstract class YenCoin : Coin
    {
        public override string About()
        {
            string strAbout = $"{this.Name} is from {this.Year}. It is worth ${this.MonetaryValue}.";

            return "This " + strAbout;
        }

        public static List<ICoin> GetUSCoinList()
        {
            List<ICoin> coinList = new List<ICoin>();

            coinList.Add(new FiveHundredYenCoin());
            coinList.Add(new HundredYenCoin());
            coinList.Add(new FiftyYenCoin());
            coinList.Add(new TenYenCoin());
            coinList.Add(new OneYenCoin());

            return coinList;

        }
    }
}
