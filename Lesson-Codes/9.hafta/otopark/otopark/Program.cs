using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otopark
{
    class Program
    {
        static void Main(string[] args)
        {
            Park park = new Park();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Which operation is executed");

                Console.WriteLine("Insert car :1");
                Console.WriteLine("Left car:2");
                Console.WriteLine("Show empty space:3");
                Console.WriteLine("Show all vehicles:4");
                Console.WriteLine("close program:5");

                int selected = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (selected)
                {
                    case 1:
                        InsertOperation(park);
                        break;
                    case 2:
                        LeftOperation(park);
                        break;
                    case 3:
                        Console.WriteLine("Empty size: " + park.EmptySpace());
                        break;
                    case 4:
                        park.ShowAllVehicles();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid operation request");
                        break;
                }

            }
            finish(); // bakılacak
        }

        private static void LeftOperation(Park park)
        {
            Console.Write("What is your ticket number:");
            int ticketNumber = Convert.ToInt32(Console.ReadLine());
            if (park.TicketIsValid(ticketNumber))
                park.LeftPark(ticketNumber);
            else
                Console.WriteLine(@"sorry but we can find your vehicle with ticket number");

        }

        private static void InsertOperation(Park park)
        {
            Vehicle vehicle;
            Console.Write("Plate Number: ");
                string plateNumber= Console.ReadLine();
            Console.WriteLine(@"\nVehicle Type\n [1->Motocycle\t 2->Automobile\t 3->Truck]");
            VehicleTypes type = (VehicleTypes)Convert.ToInt32(Console.ReadLine());
                        Console.Write("Size[You can skip this empty]: ");
            int size=0;
            if(int.TryParse(Console.ReadLine(),out size))
                vehicle=new Vehicle(plateNumber,type,size);
            else 
                vehicle=new Vehicle(plateNumber,type);
            int ticket;
            bool isInserted=park.InsertNewVehicle(vehicle,out ticket);

            if(isInserted)
                Console.WriteLine("your ticket number is :{0}",ticket);
            else
                Console.WriteLine(@"Sorry, There is no space for your vehicle");

        }

        private static void finish()
        {
            Console.ReadKey();
        }
    }
}
