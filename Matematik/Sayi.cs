using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    public class Sayi
    {
        // N degeri sayıyı temsil eder. 
        private int N { get; set; }

        // Yapılandırcı metot : N değerinin doğrudan belirlenmesini sağlar. 
        public Sayi(int n)
        {
            N = n;
        }

        public override string ToString()
        {
            return $"{N}";
        }

        /// <summary>
        /// Bir sayı tek true aksi durumda false döner. 
        /// </summary>
        /// <returns>bool</returns>
        public bool Tek() => N % 2 == 1 ? true : false;
        
        /// <summary>
        /// Bir sayı çift ise true aksi durumda false döner.
        /// </summary>
        /// <returns>bool</returns>
        public bool Cift() => N % 2 == 0 ? true : false;

        public int BirdenNkadarToplam() => N * (N + 1) / 2;
        
        /// <summary>
        /// 1 + 3 + 5 + ... + n
        /// </summary>
        /// <returns>Tek toplam sonucunu döner.</returns>
        public int TekToplam()
        {
            int n = N;
            if (Cift())
                n = n - 1;
            
            n = (n + 1) / 2;
            return n * n;
        }

        /// <summary>
        /// Çift toplam: 2 +  4 + 6 + ... + n
        /// </summary>
        /// <returns>Çift toplam değerini döner. </returns>
        public int CiftToplam()
        {
            int n = N;
            if (Tek())
                n = n - 1;
            n = n / 2;
            return n * (n + 1);
        }


        /// <summary>
        /// Asal sayı ise true aksi durumda false;
        /// </summary>
        /// <returns></returns>
        public bool AsalSayiMi()
        {
            bool s = true;
            for (int i = 2; i < N; i++)
            {
                if(N%i==0)
                {
                    s = false;
                    break;
                }
            }
            return s;
        }

        /// <summary>
        /// İlgili sayıya kadar olan tek sayıların listesi
        /// </summary>
        /// <returns></returns>
        public List<int> TekSayilarListesi()
        {
            var sayilar = new List<int>();
            for (int i = 1; i <= N; i += 2)
                sayilar.Add(i);
            return sayilar;
        }


        /// <summary>
        /// İlgili sayıya kadar olan çift sayıların listesi
        /// </summary>
        /// <returns></returns>
        public List<int> CiftSayilarListesi()
        {
            var sayilar = new List<int>();
            for (int i = 2; i <= N; i += 2)
                sayilar.Add(i);
            return sayilar;
        }




    }
}
