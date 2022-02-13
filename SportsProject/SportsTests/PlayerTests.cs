using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using SportsProject.Stats;
using SportsProject.Players;
using Moq;

namespace SportsTests
{
    [TestClass]
    public class PlayerTests
    {
        PlayerFPS pfps;
        PlayerMOBA pmoba;

        public PlayerTests()
        {
            pfps = new PlayerFPS("Default Name", 0, "Default Role");
            pmoba = new PlayerMOBA("Default Name", 0, "Default Position", "Default Main");
        }

        [TestMethod]
        public void PlayerConstructorTest()
        {
            Assert.AreEqual(0, pfps.ID);
            Assert.AreEqual("Default Name", pfps.Name);
            Assert.AreEqual(0, pfps.PlayerStats.Losses);
            Assert.AreEqual("Default Role", pfps.Role);

            Assert.AreEqual(0, pmoba.ID);
            Assert.AreEqual("Default Name", pmoba.Name);
            Assert.AreEqual(0, pmoba.PlayerStats.Losses);
            Assert.AreEqual("Default Position", pmoba.Position);
            Assert.AreEqual("Default Main", pmoba.Main);

        }

        [TestMethod]
        public void UpdateDetailsTest()
        {
            // Make sure it works as intended with the player subclasses
            pfps.UpdateDetails();
            string fpsdetails = pfps.Details;
            pmoba.UpdateDetails();
            string mobadetails = pmoba.Details;

            Assert.AreEqual("Default Name: 0 Default Role", fpsdetails);
            Assert.AreEqual("Default Name: 0 Default Position Default Main", mobadetails);
        }

        [TestMethod]
        public void UpdateStatsTest()
        {
            int beforewin = pfps.PlayerStats.Wins;
            pfps.PlayerWins();
            int afterwin = pfps.PlayerStats.Wins;

            int beforeloss = pfps.PlayerStats.Losses;
            pfps.PlayerLoses();
            int afterloss = pfps.PlayerStats.Losses;

            double beforerating = pfps.PlayerStats.Rating;
            pfps.UpdateStats();
            double afterrating = pfps.PlayerStats.Rating;

            Assert.AreEqual(0, beforewin);
            Assert.AreEqual(1, afterwin);
            Assert.AreEqual(0, beforerating);
            Assert.AreEqual(1, afterloss);
            Assert.AreEqual(0, beforerating);
            Assert.AreEqual(0.5, afterrating);
        }
    }
}
