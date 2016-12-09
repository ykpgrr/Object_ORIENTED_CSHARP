using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Soru
{
   public class Counters
    {
       public void TacWord(string metin)
       {
           string[] splitted = metin.Split(' ');
           string[] modified = new string[splitted.Length];
           int prcount = 0;
           string pr = "process";
           string ex = "excellence";
           string sa = "satisfaction";

           int excount = 0;
           int sacount = 0;
           for (int i = 0; i < splitted.Length; i++)
           {
               modified[i] = splitted[i].Trim(',', ' ', '.', ';', ':', '(', ')');
               modified[i] = modified[i].ToLower();
               if (splitted[i].Contains(pr) == true)
               {
                   prcount++;
               }
               else if (splitted[i].Contains(ex) == true)
               {
                   excount++;
               }
               else if (splitted[i].Contains(sa) == true)
               {
                   sacount++;
               }

           }
           deneme.tac = string.Format(" Total Tactical Word {0}\n Process {1}\n Excellence {2}\n Satisfaction {3} ", prcount + excount + sacount, prcount, excount, sacount);
           
       }
       public void opCount(string metin)
       {
           string[] splitted = metin.Split(' ');
           string[] modified = new string[splitted.Length];
           string to = "total";
           string nm = "number";
           string wa = "waiting";
           string ti = "time";
           string cm = "income";
           int cmcount = 0;
           int tocount = 0;
           int nbcount = 0;
           int wacount = 0;
           int ticount = 0;
           for (int i = 0; i < splitted.Length; i++)
           {
               modified[i] = splitted[i].Trim(',', ' ', '.', ';', ':', '(', ')');
               modified[i] = modified[i].ToLower();
               if (modified[i].Contains(to) == true)
               {
                   tocount++;
               }
               else if (modified[i].Contains(nm) == true)
               {
                   nbcount++;
               }
               else if (modified[i].Contains(wa) == true)
               {
                   wacount++;
               }
               else if (modified[i].Contains(ti) == true)
               {
                   ticount++;
               }
               else if (modified[i].Contains(cm) == true)
               {
                   cmcount++;
               }
           }
           int total = nbcount + tocount + cmcount + wacount + ticount;
           deneme.op = string.Format(" Total Operational Word {0}\n Number {1}\n Waiting {2}\n Time {3}\n Total {4}\n Income {5} ", total, nbcount, wacount, ticount, tocount, cmcount);

       }
       public void strCount(string metin)
       {
           string[] splitted = metin.Split(' ');
           string[] modified = new string[splitted.Length];
           int devcount = 0;
           string dev = "develop";
           string imp = "improve";
           string cul = "culture";
           int impcount = 0;
           int culcount = 0;
           for (int i = 0; i < splitted.Length; i++)
           {
               modified[i] = splitted[i].Trim(',', ' ', '.', ';', ':', '(', ')');
               modified[i] = modified[i].ToLower();
               if (modified[i].Contains(dev) == true)
               {
                   devcount++;
               }
               else if (modified[i].Contains(imp) == true)
               {
                   impcount++;
               }
               else if (modified[i].Contains(cul) == true)
               {
                   culcount++;
               }


           }
           deneme.str= string.Format(" Total Strategic Word {0}\n Development {1}\n İmprovement {2}\n Culture {3} ", devcount + impcount + culcount, devcount, impcount, culcount);
       }
        
    }
}
