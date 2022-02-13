using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFSports.ViewModels;
using SportsProject.Teams;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SportsUnitTests2.ViewModel_Tests
{
    [TestClass]
    public class MatchViewModelTests
    {
        [TestMethod]
        public void MatchViewModelTest()
        {
            MatchViewModel MatchVM = new MatchViewModel();
            Team Team1 = new Team(5, "Team 1");
            Team Team2 = new Team(5, "Team 2");
            object parameter = new object();

            MatchVM.Team1 = Team1;
            MatchVM.Team2 = Team2;
            MatchVM.Score1 = 10;
            MatchVM.Score2 = 5;

            MatchVM.ExecuteSetTeams(parameter);
            MatchVM.ExecuteStartMatch(parameter);

            string match1 = MatchVM.Results;

            MatchVM.Score1 = 1;
            MatchVM.Score2 = 5;

            MatchVM.ExecuteSetTeams(parameter);
            MatchVM.ExecuteStartMatch(parameter);

            string match2 = MatchVM.Results;

            Assert.IsTrue(MatchVM.CanSetTeams(parameter));
            Assert.IsTrue(MatchVM.CanStartMatch(parameter));
            Assert.AreEqual(Team1.Name, MatchVM.Team1.Name);
            Assert.AreEqual(Team2.Name, MatchVM.Team2.Name);
            Assert.AreEqual(match1, $"On {MatchVM.Match.MatchTime}, Team 1 and Team 2 played against each other. Team 1 won!");
            Assert.AreEqual(match2, $"On {MatchVM.Match.MatchTime}, Team 1 and Team 2 played against each other. Team 2 won!");
        }
    }
}
