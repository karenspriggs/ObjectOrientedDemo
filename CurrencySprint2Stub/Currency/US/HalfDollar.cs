﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Currency.US
{
    [Serializable]
    public class HalfDollar : USCoin
    {
        public HalfDollar()
        {
            this.MonetaryValue = .50M;
            this.Name = "Half Dollar";
        }
    }
}
