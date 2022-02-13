using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Currency.US
{
    [Serializable]
    public class Penny : USCoin
    {

        public Penny(USCoinMintMark MintMark)
        {
            this.Name = "Penny";
            this.MonetaryValue = 0.01M;
            this.Portait = "Abraham Lincoln";
            this.ReverseMotif = "Union shield";
            this.MintMark = MintMark;
        }

        public Penny() 
        {
            this.Name = "Penny";
            this.MonetaryValue = 0.01M;
            this.Portait = "Abraham Lincoln";
            this.ReverseMotif = "Union shield";
        }
    }
}
