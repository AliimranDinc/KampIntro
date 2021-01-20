using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Ali", "Engin","Cemal"};




            List<string> isimler2 = new List<string> {"Ali","Engin","Cemal"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);



            Console.ReadLine();
        }
    }
}
