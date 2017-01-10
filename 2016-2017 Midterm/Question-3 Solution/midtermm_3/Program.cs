using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Yakup Görür 040130052
//Istanbul Technical University Electronic and Communication Engineering
//https://github.com/ykpgrr
//https://tr.linkedin.com/in/ykpgrr
namespace midtermm_3
{
    class Program
    {
        //Please provide your file adress...
        private static string FileName_Places = "C:/Users/ykpgrr_windows/Desktop/Q3/3-places.txt"; //File adress
        private static string FileName_Person_List = "C:/Users/ykpgrr_windows/Desktop/Q3/3-personList.txt"; //File adress
        static void Main(string[] args)
        {

            FileHelper fileHelper = new FileHelper(FileName_Places); //Reading the File.
            List<Point> places = fileHelper.ReadAll(); // Throw all pointss in places List by  line line

            FileHelper_person fileHelper_person = new FileHelper_person(FileName_Person_List);
            List<Person> People = fileHelper_person.ReadAll();


            while (true)    //to run always
            {


                Console.WriteLine("What do you want? Please enter the index number...");
                Console.WriteLine("1 - New person");
                Console.WriteLine("2 - Add location for a person using Him/Her id");
                Console.WriteLine("3 - Add location in places.txt");
                Console.WriteLine("4 - Delete location in places.txt");
                Console.WriteLine("5 - Solve the locations of people, Show people where being same places");
                Console.WriteLine("6 - Exit the program");

                int selected = Convert.ToInt32(Console.ReadLine());  // Convert to int

                switch (selected)  //Which Selection
                {
                    case 1:

                        People = ADDnewPerson(People);
                        fileHelper_person.WriteAll(People);
                        break;

                    case 2:
                        People = addLocation(People);
                        fileHelper_person.WriteAll(People);
                        break;

                    case 3:
                        places = AddPlacelocation(places);
                        fileHelper.WriteAll(places);
                        break;

                    case 4:
                        places = Deleteplacelocation(places);
                        fileHelper.WriteAll(places);
                        break;

                    case 5:
                        Solve(People, places);
                        break;

                    case 6:

                        return;

                    default:

                        Console.WriteLine("invalid operation request");
                        break;
                }

            }
        }

        private static void Solve(List<Person> People, List<Point> places)
        {
            foreach (var person in People)
            {
                foreach (var point in person.Location)
                {
                    foreach (var place in places)
                    {
                        double a = 0;
                        a = Distance(point, place);
                        if (a <= 100)
                        {
                            Console.WriteLine("Person ID: {0} -> ({1},{2}) founded ----- ({3},{4})->{5} ", person.ID, point.Longtitude, point.Latitude, place.Longtitude, place.Latitude, place.PlaceName);
                        }
                    }
                }

            }
        }

        private static List<Point> Deleteplacelocation(List<Point> places)
        {
            Showallplaces(places);
            Console.WriteLine("enter index no:");
            int index = Convert.ToInt32(Console.ReadLine());
            places.Remove(places[index]);
            return places;
        }

        private static void Showallplaces(List<Point> places)
        {
            for (int i = 0; i < places.Count; i++)
            {
                Console.WriteLine("{0} {1}", i, places[i].Serialize());
            }
        }



        private static List<Point> AddPlacelocation(List<Point> places)
        {
            Console.WriteLine("enter Latitude:");
            double lat = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter Longtitude:");
            double longt = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter name:");
            string name = Console.ReadLine();
            Point newplace = new Point(lat, longt, name);

            places.Add(newplace);
            return places;
        }

        private static List<Person> addLocation(List<Person> People)
        {

            ShowAll_Person(People);
            Console.WriteLine("enter index no:");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter Latitude:");
            double lat = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter Longtitude:");
            double longt = Convert.ToDouble(Console.ReadLine());


            People[index].AddLocation(lat, longt);

            return People;
        }

        private static List<Person> ADDnewPerson(List<Person> People)
        {
            Console.WriteLine("Please enter the latitude:");
            double lat = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the longtitude:");
            double longt = Convert.ToDouble(Console.ReadLine());
            int id = People.Count + 1;
            var new_person = new Person(id, lat, longt);
            People.Add(new_person);
            ShowAll_Person(People);
            return People;
        }





        private static void ShowAll_Person(List<Person> People)
        {

            for (int i = 0; i < People.Count; i++)
            {
                Console.WriteLine("{0} {1}", i, People[i].Serialize());
            }
        }


        private static double Distance(Point point1, Point point2)
        {
            double R = 6371000;
            double dlon = (point1.Longtitude - point2.Longtitude) * Math.PI / 180;
            double dlat = (point1.Latitude - point2.Latitude) * Math.PI / 180;
            double a = Math.Pow(Math.Sin((dlat / 2)), 2) +
            Math.Cos(point1.Latitude * Math.PI / 180) *
            Math.Cos(point2.Latitude * Math.PI / 180) *
            Math.Pow(Math.Sin((dlon / 2)), 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double distance = R * c;
            return distance;
        }


    }
}