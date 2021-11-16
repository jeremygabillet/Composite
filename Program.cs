using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Person John = new Person("John", "Dough");
            John.Children = new List<Person>
            {
                new Person("Jean", "Dough"),
                new Person("Charles", "Dough"),
                new Person("Lucy", "Dough"),
                new Person("Catherine", "Dough")
            };
            System.Console.WriteLine(John.ToString());
        }
    }
}
