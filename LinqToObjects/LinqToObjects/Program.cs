using System;
using System.Collections;
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

            int[] random = { 10, 26, 94, 88, 43, 26, 10, 31, 65, 43 };

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
            Console.WriteLine("\n ========================= Skip");

            // var selectedSkipItems = random.SkipWhile((i,q) => i>1 && q.);                                                         DO NOT WORK!!!!!!!!!!!!!!!!

            int[] arrInt = { 5, 34, 67, 3, 87, 90, 102 };

            Console.WriteLine("\n ========================= Concat");

            //var selectedConcat = random.Concat(arrInt);
            IEnumerable<int> selectedConcat = new[] { random.Where(a => a > 50), arrInt.Skip(5) }.SelectMany(ran => ran);
            foreach (var item in selectedConcat)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n ========================= OrderByDescending");
            var selectOrderBy = arrInt.Where(h => h > 20).Take(6).OrderByDescending(h => h);
            foreach (var item in selectOrderBy)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n ========================= Then");

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

            Console.WriteLine("\n========================= Join/GroupJoin");

            var automob = Automobile.GetAutoArrayList();
            AutoOptionEntry[] autoOpt = AutoOptionEntry.AutoOptionEntries();

            //var automobileOpt = automob.Join(                                       //ArrayList do not contain Join
            //     autoOpt,
            //     s => s.id,
            //     d => d.id,
            //     (s, d) => new
            //     {
            //         id = s.id,
            //         mod = string.Format("{0}{1}", s.model, s.countryMake),
            //         options = d.optionsCount
            //     });
            //foreach (var item in automobileOpt)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine("\n========================= Distinct, Union, Except и Intersect");
            foreach (var item in random)
                Console.Write("\t" + item);
            var selectDistinct = random.Distinct();
            Console.WriteLine();
            foreach (var item in selectDistinct)
                Console.Write("\t" + item);

            Console.WriteLine("\n");
            var first = random.Take(5);
            var second = random.Skip(4);

            var concat = first.Concat(second);
            var union = first.Union(second);

            Console.WriteLine(@"array Random:{0} 
            first - {1}
            second - {2}
            concat - {3}
            union - {4}", random.Count(), first.Count(), second.Count(), concat.Count(), union.Count());
            Console.WriteLine("\n");

            var selectIntersect = first.Intersect(second);
            foreach (var item in first)
                Console.Write("\t" + item);
            Console.WriteLine();
            foreach (var item in second)
                Console.Write("\t" + item);
            Console.WriteLine();
            foreach (var item in selectIntersect)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var selectExcept = first.Except(second);
            foreach (var item in selectExcept)
                Console.WriteLine(item);

            Console.WriteLine("\n========================= Cast/ ofType");
            ArrayList list = new ArrayList();
            list.Add(new Automobile { id = 1, model = "vaz2108", countryMake = "Russia" });
            list.Add(new Automobile { id = 2, model = "Subaru", countryMake = "Japan" });
            list.Add(new AutoOptionEntry { id = 1, optionsCount = 100 });
            list.Add(new Automobile { id = 3, model = "BMW", countryMake = "Germany" });

            var items = list.Cast<Automobile>();
            Console.WriteLine("use Cast");
            try
            {
                foreach (var item in items)
                {
                    Console.WriteLine("{0}{1}{2}", item.id, item.model, item.countryMake);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}{1}", ex.Message, System.Environment.NewLine);
            }
            Console.WriteLine("use OfType");

            var items2 = list.OfType<Automobile>();
            foreach (var item in items2)
                Console.WriteLine("{0} {1} {2}",item.id,item.model, item.countryMake);

            Console.WriteLine("\n========================= DefaultIfEmpty");

            try
            {
                string subary = LinqToArray.favouriteCars.Where(n => n.Equals("subary")).DefaultIfEmpty().First();
                if (subary != null)
                    Console.WriteLine("car found");
                Console.WriteLine("car not found");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n========================= Range, Repeat и Empty");
            IEnumerable<int> strs = Enumerable.Range(1, 10);
            foreach (var item in strs)
                Console.WriteLine(item);
            
            Console.WriteLine("---");

            IEnumerable<int> repets = Enumerable.Repeat(1,3);
            foreach (var item in repets)
                Console.WriteLine(item);

            Console.WriteLine("---");

            IEnumerable<string> str = Enumerable.Empty<string>();

            foreach (string s in str)
                Console.Write(s);
            Console.WriteLine(str.Count());
        }
    }
}
