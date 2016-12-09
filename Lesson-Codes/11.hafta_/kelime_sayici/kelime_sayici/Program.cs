using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kelime_sayici
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = File.ReadAllText("data.txt", Encoding.GetEncoding("iso-8859-9"));
            string[] splitted = data.Split(' ');
            for (int i = 0; i < splitted.Length; i++)
            {
                splitted[i] = WordNormalizer(splitted[i]);       //.Trim(',', ' ', '-', ';', ':', '(', ')').ToLower(); silmeye kıyamadım gereksiz aslında burdaki yorum satırında yazan kodlar
            }
            Dictionary<string, int> returnValue = new Dictionary<string, int>();
            for (int i = 0; i < splitted.Length; i++)
            {
                MyDictionaryAdd(returnValue, splitted[i]);
            }
            returnValue = returnValue.OrderBy(i => i.Key).ToDictionary(mc => mc.Key, mc => mc.Value);

            string[] content = new string[returnValue.Count + 1];
            for (int i = 0; i < returnValue.Count; i++)
            {
                content[i] = returnValue.ElementAt(i).Key + " " + returnValue.ElementAt(i).Value;
            }
            content[returnValue.Count] = string.Format("{0} {1} {2} {3}", "total word count=",returnValue.Sum(item => item.Value),"total distinct word count",returnValue.Count);

            File.WriteAllLines("log.txt", content);

        }

        private static string WordNormalizer(string v)
        {
            string normalizedWord = string.Empty;
            for (int i = 0; i < v.Length; i++)
            {
                if (Char.IsLetter(v[i]))
                {
                    normalizedWord += v[i];
                }
            }
            return normalizedWord.ToLower();
        }


        private static void MyDictionaryAdd(Dictionary<string,int> returnValue, string v)
        {
            if (string.IsNullOrWhiteSpace(v))
            {
                return;   
            }
            for (int i = 0; i < returnValue.Count; i++)
            {
             if (returnValue.ElementAt(i).Key==v)
                {
                    var tempElement = returnValue.ElementAt(i);
                    returnValue.Remove(returnValue.ElementAt(i).Key);

                    returnValue.Add(tempElement.Key, tempElement.Value + 1);
                    return;
                }
            }
            returnValue.Add(v, 1);
            return;
        }
    }
}
