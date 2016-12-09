using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Yakup Görür 
//Istanbul Technical University Electronic and Communication Engineering
//https://github.com/ykpgrr
//https://tr.linkedin.com/in/ykpgrr

namespace midterm_calismam
{
    class FileHelper
    {
        private string FileName;

        public FileHelper(string fileName)
        {
            FileName = fileName;
            File.Open(FileName, FileMode.OpenOrCreate).Close();

        }

        public List<Plane> ReadAll()
        {
            List<Plane> planes = new List<Plane>();
            string[] lines = File.ReadAllLines(FileName);
            foreach (var line in lines)
            {
                var splitted = line.Split(',');
                Plane plane = new Plane(splitted[0], splitted[1], splitted[2], splitted[3], splitted[4], splitted[5]);
                planes.Add(plane);
            }
            return planes;
        }

        public void WriteAll(List<Plane> planes)
        {
            string[] contents = new string[planes.Count];
            for (int i = 0; i < planes.Count; i++)
            {
                contents[i] = planes[i].Serialize();
            }
            File.WriteAllLines(FileName, contents);
        }

        public void Append(Plane plane)
        {
            File.AppendAllText(FileName, string.Format("{0}{1}", plane.Serialize(), Environment.NewLine));
        }


    }
}
