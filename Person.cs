using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Composite
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Person> Children { get; set;}
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Children = new List<Person>();
        }
        public override string ToString()
        {
            string names = "";
            foreach (Person child in Children)
            {
                names += $"{child.FirstName} {child.LastName}\n";
            }
            return names;
        }
    }
}