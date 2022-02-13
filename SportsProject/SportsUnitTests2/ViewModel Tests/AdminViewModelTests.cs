using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPFSports.ViewModels;
using SportsWPF.Models.Serialization;
namespace SportsUnitTests2.ViewModel_Tests
{
    [TestClass]
    public class AdminViewModelTests
    {
        [TestMethod]
        public void AdminViewModelTest()
        {
            AdminViewModel AdminVM = new AdminViewModel();

            Assert.IsInstanceOfType(AdminVM.TeamVM, typeof(TeamViewModel));
            Assert.IsInstanceOfType(AdminVM.MatchVM, typeof(MatchViewModel));
            Assert.IsInstanceOfType(AdminVM.SportsVM, typeof(SportsViewModel));
        }
    }
}
