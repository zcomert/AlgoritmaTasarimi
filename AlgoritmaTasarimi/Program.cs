using Matematik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaTasarimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Sayi sayi = new Sayi(12);
            
            Console.WriteLine($"{"Sayi ",-20} : {sayi.ToString(),-10}");
            Console.WriteLine($"{"Tek ",-20} : {sayi.Tek(),-10}");
            Console.WriteLine($"{"Cift",-20} : {sayi.Cift(),-10}");
            Console.WriteLine($"{"Asal sayı",-20} : {sayi.AsalSayiMi(),-10}");
            
            Console.WriteLine($"{"Toplam",-20} : {sayi.BirdenNkadarToplam(),-10}");
            Console.WriteLine($"{"Tek Toplam",-20} : {sayi.TekToplam(),-10}");
            Console.WriteLine($"{"Çift Toplam",-20} : {sayi.CiftToplam(),-10}");

            Console.Write($"{"Tek sayilar listesi",-20} : ");
            sayi.TekSayilarListesi().ForEach(s => Console.Write($"{s,-3}"));

            Console.WriteLine();
            
            Console.Write($"{"Çift sayilar listesi",-20} : ");
            sayi.CiftSayilarListesi().ForEach(s => Console.Write($"{s,-3}"));

            Console.ReadKey();
        }
    }
}
