using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Currency.US
{
    [Serializable]
    public class Nickel : USCoin
    {
        public Nickel(USCoinMintMark MintMark)
        {
            this.Name = "Nickel";
            this.MonetaryValue = 0.05M;
            this.Portait = "Thomas Jefferson";
            this.ReverseMotif = "Monticello";
            this.MintMark = MintMark;
        }

        public Nickel() : this(USCoinMintMark.D)
        {
            this.Name = "Nickel";
            this.MonetaryValue = 0.05M;
            this.Portait = "Thomas Jefferson";
            this.ReverseMotif = "Monticello";
        }
    }
}
