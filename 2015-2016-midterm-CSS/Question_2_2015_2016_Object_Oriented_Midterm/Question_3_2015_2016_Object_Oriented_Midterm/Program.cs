using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Yakup Görür 
//Istanbul Technical University Electronic and Communication Engineering
//https://github.com/ykpgrr
//https://tr.linkedin.com/in/ykpgrr




//It is not completed!


namespace Question_2_2015_2016_Object_Oriented_Midterm
{
    class Program
    {

        private static string FileName = "C:/Users/ykpgrr_windows/Desktop/Library.txt"; //File adress
        static void Main(string[] args)
        {
            Dictionary<int, int> myIndex = new Dictionary<int, int>();

            FileHelper filehelper = new FileHelper(FileName);
            var books = filehelper.ReadAll();

            while (true)
            {


                Console.WriteLine("Aradığınız kitap hakkında herhangi bir bilgi:");

                string word = Console.ReadLine();
                string[] splitted_word = word.Split(' ');
               
                int name_lenght = splitted_word.Length;

                for (int i = 0; i < splitted_word.Length; i++)
                {
                    
                    find_it(splitted_word[i], books, myIndex);
                }

                for (int i = 0; i < myIndex.Count; i++)
                {
         
                    if (myIndex.ElementAt(i).Value >= name_lenght)
                    {
                        Console.WriteLine("{0}.  {1}", myIndex.ElementAt(i).Key, books[myIndex.ElementAt(i).Key]);
                    }

                }

            }


        }

        private static void find_it(string word, string[] books, Dictionary<int, int> myIndex)
        {
            word=word.ToLower();

            for (int j = 0; j < books.Length; j++)
            {
                string[] splitted = books[j].Split(' ', '~');
                
                for (int i = 0; i < splitted.Length; i++)
                {
                    
                    splitted[i] = splitted[i].ToLower();
                    if (splitted[i].Contains(word) == true)
                    {
                        Console.WriteLine(splitted[i] + " ****** " + word);
                        if (myIndex.ContainsKey(j))
                            myIndex[j]++;
                        else
                            myIndex.Add(j, 1);

                    }
                }



            }
        }
    }
}
