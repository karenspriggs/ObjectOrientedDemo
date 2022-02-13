using Currency;
using Currency.Japan;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
using System.Collections.Generic;

namespace UnitTestsCurrency
{
    [TestClass]
    public class MockCoinTests
    {
        [TestMethod]
        public void TestAboutCoins()
        {
            var mockCoin = new Mock<ICoin>();

            mockCoin.SetupProperty(mc => mc.Year, 2001);
            mockCoin.SetupProperty(mc => mc.Name, "Coin");
            mockCoin.SetupProperty(mc => mc.MonetaryValue, 0.1m);
            mockCoin.Setup(mc => mc.About()).Returns("Fake Coin");

            decimal value = mockCoin.Object.MonetaryValue;
            int year = mockCoin.Object.Year;
            string name = mockCoin.Object.Name;
            string about = mockCoin.Object.About();

            Assert.AreEqual(2001, year);
            Assert.AreEqual(0.1m, value);
            Assert.AreEqual("Coin", name);
            Assert.AreEqual("Fake Coin", about);

        }

        [TestMethod]
        public void TestBankNote()
        {
            var mockBankNote = new Mock<IBankNote>();

            mockBankNote.SetupProperty(b => b.MonetaryValue, 1m);
            mockBankNote.SetupProperty(b => b.Name, "Banknote");
            mockBankNote.Setup(mc => mc.About()).Returns("Fake Bank Note");

            string name = mockBankNote.Object.Name;
            decimal value = mockBankNote.Object.MonetaryValue;
            string about = mockBankNote.Object.About();

            Assert.AreEqual("Banknote", name);
            Assert.AreEqual("Fake Bank Note", about);
            Assert.AreEqual(1m, value);
        }
    }
}
