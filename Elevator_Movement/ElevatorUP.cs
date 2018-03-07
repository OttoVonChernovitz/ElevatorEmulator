using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator_Movement
{
    class ElevatorUP
    {
        public int upLiftOnSameFloor(Person pers,  List<ProtoElevator> Elev_list)
        {
            int chosenLift = 0;

            foreach (var elem in Elev_list)
            {
                if (elem.liftDirection == "up")
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

        public int upLiftForUpPerson(Person pers,  List<ProtoElevator> Elev_list)
        {

            int LiftCurrentMin = pers.personStartFloor;
            int chosenLift = 0;


            foreach (var elem in Elev_list)
            {
                if (elem.liftDirection == "up")
                {
                    if (elem.currentFloor < pers.personStartFloor)
                    {
                        if (pers.personStartFloor - elem.currentFloor < LiftCurrentMin)
                        {
                            LiftCurrentMin = pers.personStartFloor - elem.currentFloor;
                            chosenLift = elem.id;
                        }
                    }
                }
            }

            return chosenLift;
        }

        public int upLiftForDownPerson(Person pers,  List<ProtoElevator> Elev_list)
        {
            int LiftCurrentMin = pers.personStartFloor;
            int chosenLift=0;

            foreach (var elem in Elev_list)
            {
                if (elem.liftDirection == "up")
                {
                    if (elem.endFloor <= pers.personStartFloor)
                    {
                        if (pers.personStartFloor - elem.currentFloor < LiftCurrentMin)
                        {
                            LiftCurrentMin = pers.personStartFloor - elem.currentFloor;
                            chosenLift = elem.id;
                        }
                    }
                }
            }
            return chosenLift;
        }
        

    }
}
