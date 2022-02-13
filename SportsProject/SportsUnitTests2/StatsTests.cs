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

            PlayerStats ps = new PlayerStats();

            Assert.AreEqual(0, ps.Wins);
            Assert.AreEqual(0, ps.Losses);
            Assert.AreEqual(0, ps.Rating);
            Assert.AreEqual($"This player has won {0} times and lost {0} times.", ps.Description);
            
        }
    }
}
