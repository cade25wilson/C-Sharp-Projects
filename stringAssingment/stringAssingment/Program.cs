using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringAssingment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter what day it is Ex. Monday, Tuesday, Etc.");
            string day = Console.ReadLine();
            Console.WriteLine("Please enter what the date is Ex. May 22nd");
            string date = Console.ReadLine();
            Console.WriteLine("Please enter what year is is.");
            string year = Console.ReadLine();
            Console.WriteLine("today is " + day +" "+ date +", "+ year +"!");

            Console.WriteLine("please input a name");
            string name = Console.ReadLine();
            string upperCase = name.ToUpper();
            Console.WriteLine("You entered: " + upperCase);

            StringBuilder create = new StringBuilder();
            create.AppendLine("This is being run in C#");
            create.AppendLine("The StringBuilder is a dynamic way of creating strings");
            create.AppendLine("All of the strings are being made on a seperate line of code");
            Console.Write(create);

            Console.ReadLine();


        }
    }
}
