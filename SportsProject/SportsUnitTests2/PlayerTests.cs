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
        Player player;

        public PlayerTests()
        {
            player = new Player("Default Name", 0);
        }

        [TestMethod]
        public void PlayerConstructorTest()
        {
            Assert.AreEqual(0, player.ID);
            Assert.AreEqual("Default Name", player.Name);
        }

        [TestMethod]
        public void UpdateDetailsTest()
        {
            player.Name = "John";
            player.ID = 13;

            player.UpdateDetails();
            string psdetails = player.Details;
            Assert.AreEqual(psdetails, "John 13.This player has won 0 times and lost 0 times.");
        }

        [TestMethod]
        public void UpdateStatsTest()
        {
            
            int beforewin = player.PlayerStats.Wins;
            player.PlayerWins();
            int afterwin = player.PlayerStats.Wins;

            int beforeloss = player.PlayerStats.Losses;
            player.PlayerLoses();
            int afterloss = player.PlayerStats.Losses;

            double beforerating = player.PlayerStats.Rating;
            player.UpdateStats();
            double afterrating = player.PlayerStats.Rating;

            Assert.AreEqual(0, beforewin);
            Assert.AreEqual(1, afterwin);
            Assert.AreEqual(0, beforerating);
            Assert.AreEqual(1, afterloss);
            Assert.AreEqual(0, beforerating);
            Assert.AreEqual(0, afterrating);
        }
    }
}
