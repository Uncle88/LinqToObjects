using System;
namespace LinqToObjects
{
    public class AutoOptionEntry
    {
        public int id;
        public long optionsCount;
        public DateTime dateOfManufacture
;

        public static AutoOptionEntry[] AutoOptionEntries()
        {
            AutoOptionEntry[] autoOptions = new AutoOptionEntry[] {
        new AutoOptionEntry {
          id = 1,
          optionsCount = 2,
          dateOfManufacture = DateTime.Parse("1999/12/31") },
        new AutoOptionEntry {
          id = 2,
          optionsCount = 10000,
          dateOfManufacture = DateTime.Parse("1992/06/30")  },
        new AutoOptionEntry {
          id = 2,
          optionsCount = 10000,
          dateOfManufacture = DateTime.Parse("1994/01/01")  },
        new AutoOptionEntry {
          id = 3,
          optionsCount = 5000,
          dateOfManufacture = DateTime.Parse("1997/09/30") },
        new AutoOptionEntry {
          id = 2,
          optionsCount = 10000,
          dateOfManufacture = DateTime.Parse("2003/04/01")  },
        new AutoOptionEntry {
          id = 3,
          optionsCount = 7500,
          dateOfManufacture = DateTime.Parse("1998/09/30") },
        new AutoOptionEntry {
          id = 3,
          optionsCount = 7500,
          dateOfManufacture = DateTime.Parse("1998/09/30") },
        new AutoOptionEntry {
          id = 4,
          optionsCount = 1500,
          dateOfManufacture = DateTime.Parse("1997/12/31") },
        new AutoOptionEntry {
          id = 101,
          optionsCount = 2,
          dateOfManufacture = DateTime.Parse("1998/12/31") }
      };
            return (autoOptions);
        }
    }
}
