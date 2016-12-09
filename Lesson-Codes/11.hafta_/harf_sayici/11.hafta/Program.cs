using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _11.hafta
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("sw.txt", Encoding.GetEncoding("iso-8859-9"));
            string text = sr.ReadToEnd();
            string[] parsedText = parseText(text); ;
            int TotalCounter = 0;
            for (int i = 0; i < parsedText.Length; i++)
            {
                if (parsedText[i].Trim().Length!=0)
                {
                    char[] temp = parsedText[i].ToCharArray();
                    int wordCount = temp.Length;
                    Console.WriteLine("{0,15} {1,3}", parsedText[i], wordCount);
                    TotalCounter += wordCount;
                 

                }
            }
            Console.WriteLine("total words: " + Convert.ToString(TotalCounter));
            Finish();
        }

        private static string[] parseText(string text)
        {
            Regex rgx = new Regex("[^a-zA-Z0-9\\s]|[\t\n\r]");
            return rgx.Replace(text, "").Split(' ');
        }

        private static void Finish()
        {
            Console.WriteLine("exit");
            Console.ReadKey();
        }
    }
}
