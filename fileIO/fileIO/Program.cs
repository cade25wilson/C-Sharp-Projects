using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number here: ");
            string num1 = Console.ReadLine();

            using (StreamWriter file = new StreamWriter(@"test.txt", true))
            {
                file.Write(num1);
            }

            using (StreamReader file = new StreamReader("test.txt"))
            {
                Console.WriteLine("File Contents: ");
                Console.WriteLine(file.ReadToEnd());
            }

            Console.Read(); 
        }
    }
}
