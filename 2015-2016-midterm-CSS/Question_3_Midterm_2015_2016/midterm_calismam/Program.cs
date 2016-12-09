using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Yakup Görür 
//Istanbul Technical University Electronic and Communication Engineering
//https://github.com/ykpgrr
//https://tr.linkedin.com/in/ykpgrr


namespace midterm_calismam
{
    class Program
    {
        //Please provide your file adress...
        private static string FileName = "C:/Users/ykpgrr_windows/Desktop/FlightPlan.txt"; //File adress

        static void Main(string[] args)
        {
            FileHelper fileHelper = new FileHelper(FileName); //Reading the File.
            List<Plane> planes = fileHelper.ReadAll(); // Throw all flights in Planes List by  line line


            while (true)    //to run always
            {

                Console.WriteLine("What do you want? Please enter the index number...");
                Console.WriteLine("1 - Entering only departure point");
                Console.WriteLine("2 - Entering only arrival point");
                Console.WriteLine("3 - Entering both of departure and arrival point");
                Console.WriteLine("4 - Entering specific flight date range(Not implemented yet)");
                Console.WriteLine("5 - Entering only ticket price");
                Console.WriteLine("6 - ShowAll flights");
                Console.WriteLine("7 - Buy Ticket by using the index number(Not implemented yet)");
                Console.WriteLine("8 - Exit the program");

                int selected = Convert.ToInt32(Console.ReadLine());  // Convert to int

                Console.WriteLine();

                string arrival_point;
                string departure_point;

                switch (selected)  //Which Selection
                {
                    case 1:

                        Console.WriteLine("Please enter the departure point:");
                        departure_point = Console.ReadLine();

                        Departure_Point(planes, departure_point);
                        break;

                    case 2:

                        Console.WriteLine("Please enter the arrival point:");
                        arrival_point = Console.ReadLine();

                        Arrival_Point(planes, arrival_point);
                        break;

                    case 3:

                        Console.WriteLine("Please enter the firstly departure point:");
                        departure_point = Console.ReadLine();
                        Console.WriteLine("Please enter the secondly arrival point:");
                        arrival_point = Console.ReadLine();

                        Both_Points(planes, departure_point, arrival_point);
                        break;

                    case 4:

                        Console.WriteLine("Please enter the first date(DD/MM/YYYY):");
                        string firsdate = Console.ReadLine();
                        Console.WriteLine("Please enter the second date(DD/MM/YYYY)");
                        string seconddate = Console.ReadLine();

                        Flight_Range(planes, firsdate, seconddate);
                        break;

                    case 5:

                        Console.WriteLine("Please enter the max Price as an integer number:");
                        int prize = Convert.ToInt32(Console.ReadLine());  // Convert to int

                        Ticket_Prize(planes, prize);
                        break;

                    case 6:

                        ShowAll(planes);
                        break;

                    case 7:

                        Console.WriteLine("Please enter the index number that you want to buy the ticket's");
                        int number = Convert.ToInt32(Console.ReadLine());

                        BuyTicket(number);
                        break;

                    case 8:

                        return;

                    default:

                        Console.WriteLine("invalid operation request");
                        break;
                }

            }

        }

        private static void BuyTicket(int number)
        {
            throw new NotImplementedException();
        }

        private static void Ticket_Prize(List<Plane> planes, int prize)
        {


            for (int i = 0; i < planes.Count; i++)
            {
                if (planes[i].Ticket_Price < prize) // if ticket prize is lower than user's want
                    Console.WriteLine("{0} {1}", i + 1, planes[i].Serialize()); //print
            }
        }

        private static void Flight_Range(List<Plane> planes, string firstdate, string seconddate)
        {
            #region NotImplemented

            //for (int i = 0; i < planes.Count; i++)
            //{
            //    var splitted = planes[i].Flight_Date.Split(',');
            //    if (splitted[1] == firstdate || splitted[1] == seconddate)
            //    {
            //        Console.WriteLine("{0} {1}", i + 1, planes[i].Serialize());
            //    }
            //} 
            #endregion
        }

        private static void Both_Points(List<Plane> planes, string departure_point, string arrival_point)
        {
            for (int i = 0; i < planes.Count; i++)
            {
                if (planes[i].Departure_Point == departure_point && planes[i].Arrival_Point == arrival_point)
                {
                    Console.WriteLine("{0} {1}", i + 1, planes[i].Serialize());
                }
            }
        }

        private static void Arrival_Point(List<Plane> planes, string arrival_point)
        {
            for (int i = 0; i < planes.Count; i++)
            {
                if (planes[i].Arrival_Point == arrival_point)
                {
                    Console.WriteLine("{0} {1}", i + 1, planes[i].Serialize());
                }
            }
        }

        private static void Departure_Point(List<Plane> planes, string departure_point)
        {
            for (int i = 0; i < planes.Count; i++)
            {
                if (planes[i].Departure_Point == departure_point)
                {
                    Console.WriteLine("{0} {1}", i + 1, planes[i].Serialize());
                }
            }
        }

        private static void ShowAll(List<Plane> planes)
        {

            for (int i = 0; i < planes.Count; i++)
            {
                Console.WriteLine("{0} {1}", i + 1, planes[i].Serialize());
            }
        }
    }
}
