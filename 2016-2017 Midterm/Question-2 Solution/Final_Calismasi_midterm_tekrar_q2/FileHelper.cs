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


namespace Final_Calismasi_midterm_tekrar_q2
{
    class FileHelper
    {
        private string Filename;

        public FileHelper(string filename)
        {
            Filename = filename;
            File.Open(Filename, FileMode.OpenOrCreate).Close();
        }

        public void WriteAll(List<Tip> ourtips)
        {
            string[] contents = new string[ourtips.Count];
            for (int i = 0; i < ourtips.Count; i++)
            {
                contents[i] = ourtips[i].Serialize();
            }
            File.WriteAllLines(Filename, contents);
        }

        public void Append(Tip tip)
        {
            File.AppendAllText(Filename, string.Format("{0}{1}", tip.Serialize(), Environment.NewLine));
        }
    }
}
