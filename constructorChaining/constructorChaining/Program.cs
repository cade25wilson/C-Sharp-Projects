using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorChaining
{
    class Program
    {
        static void Main(string[] args)
        {
            const string constString = "This is constant.";
            Console.WriteLine(constString);
            var num = 3;
            Console.WriteLine("variable num is of type: " + num.GetType());
            var str = "Is a string.";
            Console.WriteLine("variable str is of type: " + str.GetType());

            Person person = new Person();
            person.SayName();
            Console.ReadLine();

        }
    }
}
