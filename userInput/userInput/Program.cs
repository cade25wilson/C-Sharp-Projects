using System;

namespace userInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a number");
            string num1 = Console.ReadLine();
            int num2 = Convert.ToInt32(num1);
            int product = num2 * 50;
            Console.WriteLine("Your number times 50 is " + product);

            Console.WriteLine("input another number");
            string num3 = Console.ReadLine();
            int num4 = Convert.ToInt32(num3);
            int total = num4 + 25;
            Console.WriteLine("Your number plus 25 is " + total);

            Console.WriteLine("Please input your favorite number");
            string favNumber = Console.ReadLine();
            double favNum = Convert.ToDouble(favNumber);
            double quotient = favNum / 12.5;
            Console.WriteLine("Your number divided by 12.5 = " + quotient);

            Console.WriteLine("Please input your age");
            string age = Console.ReadLine();
            int years = Convert.ToInt32(age);
            bool answer = years > 50;
            Console.WriteLine("You are older than 50 " + answer);

            Console.WriteLine("Please input a final number");
            string finalNumber = Console.ReadLine();
            int finNum = Convert.ToInt32(finalNumber);
            int remainder = finNum % 7;
            Console.WriteLine("the remainder of your number divided by 7 is " + remainder);
            Console.ReadLine();


        }
    }
}
