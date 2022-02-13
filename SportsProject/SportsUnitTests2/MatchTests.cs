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
        public void ResultsTest()
        {
            string results1 = m.DetermineWinner(5, 1);
            
            string results2 = m.DetermineWinner(1, 5);
            
            string results3 = m.DetermineWinner(5, 5);

            Assert.AreEqual($"On {m.MatchTime}, {m.Team1.Name} and {m.Team2.Name} played against each other. {m.Team1.Name} won!", results1);
            Assert.AreEqual($"On {m.MatchTime}, {m.Team1.Name} and {m.Team2.Name} played against each other. {m.Team2.Name} won!", results2);
            Assert.AreEqual($"On {m.MatchTime}, {m.Team1.Name} and {m.Team2.Name} played against each other. The teams had a draw!", results3);

        }
    }
}
