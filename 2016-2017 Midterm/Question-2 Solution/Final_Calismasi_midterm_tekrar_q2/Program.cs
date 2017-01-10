 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Yakup Görür 040130052
//Istanbul Technical University Electronic and Communication Engineering
//https://github.com/ykpgrr
//https://tr.linkedin.com/in/ykpgrr


namespace Final_Calismasi_midterm_tekrar_q2
{
    class Program
    {
        private static string FileName = "telephone.txt";
        static void Main(string[] args)
        {
            FileHelper fileHelper = new FileHelper(FileName);
            List<Tip> ourtips = new List<Tip>();

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("What do you want? Please enter the index number...");
                Console.WriteLine("1 - Search using the Name");
                Console.WriteLine("2 - Search using the Surname");
                Console.WriteLine("3 - Search using the Telephone Number");
                Console.WriteLine("4 - Adding new Contact");
                Console.WriteLine("5 - Delete a Contact");
                Console.WriteLine("6 - Update a Contact");
                Console.WriteLine("7 - Show all Contacts");
                Console.WriteLine("-1 - Exit the program");

                int selected = Convert.ToInt32(Console.ReadLine());
               
                switch (selected)
                {
                    case 1:
                        Console.WriteLine("welcome to Search using the Name");
                        
                        string name = Console.ReadLine();
                        Search_Name(ourtips, name);
                        
                        Console.WriteLine("----Searching Complete----");
                        break;

                    case 2:

                        Console.WriteLine("welcome to  Search using the Surname");
                        
                        Console.WriteLine("Enter the surname...");
                        string surname = Console.ReadLine();
                        Search_Surname(ourtips, surname);
                        
                        Console.WriteLine("----Searching Complete----");
                        break;

                    case 3:
                        Console.WriteLine("welcome to  Search using the Telephone Number");
                        
                        Console.WriteLine("Enter the telephone number...");
                        string telno = Console.ReadLine();
                        Search_Telno(ourtips, telno);
                        
                        Console.WriteLine("----Searching Complete----");
                        break;

                    case 4:
                        Console.WriteLine("welcome to add a contact...");
                        
                        ourtips = Addnewtip(ourtips);
                        fileHelper.WriteAll(ourtips);
                        
                        Console.WriteLine("----Adding Complete----");
                        break;
                    
                    case 5:
                        Console.WriteLine("welcome to delete a contact...");
                        
                        Console.WriteLine("Please enter the contacts name&surname&telno that you want to delete it: ");
                        string delitem=Console.ReadLine();
                        Deletetip(ourtips, delitem);
                        fileHelper.WriteAll(ourtips);
                        
                        Console.WriteLine("----Deleting Complete----");
                        break;

                    case 6:
                        Console.WriteLine("welcome to update a contact...");
                        
                        Console.WriteLine("Please enter the contacts name&surname&telno that you want to update it: ");
                        string upitem=Console.ReadLine();
                        Updatetip(ourtips, upitem);

                        Console.WriteLine("----Updating Complete----");
                        break;

                    case 7:
                        Console.WriteLine("welcome to update Showing All Contacts...");

                        Showall(ourtips);

                        Console.WriteLine("----Showing All Contacts is Complete----");
                        break;



                    
                    case -1:
                        return;

                    default:
                        Console.WriteLine("invalid operation request. Please try again...");
                        break;


                }
            }
        }

        private static void Showall(List<Tip> ourtips)
        {
            for (int i = 0; i < ourtips.Count; i++)
            {

                Console.WriteLine("{0} {1}", i + 1, ourtips[i].Serialize());
                
            }
        }

        private static void Updatetip(List<Tip> ourtips, string upitem)
        {
            for (int i = 0; i < ourtips.Count; i++)
            {
                if (ourtips[i].Name.Contains(upitem) || ourtips[i].Surname.Contains(upitem) || ourtips[i].Telno.Contains(upitem))
                {
                    Console.WriteLine("{0} {1}", i + 1, ourtips[i].Serialize());
                }
            }

            Console.WriteLine("Please enter the index number that you want to update:");
            int selectedindex = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the number of part of contact that you want to change it: ");
            Console.WriteLine("1 - Name");
            Console.WriteLine("2 - Surname");
            Console.WriteLine("3 - Telephone number");
            
            int selectedpart = Convert.ToInt32(Console.ReadLine());

            switch (selectedpart)
            {
                case 1:
                    Console.WriteLine("Please enter the new Name: ");
                    ourtips[selectedindex-1].Name = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Please enter the new Surname: ");
                    ourtips[selectedindex-1].Surname = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Please enter the new Telephone Number: ");
                    ourtips[selectedindex-1].Telno = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Wrong part selection!");
                    break;
            }



        }

        private static void Deletetip(List<Tip> ourtips, string delitem)
        {
            for (int i = 0; i < ourtips.Count; i++)
            {
                if (ourtips[i].Name.Contains(delitem) || ourtips[i].Surname.Contains(delitem) || ourtips[i].Telno.Contains(delitem))
                {
                    Console.WriteLine("{0} {1}", i + 1, ourtips[i].Serialize());
                }
            }

            Console.WriteLine("Please enter the index number that you want to delete:");
            int selected = Convert.ToInt32(Console.ReadLine());
            ourtips.RemoveAt(selected - 1);
        }

        private static List<Tip> Addnewtip(List<Tip> ourtips)
        {

            Console.WriteLine("Please enter the name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter the surname: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Please enter the telephone number: ");
            string telno = Console.ReadLine();

            var newtip = new Tip(name, surname, telno);
            ourtips.Add(newtip);
            return ourtips;
        }

        private static void Search_Telno(List<Tip> ourtips, string telno)
        {
            for (int i = 0; i < ourtips.Count; i++)
            {
                if (ourtips[i].Telno.Contains(telno))
                {
                    Console.WriteLine("{0} {1}", i + 1, ourtips[i].Serialize());
                }
            }
        }

        private static void Search_Surname(List<Tip> ourtips, string surname)
        {
            for (int i = 0; i < ourtips.Count; i++)
            {
                if (ourtips[i].Surname.Contains(surname))
                {
                    Console.WriteLine("{0} {1}", i + 1, ourtips[i].Serialize());
                }
            }
        }

        private static void Search_Name(List<Tip> ourtips, string name)
        {
            for (int i = 0; i < ourtips.Count; i++)
            {
                if (ourtips[i].Name.Contains(name))
                {
                    Console.WriteLine("{0} {1}", i + 1, ourtips[i].Serialize());
                }
            }
        }
    }
}
