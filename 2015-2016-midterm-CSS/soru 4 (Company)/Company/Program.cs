using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    enum Departments
    {
        Mobile = 1,
        Database_Management = 2,
        Web_App_Developer = 3,
    }
    class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Departments Department { get; set; }
        
        public Employee(string name, string surname, Departments department)
        {
            Name = name;
            Surname = surname;
            Department = department;
        }

        public string Serialize()
        {
            return string.Format("{0} {1} {2}", Name, Surname, Department);
        }
    }
    class Project
    {
        int Size = 5;
        public string Name { get; set; }
        public string Date { get; set; }
        public Employee[] Employees;
        public Project(string name, string date)
        {
            Name = name;
            Date = date;
            Employees = new Employee[5];
        }
        public bool AssignEmployee(Employee employee)
        {
            if (EmptySpace() <= 0)
                return false;
            for (int i = 0; i < Employees.Length; i++)
            {
                if (Employees[i] == null || Employees[i] == default(Employee))
                {
                    Employees[i] = employee;
                    break;
                }
            }
            return true;
                
        }
        public int EmptySpace()
        {
            int total = 0;
            foreach (var item in Employees)
            {
                if (!(item == null || item == default(Employee)))
                    total++;
            }

            return Size - total;
        }
        public void ShowEmployees()
        {
            foreach (var item in Employees)
            {
                if (item != null || item != default(Employee))
                    Console.WriteLine("Name: {0}", item.Name);
            }
        }

        


    }
    class Program
    {
        static void Main(string[] args)
        {
            int maxEmployee = 30;
            Employee[] developers = new Employee[maxEmployee];
            int maxProjects = 10;
            Project[] projects = new Project[maxProjects];

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Which operation is executed");

                Console.WriteLine("Hire Employee: 1");
                Console.WriteLine("Create a new Project: 2");
                Console.WriteLine("Assign Employee to a Project: 3");
                Console.WriteLine("Show projects: 4");
                Console.WriteLine("Show Employees: 5");
                Console.WriteLine("Fire Employee: 6");
                Console.WriteLine("Close program: 7");

                int selected = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (selected)
                {
                    case 1:
                        HireEmployee(developers);
                        break;
                    case 2:
                        CreateProject(projects);
                        break;
                    case 3:
                        AssignEmployee(developers, projects);
                        break;
                    case 4:
                        ShowProjects(projects);
                        break;
                    case 5:
                        ShowEmployees(developers);
                        break;
                    case 6:
                        FireEmployee(developers);
                        break;
                    case 7:
                        return; //bir nevi main metodundan çıkmayı sağlıyor programı kapatıyor döngü içinde olsa da
                    default:
                        Console.WriteLine("Invalid operation requested.");
                        break;
                }

            }
        }

        private static void FireEmployee(Employee[] developers)
        {
            Console.WriteLine("Choose Employee: ");
            for (int i = 0; i < developers.Length; i++)
            {

                if (developers[i] == null || developers[i] == default(Employee))
                {
                    break;
                }
                Console.WriteLine("{0} for {1} {2} {3}", i, developers[i].Name, developers[i].Surname, developers[i].Department);
            }

            int eselected = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = eselected; i < developers.Length; i++)
            {
                if (developers[i] == null || developers[i] == default(Employee))
                {
                    developers[i] = developers[i + 1];
                }
            }

        }

        private static void ShowEmployees(Employee[] developers)
        {
            for (int i = 0; i < developers.Length; i++)
            {

                if (developers[i] == null || developers[i] == default(Employee))
                {
                    break;
                }
                Console.WriteLine("{0} for {1} {2} {3}", i, developers[i].Name, developers[i].Surname, developers[i].Department);
            }
        }

        private static void ShowProjects(Project[] projects)
        {
            for (int i = 0; i < projects.Length; i++)
            {
                if (projects[i] == null || projects[i] == default(Project))
                {
                    return;
                }
                else
                {
                    Console.WriteLine("{0} {1}", projects[i].Name, projects[i].Date);
                    for (int j = 0; j < projects[i].Employees.Length; j++)
                    {
                        if (projects[i].Employees[j] == null || projects[i].Employees[j] == default(Employee))
                        {
                            break;
                        }
                        Console.WriteLine("{1} {2} {3}", i, projects[i].Employees[j].Name, projects[i].Employees[j].Surname, projects[i].Employees[j].Department);

                    }

                    Console.WriteLine();
                } 
            }
        }

        private static void AssignEmployee(Employee[] developers, Project[] projects)
        {
            Console.WriteLine("Choose Project: ");
            for (int i = 0; i < projects.Length; i++)
            {
                
                if (projects[i] == null || projects[i] == default(Project))
                {
                    break;
                }
                Console.WriteLine("{0} for {1} {2}", i, projects[i].Name, projects[i].Date);
            }

            int pselected = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Choose Employee: ");
            for (int i = 0; i < developers.Length; i++)
            {
                
                if (developers[i] == null || developers[i] == default(Employee))
                {
                    break;
                }
                Console.WriteLine("{0} for {1} {2} {3}", i, developers[i].Name, developers[i].Surname, developers[i].Department);
            }

            int eselected = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            projects[pselected].AssignEmployee(developers[eselected]);

        }

        private static void CreateProject(Project[] projects)
        {
            for (int i = 0; i < projects.Length; i++)
            {
                if (projects[i] == null || projects[i] == default(Project))
                {
                    Console.WriteLine("Enter Project Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Date");
                    string date = Console.ReadLine();
                    projects[i] = new Project(name, date);
                    break;
                }
            }
        }

        private static void HireEmployee(Employee[] developers)
        {
            for (int i = 0; i < developers.Length; i++)
            {
                if (developers[i] == null || developers[i] == default(Employee))
                {
                    Console.WriteLine("Enter Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Surname");
                    string surname = Console.ReadLine();
                    Console.WriteLine("Choose department. Mobile = 1 Database_Management = 2 Web_App_Developer = 3");
                    int department = Convert.ToInt32(Console.ReadLine());

                    developers[i] = new Employee(name, surname, (Departments)department);
                    break;
                }
            }
        }

    }
}
