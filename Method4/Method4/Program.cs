using System;

namespace Method4
{
    class Program
    {
        static void Main(string[] args)


        {
            //Telling the user to pick a number and passing in the operations class
            Console.WriteLine("Choose a number:");
            int userInput0 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Choose another number:");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            operations.Divide(userInput0, userInput1);

            Console.WriteLine();

            operations.Divide(inputNum1: 4, inputNum2: 10);
            Console.ReadLine();
        }
    }
}