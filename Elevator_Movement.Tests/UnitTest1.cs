using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Elevator_Movement;

namespace Elevator_Movement.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ElevatorTester0()
        {
            //arrange
            Commander comm = new Commander();

            comm.AddPerson(5, "up");

            comm.AddElevator(new ProtoElevator(3, 10, 1, true, "down"));
            comm.AddElevator(new ProtoElevator(1, 8, 13, true, "up"));
            comm.AddElevator(new ProtoElevator(2, 4, null, false, null));

            int expected=2;
            //act 

            int result = comm.optimalElevatorChoosing();

            //assert
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void ElevatorTester1()
        {
            //arrange
            Commander comm = new Commander();

            comm.AddPerson(5, "up");

            comm.AddElevator(new ProtoElevator(3, 7, 2, true, "down"));
            comm.AddElevator(new ProtoElevator(1, 5, 13, true, "up"));
            comm.AddElevator(new ProtoElevator(2, 4, 5, true, "up"));
            

            int expected = 1;
            //act 

            int result = comm.optimalElevatorChoosing();

            //assert
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void ElevatorTester2()
        {
            //arrange
            Commander comm = new Commander();

            comm.AddPerson(5, "up");

            comm.AddElevator(new ProtoElevator(6, 7, 2, true, "down"));
            comm.AddElevator(new ProtoElevator(1, 4, 13, true, "up"));
            comm.AddElevator(new ProtoElevator(4, 5, null, false, null));
            comm.AddElevator(new ProtoElevator(5, 4, 5, true, "down"));
            comm.AddElevator(new ProtoElevator(2, 4, 5, true, "up"));
            comm.AddElevator(new ProtoElevator(3, 4, 5, true, "up"));

            int expected = 4;
            //act 

            int result = comm.optimalElevatorChoosing();

            //assert
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void ElevatorTester3()
        {
            //arrange
            Commander comm = new Commander();

            comm.AddPerson(5, "up");

            comm.AddElevator(new ProtoElevator(6, 7, 2, true, "down"));
            comm.AddElevator(new ProtoElevator(1, 6, 13, true, "up"));
            comm.AddElevator(new ProtoElevator(4, 3, null, false, null));
            comm.AddElevator(new ProtoElevator(5, 4, 5, true, "down"));
            comm.AddElevator(new ProtoElevator(2, 7, 8, true, "up"));
            comm.AddElevator(new ProtoElevator(4, 9, null, false, null));

            int expected = 4;
            //act 

            int result = comm.optimalElevatorChoosing();

            //assert
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void GivenElevatorTest0()
        {
            //arrange
            Commander comm = new Commander();

            comm.AddPerson(8, "down");

            comm.AddElevator(new ProtoElevator(1, 7, 9, true, "up"));
            comm.AddElevator(new ProtoElevator(2, 1, 6, true, "up"));
            comm.AddElevator(new ProtoElevator(3, 8, null, false, null));
            comm.AddElevator(new ProtoElevator(4, 9, 6, true, "down"));
            comm.AddElevator(new ProtoElevator(5, 9, 10, true, "up"));
            
            int expected = 3;
            //act 

            int result = comm.optimalElevatorChoosing();

            //assert
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void GivenElevatorTest1()
        {
            //arrange
            Commander comm = new Commander();

            comm.AddPerson(5, "up");

            comm.AddElevator(new ProtoElevator(1, 7, 9, true, "up"));
            comm.AddElevator(new ProtoElevator(2, 10, 20, true, "up"));
            comm.AddElevator(new ProtoElevator(3, 1, 8, true, "up"));
            comm.AddElevator(new ProtoElevator(4, 6, null, false, null));           
            

            int expected = 3;
            //act 

            int result = comm.optimalElevatorChoosing();

            //assert
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void GivenElevatorTest2()
        {
            //arrange
            Commander comm = new Commander();

            comm.AddPerson(6, "up");

            comm.AddElevator(new ProtoElevator(1, 7, 9, true, "up"));
            comm.AddElevator(new ProtoElevator(2, 1, 10, true, "up"));
            comm.AddElevator(new ProtoElevator(3,6, 8, true, "up"));
            


            int expected = 3;
            //act 

            int result = comm.optimalElevatorChoosing();

            //assert
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void GivenElevatorTest3()
        {
            //arrange
            Commander comm = new Commander();

            comm.AddPerson(10, "down");

            comm.AddElevator(new ProtoElevator(1, 8, 1, true, "down"));
            comm.AddElevator(new ProtoElevator(2, 7, 8, true, "up"));            
            comm.AddElevator(new ProtoElevator(3, 10, 9, true, "down"));            
            comm.AddElevator(new ProtoElevator(4, 8, null, false, null));
            comm.AddElevator(new ProtoElevator(5, 10, 8, true, "down"));

            int expected = 3;
            //act 

            int result = comm.optimalElevatorChoosing();

            //assert
            Assert.AreEqual(expected, result);

        }

    }
}
