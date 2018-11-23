using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlutoRoverController;

namespace PlutoRoverTest
{
    [TestClass]
    public class StartupTest
    {
        [TestMethod]
        public void Test_StartUp_Location_Direction()
        {
            //Init 
            PlutoRover plutoRover = new PlutoRover();

            //Expected
            int expectedX = 0;
            int expectedY = 0;
            Direction expectedDirection = Direction.N;

            //
            Assert.AreEqual(expectedX, plutoRover.Position.X);
            Assert.AreEqual(expectedY, plutoRover.Position.Y);
            Assert.AreEqual(expectedDirection, plutoRover.Direction);
        }
    }
}
