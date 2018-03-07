using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator_Movement
{
   public class Person
    {
        public int personStartFloor;
        public string personDirection;

        public Person(int personStartFloor, string personDirection)
        {

            this.personStartFloor = personStartFloor;
            this.personDirection = personDirection; 

        }
    }
}
