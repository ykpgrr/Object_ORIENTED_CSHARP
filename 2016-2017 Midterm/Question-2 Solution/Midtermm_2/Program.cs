using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Yakup Görür 040130052
//Istanbul Technical University Electronic and Communication Engineering
//https://github.com/ykpgrr
//https://tr.linkedin.com/in/ykpgrr

namespace Midtermm_2
{
    class Program
    {
        //Please provide your file adress...
        private static string FileName = "C:/Users/ykpgrr_windows/Desktop/telephone.txt";
        static void Main(string[] args)
        {
            FileHelper fileHelper = new FileHelper(FileName); //Reading the File.
            List<Person> planes = new List<Person>();


            while (true)    //to run always
            {

                Console.WriteLine("What do you want? Please enter the index number...");
                Console.WriteLine("1 - isim ile ara");
                Console.WriteLine("2 - soyada ile ara");
                Console.WriteLine("3 - tel ile ara");
                Console.WriteLine("4 - yeni kisi gir");
                Console.WriteLine("8 - Exit the program");

                int selected = Convert.ToInt32(Console.ReadLine());  // Convert to int
                string departure_point;
                string arrival_point;
                switch (selected)  //Which Selection
                {
                    case 1:

                        Console.WriteLine("isim gir:");
                        departure_point = Console.ReadLine();

                        Departure_Point(planes, departure_point);
                        break;

                    case 2:

                        Console.WriteLine("soyad gir:");
                        arrival_point = Console.ReadLine();

                        Arrival_Point(planes, arrival_point);
                        break;

                    case 3:

                        Console.WriteLine("tel no gir");
                   
                        break;

                    case 4:
                        planes=ADDnewPerson(planes);
                        fileHelper.WriteAll(planes);
                        break;
                    case 8:

                        return;

                    default:

                        Console.WriteLine("invalid operation request");
                        break;
                }
            }
        }
        private static List<Person> ADDnewPerson(List<Person> People)
        {
            Console.WriteLine("Please enter the name:");
            string lat = Console.ReadLine();

            Console.WriteLine("Please enter the surname:");
            string longt = Console.ReadLine();
            Console.WriteLine("Please enter the tel:");
            string tel = Console.ReadLine();
            
            var new_person = new Person(lat, longt, tel);
            People.Add(new_person);
            
            return People;
        }
        private static void Arrival_Point(List<Person> planes, string arrival_point)
        {
            for (int i = 0; i < planes.Count; i++)
            {
                if (planes[i].Surname == arrival_point)
                {
                    Console.WriteLine("{0} {1}", i + 1, planes[i].Serialize());
                }
            }
        }

        private static void Departure_Point(List<Person> planes, string departure_point)
        {
            for (int i = 0; i < planes.Count; i++)
            {
                if (planes[i].Name == departure_point)
                {
                    Console.WriteLine("{0} {1}", i + 1, planes[i].Serialize());
                }
            }
        }
    }
}
