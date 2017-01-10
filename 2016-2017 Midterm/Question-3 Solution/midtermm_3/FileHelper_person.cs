using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Yakup Görür 040130052
//Istanbul Technical University Electronic and Communication Engineering
//https://github.com/ykpgrr
//https://tr.linkedin.com/in/ykpgrr
namespace midtermm_3
{
    class FileHelper_person
    {

        private string FileName;
        public int id = 0;

        public FileHelper_person(string fileName)
        {
            FileName = fileName;
            File.Open(FileName, FileMode.OpenOrCreate).Close();

        }

        public List<Person> ReadAll()
        {
            List<Person> people = new List<Person>();
            string[] lines = File.ReadAllLines(FileName);
            foreach (var line in lines)
            {
                var splitted = line.Split(' ');



                Person person = new Person(Convert.ToInt32(splitted[0]), Convert.ToDouble(splitted[1]), Convert.ToDouble(splitted[2]));

                people.Contains(person);
                //(parts.Contains(new Part { PartId = 1734, PartName = "" })) ;

                if (!(people.Exists(x => x.ID == Convert.ToInt32(splitted[0]))))
                {
                    people.Add(person);
                }
                else
                {
                    //parts.Find(x => x.PartName.Contains("seat")));

                    Console.WriteLine(people.Find(x => x.ID.Equals(Convert.ToInt32(splitted[0]))));
                    int i = people.FindIndex(x => x.ID.Equals(Convert.ToInt32(splitted[0])));
                    people[i].AddLocation(Convert.ToDouble(splitted[1]), Convert.ToDouble(splitted[2]));
                }



            }
            return people;
        }

        public void WriteAll(List<Person> People)
        {
            string[] contents = new string[People.Count];
            for (int i = 0; i < People.Count; i++)
            {
                contents[i] = People[i].Serialize();
            }
            File.WriteAllLines(FileName, contents);
        }

        public void Append(Person plane)
        {
            File.AppendAllText(FileName, string.Format("{0}{1}", plane.Serialize(), Environment.NewLine));
        }
    }
}
