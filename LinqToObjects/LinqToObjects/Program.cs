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

            foreach (var item in someCars)
            {
                Console.WriteLine(item);
            }
        }
    }
}
