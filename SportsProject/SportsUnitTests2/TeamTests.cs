using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using SportsProject.Teams;
using SportsProject.Stats;
using SportsProject.Players;
using Moq;

namespace SportsTests
{
    [TestClass]
    public class TeamTests
    {
        Team t;

        public TeamTests()
        {
            t = new Team(5, "Default Team");
        }

        [TestMethod]
        public void TeamConstructorTest()
        {
            Assert.AreEqual("Default Team", t.Name);
            Assert.AreEqual(5, t.Size);

            Assert.AreEqual("Default Player", t.Lineup[0].Name);
            Assert.AreEqual("Default Player", t.Lineup[1].Name);
            Assert.AreEqual("Default Player", t.Lineup[2].Name);
            Assert.AreEqual("Default Player", t.Lineup[3].Name);
            Assert.AreEqual("Default Player", t.Lineup[4].Name);
        }

        [TestMethod]
        public void UpdateTeamTests()
        {
            // Test update score, description, and rating methods
            int winbefore = t.TeamStats.Wins;
            t.TeamWins();
            int winafter = t.TeamStats.Wins;

            int losebefore = t.TeamStats.Losses;
            t.TeamLoses();
            int loseafter = t.TeamStats.Losses;

            Assert.AreEqual(0, winbefore);
            Assert.AreEqual(1, winafter);
            Assert.AreEqual(0, losebefore);
            Assert.AreEqual(1, loseafter);

            double ratingbefore = t.TeamStats.Rating;
            t.UpdatePlayerRating(10);
            t.UpdateRating();
            double ratingafter = t.TeamStats.Rating;

            Assert.AreEqual(0, ratingbefore);
            Assert.AreEqual(50, ratingafter);
        }

        [TestMethod]
        public void AddRemoveTests()
        {
            int beforeremove = t.Lineup.Count;
            t.RemovePlayer();
            int afterremove = t.Lineup.Count;

            var mockPlayer = new Mock<IPlayer>();
            t.AddPlayer(mockPlayer.Object);
            int afteradd = t.Lineup.Count;

            Assert.AreEqual(beforeremove, 5);
            Assert.AreEqual(afterremove, 4);
            Assert.AreEqual(afteradd, 5);
        }
    }
}
