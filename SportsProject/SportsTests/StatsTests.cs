using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using SportsProject.Stats;

namespace SportsTests
{
    [TestClass]
    public class StatsTests
    {
        [TestMethod]
        public void TeamStatConstructorTest()
        {
            TeamStats ts = new TeamStats();

            Assert.AreEqual(0, ts.Wins);
            Assert.AreEqual(0, ts.Losses);
            Assert.AreEqual(0, ts.Rating);
            Assert.AreEqual("Default team description", ts.Description);
        }

        [TestMethod]
        public void PlayerStatConstructorTest()
        {
            StatsFPS fps = new StatsFPS();
            StatsMOBA moba = new StatsMOBA();

            Assert.AreEqual(0, fps.Wins);
            Assert.AreEqual(0, fps.Losses);
            Assert.AreEqual(0, fps.Rating);
            Assert.AreEqual(0, fps.Headshots);
            Assert.AreEqual("Default fps description", fps.Description);

            Assert.AreEqual(0, moba.Wins);
            Assert.AreEqual(0, moba.Losses);
            Assert.AreEqual(0, moba.Rating);
            Assert.AreEqual(0, moba.Gold);
            Assert.AreEqual(0, moba.Objectives);
            Assert.AreEqual("Default moba description", moba.Description);
        }
    }
}
