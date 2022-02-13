using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Japan
{
    public class FiveHundredYenCoin : YenCoin
    {
        public FiveHundredYenCoin()
        {
            this.MonetaryValue = 500m;
            this.Name = "Five Hundred Yen Coin";
            this.Year = 2005;
            this.Portait = "Rice paddy field";
            this.ReverseMotif = "Airplane";
        }
    }
}
