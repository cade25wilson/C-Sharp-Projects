using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee worker1 = new Employee("jim", "Jones");
            Employee worker2 = new Employee("John", "Jacobs");
            Employee worker3 = new Employee("jim", "Jones");
            worker2.ID = 1;

            Console.WriteLine("Are the first 2 employees the same? ");
            Console.WriteLine("Result: " + Convert.ToString(worker1 == worker2));
            Console.WriteLine("Are worker 2 and worker 3 the same? ");
            Console.WriteLine("Result: " + Convert.ToString(worker3 == worker2));
            Console.WriteLine("Are employee 1 and 3 the same? ");
            Console.WriteLine("Result: " + Convert.ToString(worker1 == worker3));
            Console.ReadLine();
        }
    }
}
