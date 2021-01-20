using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ID = 1;
            product1.CategoryId = 2;//Mobilyaya karşılık
            product1.ProductName = "Masa";
            product1.UnitePrice = 500;
            product1.UnitsInStock = 4;


            Product product2 = new Product {ID = 2, CategoryId = 5,ProductName = "Kalem",UnitePrice = 50,UnitsInStock = 10};

           

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine();





            Console.ReadLine();
        }
    }
}
