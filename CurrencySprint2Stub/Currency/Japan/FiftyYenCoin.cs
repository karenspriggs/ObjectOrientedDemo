using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Japan
{
    public class FiftyYenCoin : YenCoin
    {
        public FiftyYenCoin()
        {
            this.MonetaryValue = 50m;
            this.Name = "Fifty Yen Coin";
            this.Year = 1983;
            this.Portait = "Chrysanthemum";
            this.ReverseMotif = "The number 50";
        }
    }
}
