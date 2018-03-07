using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator_Movement
{
    class ElevatorDOWN
    {
        public int downLiftOnSameFloor(Person pers, List<ProtoElevator> Elev_list)
        {
            int chosenLift = 0;

            foreach (var elem in Elev_list)
            {
                if (elem.liftDirection == "down")
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

        public int downLiftForDownPerson(Person pers, List<ProtoElevator> Elev_list)
        {
            int liftCurrentMin=0;

            foreach (var elem in Elev_list)
            {
                if (elem.currentFloor>pers.personStartFloor)
                {
                    if (elem.liftDirection == "down")
                    {
                        liftCurrentMin = elem.currentFloor;
                    }
                }
            }
            int chosenLift = 0;


            foreach (var elem in Elev_list)
            {
                if (elem.liftDirection == "down")
                {
                    if (elem.currentFloor > pers.personStartFloor)
                    {
                        if ( elem.currentFloor - pers.personStartFloor < liftCurrentMin)
                        {
                            liftCurrentMin = elem.currentFloor - pers.personStartFloor;
                            chosenLift = elem.id;
                        }
                    }
                }
            }

            return chosenLift;
        }

        public int downLiftForUpPerson(Person pers, List<ProtoElevator> Elev_list)
        {
            int liftCurrentMin = 0;

            foreach (var elem in Elev_list)
            {
                if (elem.liftDirection == "down")
                {
                    if (elem.endFloor >= pers.personStartFloor)
                    {
                        liftCurrentMin = elem.currentFloor;
                    }
                }
            }
            int chosenLift = 0;


            foreach (var elem in Elev_list)
            {
                if (elem.liftDirection == "down")
                {
                    if (elem.endFloor >= pers.personStartFloor)
                    {

                        if (elem.currentFloor > pers.personStartFloor)
                        {
                            if (elem.currentFloor - pers.personStartFloor < liftCurrentMin)
                            {
                                liftCurrentMin = elem.currentFloor - pers.personStartFloor;
                                chosenLift = elem.id;
                            }
                        }
                    }
                }
            }





            return chosenLift;
        }

    }
}
