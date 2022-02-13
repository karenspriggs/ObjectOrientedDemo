using Currency;
using Currency.Japan;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestsCurrency
{
    [TestClass]
    public class YenRepoTests
    {
        ICurrencyRepo repo;
        OneYenCoin oneyen;
        FiveYenCoin fiveyen;
        TenYenCoin tenyen;
        FiftyYenCoin fiftyyen;
        HundredYenCoin hundredyen;
        FiveHundredYenCoin fivehundredyen;

        public YenRepoTests()
        {
            repo = new YenCurrencyRepo();
            oneyen = new OneYenCoin();
            fiveyen = new FiveYenCoin();
            tenyen = new TenYenCoin();
            fiftyyen = new FiftyYenCoin();
            hundredyen = new HundredYenCoin();
            fivehundredyen = new FiveHundredYenCoin();
        }

        [TestMethod]
        public void AddCoinTest()
        {
            int numYen = 5;
            int initialcount = repo.GetCoinCount();
            decimal initialvalue = repo.TotalValue();

            repo.AddCoin(oneyen);
            int countAfterOneYen = repo.GetCoinCount();
            decimal amountAfterOneYen = repo.TotalValue();

            for (int i = 0; i < numYen; i++)
            {
                repo.AddCoin(oneyen);
            }
            int countAfterFive = repo.GetCoinCount();
            decimal valueAfterFive = repo.TotalValue();

            repo.AddCoin(fiveyen);
            decimal valueAfterFiveCoin = repo.TotalValue();
            repo.AddCoin(tenyen);
            decimal valueAfterTen = repo.TotalValue();
            repo.AddCoin(fiftyyen);
            decimal valueAfterFifty = repo.TotalValue();
            repo.AddCoin(hundredyen);
            decimal valueAfterHundred = repo.TotalValue();
            repo.AddCoin(fivehundredyen);
            decimal valueAfterFiveHundred = repo.TotalValue();

            Assert.AreEqual(initialcount + 1, countAfterOneYen);
            Assert.AreEqual(countAfterOneYen + numYen, countAfterFive);

            Assert.AreEqual(initialvalue + oneyen.MonetaryValue, amountAfterOneYen);
            Assert.AreEqual(amountAfterOneYen + (numYen * oneyen.MonetaryValue), valueAfterFive);

            Assert.AreEqual(valueAfterFive + fiveyen.MonetaryValue, valueAfterFiveCoin);
            Assert.AreEqual(valueAfterFiveCoin + tenyen.MonetaryValue, valueAfterTen);
            Assert.AreEqual(valueAfterTen + fiftyyen.MonetaryValue, valueAfterFifty);
            Assert.AreEqual(valueAfterFifty + hundredyen.MonetaryValue, valueAfterHundred);
            Assert.AreEqual(valueAfterHundred + fivehundredyen.MonetaryValue, valueAfterFiveHundred);
        }


        [TestMethod]
        public void RemoveCoinTest()
        {
            int numYen = 5;

            repo = new YenCurrencyRepo();  
            repo.AddCoin(oneyen);
            for (int i = 0; i < numYen; i++)
            {
                repo.AddCoin(oneyen);
            }
            repo.AddCoin(fiveyen);
            repo.AddCoin(tenyen);
            repo.AddCoin(fiftyyen);
            repo.AddCoin(hundredyen);
            repo.AddCoin(fivehundredyen);

            //Act
            int initialcount = repo.GetCoinCount();
            decimal initialvalue = repo.TotalValue();
            repo.RemoveCoin(oneyen);
            int countAfterOneYen = repo.GetCoinCount();
            decimal amountAfterOneYen = repo.TotalValue();

            for (int i = 0; i < numYen; i++)
            {
                repo.RemoveCoin(oneyen);
            }
            int countAfterFive = repo.GetCoinCount() + 1;
            decimal valueAfterFive = repo.TotalValue();

            repo.RemoveCoin(fiveyen);
            decimal valueAfterFiveCoin = repo.TotalValue();
            repo.RemoveCoin(tenyen);
            decimal valueAfterTen = repo.TotalValue();
            repo.RemoveCoin(fiftyyen);
            decimal valueAfterFifty = repo.TotalValue();
            repo.RemoveCoin(hundredyen);
            decimal valueAfterHundred = repo.TotalValue();
            repo.RemoveCoin(fivehundredyen);
            decimal valueAfterFiveHundred = repo.TotalValue();


            //Assert
            Assert.AreEqual(initialcount - 1, countAfterOneYen);
            Assert.AreEqual(initialcount - numYen, countAfterFive);

            Assert.AreEqual(initialvalue - oneyen.MonetaryValue, amountAfterOneYen);
            Assert.AreEqual(amountAfterOneYen - (numYen * oneyen.MonetaryValue), valueAfterFive);

            Assert.AreEqual(valueAfterFive - fiveyen.MonetaryValue, valueAfterFiveCoin);
            Assert.AreEqual(valueAfterFiveCoin - tenyen.MonetaryValue, valueAfterTen);
            Assert.AreEqual(valueAfterTen - fiftyyen.MonetaryValue, valueAfterFifty);
            Assert.AreEqual(valueAfterFifty - hundredyen.MonetaryValue, valueAfterHundred);
            Assert.AreEqual(valueAfterHundred - fivehundredyen.MonetaryValue, valueAfterFiveHundred);

        }

        [TestMethod]
        public void MakeChangeTests()
        {

            YenCurrencyRepo changerepo = new YenCurrencyRepo();
            YenCurrencyRepo changeTwoHundred = (YenCurrencyRepo)YenCurrencyRepo.CreateChange(2m);
            YenCurrencyRepo changeOneFifty = (YenCurrencyRepo)YenCurrencyRepo.CreateChange(150m);
            YenCurrencyRepo changeSixty = (YenCurrencyRepo)YenCurrencyRepo.CreateChange(60m);

            YenCurrencyRepo changeEleven = (YenCurrencyRepo)YenCurrencyRepo.CreateChange(11m);
            YenCurrencyRepo changeSix = (YenCurrencyRepo)YenCurrencyRepo.CreateChange(6m);
            YenCurrencyRepo changeFour = (YenCurrencyRepo)YenCurrencyRepo.CreateChange(4m);

            Assert.AreEqual(changeTwoHundred.Coins.Count, 2);
            Assert.AreEqual(changeTwoHundred.Coins[0].GetType(), new HundredYenCoin().GetType());
            Assert.AreEqual(changeTwoHundred.Coins[1].GetType(), new HundredYenCoin().GetType());

            Assert.AreEqual(changeOneFifty.Coins.Count, 2);
            Assert.AreEqual(changeOneFifty.Coins[0].GetType(), new HundredYenCoin().GetType());
            Assert.AreEqual(changeOneFifty.Coins[1].GetType(), new FiftyYenCoin().GetType());


            Assert.AreEqual(changeSixty.Coins.Count, 2);
            Assert.AreEqual(changeSixty.Coins[0].GetType(), new FiftyYenCoin().GetType());
            Assert.AreEqual(changeSixty.Coins[1].GetType(), new TenYenCoin().GetType());

            Assert.AreEqual(changeEleven.Coins.Count, 2);
            Assert.AreEqual(changeEleven.Coins[0].GetType(), new TenYenCoin().GetType());
            Assert.AreEqual(changeEleven.Coins[1].GetType(), new OneYenCoin().GetType());

            Assert.AreEqual(changeSix.Coins.Count, 2);
            Assert.AreEqual(changeSix.Coins[0].GetType(), new FiveYenCoin().GetType());
            Assert.AreEqual(changeSix.Coins[1].GetType(), new OneYenCoin().GetType());


            Assert.AreEqual(4, changeFour.Coins.Count);
            Assert.AreEqual(changeFour.Coins[0].GetType(), new OneYenCoin().GetType());
            Assert.AreEqual(changeFour.Coins[1].GetType(), new OneYenCoin().GetType());
            Assert.AreEqual(changeFour.Coins[2].GetType(), new OneYenCoin().GetType());
            Assert.AreEqual(changeFour.Coins[3].GetType(), new OneYenCoin().GetType());

        }
    }
}
