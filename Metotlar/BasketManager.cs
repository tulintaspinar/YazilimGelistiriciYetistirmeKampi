using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class BasketManager
    {
        //naming convention
        public void Add(Product urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : "+urun.Adi);
        }
        public void Add2(string urunAdi,string urunAciklam,double fiyat,int stokAdeti)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi:"+urunAdi);
        }
    }
}
