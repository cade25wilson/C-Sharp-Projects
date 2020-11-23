using System;


namespace boolComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //Two different programs showing usage of while and do while with boolean comparison
            //while
            Console.WriteLine("Given these numbers: 16, 06, 68, 88, ?, 98");
            Console.WriteLine("fill in the blank number");
            int input1 = Convert.ToInt32(Console.ReadLine());
            bool number = input1 == 87;

            while (!number)
            {
                switch (input1)
                {
                    case 87:
                        Console.WriteLine("That is correct, congrats!");
                        number = true;
                        break;
                    default:
                        Console.WriteLine("Try again.");
                        Console.WriteLine("Hint: Try reading the numbers upsidedown.");
                        input1 = Convert.ToInt32(Console.ReadLine());
                        break;
                }
                Console.ReadLine();
            }

            //do while 
            Console.WriteLine("What is 6 * (5/5)?");
            int input2 = Convert.ToInt32(Console.ReadLine());
            bool number2 = input2 == 6;

            do
            {
                switch (input2)
                {
                    case 5:
                        Console.WriteLine("Almost! try again");
                        input2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("You are correct!");
                        number2 = true;
                        break;
                    default:
                        Console.WriteLine("Incorrect (hint: remnember to use PEMDAS.)");
                        input2 = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!number2);
            Console.ReadLine();
        }
    }
}
