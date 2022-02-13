using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Japan
{
    public class TenYenCoin : YenCoin
    {
        public TenYenCoin()
        {
            this.MonetaryValue = 10m;
            this.Name = "Ten Yen Coin";
            this.Year = 1994;
            this.Portait = "Phoenix Hall";
            this.ReverseMotif = "Bay laurel leaves";
        }
    }
}
