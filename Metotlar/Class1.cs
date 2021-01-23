using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
    public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! " + urun.Adi);
        }
    public void Ekle2(  string urunAdi,  string aciklama, double fiyat,  int Stok )
        { 
 
            Console.WriteLine("Tebrikler. sepete eklendi! " + urunAdi + aciklama + fiyat + Stok );
                 
        }
    }
}
