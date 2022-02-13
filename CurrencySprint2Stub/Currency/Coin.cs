﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Currency
{
    [Serializable]
    public abstract class Coin : ICoin
    {
        
        public int Year { get; set; }
        // Changed MonetaryValue to a double as the test methods try to add the property to another value that is a double
        public decimal MonetaryValue { get; set; }
        //public double  CollectorsValue;
        public string Name { get; set; }
        public string Portait { get; set; }
        public string ReverseMotif { get; set; }

        public Coin()
        {
            this.Name = "Coin";
            this.Year = System.DateTime.Now.Year;
            
        }

        /// <summary>
        /// Tells infomation about a Coin
        /// </summary>
        /// <returns></returns>
        public virtual string About()
        {
            string strAbout = $"This {this.Name} is from {this.Year}. It is worth {this.MonetaryValue}.";
            return strAbout;
        }
    }    
}
