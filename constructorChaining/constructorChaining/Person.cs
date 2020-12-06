using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorChaining
{
    class Person
    {
        string firstName;
        string lastName;

        public Person() : this("John", "Doe") { }

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void SayName()
        {
            Console.WriteLine("Name: " + "[" + firstName + " " + lastName + "]");
        }
    }
}
