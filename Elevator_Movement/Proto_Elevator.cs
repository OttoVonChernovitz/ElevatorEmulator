using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator_Movement
{
    public  class ProtoElevator
    {
        public int id;
        public int currentFloor;
        public int endFloor;
        public bool movementState;
        public string liftDirection;
            



        public ProtoElevator(int id, int  currentFloor, int? endFloor, bool movementState, string liftDirection)
        {
            this.id = id;
            this.currentFloor = currentFloor;
            this.endFloor = endFloor.GetValueOrDefault();
            this.movementState = movementState;
            this.liftDirection = liftDirection;

          
        }

        public void Show()
        {
            Console.WriteLine("Lift number {0} located on {1} floor, moves to {2} floor", id, currentFloor, endFloor);
        }
    }
}
