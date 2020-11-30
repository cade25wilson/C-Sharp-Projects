using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorComparison
{
    public class Employee : Person
    {
        public int ID = 0;

        public Employee(string FirstName, string LastName) : base(FirstName, LastName)
        {

        }

        public static bool operator== (Employee a, Employee b)
        {
            return a.ID == b.ID;
        }

        public static bool operator!= (Employee a, Employee b)
        {
            return a.ID != b.ID;
        }
    }
}
