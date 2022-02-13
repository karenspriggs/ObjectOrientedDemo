using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Currency.US
{
    [Serializable]
    public class Quarter : USCoin
    {
        public Quarter(USCoinMintMark MintMark)
        {
            this.Name = "Quarter";
            this.MonetaryValue = 0.25M;
            this.MintMark = MintMark;
        }

        public Quarter()
        {
            this.Name = "Quarter";
            this.MonetaryValue = 0.25M;
        }
    }
}
