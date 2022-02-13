using Currency;
using Currency.Japan;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
using System.Collections.Generic;

namespace UnitTestsCurrency
{
    [TestClass]
    public class MockCurrencyRepoTests
    {
        [TestMethod]
        public void MockRepoTests()
        {
            int initialcount;
            int onecount;
            string fakeabout;
            decimal faketotal;
            List<ICoin> coinlist = new List<ICoin>();

            var mockRepo = new Mock<ICurrencyRepo>();
            var mockCoin = new Mock<ICoin>();

            mockRepo.SetupProperty(x => x.Coins, coinlist);
            mockRepo.Setup(x => x.About()).Returns("Fake Currency Repo");
            mockRepo.Setup(x => x.GetCoinCount()).Returns(1);
            mockRepo.Setup(x => x.TotalValue()).Returns(0.5m);

            List<ICoin> defaultCoins = mockRepo.Object.Coins;
            initialcount = mockRepo.Object.Coins.Count;
            mockRepo.Object.AddCoin(new OneYenCoin());
            onecount = mockRepo.Object.GetCoinCount();
            fakeabout = mockRepo.Object.About();
            faketotal = mockRepo.Object.TotalValue();

            Assert.AreEqual(coinlist, defaultCoins);
            Assert.AreEqual(0, initialcount);
            Assert.AreEqual(1, onecount);
            Assert.AreEqual(0.5m, faketotal);
            Assert.AreEqual("Fake Currency Repo", fakeabout);
        }
    }
}
