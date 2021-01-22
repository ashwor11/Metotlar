
using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //namin convention(isimlendirme kuralı)
        //syntax
        
        public void Ekle(params Product [] products)
        {
            string sepettext = "-";
            foreach (var product in products)
            {
                sepettext += product.Adi+"-";
            }
            
            Console.WriteLine("Tebrikler! "+sepettext +" Sepete eklendi.");


        }
        public void Ekle2(string urunAdi, string aciklama, double fiyati, int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi:" + urunAdi);
        }
    }
}
