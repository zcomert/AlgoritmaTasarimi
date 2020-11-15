using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    public class Seri
    {
        // Serinin değerlerini tutar. 
        public List<int> S { get; set; }
        
        // Belirli sayılardan bir seri oluşturur. 
        public Seri(params int[] s)
        {
            S = new List<int>();
            foreach (var item in s)
                S.Add(item);
        }

        /// <summary>
        /// Seri toplamini hesaplar. 
        /// </summary>
        /// <returns></returns>
        public int Toplam()
        {
            // toplami turar. 
            int toplam = 0;

            // toplami hesaplar.
            foreach (var item in S)
                toplam += item;
            // toplami doner
            return toplam;
        }
    }
}
