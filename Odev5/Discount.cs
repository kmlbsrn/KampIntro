using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class Discount
    {
    public void Çarp(int price1,int price2,int discount1,int discount2)
        {
            int Odeme1 = price1 % discount1;
            int Odeme2 = price1 % discount2;
            int Odeme3 = price2 % discount1;
            int Odeme4 = price2 % discount2;
            Console.WriteLine("Ödenecek tutar :" + Odeme2);
        }
    
    }
}
