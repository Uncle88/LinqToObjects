using System;
using System.Collections;

namespace LinqToObjects
{
    public class Automobile
    {
        public int id;
        public string model;
        public string countryMake;

        public static ArrayList GetAutoArrayList()
        {
            ArrayList list = new ArrayList();

            list.Add(new Automobile { id = 1, model = "WV", countryMake = "Germany" });
            list.Add(new Automobile { id = 2, model = "Porshe", countryMake = "Germany" });
            list.Add(new Automobile { id = 3, model = "Subaru", countryMake = "Japan" });
            list.Add(new Automobile { id = 4, model = "Infinity", countryMake = "Japan" });
            list.Add(new Automobile { id = 101, model = "Ford", countryMake = "USA" });
            return (list);
        }

        public static Automobile[] GetEmployeesArray()
        {
            return ((Automobile[])GetAutoArrayList().ToArray(typeof(Automobile)));
        }
    }
}
