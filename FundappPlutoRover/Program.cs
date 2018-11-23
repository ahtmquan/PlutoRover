using PlutoRoverController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundappPlutoRover
{
    class Program
    {
        static void Main(string[] args)
        {
            PlutoRover plutoRover = new PlutoRover();

            Console.WriteLine("Pluto Rover Commander");

            while (true)
            {
                Console.Write("Current Location: ");

                Console.WriteLine("{0},{1},{2}", plutoRover.Position.X, plutoRover.Position.Y, plutoRover.Direction);

                Console.Write("Please Enter You Command:");
                string command = Console.ReadLine();

                if (command == "")
                {
                    break;
                }
                else {
                    plutoRover.ReceiveCommand(command);
                }
            }

            Console.WriteLine("Bye!");
        }
    }
}
