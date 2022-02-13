using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Japan
{
    public class FiveYenCoin : YenCoin
    {
        public FiveYenCoin()
        {
            this.MonetaryValue = 5m;
            this.Name = "Five Yen Coin";
            this.Year = 2003;
            this.Portait = "Rice, water, and a gear";
            this.ReverseMotif = "Tree sprouts";
        }
    }
}
