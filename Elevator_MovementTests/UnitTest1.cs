using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Elevator_Movement;

namespace Elevator_MovementTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            Commander comm = new Commander();


            comm.AddElevator(new ProtoElevator(3, 10, 1, true, "down"));
            comm.AddElevator(new ProtoElevator(1, 8, 13, true, "up"));
            comm.AddElevator(new ProtoElevator(2, 4, null, false, null));

            int expected = 2;

            //act

            int result = comm.optimalElevatorChoosing();

            //assert

            Assert.AreEqual(expected, result);
        }
    }
}
