using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator_Movement
{
    class ElevatorUNMOVING
    {

        public int unmovingLiftOnSameFloor(Person pers, List<ProtoElevator> Elev_list)
        {
            int chosenLift = 0;
            foreach (var elem in Elev_list)
            {
                if (!elem.movementState)
                {
                    if (elem.currentFloor == pers.personStartFloor)
                    {
                        chosenLift = elem.id;
                        break;
                    }
                }
            }
            return chosenLift;

        }

        public int unmovingLiftForAnyFloor(Person pers, List<ProtoElevator> Elev_list)
        {
            int chosenLift = 0;
            int distanceMin=0;

            foreach (var elem in Elev_list)
            {
                if  (!elem.movementState)
                {
                        distanceMin = Math.Abs(pers.personStartFloor-elem.currentFloor);
                        break;

                }
            }


            foreach (var elem in Elev_list)
            {
                if (!elem.movementState)
                {
                   if (Math.Abs(pers.personStartFloor - elem.currentFloor) <= distanceMin)
                   {
                      distanceMin = Math.Abs(pers.personStartFloor - elem.currentFloor);
                      chosenLift = elem.id;
                   }                        
                }
            }

            return chosenLift;
        }

    }
}
