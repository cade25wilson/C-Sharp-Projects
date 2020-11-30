using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> empString = new Employee<string>();
            empString.Things.Add("first");
            empString.Things.Add("second");
            empString.Things.Add("third");
            empString.Things.Add("fourth");
            empString.Things.Add("fifth");
            Employee<int> intString = new Employee<int>();
            intString.Things.Add(1);
            intString.Things.Add(2);
            intString.Things.Add(3);
            intString.Things.Add(4);
            intString.Things.Add(5);

            Console.WriteLine("Employee.Thing of type string: ");
            empString.Things.ForEach(x => { Console.WriteLine(x); });
            Console.WriteLine("Employee.Thing of type int: ");
            intString.Things.ForEach(x => { Console.WriteLine(x); });

            Console.Read();
        }
    }
}
