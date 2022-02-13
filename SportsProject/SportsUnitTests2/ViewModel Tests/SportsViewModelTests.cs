using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPFSports.ViewModels;
using SportsProject.Sports;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SportsUnitTests2.ViewModel_Tests
{
    [TestClass]
    public class SportsViewModelTests
    {
        [TestMethod]
        public void SportsViewModelTest()
        {
            SportsViewModel SportsVM = new SportsViewModel();
            SportsVM.NewSportName = "CSGO";
            SportsVM.NewSportSize = 6;

            object parameter = new object();

            SportsVM.ExecuteAddSport(parameter);

            string addsportname = SportsVM.CurrentSports[2].Name;

            SportsVM.RemovedSport = SportsVM.CurrentSports[1];

            SportsVM.ExecuteRemoveSport(parameter);

            string newsportname = SportsVM.CurrentSports[1].Name;

            Assert.IsTrue(SportsVM.CanAddSport(parameter));
            Assert.IsTrue(SportsVM.CanRemoveSport(parameter));
            Assert.AreEqual(addsportname, "CSGO");
            Assert.AreEqual(newsportname, "CSGO");
        }
    }
}
