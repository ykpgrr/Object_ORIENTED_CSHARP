using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        private static string FileName="User.txt";
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Which operation is executed");

                Console.WriteLine("show all users: 1");
                Console.WriteLine("register new user: 2");
                Console.WriteLine("update user: 3");
                Console.WriteLine("remove user : 4");
                Console.WriteLine("close program: 5");

                int selected = Convert.ToInt32(Console.ReadLine());

              //  while (!int.TryParse(Console.ReadLine(), out selected)) ;
                Console.WriteLine();

                switch (selected)
                {
                    case 1:
                        ShowAll();
                        break;
                    case 2:
                        Register();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Remove();
                        break;
                    case 5:
                        return;
                        
                    default:
                        Console.WriteLine("invalid operation request");
                        break;
                }
            }
        }

        private static void Remove()
        {
            ShowAll();
            #region SelectIndex
            Console.WriteLine("\n\nSelected Index: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine();

            #endregion
            FileHelper fileHelper = new FileHelper(FileName);
            List<User> users = fileHelper.ReadAll();
            users.RemoveAt(index);
            fileHelper.WriteAll(users);

        }

        private static void Update()
        {
            #region SelectIndex
            Console.WriteLine("\n\nSelected Index: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine();

            #endregion

            #region CreateNewUser
            Console.WriteLine(@"FirstName | lastname | cardtype | school (demand) student->1 teacher->2 elder->3 regular->4");
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            CardTypes cardType = (CardTypes)int.Parse(Console.ReadLine());
            string school = Console.ReadLine();
             User user = new User(firstName, lastName, cardType, school);
            #endregion
            FileHelper fileHelper = new FileHelper(FileName);
            List<User> users = fileHelper.ReadAll();
            users[index] = user;
            fileHelper.WriteAll(users);
        }

        private static void Register()
        {
            #region CreateNewUser
            Console.WriteLine(@"FirstName | lastname | cardtype | school (demand) student->1 teacher->2 elder->3 regular->4");
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            CardTypes cardType = (CardTypes)int.Parse(Console.ReadLine());
            string school = Console.ReadLine();
            User user = new User(firstName, lastName, cardType, school);
            #endregion

            FileHelper fileHelper = new FileHelper(FileName);

            fileHelper.Append(user);
        }

        private static void ShowAll()
        {
            FileHelper fileHelper = new FileHelper(FileName);
            List<User> users = fileHelper.ReadAll();
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine("{0}.  {1}", i + 1, users[i].Serialize());
            }
        }

    }
}
