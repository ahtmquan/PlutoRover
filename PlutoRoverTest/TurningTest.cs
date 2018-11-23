using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlutoRoverController;

namespace PlutoRoverTest
{
    [TestClass]
    public class TurningTest
    {
        [TestMethod]
        public void Test_TurnRight()
        {
            //Init 
            PlutoRover plutoRover = new PlutoRover();

            int expectedX = 0;
            int expectedY = 0;
            Direction expectedDirection = Direction.N;
            Assert.AreEqual(expectedDirection, plutoRover.Direction);

            plutoRover.ReceiveCommand("R");
            expectedDirection = Direction.E;
            Assert.AreEqual(expectedDirection, plutoRover.Direction);

            plutoRover.ReceiveCommand("R");
            expectedDirection = Direction.S;
            Assert.AreEqual(expectedDirection, plutoRover.Direction);

            plutoRover.ReceiveCommand("R");
            expectedDirection = Direction.W;
            Assert.AreEqual(expectedDirection, plutoRover.Direction);

            plutoRover.ReceiveCommand("R");
            expectedDirection = Direction.N;
            Assert.AreEqual(expectedDirection, plutoRover.Direction);

            //
            Assert.AreEqual(expectedX, plutoRover.Position.X);
            Assert.AreEqual(expectedY, plutoRover.Position.Y);
        }


        [TestMethod]
        public void Test_TurnLeft()
        {
            //Init 
            PlutoRover plutoRover = new PlutoRover();

            int expectedX = 0;
            int expectedY = 0;
            Direction expectedDirection = Direction.N;
            Assert.AreEqual(expectedDirection, plutoRover.Direction);

            plutoRover.ReceiveCommand("L");
            expectedDirection = Direction.W;
            Assert.AreEqual(expectedDirection, plutoRover.Direction);

            plutoRover.ReceiveCommand("L");
            expectedDirection = Direction.S;
            Assert.AreEqual(expectedDirection, plutoRover.Direction);

            plutoRover.ReceiveCommand("L");
            expectedDirection = Direction.E;
            Assert.AreEqual(expectedDirection, plutoRover.Direction);

            plutoRover.ReceiveCommand("L");
            expectedDirection = Direction.N;
            Assert.AreEqual(expectedDirection, plutoRover.Direction);

            //
            Assert.AreEqual(expectedX, plutoRover.Position.X);
            Assert.AreEqual(expectedY, plutoRover.Position.Y);
        }
    }
}
