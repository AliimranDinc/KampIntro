using System;

namespace KampIntro
{
    class Program
    { 
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            bool sistemeGirisYapmisMi = true;

            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu ");
            }
            else
            {
                Console.WriteLine("Eşittir Butonu");
            }
           


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            
            
            Console.WriteLine(kategoriEtiketi);
            
            Console.ReadLine();
        }
    }
}
