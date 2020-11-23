using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        string[] strArray = { "Bob", "Tom", "Bill", "Billy", "Joe", "Ted" };

        Console.WriteLine("Please pick a number between 0-5");
        int selection = Convert.ToInt32(Console.ReadLine());

        while (selection < 0 || selection >= 6)
        {
            Console.WriteLine("Please choose a number between 0-5");
            selection = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("The name in the array you picked was " + strArray[selection]);



        int[] numArray = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60 };

        Console.WriteLine("Please pick another number this time between 0-11");
        int pick = Convert.ToInt32(Console.ReadLine());

        while (pick < 0 || pick >= 12)
        {
            Console.WriteLine("Please choose a number between 0 and 11");
            pick = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("The number in the array you picked was " + numArray[pick]);

        List<string> strList = new List<string>();
        strList.Add("good");
        strList.Add("job");
        strList.Add("you");
        strList.Add("picked");
        strList.Add("a");
        strList.Add("valid");
        strList.Add("list");
        strList.Add("choice");

        Console.WriteLine("Please pick a final number between 0-7");
        int listPick = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The word you picked in the list was " + strList[listPick]);
        Console.ReadLine();



    }
}

