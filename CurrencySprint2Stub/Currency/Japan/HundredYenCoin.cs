using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Japan
{
    public class HundredYenCoin : YenCoin
    {
        public HundredYenCoin()
        {
            this.MonetaryValue = 100m;
            this.Name = "One Hundred Yen Coin";
            this.Year = 1970;
            this.Portait = "Mountain";
            this.ReverseMotif = "Expo 70 Logo";
        }
    }
}
