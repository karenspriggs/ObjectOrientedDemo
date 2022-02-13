using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using SportsProject.Teams;
using SportsProject.Stats;
using SportsProject.Players;

namespace SportsTests
{
    [TestClass]
    public class TeamTests
    {
        Team t;

        public TeamTests()
        {
            t = new Team(5, "Default Team");
            t.Lineup[0] = new PlayerFPS("Default Name 1", 0, "Default Role");
            t.Lineup[1] = new PlayerFPS("Default Name 2", 0, "Default Role");
            t.Lineup[2] = new PlayerFPS("Default Name 3", 0, "Default Role");
            t.Lineup[3] = new PlayerFPS("Default Name 4", 0, "Default Role");
            t.Lineup[4] = new PlayerFPS("Default Name 5", 0, "Default Role");
        }

        [TestMethod]
        public void TeamConstructorTest()
        {
            Assert.AreEqual("Default Team", t.Name);
            Assert.AreEqual(5, t.Size);

            Assert.AreEqual("Default Name 1", t.Lineup[0].Name);
            Assert.AreEqual("Default Name 2", t.Lineup[1].Name);
            Assert.AreEqual("Default Name 3", t.Lineup[2].Name);
            Assert.AreEqual("Default Name 4", t.Lineup[3].Name);
            Assert.AreEqual("Default Name 5", t.Lineup[4].Name);
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
        public void AddPlayerTest()
        {
            PlayerFPS newplayer = new PlayerFPS("New Player", 0, "New Role");

            Assert.AreEqual("Default Name 1", t.Lineup[0].Name);

            t.AddPlayer(newplayer, 0);

            Assert.AreEqual("New Player", t.Lineup[0].Name);
        }
    }
}
