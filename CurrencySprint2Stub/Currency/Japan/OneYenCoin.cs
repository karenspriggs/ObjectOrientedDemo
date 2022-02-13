using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Japan
{
    public class  OneYenCoin : YenCoin
    {
        public OneYenCoin()
        {
            this.MonetaryValue = 1m;
            this.Name = "One Yen Coin";
            this.Year = 2010;
            this.Portait = "Young tree";
            this.ReverseMotif = "Number 1 in circle";
        }
    }
}
