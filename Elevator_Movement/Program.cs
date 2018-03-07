using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator_Movement
{
    class Program
    {
        static void Main(string[] args)
        {
            Commander comm = new Commander();

            comm.AddPerson(10, "down");


            comm.AddElevator(new ProtoElevator(1, 8, 1, true, "down"));
            comm.AddElevator(new ProtoElevator(2, 7, 8, true, "up"));
            comm.AddElevator(new ProtoElevator(3, 10, 9, true, "down"));
            comm.AddElevator(new ProtoElevator(4, 8, null, false, null));
            comm.AddElevator(new ProtoElevator(5, 10, 8, true, "down"));


            comm.ShowAll();
            Console.WriteLine();

            Console.WriteLine("Lift number {0} will arrive soon", comm.optimalElevatorChoosing());

            Console.ReadKey();

        }
    }
}
