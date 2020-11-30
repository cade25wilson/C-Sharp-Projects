using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface2
{
    public class Employee : Person, IQuittable
    {
        public void SayName()
        {
            base.SayName();
        }

        public void Quit(Employee employee)
        {
            Console.WriteLine(employee.FirstName +" " + employee.LastName + " Has quit this job");
            Console.ReadLine();
        }

        
    }
}
