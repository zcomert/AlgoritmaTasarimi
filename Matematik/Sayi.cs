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
            if (Cift())
                N = N - 1;
            
            N = (N + 1) / 2;
            return N * N;
        }

        /// <summary>
        /// Çift toplam: 2 +  4 + 6 + ... + n
        /// </summary>
        /// <returns>Çift toplam değerini döner. </returns>
        public int CiftToplam()
        {
            if (Tek())
                N = N - 1;
            N = N / 2;
            return N * (N + 1);
        }



        
    }
}
