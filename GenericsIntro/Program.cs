﻿using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Ali");
            Console.WriteLine(isimler.Length);

            isimler.Add("Can");
            Console.WriteLine(isimler.Length);

            isimler.Add("Engin");
            Console.WriteLine(isimler.Length);


            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }




            Console.ReadLine();
        }
    }
}
