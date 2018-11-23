using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlutoRoverController;

namespace PlutoRoverTest
{
    [TestClass]
    public class MovingTest
    {
        [TestMethod]
        [DataRow("FFRFF", 2, 2, Direction.E)]
        [DataRow("FFF",3,0, Direction.N)]
        public void Test_North_Moving(string command, int x, int y, Direction direction)
        {
            //Init 
            PlutoRover plutoRover = new PlutoRover();

            //Expected
            Direction expectedDirection = direction;
            int expectedX = x;
            int expectedY = y;

            //Action
            plutoRover.ReceiveCommand(command);

            //Result
            Assert.AreEqual(expectedDirection, plutoRover.Direction);
            Assert.AreEqual(expectedX, plutoRover.Position.X);
            Assert.AreEqual(expectedY, plutoRover.Position.Y);
        }
    }
}
