﻿using System;
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

            //var selectedTakeWhileItem = random.Where(ran => ran>3)
        }
    }
}
