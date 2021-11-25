using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotuygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 1, 5, 42, 89, 43, 7, 86, 58 };
            int a=topla(dizi);
            Console.WriteLine($"Dizi elemanlarının toplamı : {a}");
            int b = ortalama(dizi);
            Console.WriteLine($"Dizi elemanlarının ortalaması : {b}");
            Console.ReadLine();

        }

        public static int topla(int[] toplama)
        {
            int toplam = 0;
            for (int i = 0; i < toplama.Length; i++)
            {
                toplam += toplama[i];
            }
            return toplam;
        }

        public static int ortalama(int[] ort)
        {
            int ortalama = 0;
            int toplam = 0;
            for (int i = 0; i < ort.Length; i++)
            {
                toplam += ort[i];
                ortalama = toplam / (ort.Length);
            }
            return ortalama;
        }
    }
}
