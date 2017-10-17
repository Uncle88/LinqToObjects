using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqToObjects
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IEnumerable<string> someCars = from item in LinqToArray.favouriteCars where item.Contains("7") orderby item select item;

            Console.WriteLine("*******first array\n");
            foreach (var item in someCars)
            {
                Console.WriteLine(item);
            }

            LinqToArray.favouriteCars[0] = "Volvo";

            IEnumerable<string> newSomeCar = from item in LinqToArray.favouriteCars where item.Contains(".") 
                                                                         where item.Contains("") orderby item select item;

            Console.WriteLine("\n*******Array after change\n");
            foreach (var item in newSomeCar)
            {
                Console.WriteLine(item);
            }

        }
    }
}
