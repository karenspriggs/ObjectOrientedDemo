using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using SportsProject.Sports;

namespace SportsTests
{
    [TestClass]
    public class SportTests
    {
        Overwatch ow = new Overwatch();
        League le = new League();
        CSGO csgo = new CSGO();

        [TestMethod]
        public void SportsConstructorTests()
        {
            Assert.AreEqual("Overwatch", ow.Name);
            Assert.AreEqual("", ow.Description);
            Assert.AreEqual(6, ow.TeamSize);

            Assert.AreEqual("League of Legends", le.Name);
            Assert.AreEqual("", le.Description);
            Assert.AreEqual(5, le.TeamSize);

            Assert.AreEqual("Counter Strike: Source", csgo.Name);
            Assert.AreEqual("", csgo.Description);
            Assert.AreEqual(6, csgo.TeamSize);
        }
    }
}
