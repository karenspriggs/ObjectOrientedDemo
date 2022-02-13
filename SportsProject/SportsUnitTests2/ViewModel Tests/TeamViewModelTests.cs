using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPFSports.ViewModels;
using SportsProject.Teams;
using SportsProject.Sports;
using SportsProject.Players;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.ObjectModel;

namespace SportsUnitTests2.ViewModel_Tests
{
    [TestClass]
    public class TeamViewModelTests
    {
        [TestMethod]
        public void TeamViewModelTest()
        {
            TeamViewModel TeamVM = new TeamViewModel();
            var mockSport = new Mock<ISport>();
            mockSport.Setup(s => s.TeamSize).Returns(5);
            mockSport.Setup(s => s.Teams).Returns(new List<ITeam>()); ;

            TeamVM.SelectedSport = mockSport.Object;
            TeamVM.NewTeamName = "New Team";

            object parameter = new object();

            TeamVM.ExecuteAddTeam(parameter);
            TeamVM.ExecuteAddTeam(parameter);

            Assert.IsTrue(TeamVM.CanAddTeam(parameter));
            Assert.AreEqual(TeamVM.CurrentTeams[0].Name, "New Team");
            Assert.AreEqual(TeamVM.CurrentTeams[0].Size, 5);
            Assert.AreEqual(TeamVM.CurrentTeams.Count, 2);

            TeamVM.SelectedTeam = TeamVM.CurrentTeams[0];
            TeamVM.ExecuteRemoveTeam(parameter);
            Assert.AreEqual(TeamVM.CurrentTeams.Count, 2);

            TeamVM.NewPlayerName = "New Player";
            TeamVM.NewPlayerID = 5;

            var mockTeam = new Mock<ITeam>();
            mockTeam.Setup(s => s.Lineup).Returns(new List<IPlayer>());
            TeamVM.TeamPlayers = new ObservableCollection<IPlayer>();
            TeamVM.SelectedTeam = mockTeam.Object;

            TeamVM.ExecuteAddPlayer(parameter);

            Assert.IsTrue(TeamVM.CanAddPlayer(parameter));
            Assert.AreEqual(TeamVM.TeamPlayers[0].Name, "New Player");
            Assert.AreEqual(TeamVM.TeamPlayers[0].ID, 5);

            TeamVM.ExecuteAddPlayer(parameter);

            Assert.AreEqual(TeamVM.TeamPlayers.Count, 2);

            TeamVM.SelectedPlayer = TeamVM.TeamPlayers[0];

            TeamVM.ExecuteRemovePlayer(parameter);

            Assert.AreEqual(TeamVM.TeamPlayers.Count, 1);

        }
    }
}
