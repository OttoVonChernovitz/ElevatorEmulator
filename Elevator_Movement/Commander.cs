using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator_Movement
{
   public class Commander
    {

        ElevatorUP elevUP = new ElevatorUP();
        ElevatorDOWN elevDOWN = new ElevatorDOWN();
        ElevatorUNMOVING elevUNM = new ElevatorUNMOVING();

       
        Person pers;



        public void AddPerson(int floor, string direction)
        {
            pers = new Person(floor, direction);
        }

        List<ProtoElevator> Elev_List = new List<ProtoElevator>();


        public void AddElevator(ProtoElevator lift)
        {
            Elev_List.Add(lift);
        }

        public void ShowAll()
        {
            foreach (var elem in Elev_List)
                elem.Show();

        }

        public int optimalElevatorChoosing()
        {
            int chosenElevator = 0;
            switch (pers.personDirection)
            {
                case "up":
                chosenElevator = elevUP.upLiftOnSameFloor(pers, Elev_List);
                    if(chosenElevator==0)
                    {
                       chosenElevator = elevUNM.unmovingLiftOnSameFloor(pers, Elev_List);
                            if (chosenElevator == 0)
                            {
                            chosenElevator = elevUP.upLiftForUpPerson(pers, Elev_List);
                                if (chosenElevator == 0)
                                {
                                chosenElevator = elevDOWN.downLiftForUpPerson(pers, Elev_List);
                                    if (chosenElevator == 0)
                                    {
                                    chosenElevator = elevUNM.unmovingLiftForAnyFloor(pers, Elev_List);
                                    }
                                }
                            }
                    }
                    break;
                case "down":
                    chosenElevator = elevDOWN.downLiftOnSameFloor(pers, Elev_List);
                    if (chosenElevator == 0)
                    {
                        chosenElevator = elevUNM.unmovingLiftOnSameFloor(pers, Elev_List);
                        if (chosenElevator == 0)
                        {
                            chosenElevator = elevDOWN.downLiftForDownPerson(pers, Elev_List);
                            if (chosenElevator == 0)
                            {
                                chosenElevator = elevUP.upLiftForDownPerson(pers, Elev_List);
                                if (chosenElevator == 0)
                                {
                                    chosenElevator = elevUNM.unmovingLiftForAnyFloor(pers, Elev_List);
                                }
                            }
                        }
                    }
                    break;
            }
            return chosenElevator;
        }
 
        

    }
}
