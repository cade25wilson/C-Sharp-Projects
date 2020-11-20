using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? please answer 'true' or 'false'");
            bool DUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int speedTickets = Convert.ToInt32(tickets);

            bool qualified = (age > 15 && DUI ==false && speedTickets <= 3);
            Console.WriteLine("Qualified");
            Console.WriteLine(qualified);
            Console.ReadLine();



        }
    }
}
