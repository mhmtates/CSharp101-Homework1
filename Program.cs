using System;
using System.Linq;

namespace Homework1
{
    public class Program
    {
        public static void Main(string[] args)
        {
        //     //<---1.soru çözümü başlangıcı---> 
        //     Console.WriteLine("Lütfen pozitif bir sayı giriniz:");
        //     int length = Convert.ToInt32(Console.ReadLine());
        //     int[] positivenumbers = new int[length];

        //     for (int i = 0; i < length; i++)
        //     {
        //         Console.Write("{0}.pozitif sayıyı giriniz:  ", i + 1);
        //         positivenumbers[i] = Convert.ToInt32(Console.ReadLine());
        //     }

        //     foreach (int positivenumber in positivenumbers)
        //     {
        //         if (positivenumber % 2 == 0)
        //             Console.WriteLine(positivenumber);
        //     }
        //     //<------1.soru çözümü bitişi------>//
            
        //     //<---- 2.soru çözümü başlangıcı----->//
        //     Console.Write("Bir pozitif sayı giriniz:");
        //     int n = int.Parse(Console.ReadLine());
        //     Console.Write("Bir pozitif sayı daha giriniz:");
        //     int m = int.Parse(Console.ReadLine());
        //     int[] dizi = new int[n];
        //     for (int i = 0; i < n; i++)
        //     {
        //         Console.WriteLine(" {0}.pozitif sayıyı giriniz:", i + 1);
        //         dizi[i] = int.Parse(Console.ReadLine());

        //     }

        //     foreach (int sayi in dizi)
        //     {
        //         if (m == sayi || m % sayi == 0)
        //             Console.WriteLine(sayi);

        //     }
        //     //<----2.soru çözümü bitişi---->//

        //      //<----3.soru çözümü başlangıcı---->
        //     Console.Write("Bir pozitif sayı giriniz:");
        //     int N = int.Parse(Console.ReadLine());
        //     string[] kelimeDizisi = new string[N];
        //     for (int i = 0; i <N; i++)
        //    {
        //        Console.Write("Bir kelime giriniz:");
        //        kelimeDizisi[i] = Console.ReadLine();
              
        //    }

          
        //  Array.Reverse(kelimeDizisi);
        //   foreach (string kelime in kelimeDizisi)
        //     {
                
        //         Console.WriteLine(kelime);
        //     }
        // //<----3.soru çözümü bitişi----->//
       
        //<----4.soru çözümü başlangıcı--->//
         Console.WriteLine("Bir cümle yazınız:");
         string sentence = Console.ReadLine();
         string[] wordArray = sentence.Split(" ");

         Console.WriteLine("Cümledeki kelime sayısı :"+wordArray.Length);
         Console.WriteLine("Cümledeki harf sayısı : "+ sentence.Length);
         //<-----4.soru çözümü bitişi------>//







        }
       


    }
}









