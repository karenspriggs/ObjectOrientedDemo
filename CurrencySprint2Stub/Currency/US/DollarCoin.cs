using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Currency.US
{
    [Serializable]
    public class DollarCoin : USCoin
    {
        public DollarCoin(USCoinMintMark MintMark)
        {
            this.Name = "Dollar Coin";
            this.MonetaryValue = 1.0M;
            this.MintMark = MintMark;
        }

        public DollarCoin() 
        {
            this.Name = "Dollar Coin";
            this.MonetaryValue = 1.0M;
        }
    }
}