using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace annonIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate");
            string hourRate = Console.ReadLine();
            int hourlyRate = Convert.ToInt32(hourRate);

            Console.WriteLine("Hours worked");
            string workHour = Console.ReadLine();
            int hourWorked = Convert.ToInt32(workHour);
            int payCheck = hourlyRate * hourWorked;
            int salary = payCheck * 52;

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate");
            string hourRate2 = Console.ReadLine();
            int hourlyRate2 = Convert.ToInt32(hourRate2);

            Console.WriteLine("Hours worked");
            string workHour2 = Console.ReadLine();
            int hourWorked2 = Convert.ToInt32(workHour2);
            int payCheck2 = hourlyRate2 * hourWorked2;
            int salary2 = payCheck2 * 52;

            Console.WriteLine("Annual salary of person 1:");
            Console.WriteLine(salary);

            Console.WriteLine("Annual salary of person 2:");
            Console.WriteLine(salary2);

            bool comparison = salary > salary2;

            Console.WriteLine("Does person 1 make more money than person 2?");
            Console.WriteLine(comparison);
            Console.ReadLine();


        }
    }
}
