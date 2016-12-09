using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class FileHelper
    {
        private string FileName;

        public FileHelper(string fileName)
        {
            FileName = fileName;
            File.Open(FileName,FileMode.OpenOrCreate).Close();
        }
        public List<User> ReadAll()
        {
           List<User> users = new List<User>();
           string[] lines = File.ReadAllLines(FileName);
           foreach (var line in lines)
           {
               var splitted= line.Split(' ');
               User user=new User(splitted[0],splitted[1],(CardTypes)Enum.Parse(typeof(CardTypes),splitted[2],true),splitted[3]);
               users.Add(user);
           }
           return users;
            #region Way2
           //StreamReader reader = new StreamReader(FileName);

           //string line;
           // while((line=reader.ReadLine())!=null)
           // {
           //     var splitted = line.Split(' ');
           //     User user = new User(splitted[0], splitted[1], (CardTypes)Enum.Parse(typeof(CardTypes), splitted[2], true), splitted[3]);
           // }
           // reader.Close;
           // return users;
            #endregion
        }
        public void WriteAll(List<User> users)
        {
            string[] contents = new string[users.Count];
            for (int i = 0; i < users.Count; i++)
            {
                contents[i] = users[i].Serialize();

            }
            File.WriteAllLines(FileName, contents);
        }
        public void Append(User user)
        {
            File.AppendAllText(FileName, string.Format("{0}{1}", user.Serialize(), Environment.NewLine));
        }
       
    }
}
