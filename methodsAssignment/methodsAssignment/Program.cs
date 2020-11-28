using System;


namespace methodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number would you like to perfrom calculations on? ");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(input + " + 2 = " + Operations.addTwo(input));
            Console.WriteLine(input + " - 2 = " + Operations.subTwo(input));
            Console.WriteLine(input + " / 2 = " + Operations.divTwo(input));

            Console.Read();
        }
    }
}