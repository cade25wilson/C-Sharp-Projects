using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Operators myClass = new Operators();

            Console.WriteLine("Please input one whole number or two");
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            int total;
            if (String.IsNullOrEmpty(num2))
                total = Operators.operatorMethod(Convert.ToInt32(num1));
            else
                total = Operators.operatorMethod(Convert.ToInt32(num1), Convert.ToInt32(num2));

            Console.WriteLine("This should display the total of the numbers you multiplied together, or if you only put 1 number the total should be that number multiplied by 5 " + total); ;
            Console.Read();
        }
    }
}
