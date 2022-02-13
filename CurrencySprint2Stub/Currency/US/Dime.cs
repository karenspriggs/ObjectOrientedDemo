using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Currency.US
{
    [Serializable]
    public class Dime : USCoin
    {
        public Dime(USCoinMintMark MintMark)
        {
            this.Name = "Dime";
            this.MonetaryValue = 0.1M;
            this.Portait = "Franklin D. Roosevelt";
            this.ReverseMotif = "torch, oak branch, olive branch";
            this.MintMark = MintMark;
        }

        public Dime() 
        {
            this.Name = "Dime";
            this.Portait = "Franklin D. Roosevelt";
            this.ReverseMotif = "torch, oak branch, olive branch";
            this.MonetaryValue = 0.10M;
        }
    }
}
