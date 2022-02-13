using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using SportsProject.Matches;
using SportsProject.Teams;
using Moq;

namespace SportsTests
{
    [TestClass]
    public class MatchTests
    {
        SportsProject.Matches.Match m;
        public MatchTests()
        {
            var mockTeam1 = new Mock<ITeam>();
            mockTeam1.Setup(s => s.Name).Returns("Team 1");
            var mockTeam2 = new Mock<ITeam>();
            mockTeam2.Setup(s => s.Name).Returns("Team 2");

            m = new SportsProject.Matches.Match(mockTeam1.Object, mockTeam2.Object);
        }

        [TestMethod]
        public void SetTimeTest()
        {
            Assert.AreEqual(DateTime.Now.Date, m.MatchTime);
        }

        [TestMethod]
        public void ResultsTest()
        {
            // Check the methods that set the winning team and update the results for those teams
            // Make sure it updates the ratings of the players as well

            m.DetermineWinner(5, 1);
            string results1 = m.Results;
            m.DetermineWinner(1, 5);
            string results2 = m.Results;
            m.DetermineWinner(5, 5);
            string results3 = m.Results;

            Assert.AreEqual($"Team 1 won!", results1);
            Assert.AreEqual($"Team 2 won!", results2);
            Assert.AreEqual($"Team 1 and Team 2 had a draw!", results3);

        }
    }
}
