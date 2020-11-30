using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    class Employee : Person
    {
        public int ID { get; set; }

        public Employee(string FirstName, string LastName, int ID) : base(FirstName, LastName)
        {
            this.ID = ID;
        }

        public void SayName()
        {
            Console.WriteLine("Name: " + "[" + base.FirstName + " " + base.LastName + "]");
        }
    }
}

