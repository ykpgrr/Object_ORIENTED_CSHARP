using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ1_SORU3
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, min, girsayi, oyunsayi, sanssayi, sanssizsayi;
            int[] sansdizi = new int[100];
            int[] sanssizdizi = new int[100];


            #region Max-Min girişi
            do
            {
                Console.WriteLine("Lütfen max değeri giriniz...");
                max = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Lütfen min değerini giriniz...");
                min = Int32.Parse(Console.ReadLine());
                if ((max - min) <= 0)
                    Console.WriteLine("yanlis max-min girdiniz.");

            } while ((max - min) <= 0);
            #endregion

            #region Kaç adet sayı seçilecek
            Console.Write("Kaç adet sayı seçilecek? Enfazla secilebilecek sayi: ");
            Console.Write(max - min);
            Console.WriteLine(" adet sayı seçebilirsiniz. Lütfen giriniz...  ");
            girsayi = Int32.Parse(Console.ReadLine());


            while (girsayi > (max - min) || girsayi <= 0)
            {
                Console.WriteLine("Şans faktörü oluşmadı. Lütfen yeniden giriniz...");
                girsayi = Int32.Parse(Console.ReadLine());
            }
            #endregion


            Console.Write(Kombinasyon((max - min + 1), girsayi));
            Console.WriteLine(" Adet seçim yapılabilir.");


            #region Kaç Oyun Oynanacak
            Console.WriteLine("Kaç defa oynamak istersiniz...");
            oyunsayi = Int32.Parse(Console.ReadLine());

            while (oyunsayi > Kombinasyon((max - min + 1), girsayi) || girsayi <= 0)
            {
                Console.WriteLine("Yanlis deger girdiniz tekrar deneyiniz...");
                oyunsayi = Int32.Parse(Console.ReadLine());
            }
            #endregion


            int sanscounter = 0;
            #region Şans sayisi
            sanssayi = GirSansSayi((max - min + 1), girsayi, oyunsayi);
            Console.Write(sanssayi);
            Console.WriteLine(" adet sanssayisi girebilirsiniz.");


            if (sanssayi > 0)
            {
                for (; sanscounter < sanssayi; sanscounter++)
                {
                    Console.Write("Şanslı sayınız var ise lütfen giriniz yoksa enter a basınız...");
                    Console.Write(" kalan hakkınız: ");
                    Console.WriteLine((sanssayi - sanscounter));

                    var a = Console.ReadLine();

                    if (a == "")
                    {
                        break;
                    }
                    else
                    {
                        sansdizi[sanscounter] = Int32.Parse(a);
                    }

                }
            }
            #endregion


            int sanssizcounter = 0;
            // sanssız sayı girebilme sayısı = toplam sayımız - Kombinasyon sayımız(kaç sayı seçilecek) 
            #region sanssizsayii


            sanssizsayi = (max - min + 1) - girsayi;
            Console.Write(sanssizsayi);
            Console.WriteLine(" adet sanssizsayi girebilirsiniz.");


            if (sanssizsayi > 0)
            {
                for (; sanssizcounter < sanssizsayi; sanssizcounter++)
                {
                    Console.Write("sansiz sayiniz var ise lütfen giriniz yoksa enter'a basınız...");
                    Console.Write("kalan hakkınız: ");
                    Console.WriteLine((sanssizsayi - sanssizcounter));
                    var a = Console.ReadLine();
                    if (a != "")
                        sanssizdizi[sanssizcounter] = Int32.Parse(a);
                    else
                        break;
                }
            }
            #endregion


            List<int> Numbers = new List<int>();
            #region şans ve şanssız numaralaraı çıkartma

            for (int i = min, k = 0; i <= max; i++)
            {
                bool kontrol = true;


                foreach (int a in sansdizi)
                {
                    if (a == i)
                        kontrol = false;
                }

                if (!kontrol)
                    continue;


                foreach (int a in sanssizdizi)
                {
                    if (a == i)
                        kontrol = false;
                }

                if (!kontrol)
                    continue;


                Numbers.Add(i);


            }
            #endregion


            #region kupon yazdırma
            int r = girsayi - sanscounter;
            int[] data = new int[r];
            CombinationUtil(Numbers, data, 0, (Numbers.Count - 1), 0, r, sansdizi, sanscounter);
            #endregion




            /*
            for (int i = 0; i <= (Numbers.Count - r); i++)
            {
                Console.WriteLine("kupon #" + (i + 1));
                SansYazdir(sansdizi, sanscounter);
                Console.Write(Numbers[i] + " ");
                Numbers.RemoveAt(0);
                Kombinasyonbulma(Numbers, r - 1);

            }
            */
            //Kombinasyonbulma( Numbers, (girsayi - sanscounter),true);







            /* #region Kupon Yazdırma
            for (int i = 0, kuponsayac=1; i < Numbers.Count; i++)
            {
                for (int j = i+1; j < Numbers.Count; j++)
                {
                    Console.WriteLine("Kupon #"+ kuponsayac++);
                    SansYazdir(sansdizi, sanscounter);
                    Console.Write(Numbers[i]);
                    Console.Write(" ");
                    Console.WriteLine(Numbers[j]);
                }
            }
            #endregion
            */

            Console.ReadKey();


        }


        // Numbers[]  ---> Input Array
        //data[] ---> Temporary array to store current combination
        //start & end ---> Staring and Ending indexes in arr[]
        //index  ---> Current index in data[]
        //r ---> Size of a combination to be printed */
        static void CombinationUtil(List<int> Numbers, int[] data, int start, int end, int index, int r, int[] sansdizi, int sanscounter)
        {
            // Current combination is ready to be printed, print it
            if (index == r)
            {
                SansYazdir(sansdizi, sanscounter);
                for (int j = 0; j < r; j++)
                    Console.Write(data[j] + " ");

                Console.WriteLine();
                return;
            }

            // replace index with all possible elements. The condition
            // "end-i+1 >= r-index" makes sure that including one element
            // at index will make a combination with remaining elements
            // at remaining positions

            for (int i = start; i <= end && end - i + 1 >= r - index; i++)
            {
                data[index] = Numbers[i];
                CombinationUtil(Numbers, data, i + 1, end, index + 1, r, sansdizi, sanscounter);

            }

        }



        static int Kombinasyon(int i, int j)
        {
            int toplam = 1;
            int k = j;
            for (; j > 0; --j)
            {
                toplam *= i--;
            }
            for (; k > 1; --k)
            {
                toplam /= k;
            }
            return toplam;
        }

        static int GirSansSayi(int i, int j, int oyunsayi)
        {
            int sanssayi = 0;
            while (Kombinasyon(i, j - sanssayi - 1) >= oyunsayi)
            {
                sanssayi++;
            }

            return sanssayi;
        }

        static void SansYazdir(int[] sansdizi, int sanscounter)
        {

            for (int i = 0; i < sanscounter; i++)
            {
                Console.Write(sansdizi[i]);
                Console.Write(" ");
            }
        }


    }
}
