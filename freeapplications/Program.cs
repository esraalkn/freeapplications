using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freeapplications
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen vize notunu giriniz: ");
            int vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen final notunu giriniz: ");
            int final = Convert.ToInt32(Console.ReadLine());
            int a=durum(vize, final);
            Console.WriteLine(a);
            Console.ReadLine();


           


        }
        static int durum(int not1,int not2)
        {
            int ort = (not1 + not2) / 2;
            if (ort<100 && ort>45)
            {
                Console.WriteLine($"Tebrikler dersi geçtiniz ortalamanız {ort}");
            }
            else
            {
                Console.WriteLine($"Dersden kaldınız ortalamanız {ort}");
            }
            return ort;
        }
    }
}
