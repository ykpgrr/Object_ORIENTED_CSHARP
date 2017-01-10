using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Midtermm_2
{
    class FileHelper
    {
        private string FileName;

        public FileHelper(string fileName)
        {
            FileName = fileName;
            File.Open(FileName, FileMode.OpenOrCreate).Close();

        }

        //public List<Person> ReadAll()
        //{
        //    List<Person> planes = new List<Plane>();
        //    string[] lines = File.ReadAllLines(FileName);
        //    foreach (var line in lines)
        //    {
        //        var splitted = line.Split(',');
        //        Person plane = new Person(splitted[0], splitted[1], splitted[2], splitted[3], splitted[4], splitted[5]);
        //        planes.Add(plane);
        //    }
        //    return planes;
        //}

        public void WriteAll(List<Person> people)
        {
            string[] contents = new string[people.Count];
            for (int i = 0; i < people.Count; i++)
            {
                contents[i] = people[i].Serialize();
            }
            File.WriteAllLines(FileName, contents);
        }

        public void Append(Person plane)
        {
            File.AppendAllText(FileName, string.Format("{0}{1}", plane.Serialize(), Environment.NewLine));
        }


    }

}
