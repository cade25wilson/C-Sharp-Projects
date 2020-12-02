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
            Employee<string> numString = new Employee<string>();
            numString.Things.Add("first");
            numString.Things.Add("second");
            numString.Things.Add("third");
            numString.Things.Add("fourth");
            numString.Things.Add("fifth");
            Employee<int> intString = new Employee<int>();
            intString.Things.Add(1);
            intString.Things.Add(2);
            intString.Things.Add(3);
            intString.Things.Add(4);
            intString.Things.Add(5);

            Console.WriteLine("Loop printing out all .things in string list ");
            numString.Things.ForEach(x => { Console.WriteLine(x); });
            Console.WriteLine("Loop printing out all .things in int list ");
            intString.Things.ForEach(x => { Console.WriteLine(x); });

            Console.Read();
        }
    }
}
