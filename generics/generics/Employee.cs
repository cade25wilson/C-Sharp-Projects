using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    class Employee<T> : Person
    {

        public int Id = 0;
        public List<T> Things = new List<T>();

        //Calls the base constructor (Person)
        public Employee()
        {

        }

    }
}
