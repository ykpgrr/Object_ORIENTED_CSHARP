using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Yakup Görür 040130052
//Istanbul Technical University Electronic and Communication Engineering
//https://github.com/ykpgrr
//https://tr.linkedin.com/in/ykpgrr
namespace midtermm_3
{
    class FileHelper
    {
        private string FileName;

        public FileHelper(string fileName)
        {
            FileName = fileName;
            File.Open(FileName, FileMode.OpenOrCreate).Close();

        }

        public List<Point> ReadAll()
        {
            List<Point> places = new List<Point>();
            string[] lines = File.ReadAllLines(FileName);
            foreach (var line in lines)
            {
                var splitted = line.Split(' ');

                Double p1;
                Double p2;
                Double.TryParse(splitted[0], out p1);
                Double.TryParse(splitted[1], out p2);
                Point place = new Point(p1, p2, splitted[2]);

                places.Add(place);
            }
            return places;
        }

        public void WriteAll(List<Point> planes)
        {
            string[] contents = new string[planes.Count];
            for (int i = 0; i < planes.Count; i++)
            {
                contents[i] = planes[i].Serialize();
            }
            File.WriteAllLines(FileName, contents);
        }

        public void Append(Point plane)
        {
            File.AppendAllText(FileName, string.Format("{0}{1}", plane.Serialize(), Environment.NewLine));
        }
    }
}
