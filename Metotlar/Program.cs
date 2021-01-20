using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır Karpuzu";

            Product[] products = new Product[] {product1, product2 };
            foreach (var product in products)
            {
                Console.WriteLine("Ürün adları: "+product.Adi);
                Console.WriteLine("Ürün Fiyatları: " + product.Fiyati);
                Console.WriteLine("Ürün Açıklaması: " + product.Aciklama);
                Console.WriteLine("-------------------------------------------");
            }


            Console.WriteLine("------------------Metotlar--------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);


            sepetManager.Ekle2("Armut", "Yeşil Armut", 15,9);
            sepetManager.Ekle2("elma", "Yeşil elma", 15,5);
            sepetManager.Ekle2("karpuz", "Diyarbakır karpuzu", 15,5);




            Console.ReadLine();
        }
    }
}
