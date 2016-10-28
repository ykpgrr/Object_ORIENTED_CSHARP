using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ1_SORU1
{
    //Yakup Görür- 040130052
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Sıralama seçeneği 1 -> En kritik hatadan en az kritik hataya göre sıralanma ");
            Console.WriteLine("Sıralama seçeneği 2 -> En az kritik hatadan en kritik hataya ");
            Console.WriteLine("Sıralama seçeneği 3 -> En sık rastlanan hatadan en nadir rastlanan hataya ");
            Console.WriteLine("Sıralama seçeneği 4 -> En nadir rastlanan hatadan en çok karşılaşılan hataya ");

            Console.WriteLine("Lütfen seçenek numarası giriniz... ");


            int[,] Array = ArrayInitializer();
            int ArrayL = Array.Length / 2;



            int a = Int32.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    {
                        Console.WriteLine("seçenek 1: ");
                        Array = bubble_sort(Array);
                        Yazdir(Array, 1);

                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("seçenek 2: ");
                        Array = bubble_sort(Array);
                        Yazdir(Array, 0);

                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("seçenek 3: ");
                        Array = Nadir(Array);
                        Yazdir(Array, 3);


                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("seçenek 4: ");
                        Array = Nadir(Array);
                        Yazdir(Array, 2);

                        break;
                    }

                default: Console.WriteLine("Yanlis secim yaptiniz ! o.O "); break;
            }


            Console.ReadKey();

        }

        public static void Yazdir(int[,] Array, int j = 0)
        {
            int ArrayL = Array.Length / 2;

            if (j == 0)
            {
                for (int i = 0; i < ArrayL; i++)
                {
                    Console.Write(Array[i, 0]);
                    Console.Write(", ");
                    Console.WriteLine(Array[i, 1]);

                }
            }

            else if (j == 1)
            {
                for (int i = ArrayL - 1; i >= 0; i--)
                {
                    Console.Write(Array[i, 0]);
                    Console.Write(", ");
                    Console.WriteLine(Array[i, 1]);

                }
            }
            else if (j == 2)
            {
                for (int i = 0; i < ArrayL; i++)
                {
                    if (Array[i, 0] != 0)
                    {
                        Console.Write(Array[i, 0]);
                        Console.Write("tane -> ilk hata kodu : ");
                        Console.Write(Array[i, 1]);
                        Console.WriteLine(" var");
                    }

                }

            }
            else if (j == 3)
            {
                for (int i = ArrayL - 1; i >= 0; i--)
                {
                    if (Array[i, 0] == 0)
                        break;
                    Console.Write(Array[i, 0]);
                    Console.Write("tane -> ilk hata kodu : ");
                    Console.Write(Array[i, 1]);
                    Console.WriteLine(" var");

                }
            }



        }

        public static int[,] bubble_sort(int[,] dizi)
        {


            for (int i = 0; i < dizi.Length / 2 - 1; i++)
            {
                for (int j = 1; j < dizi.Length / 2 - i; j++)
                {


                    if (dizi[j, 0] < dizi[(j - 1), 0])
                    {
                        int gecici = dizi[j - 1, 0];
                        int gecici2 = dizi[j - 1, 1];

                        dizi[j - 1, 0] = dizi[j, 0];
                        dizi[j - 1, 1] = dizi[j, 1];

                        dizi[j, 0] = gecici;
                        dizi[j, 1] = gecici2;
                    }



                    if (dizi[j, 0] == dizi[(j - 1), 0] && dizi[j, 1] < dizi[(j - 1), 1])
                    {
                        int gecici = dizi[j - 1, 0];
                        int gecici2 = dizi[j - 1, 1];

                        dizi[j - 1, 0] = dizi[j, 0];
                        dizi[j - 1, 1] = dizi[j, 1];

                        dizi[j, 0] = gecici;
                        dizi[j, 1] = gecici2;
                    }



                }
            }


            return dizi;
        }







        public static int[,] Nadir(int[,] Array)
        {

            int ArrayL = Array.Length / 2;
            Array = bubble_sort(Array);
            int[,] nadirArray = new int[ArrayL, 2];



            int degisken = Array[0, 0];
            int kactane = 0;
            int a = 0;
            for (int i = 0; i < ArrayL; i++)
            {
                if (Array[i, 0] == degisken)
                {
                    kactane++;
                }

                else
                {
                    nadirArray[a, 0] = kactane;
                    nadirArray[a++, 1] = degisken;
                    degisken = Array[i, 0];
                    kactane = 1;
                }

            }


            nadirArray = bubble_sort(nadirArray);
            return nadirArray;
        }



        private static int[,] ArrayInitializer()
        {
            return new int[,] {
                { 5, 6 }, { 1, 2 }, { 1, 3 }, { 2, 2 }, {11, 7 }, { 5, 3 }, { 4, 11},
                {15, 8 }, {14, 2 }, { 3, 9 }, { 7, 4 }, { 6, 8 }, { 8, 6 }, { 9, 5 },
                 {11, 3 }, {15, 5 }, {13, 15}, {18, 14}, { 5, 19}, {15, 16}, {15, 11},
                {13, 12}, {14, 5 }, { 1, 13}, { 8, 5 }, { 9, 7 }
            };
        }
    }
}
