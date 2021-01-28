using System;
using System.Collections.Generic;

namespace Colection
{
    class Program
    {
        private static object;

        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Engin", "Murat", "Funda" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            


            List<string> isimler2 = new List<string> { "Engin", "Murat", "Funda" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            
            isimler2.Add("İlker");
            Console.WriteLine(isimler[3]);
            Console.WriteLine(isimler[0]);
            
            



        }
    }
}
