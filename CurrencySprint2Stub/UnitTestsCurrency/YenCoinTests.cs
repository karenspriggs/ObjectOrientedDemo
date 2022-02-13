using Currency;
using Currency.Japan;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestsCurrency
{
    [TestClass]
    public class YenCoinTests
    {
        [TestMethod]
        public void OneYenTest()
        {
            OneYenCoin y = new OneYenCoin();

            Assert.AreEqual("One Yen Coin", y.Name);
            Assert.AreEqual(2010, y.Year);
            Assert.AreEqual(1m, y.MonetaryValue);
            Assert.AreEqual("Young tree", y.Portait);
            Assert.AreEqual("Number 1 in circle", y.ReverseMotif);

        }

        [TestMethod]
        public void FiveYenTest()
        {
            FiveYenCoin y = new FiveYenCoin();

            Assert.AreEqual("Five Yen Coin", y.Name);
            Assert.AreEqual(2003, y.Year);
            Assert.AreEqual(5m, y.MonetaryValue);
            Assert.AreEqual("Rice, water, and a gear", y.Portait);
            Assert.AreEqual("Tree sprouts", y.ReverseMotif);

        }

        [TestMethod]
        public void TenYenTest()
        {
            TenYenCoin y = new TenYenCoin();

            Assert.AreEqual("Ten Yen Coin", y.Name);
            Assert.AreEqual(1994, y.Year);
            Assert.AreEqual(10m, y.MonetaryValue);
            Assert.AreEqual("Phoenix Hall", y.Portait);
            Assert.AreEqual("Bay laurel leaves", y.ReverseMotif);

        }

        [TestMethod]
        public void FiftyYenTest()
        {
            FiftyYenCoin y = new FiftyYenCoin();

            Assert.AreEqual("Fifty Yen Coin", y.Name);
            Assert.AreEqual(1983, y.Year);
            Assert.AreEqual(50m, y.MonetaryValue);
            Assert.AreEqual("Chrysanthemum", y.Portait);
            Assert.AreEqual("The number 50", y.ReverseMotif);

        }

        [TestMethod]
        public void HundredYenTest()
        {
            HundredYenCoin y = new HundredYenCoin();

            Assert.AreEqual("One Hundred Yen Coin", y.Name);
            Assert.AreEqual(1970, y.Year);
            Assert.AreEqual(100m, y.MonetaryValue);
            Assert.AreEqual("Mountain", y.Portait);
            Assert.AreEqual("Expo 70 Logo", y.ReverseMotif);

        }

        public void FiveHundredYenTest()
        {
            FiveHundredYenCoin y = new FiveHundredYenCoin();

            Assert.AreEqual("Five Hundred Yen Coin", y.Name);
            Assert.AreEqual(2005, y.Year);
            Assert.AreEqual(1m, y.MonetaryValue);
            Assert.AreEqual("Rice paddy field", y.Portait);
            Assert.AreEqual("Airplane", y.ReverseMotif);
        }
    }
}
