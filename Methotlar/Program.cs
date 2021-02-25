using System;

namespace Methotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = new string[] {"elma ", "karpuz"}; 
            //tek tek herbir özellik için böyle dizi oluşturmak mantıksız olacağından classları kullanmak daha mantıklı ve anlaşılır 

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";
            product1.StokAdedi = 150;



            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır Karpuzu";
            product2.StokAdedi = 200; 

            Product[] products = new Product[] {product1, product2,};

            foreach (Product product in products)
            {
                Console.WriteLine("Adı : " + product.Adi);
                Console.WriteLine("Fiyatı : " + product.Fiyati);
                Console.WriteLine("Açıklama : " + product.Aciklama);
                Console.WriteLine("-----------------------");

            }

            Console.WriteLine("----------Metotlar----------");
           
            //instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);


            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Kırmızı Elma", 15, 80);

        }
    }
}


//Dont Repeat Yourself - DRY