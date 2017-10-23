using System;
namespace LinqToObjects
{
    public static class LinqToArray
    {
        public static string[] favouriteCars = { "Skoda Yetti", "7Wolksvagen Golf7", "Seat Ibiza", "Reno Scenic", "Skoda Fabia1.4", "7Hundai i70", "Wolksvagen Polo1.4"};

        public static Person[] people =
        {
            new Person {Name = "dgj", Surname = "sldfyur5j", Age= 10},
            new Person {Name = "dgsfj", Surname = "slddffj", Age= 20},
            new Person {Name = "dsdgrgj", Surname = "slwrtydfj", Age= 30},
            new Person {Name = "dg345j", Surname = "sldrfthfj", Age= 40},
            new Person {Name = "dgrtj", Surname = "sldwerfj", Age= 50},
            new Person {Name = "dgjftruki", Surname = "sldtyfj", Age= 60}
        };
    }

    public class Person
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }
    }
}
