using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual individual1 = new Individual();
            individual1.ID = 1;
            individual1.CustomerNumber = "12345";
            individual1.Name = "Ali";
            individual1.Surname = "Dinç";
            individual1.TcNo = "11111111111";


            Coorporate coorporate2 = new Coorporate();
            coorporate2.ID = 2;
            coorporate2.CustomerNumber = "54321";
            coorporate2.SirketAdi = "Dinç Holding";
            coorporate2.VergiNo = "ABC123456789";


            Customer customer4 = new Individual();
            Customer customer5 = new Coorporate();


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(individual1);
            customerManager.Add(coorporate2);



        }
    }
}
