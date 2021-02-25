using System;
using System.Collections.Generic;
using System.Text;

namespace Methotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi! : " + product.Adi   + "\n------------" +  " Ürünün Fiyatı : " + product.Fiyati + "\n------------" + " Stoktakta Kalan : "  +   product.StokAdedi);

        }
            
        public void Ekle2(string urunAdi, string aciklama, double fiyat , int stokAdedi ) 
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi! : " + urunAdi );       
        }
                
    }

}
