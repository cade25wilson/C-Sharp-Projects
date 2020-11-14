using System;

namespace Daily_Report_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \nStudent Daily Report");

            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string courseNumber = Console.ReadLine();

            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            bool input = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Where there any positive experiences you'd like to share? Please give specifics.");
            string stuExp = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific?");
            string stuFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int studyTime = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();


        }
    }
}
