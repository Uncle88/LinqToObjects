using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqToObjects
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //IEnumerable<string> someCars = LinqToArray.favouriteCars.Where(n => n.Contains("7")).OrderBy(n => n);//.Select(n => n);

            //Console.WriteLine("*******first array\n");
            //foreach (var item in someCars)
            //{
            //    Console.WriteLine(item);
            //}

            LinqToArray.favouriteCars[0] = "Volvo";

            IEnumerable<string> newSomeCar = LinqToArray.favouriteCars.Where(item => item.Contains(".") && item.Contains("")).
                                                        Where(item => item.Contains(".") && item.Contains("")).OrderBy(item => item).Select(item => item);
                                                                                        //from item in LinqToArray.favouriteCars where item.Contains(".") 
                                                                                                                               //where item.Contains("") orderby item select item;

            Console.WriteLine("\n*******Array after change\n");
            foreach (var item in newSomeCar)
            {
                Console.WriteLine(item);
            }

            int[] random = { 1, 26, 94, 88, 43, 28, 10, 31, 65, 40 };

            int[] selectedItem = (random.Where(ran => (ran > 3 && ran < 10)).OrderBy(ran => ran).Select(ran => ran)).ToArray();
            //int[] selectedItem = (from ran in random where ran > 3 && ran < 10 orderby ran select ran).ToArray();

            Console.WriteLine("*********ARRAY");
            foreach (var item in selectedItem)
            {
                Console.WriteLine(item);
            }

            List<int> listItems = (random.Where(ran => ran > 5).OrderBy(ran => ran).Select(ran => ran)).ToList();
            //List<int> listItems = (from ran in random where ran > 5 orderby ran select ran).ToList();

            Console.WriteLine("********LIST");
            foreach (var item in listItems)
            {
                Console.WriteLine(item);
            }

            var selectedPeople = LinqToArray.people.Where(p => p.Age > 10 && p.Age < 40).Select(p => new { p.Name, p.Age });
            Console.WriteLine("=========================Take-TakeWhile;Skip-SkipWhile===========================");

            var selectedTakeItem = random.Where(ran => ran > 0).Take(5).OrderBy(ran => ran).Select(ran => ran);
            foreach (var item in selectedTakeItem)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");
            var selectedSkipItem = random.Skip(5).Select(ran => ran);
            foreach (var item in selectedSkipItem)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n Skip");

            // var selectedSkipItems = random.SkipWhile((i,q) => i>1 && q.);                                                         DO NOT WORK!!!!!!!!!!!!!!!!

            int[] arrInt = { 5, 34, 67, 3, 87, 90, 102 };

            Console.WriteLine("\n Concat");

            //var selectedConcat = random.Concat(arrInt);
            IEnumerable<int> selectedConcat = new[] {random.Where(a => a > 50), arrInt.Skip(5)}.SelectMany(ran => ran);
            foreach (var item in selectedConcat)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n OrderByDescending");
            var selectOrderBy = arrInt.Where(h => h > 20).Take(6).OrderByDescending(h => h);
            foreach (var item in selectOrderBy)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n Then");

            IEnumerable<string> newSoCar = LinqToArray.favouriteCars.OrderBy(s => s).ThenBy(s => s);             // N1
            foreach (var item in newSoCar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            IEnumerable<string> newSoCar2 = LinqToArray.favouriteCars.OrderBy(s => s).ThenByDescending(s => s);  // N2       what's the difference beetwen N1 & N2 ????
            foreach (var item in newSoCar2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
