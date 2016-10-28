using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ1_SORU2
{
    class Program
    {
        static void Main(string[] args)
        {


            int[,] array = ArrayInitializer();
            int arraylenght = array.GetLength(0);


            /* 
                memory<TKey,Tvalue> degiskeni  
             * TKey= 'id'
             * Tvalue= 'o id 'myArray'de kaçıncı satırda tutuluyor? göstergesi'
             */
            var memory = new Dictionary<int, int>();





            var People = new Person[arraylenght]; //'Person' türünde 'People' dizisi. Kişiler burada tutulacak.

            int peopleArraySırası = 0; //Kaç id olduğunu gösteriyor. Her yeni gelen id için +1 artacak.



            #region 'Person' türünden 'People' dizisi oluşturma ve aynı 'id' leri birleştirme işlemi


            for (int i = 0; i < arraylenght; i++)
            {

                // bu if döngüsü tekrar eden 'id' leri anlamamıza yarayacak.
                // array[i,0] -> id'yi gösteriyor.
                // memory dictionary içinde array[i,0] var ise bu if'e girmez
                // eğer yok ise yeni bir id ile karşılaşıyoruz. Bu id'yi tanımlamamız gerekecek.
                if (!memory.ContainsKey(array[i, 0]))
                {
                    memory.Add(array[i, 0], peopleArraySırası);   //'peopleArraysırası' => int türünden değişken. Her yeni gelen id için +1 artacak.

                    People[peopleArraySırası].id = array[i, 0]; // 'array' deki id bilgisini 'People' dizisinde 'peopleArraysırası'inci elemanının 'id' bilgisine atıyorum.
                    peopleArraySırası++; //yeni gelen id olursa peopleArraysırası bir atmış olacak.
                }


                // 'memory' dictionary 'den id'nin bizim 'People' dizimizde kaçıncı sırada olduğunu öğreniyorum.
                int dizisırası = memory[array[i, 0]];  // array[i,0] == id;

                //'ödenmiş ceza' ve 'alınan  cezayı' 'Person' struct'ının 'totalodeme' ve 'totalceza' sına ekliyorum.
                People[dizisırası].totalodeme += array[i, 1];
                People[dizisırası].totalceza += array[i, 2];
                People[dizisırası].cezasayısı += 1; // cezasayısını bir artırdım.


            }


            #endregion



            #region sıralama seceneği belirleme:

            Console.WriteLine("Sıralama seçeneği 1 => Ceza alma sayısı en çok olan kişiden en az olana doğru");
            Console.WriteLine("Sıralama seçeneği 2 => Toplamda en fazla para cezası alandan en az alan kişiye doğru");
            Console.WriteLine("Sıralama seçeneği 3 => Anlık olarak bakılınca ödenmeyi bekleyen borç miktarı en fazla olan kişiden en az olana doğru ");
            Console.WriteLine("Sıralama seçeneği 4 => Kimlik numarasına göre, ceza toplam tutar ve ödediği toplam tutar");


            int k = 0; //sıralama seceneği.
            do
            {
                Console.WriteLine("Lütfen bir seçenek giriniz.");

                k = Convert.ToInt32(Console.ReadLine());
            }
            while (k > 4 || k < 1);

            #endregion


            Sıralama(People, peopleArraySırası, k);

            Console.ReadKey();

        }



        private static void Sıralama(Person[] People, int counter, int secenek)
        {
            switch (secenek)
            {
                case 1:
                    Console.WriteLine("Ceza sayısı artan-azalan sıralama...");

                    Array.Sort(People, (x, y) => y.cezasayısı.CompareTo(x.cezasayısı)); //Ceza sayısına göre Array'i sıralama.

                    for (int a = 0; a < counter; a++) //Array'i yazdırma.
                    {
                        Console.WriteLine(" id: " + People[a].id + " ( " + People[a].cezasayısı + " ceza almış)");
                    }

                    break;

                case 2:
                    Console.WriteLine("Toplam ceza'ya göre artan-azalan sıralama...");

                    Array.Sort(People, (x, y) => y.totalceza.CompareTo(x.totalceza)); // Toplam ceza'ya göre sıraama.

                    for (int a = 0; a < counter; a++) //Array'i yazdırma.
                    {
                        Console.WriteLine(" id: " + People[a].id + " ( total alınan ceza: " + People[a].totalceza + "TL");
                    }

                    break;

                case 3:
                    Console.WriteLine("Kalan Borca göre artan-azalan sıralama...");

                    Array.Sort(People, (x, y) => (y.totalceza - y.totalodeme).CompareTo(x.totalceza - x.totalodeme));

                    for (int a = 0; a < counter; a++) //Array'i yazdırma.
                    {
                        Console.WriteLine(" id: " + People[a].id + " ( kalan borç: " + (People[a].totalceza - People[a].totalodeme) + "TL )");
                    }

                    break;

                case 4:
                    Console.WriteLine("Kimlik no'ya göre sıralama ...");
                    Array.Sort(People, (x, y) => x.id.CompareTo(y.id));
                    for (int a = 0; counter > 0; a++) //Array'i yazdırma.
                    {
                        if (People[a].id == 0)
                        {
                            continue;
                        }
                        else
                        {
                            counter--;
                            Console.WriteLine(" id: " + People[a].id + " ||| Toplan odenen para: " + People[a].totalodeme + " ||| Toplan alınan ceza: " + People[a].totalceza + " ||| Kalan ödeme :" + (People[a].totalceza - People[a].totalodeme) + " ||| Kaç ceza almış:" + People[a].cezasayısı);
                        }

                    }

                    break;

                default:
                    break;

            }




            //Array.Sort(People, delegate(Person x, Person y) { return y.cezasayısı.CompareTo(x.cezasayısı); });
            Array.Sort(People, (x, y) => y.cezasayısı.CompareTo(x.cezasayısı));


        }






        private static int[,] ArrayInitializer()
        {
            return new int[,] {
 { 1, 10, 10 }, { 3, 10, 20 }, { 2, 15, 100 }, { 4, 250, 300 },
 { 1, 50, 150 }, { 6, 47, 60 }, { 7, 50, 150 }, { 3, 0, 175 },
 { 3, 80, 145 }, { 8, 0, 250 }, { 9, 15, 45 }, { 4, 40, 40 },
 { 6, 8, 15 }, { 8, 60, 60 }, { 10, 50, 50 }, { 11 , 451, 452},
 {12, 15, 46 }, {13, 45, 55 }, {13, 50, 95}, {14, 55, 80},
 {10, 20, 50}, {15, 16, 46}, {16, 0, 450}, {17, 10, 100},
 {17, 5, 145 }, {2, 13, 23}, { 8, 95, 235 }, { 9, 70, 70 }
 };
        }

    }
}
