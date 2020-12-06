using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionPart2
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            Console.WriteLine("Please enter your age:");
            int birthYear = 0;
            //catching year that is negative or 0
            try
            {
                birthYear = Convert.ToInt32(Console.ReadLine());
                if (birthYear < 1)
                    throw new InvalidOperationException();
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Please do not enter a value lower than 1");
                goto Start;
            }
            //catching inputs that are not numbers
            catch (Exception)
            {
                Console.WriteLine("Please only enter digits.");
                goto Start;
            }
            //subtracting birthyear from current date
            Console.WriteLine("User was born in: " + DateTime.Now.AddYears(-birthYear).Year);
            Console.ReadLine();



        }
    }
}